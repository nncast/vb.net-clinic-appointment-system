Public Class PatientForm
        Public adding As Boolean = False
        Public updating As Boolean = False
    Public ptid As Integer = Nothing

    Private Sub PatientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect("localhost", "clinic", "3306", "root", "")

        fill()
        btnnew.Enabled = True
        btnsave.Enabled = False
        pnlinput.Enabled = False
    End Sub

    Public Sub fill()
        GetQuery("SELECT p.id, p.fname, p.lname, p.dob, p.sex, p.phonenum, p.email, p.password, a.street, a.barangay, a.city, a.province FROM tblpatient p LEFT JOIN tblpatientaddress a ON p.id = a.patientid", "tblpatient")
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
                .Add(ds.Tables("tblpatient").Rows(i).Item("password").ToString())
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

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        enablebuttons()
        clearfields()
        adding = True
        pnlinput.Enabled = True
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        enablebuttons()
        updating = True
        pnlinput.Enabled = True
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If adding Then
            If txtfname.Text = "" Or txtlname.Text = "" Or txtdob.Text = "" Or cmbsex.SelectedIndex = -1 Or txtphonenum.Text = "" Or txtstreet.Text = "" Or txtbarangay.Text = "" Or txtcity.Text = "" Or txtprovince.Text = "" Or txtemail.Text = "" Or txtpassword.Text = "" Then
                MsgBox("All fields are required!", MsgBoxStyle.Critical, "Validation Error")
            Else
                If MsgBox("Are you sure you want to add this patient?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    SetQuery("INSERT INTO tblpatient (fname, lname, dob, sex, phonenum, email, password) VALUES ('" & txtfname.Text.Trim() & "', '" & txtlname.Text.Trim() & "', '" & txtdob.Text.Trim() & "', '" & cmbsex.Text.Trim() & "', '" & txtphonenum.Text.Trim() & "', '" & txtemail.Text.Trim() & "', '" & txtpassword.Text.Trim() & "')")
                    Dim lastPatientID As Integer = GetLastInsertedID()
                    SetQuery("INSERT INTO tblpatientaddress (patientid, street, barangay, city, province) VALUES (" & lastPatientID & ", '" & txtstreet.Text.Trim() & "', '" & txtbarangay.Text.Trim() & "', '" & txtcity.Text.Trim() & "', '" & txtprovince.Text.Trim() & "')")

                    fill()
                    clearfields()
                    disablebuttons()
                    pnlinput.Enabled = False
                    adding = False
                    MsgBox("Patient added successfully!", MsgBoxStyle.Information, "Success")
                End If
            End If
        ElseIf updating Then
            If MsgBox("Are you sure you want to update this patient's information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                SetQuery("UPDATE tblpatient SET " & "fname = '" & txtfname.Text.Trim() & "', " & "lname = '" & txtlname.Text.Trim() & "', " & "dob = '" & txtdob.Text.Trim() & "', " & "sex = '" & cmbsex.Text.Trim() & "', " & "phonenum = '" & txtphonenum.Text.Trim() & "', " & "email = '" & txtemail.Text.Trim() & "', " & "password = '" & txtpassword.Text.Trim() & "' " & "WHERE id = " & ptid)
                SetQuery("UPDATE tblpatientaddress SET " & "street = '" & txtstreet.Text.Trim() & "', " & "barangay = '" & txtbarangay.Text.Trim() & "', " & "city = '" & txtcity.Text.Trim() & "', " & "province = '" & txtprovince.Text.Trim() & "' " & "WHERE patientid = " & ptid)

                fill()
                clearfields()
                disablebuttons()
                pnlinput.Enabled = False
                updating = False
                MsgBox("Patient updated successfully!", MsgBoxStyle.Information, "Success")
            End If
        End If
    End Sub

    Private Sub classview_DoubleClick(sender As Object, e As EventArgs) Handles patientview.DoubleClick
        ptid = patientview.FocusedItem.SubItems(0).Text

        GetQuery("SELECT p.id, p.fname, p.lname, p.dob, p.sex, p.phonenum, p.email, p.password, a.street, a.barangay, a.city, a.province " & "FROM tblpatient p " & "LEFT JOIN tblpatientaddress a ON p.id = a.patientid " & "WHERE p.id = " & ptid, "tblpatient")

        txtid.Text = ds.Tables("tblpatient").Rows(0).Item("fname").ToString()
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
        txtpassword.Text = ds.Tables("tblpatient").Rows(0).Item("password").ToString()

        btnupdate.Enabled = True
        btndelete.Enabled = True
        lockupdate.Visible = 0
        lockdelete.Visible = 0
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If ptid = Nothing Then
            MsgBox("Select tblpatient to delete", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
        Else
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                SetQuery("DELETE FROM tblpatient WHERE id ='" & ptid & "'")
                fill()
                clearfields()
                ptid = Nothing
                MsgBox("Deleted", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            End If
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        If updating Then
            If MsgBox("Are you sure you want to cancel updating classroom information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
                updating = False
                disablebuttons()
                clearfields()
                pnlinput.Enabled = False
                ptid = Nothing
            End If
        ElseIf adding Then
            If MsgBox("Are you sure you want to cancel adding new classroom information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
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

End Class