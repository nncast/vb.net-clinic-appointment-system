Public Class SignUpForm

    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect("localhost", "clinic", "3306", "root", "")
    End Sub

    Public Sub clearfields()
        txtfname.Clear()
        txtlname.Clear()
        txtdob.Clear()
        cmbsex.SelectedValue = -1
        txtphonenum.Clear()
        txtstreet.Clear()
        txtbarangay.Clear()
        txtcity.Clear()
        txtprovince.Clear()
        txtemail.Clear()
        txtpassword.Clear()
        HandleFocus(txtstreet, shapestreet, True, "Street")
        HandleFocus(txtbarangay, shapestreet, True, "Barangay")
        HandleFocus(txtcity, shapestreet, True, "City")
        HandleFocus(txtprovince, shapestreet, True, "Province")
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        If txtfname.Text.Trim = Nothing Or txtlname.Text.Trim = Nothing Or txtdob.Text.Trim = Nothing Or cmbsex.SelectedIndex = -1 Or txtphonenum.Text.Trim = Nothing Or txtstreet.Text.Trim = Nothing Or txtbarangay.Text.Trim = Nothing Or txtcity.Text.Trim = Nothing Or txtprovince.Text.Trim = Nothing Or txtemail.Text.Trim = Nothing Or txtpassword.Text.Trim = Nothing Then
            MsgBox("All fields are required!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Missing Information")
        Else
            SetQuery("INSERT INTO tblPatient (fname, lname, dob, sex, phonenum, email, password) VALUES ('" & txtfname.Text.Trim() & "', '" & txtlname.Text.Trim() & "', '" & txtdob.Text.Trim() & "', " & "'" & cmbsex.SelectedItem.ToString() & "', '" & txtphonenum.Text.Trim() & "', '" & txtemail.Text.Trim() & "', " & "'" & txtpassword.Text.Trim() & "')")

            Dim patientid As Integer
            GetQuery("SELECT LAST_INSERT_ID() AS last_id", "last_id")
            patientid = ds.Tables("last_id").Rows(0).Item("last_id")

            SetQuery("INSERT INTO tblPatientAddress (patientid, street, barangay, city, province) VALUES (" & patientid & ", '" & txtstreet.Text.Trim() & "', '" & txtbarangay.Text.Trim() & "', '" & txtcity.Text.Trim() & "', '" & txtprovince.Text.Trim() & "')")

            MsgBox("Registration successful!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")
            clearfields()
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub lbllogin_Click(sender As Object, e As EventArgs) Handles lbllogin.Click
        If MsgBox("Are you sure you want to cancel signing up?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel Signup") = MsgBoxResult.Yes Then
            Me.Hide()
            LoginForm.Show()
            clearfields()
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
        HandleFocus(txtstreet, shapestreet, True, "Street")
    End Sub

    Private Sub txtstreet_LostFocus(sender As Object, e As EventArgs) Handles txtstreet.LostFocus
        HandleFocus(txtstreet, shapestreet, False, "Street")
    End Sub

    Private Sub txtbarangay_GotFocus(sender As Object, e As EventArgs) Handles txtbarangay.GotFocus
        HandleFocus(txtbarangay, shapebarangay, True, "Barangay")
    End Sub

    Private Sub txtbarangay_LostFocus(sender As Object, e As EventArgs) Handles txtbarangay.LostFocus
        HandleFocus(txtbarangay, shapebarangay, False, "Barangay")
    End Sub

    Private Sub txtcity_GotFocus(sender As Object, e As EventArgs) Handles txtcity.GotFocus
        HandleFocus(txtcity, shapecity, True, "City")
    End Sub

    Private Sub txtcity_LostFocus(sender As Object, e As EventArgs) Handles txtcity.LostFocus
        HandleFocus(txtcity, shapecity, False, "City")
    End Sub

    Private Sub txtprovince_GotFocus(sender As Object, e As EventArgs) Handles txtprovince.GotFocus
        HandleFocus(txtprovince, shapeprovince, True, "Province")
    End Sub

    Private Sub txtprovince_LostFocus(sender As Object, e As EventArgs) Handles txtprovince.LostFocus
        HandleFocus(txtprovince, shapeprovince, False, "Province")
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