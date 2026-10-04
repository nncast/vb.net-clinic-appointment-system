Public Class PatientForm
    Public adding As Boolean = False
    Public updating As Boolean = False
    Public ptid As Integer = Nothing
    Private ReadOnly passwordTip As New ToolTip()

    Private Sub PatientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()

        passwordTip.SetToolTip(txtpassword, "Required for a new patient. When updating, leave blank to keep the current password.")
        fill()
        btnnew.Enabled = True
        btnsave.Enabled = False
        pnlinput.Enabled = False
    End Sub

    Public Sub fill()
        ' Passwords are hashed and never shown.
        GetQuery("SELECT p.id, p.fname, p.lname, p.dob, p.sex, p.phonenum, p.email, a.street, a.barangay, a.city, a.province FROM tblpatient p LEFT JOIN tblpatientaddress a ON p.id = a.patientid", "tblpatient")
        patientview.Items.Clear()
        For i = 0 To ds.Tables("tblpatient").Rows.Count - 1
            Dim item = patientview.Items.Add(ds.Tables("tblpatient").Rows(i).Item("id").ToString())
            With item.SubItems
                .Add(ds.Tables("tblpatient").Rows(i).Item("fname").ToString())
                .Add(ds.Tables("tblpatient").Rows(i).Item("lname").ToString())
                .Add(ds.Tables("tblpatient").Rows(i).Item("dob").ToString())
                .Add(ds.Tables("tblpatient").Rows(i).Item("sex").ToString())
                .Add(ds.Tables("tblpatient").Rows(i).Item("phonenum").ToString())
                .Add(ds.Tables("tblpatient").Rows(i).Item("street").ToString())
                .Add(ds.Tables("tblpatient").Rows(i).Item("barangay").ToString())
                .Add(ds.Tables("tblpatient").Rows(i).Item("city").ToString())
                .Add(ds.Tables("tblpatient").Rows(i).Item("province").ToString())
                .Add(ds.Tables("tblpatient").Rows(i).Item("email").ToString())
            End With
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
        txtfname.Clear()
        txtlname.Clear()
        txtdob.Clear()
        cmbsex.SelectedIndex = -1
        txtphonenum.Clear()
        txtstreet.Clear()
        txtbarangay.Clear()
        txtcity.Clear()
        txtprovince.Clear()
        txtemail.Clear()
        txtpassword.Clear()
    End Sub

    Private Function validfields() As Boolean
        Dim dob As Date

        If txtfname.Text.Trim() = "" Or txtlname.Text.Trim() = "" Or Not txtdob.MaskCompleted Or cmbsex.SelectedIndex = -1 Or Not txtphonenum.MaskCompleted Or txtstreet.Text.Trim() = "" Or txtbarangay.Text.Trim() = "" Or txtcity.Text.Trim() = "" Or txtprovince.Text.Trim() = "" Or txtemail.Text.Trim() = "" Then
            MsgBox("All fields are required!", MsgBoxStyle.Critical, "Validation Error")
            Return False
        End If

        If Not TryGetDate(txtdob, dob) OrElse dob > Today Then
            MsgBox("Enter a valid date of birth (YYYY-MM-DD).", MsgBoxStyle.Critical, "Validation Error")
            Return False
        End If

        Dim password As String = txtpassword.Text.Trim()
        If adding And password = "" Then
            MsgBox("A password is required for a new patient.", MsgBoxStyle.Critical, "Validation Error")
            Return False
        End If
        If password <> "" And password.Length < MinPasswordLength Then
            MsgBox("Password must be at least " & MinPasswordLength & " characters.", MsgBoxStyle.Critical, "Validation Error")
            Return False
        End If

        If CInt(GetValue("SELECT COUNT(*) FROM tblpatient WHERE email = @e AND id <> @id", P("@e", txtemail.Text.Trim()), P("@id", If(updating, ptid, -1)))) > 0 Then
            MsgBox("Another patient already uses this email.", MsgBoxStyle.Critical, "Validation Error")
            Return False
        End If

        Return True
    End Function

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        enablebuttons()
        clearfields()
        ptid = Nothing
        adding = True
        pnlinput.Enabled = True
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If ptid = Nothing Then
            MsgBox("Select a patient to update", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            Exit Sub
        End If

        enablebuttons()
        updating = True
        pnlinput.Enabled = True
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If Not (adding Or updating) Then Exit Sub
        If Not validfields() Then Exit Sub

        Dim question As String = If(adding, "Are you sure you want to add this patient?", "Are you sure you want to update this patient's information?")
        If MsgBox(question, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") <> MsgBoxResult.Yes Then Exit Sub

        Dim dob As Date
        TryGetDate(txtdob, dob)
        Dim password As String = txtpassword.Text.Trim()

        Try
            BeginTransaction()
            If adding Then
                Execute("INSERT INTO tblpatient (fname, lname, dob, sex, phonenum, email, password) VALUES (@fname, @lname, @dob, @sex, @phone, @email, @password)",
                        P("@fname", txtfname.Text.Trim()), P("@lname", txtlname.Text.Trim()), P("@dob", dob.ToString("yyyy-MM-dd")), P("@sex", cmbsex.Text.Trim()),
                        P("@phone", txtphonenum.Text.Trim()), P("@email", txtemail.Text.Trim()), P("@password", HashPassword(password)))
                ptid = GetLastInsertedID()
            Else
                Execute("UPDATE tblpatient SET fname = @fname, lname = @lname, dob = @dob, sex = @sex, phonenum = @phone, email = @email WHERE id = @id",
                        P("@fname", txtfname.Text.Trim()), P("@lname", txtlname.Text.Trim()), P("@dob", dob.ToString("yyyy-MM-dd")), P("@sex", cmbsex.Text.Trim()),
                        P("@phone", txtphonenum.Text.Trim()), P("@email", txtemail.Text.Trim()), P("@id", ptid))
                ' A blank password box keeps the current password.
                If password <> "" Then
                    Execute("UPDATE tblpatient SET password = @password WHERE id = @id", P("@password", HashPassword(password)), P("@id", ptid))
                End If
            End If

            ' patientid is unique, so this inserts the address if it was missing and updates it otherwise.
            Execute("INSERT INTO tblpatientaddress (patientid, street, barangay, city, province) VALUES (@id, @street, @barangay, @city, @province) " &
                    "ON DUPLICATE KEY UPDATE street = VALUES(street), barangay = VALUES(barangay), city = VALUES(city), province = VALUES(province)",
                    P("@id", ptid), P("@street", txtstreet.Text.Trim()), P("@barangay", txtbarangay.Text.Trim()), P("@city", txtcity.Text.Trim()), P("@province", txtprovince.Text.Trim()))
            CommitTransaction()
        Catch ex As Exception
            RollbackTransaction()
            MsgBox("Could not save the patient: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try

        Dim message As String = If(adding, "Patient added successfully!", "Patient updated successfully!")
        fill()
        clearfields()
        disablebuttons()
        pnlinput.Enabled = False
        adding = False
        updating = False
        ptid = Nothing
        MsgBox(message, MsgBoxStyle.Information, "Success")
    End Sub

    Private Sub classview_DoubleClick(sender As Object, e As EventArgs) Handles patientview.DoubleClick
        If adding Or updating Or patientview.SelectedItems.Count = 0 Then Exit Sub

        ptid = CInt(patientview.SelectedItems(0).SubItems(0).Text)

        GetQuery("SELECT p.id, p.fname, p.lname, p.dob, p.sex, p.phonenum, p.email, a.street, a.barangay, a.city, a.province " &
                 "FROM tblpatient p LEFT JOIN tblpatientaddress a ON p.id = a.patientid WHERE p.id = @id", "tblpatient", P("@id", ptid))
        If ds.Tables("tblpatient").Rows.Count = 0 Then Exit Sub

        txtid.Text = ds.Tables("tblpatient").Rows(0).Item("id").ToString()
        txtfname.Text = ds.Tables("tblpatient").Rows(0).Item("fname").ToString()
        txtlname.Text = ds.Tables("tblpatient").Rows(0).Item("lname").ToString()
        txtdob.Text = ds.Tables("tblpatient").Rows(0).Item("dob").ToString()
        cmbsex.Text = ds.Tables("tblpatient").Rows(0).Item("sex").ToString()
        txtphonenum.Text = ds.Tables("tblpatient").Rows(0).Item("phonenum").ToString()
        txtstreet.Text = ds.Tables("tblpatient").Rows(0).Item("street").ToString()
        txtbarangay.Text = ds.Tables("tblpatient").Rows(0).Item("barangay").ToString()
        txtcity.Text = ds.Tables("tblpatient").Rows(0).Item("city").ToString()
        txtprovince.Text = ds.Tables("tblpatient").Rows(0).Item("province").ToString()
        txtemail.Text = ds.Tables("tblpatient").Rows(0).Item("email").ToString()
        txtpassword.Clear()

        btnupdate.Enabled = True
        btndelete.Enabled = True
        lockupdate.Visible = 0
        lockdelete.Visible = 0
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If ptid = Nothing Then
            MsgBox("Select a patient to delete", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
        Else
            If MsgBox("Are you sure you want to delete this patient? Their address and appointments will also be deleted.", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                ' The address and appointments go with it (ON DELETE CASCADE).
                If SetQuery("DELETE FROM tblpatient WHERE id = @id", P("@id", ptid)) Then
                    fill()
                    clearfields()
                    ptid = Nothing
                    MsgBox("Deleted", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
                End If
            End If
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        If updating Then
            If MsgBox("Are you sure you want to cancel updating patient information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
                updating = False
                disablebuttons()
                clearfields()
                pnlinput.Enabled = False
                ptid = Nothing
            End If
        ElseIf adding Then
            If MsgBox("Are you sure you want to cancel adding new patient information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
                adding = False
                disablebuttons()
                clearfields()
                pnlinput.Enabled = False
                ptid = Nothing
            End If
        Else
            ptid = Nothing
            adding = False
            updating = False
            disablebuttons()
            clearfields()
            pnlinput.Enabled = False
        End If
    End Sub

    Private Sub piclogout_Click(sender As Object, e As EventArgs) Handles piclogout.Click
        If MsgBox("Are you sure you want to logout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Logout") = MsgBoxResult.Yes Then
            clearfields()
            pnlinput.Enabled = False
            disablebuttons()
            adding = False
            updating = False
            ptid = Nothing
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub txtfname_GotFocus(sender As Object, e As EventArgs) Handles txtfname.GotFocus
        HandleFocus(shapefname, True)
    End Sub

    Private Sub txtfname_LostFocus(sender As Object, e As EventArgs) Handles txtfname.LostFocus
        HandleFocus(shapefname, False)
    End Sub

    Private Sub txtlname_GotFocus(sender As Object, e As EventArgs) Handles txtlname.GotFocus
        HandleFocus(shapelname, True)
    End Sub

    Private Sub txtlname_LostFocus(sender As Object, e As EventArgs) Handles txtlname.LostFocus
        HandleFocus(shapelname, False)
    End Sub

    Private Sub txtdob_GotFocus(sender As Object, e As EventArgs) Handles txtdob.GotFocus
        HandleFocus(shapedob, True)
    End Sub

    Private Sub txtdob_LostFocus(sender As Object, e As EventArgs) Handles txtdob.LostFocus
        HandleFocus(shapedob, False)
    End Sub

    Private Sub cmbsex_GotFocus(sender As Object, e As EventArgs) Handles cmbsex.GotFocus
        HandleFocus(shapesex, True)
    End Sub

    Private Sub cmbsex_LostFocus(sender As Object, e As EventArgs) Handles cmbsex.LostFocus
        HandleFocus(shapesex, False)
    End Sub

    Private Sub txtphonenum_GotFocus(sender As Object, e As EventArgs) Handles txtphonenum.GotFocus
        HandleFocus(shapephonenum, True)
    End Sub

    Private Sub txtphonenum_LostFocus(sender As Object, e As EventArgs) Handles txtphonenum.LostFocus
        HandleFocus(shapephonenum, False)
    End Sub

    Private Sub txtstreet_GotFocus(sender As Object, e As EventArgs) Handles txtstreet.GotFocus
        HandleFocus(shapestreet, True)
    End Sub

    Private Sub txtstreet_LostFocus(sender As Object, e As EventArgs) Handles txtstreet.LostFocus
        HandleFocus(shapestreet, False)
    End Sub

    Private Sub txtbarangay_GotFocus(sender As Object, e As EventArgs) Handles txtbarangay.GotFocus
        HandleFocus(shapebarangay, True)
    End Sub

    Private Sub txtbarangay_LostFocus(sender As Object, e As EventArgs) Handles txtbarangay.LostFocus
        HandleFocus(shapebarangay, False)
    End Sub

    Private Sub txtcity_GotFocus(sender As Object, e As EventArgs) Handles txtcity.GotFocus
        HandleFocus(shapecity, True)
    End Sub

    Private Sub txtcity_LostFocus(sender As Object, e As EventArgs) Handles txtcity.LostFocus
        HandleFocus(shapecity, False)
    End Sub

    Private Sub txtprovince_GotFocus(sender As Object, e As EventArgs) Handles txtprovince.GotFocus
        HandleFocus(shapeprovince, True)
    End Sub

    Private Sub txtprovince_LostFocus(sender As Object, e As EventArgs) Handles txtprovince.LostFocus
        HandleFocus(shapeprovince, False)
    End Sub

    Private Sub txtemail_GotFocus(sender As Object, e As EventArgs) Handles txtemail.GotFocus
        HandleFocus(shapeemail, True)
    End Sub

    Private Sub txtemail_LostFocus(sender As Object, e As EventArgs) Handles txtemail.LostFocus
        HandleFocus(shapeemail, False)
    End Sub

    Private Sub txtpassword_GotFocus(sender As Object, e As EventArgs) Handles txtpassword.GotFocus
        HandleFocus(shapepassword, True)
    End Sub

    Private Sub txtpassword_LostFocus(sender As Object, e As EventArgs) Handles txtpassword.LostFocus
        HandleFocus(shapepassword, False)
    End Sub

    ' The login form is only hidden after signing in, so closing this window
    ' has to end the program; otherwise it keeps running in the background.
    Private Sub PatientForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class
