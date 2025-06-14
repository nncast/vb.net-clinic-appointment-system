Module Globals
    Public loggedinpatientid As Integer

    Public Sub HandleFocus(shape As PowerPacks.RectangleShape, isFocused As Boolean)
        If isFocused Then
            shape.BorderColor = Color.FromArgb(72, 226, 176)
        Else
            shape.BorderColor = Color.Black
        End If
    End Sub

    Public Sub HandleFocus(txtbox As TextBox, shape As PowerPacks.RectangleShape, isFocused As Boolean, defaultText As String)
        If isFocused Then
            shape.BorderColor = Color.FromArgb(72, 226, 176)
            If txtbox.Text = defaultText And txtbox.ForeColor = Color.Silver Then
                txtbox.Clear()
                txtbox.ForeColor = Color.Black
            End If
        Else
            shape.BorderColor = Color.Black
            If txtbox.Text.Trim = Nothing Then
                txtbox.ForeColor = Color.Silver
                txtbox.Text = defaultText
            End If
        End If
    End Sub

End Module
