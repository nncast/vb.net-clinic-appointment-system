Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect("localhost", "clinic", "3306", "root", "")
    End Sub

    Public Sub clearfields()
        txtemail.Clear()
        txtpassword.Clear()
        HandleFocus(txtemail, shapeemail, False, "Email")
        HandleFocus(txtpassword, shapepassword, False, "Password")
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtemail.Text = "admin" And txtpassword.Text = "admin" Then
            clearfields()
            txtpassword.UseSystemPasswordChar = False
            Me.Hide()
            PatientForm.Show()
            Exit Sub
        End If

        GetQuery("SELECT id FROM tblpatient WHERE email = '" & txtemail.Text.Trim & "' AND password = '" & txtpassword.Text.Trim & "'", "tblpatient")

        If ds.Tables("tblpatient").Rows.Count > 0 Then
            Dim patientid As Integer = ds.Tables("tblpatient").Rows(0).Item("id")
            loggedinpatientid = patientid

            MsgBox("Login successful!", MsgBoxStyle.Information, "Welcome")
            clearfields()
            txtpassword.UseSystemPasswordChar = False
            Me.Hide()
            AppointmentForm.Show()
            AppointmentForm.fill()
        Else
            MsgBox("Incorrect email or password.", MsgBoxStyle.Critical, "Login Failed")
        End If

    End Sub

    Private Sub lblsignup_Click(sender As Object, e As EventArgs) Handles lblsignup.Click
        If MsgBox("Are you sure you want to cancel logging in?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel Login") = MsgBoxResult.Yes Then
            clearfields()
            Me.Hide()
            SignUpForm.Show()
        End If
    End Sub

    Private Sub txtemail_GotFocus(sender As Object, e As EventArgs) Handles txtemail.GotFocus
        HandleFocus(txtemail, shapeemail, True, "Email")
    End Sub

    Private Sub txtemail_LostFocus(sender As Object, e As EventArgs) Handles txtemail.LostFocus
        HandleFocus(txtemail, shapeemail, False, "Email")
    End Sub

    Private Sub txtpassword_GotFocus(sender As Object, e As EventArgs) Handles txtpassword.GotFocus
        HandleFocus(txtpassword, shapepassword, True, "Password")
    End Sub

    Private Sub txtpassword_LostFocus(sender As Object, e As EventArgs) Handles txtpassword.LostFocus
        HandleFocus(txtpassword, shapepassword, False, "Password")
    End Sub

    Private Sub piceyeview_Click(sender As Object, e As EventArgs) Handles piceyeview.Click
        txtpassword.UseSystemPasswordChar = False
        piceyeview.Visible = False
        piceyehide.Visible = True
    End Sub

    Private Sub piceyehide_Click(sender As Object, e As EventArgs) Handles piceyehide.Click
        txtpassword.UseSystemPasswordChar = True
        piceyeview.Visible = True
        piceyehide.Visible = False
    End Sub

End Class