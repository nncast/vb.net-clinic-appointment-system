Public Class AppointmentForm
    Public adding As Boolean = False
    Public updating As Boolean = False
    Public appointmentid As Integer = Nothing

    Private Sub appointmentform_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect("localhost", "clinic", "3306", "root", "")

        btnnew.Enabled = True
        btnsave.Enabled = False
        pnlinput.Enabled = False
    End Sub

    Public Sub fill()
        GetQuery("SELECT a.id, a.appointmenttype, a.procedurereq, a.appointmentdate, a.appointmenttime, a.reason, d.docname FROM tblappointment a INNER JOIN tbldoctor d ON a.doctorid = d.id WHERE a.patientid = " & loggedinpatientid, "tblappointment")
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

    Private Sub btnnew_click(sender As Object, e As EventArgs) Handles btnnew.Click
        enablebuttons()
        clearfields()
        adding = True
        pnlinput.Enabled = True
        listdoctor()
    End Sub

    Private Sub btnupdate_click(sender As Object, e As EventArgs) Handles btnupdate.Click
        enablebuttons()
        updating = True
        pnlinput.Enabled = True
    End Sub

    Private Sub btnsave_click(sender As Object, e As EventArgs) Handles btnsave.Click
        If adding Then
            If cmbapttype.SelectedIndex = -1 Or cmbdoctor.SelectedIndex = -1 Or cmbprocedurereq.SelectedIndex = -1 Or txtdate.Text.Trim = Nothing Or cmbtime.SelectedIndex = -1 Or txtreason.Text.Trim = Nothing Then
                MsgBox("All fields are required!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Missing Information")
            Else
                If MsgBox("Are you sure you want to add a new appointment?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SetQuery("INSERT INTO tblappointment (patientid, doctorid, appointmenttype, procedurereq, appointmentdate, appointmenttime, reason) VALUES (" & loggedinpatientid & ", " & cmbdoctor.SelectedValue & ", '" & cmbapttype.Text.Trim() & "', '" & cmbprocedurereq.Text.Trim() & "', '" & txtdate.Text.Trim() & "', '" & cmbtime.Text.Trim() & "', '" & txtreason.Text & "')")

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
                SetQuery("UPDATE tblappointment SET appointmenttype = '" & cmbapttype.Text.Trim() & "', procedurereq = '" & cmbprocedurereq.Text.Trim() & "', appointmentdate = '" & txtdate.Text.Trim() & "', appointmenttime = '" & cmbtime.Text.Trim() & "', reason = '" & txtreason.Text.Trim() & "', doctorid = " & cmbdoctor.SelectedValue & " WHERE id = " & appointmentid)

                fill()
                disablebuttons()
                clearfields()
                pnlinput.Enabled = False
                updating = False
                MsgBox("Updated", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            End If
        End If
    End Sub

    Private Sub btndelete_click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtid.Text.Trim = Nothing Then
            MsgBox("Please select an appointment to delete.", MsgBoxStyle.Information, "no selection")
            Exit Sub
        End If

        If MsgBox("are you sure you want to delete this appointment?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "confirm delete") = MsgBoxResult.Yes Then
            SetQuery("DELETE FROM tblappointment WHERE id = " & txtid.Text)
            fill()
            clearfields()
            MsgBox("Appointment deleted successfully!", MsgBoxStyle.Information, "success")
        End If
    End Sub

    Private Sub appointmentlist_doubleclick(sender As Object, e As EventArgs) Handles appointmentlist.DoubleClick
        appointmentid = appointmentlist.FocusedItem.SubItems(7).Text

        GetQuery("SELECT a.id, a.appointmenttype, a.procedurereq, a.appointmentdate, a.appointmenttime, a.reason, a.doctorid, d.docname FROM tblappointment a INNER JOIN tbldoctor d ON a.doctorid = d.id WHERE a.id = " & appointmentid, "tblappointment")

        Dim doctorid As String = ds.Tables("tblappointment").Rows(0).Item("doctorid").ToString

        txtid.Text = ds.Tables("tblappointment").Rows(0).Item("id").ToString
        cmbapttype.SelectedItem = ds.Tables("tblappointment").Rows(0).Item("appointmenttype").ToString
        cmbprocedurereq.SelectedItem = ds.Tables("tblappointment").Rows(0).Item("procedurereq").ToString
        txtdate.Text = ds.Tables("tblappointment").Rows(0).Item("appointmentdate").ToString
        cmbtime.SelectedItem = ds.Tables("tblappointment").Rows(0).Item("appointmenttime").ToString
        txtreason.Text = ds.Tables("tblappointment").Rows(0).Item("reason").ToString

        listdoctor()
        cmbdoctor.SelectedValue = doctorid

        btnupdate.Enabled = True
        btndelete.Enabled = True
        lockupdate.Visible = 0
        lockdelete.Visible = 0
    End Sub

    Public Sub listdoctor()
        GetQuery("SELECT id, docname FROM tbldoctor", "tbldoctor")
        If ds.Tables("tbldoctor").Rows.Count = 0 Then
            MsgBox("No doctors found in the database.", MsgBoxStyle.Information, "Debug")
            Exit Sub
        End If

        cmbdoctor.DisplayMember = "docname"
        cmbdoctor.ValueMember = "id"
        cmbdoctor.DataSource = ds.Tables("tbldoctor")
    End Sub

    Private Sub btncancel_click(sender As Object, e As EventArgs) Handles btncancel.Click
        If updating Then
            If MsgBox("Are you sure you want to cancel updating classroom information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
                updating = False
                disablebuttons()
                clearfields()
                pnlinput.Enabled = False
                appointmentid = Nothing
            End If
        ElseIf adding Then
            If MsgBox("Are you sure you want to cancel adding new classroom information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
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
            loggedinpatientid = Nothing
            clearfields()
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
End Class
