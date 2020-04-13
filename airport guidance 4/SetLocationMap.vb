Public Class SetLocationMap
    Dim idleTimer As DateTime
    Private Sub btnCancelNode_Click(sender As Object, e As EventArgs) Handles btnCancelNode.Click
        Dim open As New MapWindow
        open.ShowDialog()
        Close()
    End Sub

    Private Sub SetLocationMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If span.Seconds > 40 Then
            Dim open As New MapWindow
            Timer1.Stop()
            open.ShowDialog()
            Close()
            Dispose(True)
        End If
    End Sub

    Private Sub MapWithNodes_Click(sender As Object, e As EventArgs) Handles MapWithNodes.Click

    End Sub
End Class