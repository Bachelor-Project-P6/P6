Public Class MapResult
    Dim idleTimer As DateTime
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

    Private Sub MapResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idleTimer = DateTime.Now
        Timer1.Start()
        Timer1.Interval = 5000
    End Sub

    Private Sub DestSelect_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        idleTimer = DateTime.Now
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim checkTime As DateTime = DateTime.Now
        Dim span As TimeSpan = checkTime.Subtract(idleTimer)
        If span.Seconds > 60 Then
            Dim open As New MapWindow
            Timer1.Stop()
            open.ShowDialog()
            Close()
            Dispose(True)
        End If
    End Sub

    Private Sub MapWRoute_Click(sender As Object, e As EventArgs) Handles MapWRoute.Click

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class