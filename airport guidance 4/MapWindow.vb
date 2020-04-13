Public Class MapWindow
    Private Sub btnSelectDest_Click(sender As Object, e As EventArgs) Handles btnSelectDest.Click
        Dim open As New SelectDest
        open.ShowDialog()
        Close()
    End Sub

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        Dim open As New Password
        open.ShowDialog()
        Close()
    End Sub
End Class
