Public Class Selection
    Private Sub OrderButton_Click(sender As Object, e As EventArgs) Handles OrderButton.Click

    End Sub

    Private Sub openformadmin()
        AdminLogin.Show()
        Me.Hide()
    End Sub

    Private Sub AdminButton_Click(sender As Object, e As EventArgs) Handles AdminButton.Click
        openformadmin()
    End Sub

    Private Sub AdminLabel_Click(sender As Object, e As EventArgs) Handles AdminLabel.Click
        openformadmin()
    End Sub
End Class