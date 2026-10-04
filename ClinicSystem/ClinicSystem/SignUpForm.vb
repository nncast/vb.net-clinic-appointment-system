Public Class SignUpForm

    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        txtpassword.UseSystemPasswordChar = True
    End Sub

    Public Sub clearfields()
        txtfname.Clear()
        txtlname.Clear()
        txtdob.Clear()
        ' SelectedValue can't be set on an unbound combo box (it throws), so reset the index.
        cmbsex.SelectedIndex = -1
        txtphonenum.Clear()
        txtstreet.Clear()
        txtbarangay.Clear()
        txtcity.Clear()
        txtprovince.Clear()
        txtemail.Clear()
        txtpassword.Clear()
        ' Put the grey placeholders back (focused = False), each on its own outline.
        HandleFocus(txtstreet, shapestreet, False, "Street")
        HandleFocus(txtbarangay, shapebarangay, False, "Barangay")
        HandleFocus(txtcity, shapecity, False, "City")
        HandleFocus(txtprovince, shapeprovince, False, "Province")
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Dim street As String = TypedText(txtstreet, "Street")
        Dim barangay As String = TypedText(txtbarangay, "Barangay")
        Dim city As String = TypedText(txtcity, "City")
        Dim province As String = TypedText(txtprovince, "Province")
        Dim email As String = txtemail.Text.Trim()
        Dim password As String = txtpassword.Text.Trim()
        Dim dob As Date

        If txtfname.Text.Trim = Nothing Or txtlname.Text.Trim = Nothing Or Not txtdob.MaskCompleted Or cmbsex.SelectedIndex = -1 Or Not txtphonenum.MaskCompleted Or street = "" Or barangay = "" Or city = "" Or province = "" Or email = "" Or password = "" Then
            MsgBox("All fields are required!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Missing Information")
            Exit Sub
        End If

        If Not TryGetDate(txtdob, dob) OrElse dob > Today Then
            MsgBox("Enter a valid date of birth (YYYY-MM-DD).", MsgBoxStyle.Exclamation, "Invalid Date")
            Exit Sub
        End If

        If password.Length < MinPasswordLength Then
            MsgBox("Password must be at least " & MinPasswordLength & " characters.", MsgBoxStyle.Exclamation, "Weak Password")
            Exit Sub
        End If

        If CInt(GetValue("SELECT COUNT(*) FROM tblpatient WHERE email = @e", P("@e", email))) > 0 Then
            MsgBox("An account with this email already exists.", MsgBoxStyle.Exclamation, "Email Taken")
            Exit Sub
        End If

        Try
            BeginTransaction()
            Execute("INSERT INTO tblpatient (fname, lname, dob, sex, phonenum, email, password) VALUES (@fname, @lname, @dob, @sex, @phone, @email, @password)",
                    P("@fname", txtfname.Text.Trim()), P("@lname", txtlname.Text.Trim()), P("@dob", dob.ToString("yyyy-MM-dd")),
                    P("@sex", cmbsex.SelectedItem.ToString()), P("@phone", txtphonenum.Text.Trim()), P("@email", email), P("@password", HashPassword(password)))
            Dim patientid As Integer = GetLastInsertedID()
            Execute("INSERT INTO tblpatientaddress (patientid, street, barangay, city, province) VALUES (@id, @street, @barangay, @city, @province)",
                    P("@id", patientid), P("@street", street), P("@barangay", barangay), P("@city", city), P("@province", province))
            CommitTransaction()
        Catch ex As Exception
            RollbackTransaction()
            MsgBox("Registration failed: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try

        MsgBox("Registration successful!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")
        clearfields()
        Me.Hide()
        LoginForm.Show()
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

    ' Closing sign-up goes back to the (hidden) login form instead of leaving
    ' the program running with no window.
    Private Sub SignUpForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub
End Class
