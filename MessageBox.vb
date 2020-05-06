Public Class MessageBoxs
    Private Sub YesCheck_Click(sender As Object, e As EventArgs) Handles YesCheck.Click
        If ErrorText.Tag = "Admin" Then
            AdminLogin.Show()
            Me.Close()
        End If
    End Sub
End Class