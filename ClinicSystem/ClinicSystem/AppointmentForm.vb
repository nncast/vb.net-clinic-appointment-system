Public Class AppointmentForm
    Public adding As Boolean = False
    Public updating As Boolean = False
    Public appointmentid As Integer = Nothing

    Private Sub appointmentform_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()

        btnnew.Enabled = True
        btnsave.Enabled = False
        pnlinput.Enabled = False
    End Sub

    Public Sub fill()
        GetQuery("SELECT a.id, a.appointmenttype, a.procedurereq, a.appointmentdate, a.appointmenttime, a.reason, d.docname FROM tblappointment a INNER JOIN tbldoctor d ON a.doctorid = d.id WHERE a.patientid = @pid ORDER BY a.appointmentdate, a.id",
                 "tblappointment", P("@pid", loggedinpatientid))
        appointmentlist.Items.Clear()
        For i = 0 To ds.Tables("tblappointment").Rows.Count - 1
            Dim item = appointmentlist.Items.Add((i + 1).ToString())
            item.SubItems.Add(ds.Tables("tblappointment").Rows(i).Item("appointmenttype").ToString())
            item.SubItems.Add(ds.Tables("tblappointment").Rows(i).Item("docname").ToString())
            item.SubItems.Add(ds.Tables("tblappointment").Rows(i).Item("procedurereq").ToString())
            item.SubItems.Add(ds.Tables("tblappointment").Rows(i).Item("appointmentdate").ToString())
            item.SubItems.Add(ds.Tables("tblappointment").Rows(i).Item("appointmenttime").ToString())
            item.SubItems.Add(ds.Tables("tblappointment").Rows(i).Item("reason").ToString())
            item.SubItems.Add(ds.Tables("tblappointment").Rows(i).Item("id").ToString())
        Next
    End Sub


    Public Sub enablebuttons()
        btnnew.Enabled = 0
        btnupdate.Enabled = 0
        btndelete.Enabled = 0
        btncancel.Enabled = 1
        btnsave.Enabled = 1

        locknew.Visible = 1
        lockupdate.Visible = 1
        lockdelete.Visible = 1
        locksave.Visible = 0
    End Sub

    Public Sub disablebuttons()
        btnnew.Enabled = 1
        btnupdate.Enabled = 1
        btndelete.Enabled = 1
        btncancel.Enabled = 1
        btnsave.Enabled = 0

        locknew.Visible = 0
        lockupdate.Visible = 0
        lockdelete.Visible = 0
        locksave.Visible = 1
    End Sub

    Public Sub clearfields()
        txtid.Clear()
        cmbapttype.SelectedIndex = -1
        cmbprocedurereq.SelectedIndex = -1
        txtdate.Clear()
        cmbtime.SelectedIndex = -1
        cmbdoctor.SelectedIndex = -1
        txtreason.Clear()
    End Sub

    Private Function validfields() As Boolean
        Dim appointmentDate As Date

        If cmbapttype.SelectedIndex = -1 Or cmbdoctor.SelectedIndex = -1 Or cmbprocedurereq.SelectedIndex = -1 Or Not txtdate.MaskCompleted Or cmbtime.SelectedIndex = -1 Or txtreason.Text.Trim = Nothing Then
            MsgBox("All fields are required!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Missing Information")
            Return False
        End If

        If Not TryGetDate(txtdate, appointmentDate) Then
            MsgBox("Enter a valid appointment date (YYYY-MM-DD).", MsgBoxStyle.Exclamation, "Invalid Date")
            Return False
        End If

        If adding AndAlso appointmentDate < Today Then
            MsgBox("The appointment date cannot be in the past.", MsgBoxStyle.Exclamation, "Invalid Date")
            Return False
        End If

        ' A doctor can only see one patient per time slot.
        Dim taken As Integer = CInt(GetValue("SELECT COUNT(*) FROM tblappointment WHERE doctorid = @doc AND appointmentdate = @d AND appointmenttime = @t AND id <> @id",
                                             P("@doc", cmbdoctor.SelectedValue), P("@d", appointmentDate.ToString("yyyy-MM-dd")), P("@t", cmbtime.Text.Trim()), P("@id", If(updating, appointmentid, -1))))
        If taken > 0 Then
            MsgBox(cmbdoctor.Text & " already has an appointment at " & cmbtime.Text & " on " & appointmentDate.ToString("yyyy-MM-dd") & ". Please choose another time.", MsgBoxStyle.Exclamation, "Time Slot Taken")
            Return False
        End If

        Return True
    End Function

    Private Sub btnnew_click(sender As Object, e As EventArgs) Handles btnnew.Click
        enablebuttons()
        clearfields()
        appointmentid = Nothing
        adding = True
        pnlinput.Enabled = True
        listdoctor()
        cmbdoctor.SelectedIndex = -1
    End Sub

    Private Sub btnupdate_click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If appointmentid = Nothing Then
            MsgBox("Please select an appointment to update.", MsgBoxStyle.Information, "No Selection")
            Exit Sub
        End If

        enablebuttons()
        updating = True
        pnlinput.Enabled = True
    End Sub

    Private Sub btnsave_click(sender As Object, e As EventArgs) Handles btnsave.Click
        If Not (adding Or updating) Then Exit Sub
        If Not validfields() Then Exit Sub

        Dim appointmentDate As Date
        TryGetDate(txtdate, appointmentDate)

        If adding Then
            If MsgBox("Are you sure you want to add a new appointment?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                If SetQuery("INSERT INTO tblappointment (patientid, doctorid, appointmenttype, procedurereq, appointmentdate, appointmenttime, reason) VALUES (@pid, @doc, @type, @proc, @d, @t, @reason)",
                            P("@pid", loggedinpatientid), P("@doc", cmbdoctor.SelectedValue), P("@type", cmbapttype.Text.Trim()), P("@proc", cmbprocedurereq.Text.Trim()),
                            P("@d", appointmentDate.ToString("yyyy-MM-dd")), P("@t", cmbtime.Text.Trim()), P("@reason", txtreason.Text.Trim())) Then
                    fill()
                    disablebuttons()
                    clearfields()
                    pnlinput.Enabled = False
                    adding = False
                    MsgBox("Appointment saved successfully!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")
                End If
            End If
        ElseIf updating Then
            If MsgBox("Are you sure you want to update the appointment information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                ' patientid in the WHERE keeps a patient from changing someone else's appointment.
                If SetQuery("UPDATE tblappointment SET appointmenttype = @type, procedurereq = @proc, appointmentdate = @d, appointmenttime = @t, reason = @reason, doctorid = @doc WHERE id = @id AND patientid = @pid",
                            P("@type", cmbapttype.Text.Trim()), P("@proc", cmbprocedurereq.Text.Trim()), P("@d", appointmentDate.ToString("yyyy-MM-dd")),
                            P("@t", cmbtime.Text.Trim()), P("@reason", txtreason.Text.Trim()), P("@doc", cmbdoctor.SelectedValue),
                            P("@id", appointmentid), P("@pid", loggedinpatientid)) Then
                    fill()
                    disablebuttons()
                    clearfields()
                    pnlinput.Enabled = False
                    updating = False
                    appointmentid = Nothing
                    MsgBox("Updated", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
                End If
            End If
        End If
    End Sub

    Private Sub btndelete_click(sender As Object, e As EventArgs) Handles btndelete.Click
        If appointmentid = Nothing Then
            MsgBox("Please select an appointment to delete.", MsgBoxStyle.Information, "No Selection")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete this appointment?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then
            If SetQuery("DELETE FROM tblappointment WHERE id = @id AND patientid = @pid", P("@id", appointmentid), P("@pid", loggedinpatientid)) Then
                fill()
                clearfields()
                appointmentid = Nothing
                MsgBox("Appointment deleted successfully!", MsgBoxStyle.Information, "Success")
            End If
        End If
    End Sub

    Private Sub appointmentlist_doubleclick(sender As Object, e As EventArgs) Handles appointmentlist.DoubleClick
        If adding Or updating Or appointmentlist.SelectedItems.Count = 0 Then Exit Sub

        appointmentid = CInt(appointmentlist.SelectedItems(0).SubItems(7).Text)

        GetQuery("SELECT a.id, a.appointmenttype, a.procedurereq, a.appointmentdate, a.appointmenttime, a.reason, a.doctorid, d.docname FROM tblappointment a INNER JOIN tbldoctor d ON a.doctorid = d.id WHERE a.id = @id AND a.patientid = @pid",
                 "tblappointment", P("@id", appointmentid), P("@pid", loggedinpatientid))
        If ds.Tables("tblappointment").Rows.Count = 0 Then
            appointmentid = Nothing
            Exit Sub
        End If

        Dim row As DataRow = ds.Tables("tblappointment").Rows(0)
        Dim doctorid As Integer = CInt(row.Item("doctorid"))

        txtid.Text = row.Item("id").ToString
        cmbapttype.SelectedItem = row.Item("appointmenttype").ToString
        cmbprocedurereq.SelectedItem = row.Item("procedurereq").ToString
        txtdate.Text = row.Item("appointmentdate").ToString
        cmbtime.SelectedItem = row.Item("appointmenttime").ToString
        txtreason.Text = row.Item("reason").ToString

        listdoctor()
        cmbdoctor.SelectedValue = doctorid

        btnupdate.Enabled = True
        btndelete.Enabled = True
        lockupdate.Visible = 0
        lockdelete.Visible = 0
    End Sub

    Public Sub listdoctor()
        GetQuery("SELECT id, docname FROM tbldoctor ORDER BY docname", "tbldoctor")
        If ds.Tables("tbldoctor").Rows.Count = 0 Then
            MsgBox("No doctors found in the database.", MsgBoxStyle.Information, "No Doctors")
            Exit Sub
        End If

        ' Bind a copy so later queries can't empty the list while it is shown.
        cmbdoctor.DisplayMember = "docname"
        cmbdoctor.ValueMember = "id"
        cmbdoctor.DataSource = ds.Tables("tbldoctor").Copy()
    End Sub

    Private Sub btncancel_click(sender As Object, e As EventArgs) Handles btncancel.Click
        If updating Then
            If MsgBox("Are you sure you want to cancel updating this appointment?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
                updating = False
                disablebuttons()
                clearfields()
                pnlinput.Enabled = False
                appointmentid = Nothing
            End If
        ElseIf adding Then
            If MsgBox("Are you sure you want to cancel adding a new appointment?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
                adding = False
                disablebuttons()
                clearfields()
                pnlinput.Enabled = False
                appointmentid = Nothing
            End If
        Else
            appointmentid = Nothing
            adding = False
            updating = False
            disablebuttons()
            clearfields()
            pnlinput.Enabled = False
        End If
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles piclogout.Click
        If MsgBox("Are you sure you want to logout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Logout") = MsgBoxResult.Yes Then
            loggedinpatientid = 0
            appointmentid = Nothing
            adding = False
            updating = False
            clearfields()
            appointmentlist.Items.Clear()
            pnlinput.Enabled = False
            disablebuttons()
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub cmbapttype_GotFocus(sender As Object, e As EventArgs) Handles cmbapttype.GotFocus
        HandleFocus(shapeappointmenttype, True)
    End Sub

    Private Sub cmbapttype_LostFocus(sender As Object, e As EventArgs) Handles cmbapttype.LostFocus
        HandleFocus(shapeappointmenttype, False)
    End Sub

    Private Sub cmbdoctor_GotFocus(sender As Object, e As EventArgs) Handles cmbdoctor.GotFocus
        HandleFocus(shapedoctor, True)
    End Sub

    Private Sub cmbdoctor_LostFocus(sender As Object, e As EventArgs) Handles cmbdoctor.LostFocus
        HandleFocus(shapedoctor, False)
    End Sub

    Private Sub cmbprocedurereq_GotFocus(sender As Object, e As EventArgs) Handles cmbprocedurereq.GotFocus
        HandleFocus(shapeprocedurereq, True)
    End Sub

    Private Sub cmbprocedurereq_LostFocus(sender As Object, e As EventArgs) Handles cmbprocedurereq.LostFocus
        HandleFocus(shapeprocedurereq, False)
    End Sub

    Private Sub txtdate_GotFocus(sender As Object, e As EventArgs) Handles txtdate.GotFocus
        HandleFocus(shapedate, True)
    End Sub

    Private Sub txtdate_LostFocus(sender As Object, e As EventArgs) Handles txtdate.LostFocus
        HandleFocus(shapedate, False)
    End Sub

    Private Sub cmbtime_GotFocus(sender As Object, e As EventArgs) Handles cmbtime.GotFocus
        HandleFocus(shapetime, True)
    End Sub

    Private Sub cmbtime_LostFocus(sender As Object, e As EventArgs) Handles cmbtime.LostFocus
        HandleFocus(shapetime, False)
    End Sub

    Private Sub txtreason_GotFocus(sender As Object, e As EventArgs) Handles txtreason.GotFocus
        HandleFocus(shapereason, True)
    End Sub

    Private Sub txtreason_LostFocus(sender As Object, e As EventArgs) Handles txtreason.LostFocus
        HandleFocus(shapereason, False)
    End Sub

    ' The login form is only hidden after signing in, so closing this window
    ' has to end the program; otherwise it keeps running in the background.
    Private Sub AppointmentForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class
