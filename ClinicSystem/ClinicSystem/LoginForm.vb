Public Class LoginForm
    Private passwordRevealed As Boolean = False
    Private adminTableExists As Boolean = True

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()

        ' Databases created before v0.1.1 have no admin table yet (see database/upgrade-v0.1.1.sql).
        adminTableExists = CInt(GetValue("SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = DATABASE() AND table_name = 'tbladmin'")) > 0

        ' The password is hidden while typing; the eye icon shows it.
        piceyeview.Visible = True
        piceyehide.Visible = False
        UpdatePasswordMask()
    End Sub

    Public Sub clearfields()
        txtemail.Clear()
        txtpassword.Clear()
        HandleFocus(txtemail, shapeemail, False, "Email")
        HandleFocus(txtpassword, shapepassword, False, "Password")
        UpdatePasswordMask()
    End Sub

    ' The grey "Password" placeholder must stay readable; typed text is masked unless revealed.
    Private Sub UpdatePasswordMask()
        txtpassword.UseSystemPasswordChar = Not passwordRevealed AndAlso Not IsPlaceholder(txtpassword, "Password")
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim login As String = TypedText(txtemail, "Email")
        Dim password As String = TypedText(txtpassword, "Password")

        If login = "" Or password = "" Then
            MsgBox("Please enter your email and password.", MsgBoxStyle.Exclamation, "Missing Information")
            Exit Sub
        End If

        ' Admin accounts are stored (hashed) in tbladmin instead of being hard-coded.
        If adminTableExists Then
            GetQuery("SELECT id, password FROM tbladmin WHERE username = @u", "tbladmin", P("@u", login))
            If ds.Tables("tbladmin").Rows.Count > 0 Then
                Dim admin As DataRow = ds.Tables("tbladmin").Rows(0)
                If VerifyPassword(password, admin("password").ToString()) Then
                    UpgradeLegacyPassword("tbladmin", CInt(admin("id")), password, admin("password").ToString())
                    clearfields()
                    Me.Hide()
                    PatientForm.Show()
                    Exit Sub
                End If
            End If
        ElseIf login.Equals("admin", StringComparison.OrdinalIgnoreCase) Then
            MsgBox("This database has no admin account table yet. Import database/upgrade-v0.1.1.sql, then log in again.", MsgBoxStyle.Exclamation, "Database Upgrade Needed")
            Exit Sub
        End If

        GetQuery("SELECT id, password FROM tblpatient WHERE email = @e", "tblpatient", P("@e", login))

        If ds.Tables("tblpatient").Rows.Count > 0 AndAlso VerifyPassword(password, ds.Tables("tblpatient").Rows(0)("password").ToString()) Then
            Dim patient As DataRow = ds.Tables("tblpatient").Rows(0)
            Dim patientid As Integer = CInt(patient("id"))
            UpgradeLegacyPassword("tblpatient", patientid, password, patient("password").ToString())
            loggedinpatientid = patientid

            MsgBox("Login successful!", MsgBoxStyle.Information, "Welcome")
            clearfields()
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
        UpdatePasswordMask()
    End Sub

    Private Sub txtpassword_LostFocus(sender As Object, e As EventArgs) Handles txtpassword.LostFocus
        HandleFocus(txtpassword, shapepassword, False, "Password")
        UpdatePasswordMask()
    End Sub

    Private Sub piceyeview_Click(sender As Object, e As EventArgs) Handles piceyeview.Click
        passwordRevealed = True
        UpdatePasswordMask()
        piceyeview.Visible = False
        piceyehide.Visible = True
    End Sub

    Private Sub piceyehide_Click(sender As Object, e As EventArgs) Handles piceyehide.Click
        passwordRevealed = False
        UpdatePasswordMask()
        piceyeview.Visible = True
        piceyehide.Visible = False
    End Sub

End Class
