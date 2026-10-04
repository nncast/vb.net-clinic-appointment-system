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

    ' True when the box only shows its grey placeholder text (i.e. nothing was typed).
    Public Function IsPlaceholder(txtbox As TextBox, defaultText As String) As Boolean
        Return txtbox.ForeColor = Color.Silver AndAlso txtbox.Text = defaultText
    End Function

    ' Text typed into a box with a placeholder, or "" when only the placeholder is showing.
    Public Function TypedText(txtbox As TextBox, defaultText As String) As String
        If IsPlaceholder(txtbox, defaultText) Then Return ""
        Return txtbox.Text.Trim()
    End Function

    ' Parses a yyyy-MM-dd date from a masked box; False when it is incomplete or not a real date.
    Public Function TryGetDate(box As MaskedTextBox, ByRef value As Date) As Boolean
        If Not box.MaskCompleted Then Return False
        Return Date.TryParseExact(box.Text, "yyyy-MM-dd", Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, value)
    End Function

    ' Replaces a plain-text password left over from before hashing with its hash.
    Public Sub UpgradeLegacyPassword(table As String, id As Integer, password As String, stored As String)
        If NeedsRehash(stored) Then
            SetQuery("UPDATE " & table & " SET password = @p WHERE id = @id", P("@p", HashPassword(password)), P("@id", id))
        End If
    End Sub

End Module
