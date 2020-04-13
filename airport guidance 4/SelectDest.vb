Public Class SelectDest
    Dim idleTimer As DateTime
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRestroom.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnShop.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnFood.Click

    End Sub

    Private Sub btnShowResult_Click(sender As Object, e As EventArgs) Handles btnShowResult.Click
        Dim open As New MapResult
        open.ShowDialog()
        Close()
    End Sub

    Private Sub SelectDest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If span.Seconds > 20 Then
            Dim open As New MapWindow
            Timer1.Stop()
            open.ShowDialog()
            Close()
            Dispose(True)
        End If
    End Sub

    Private Sub BtnGate_Click(sender As Object, e As EventArgs) Handles BtnGate.Click
        Dim open As New Gate
        open.ShowDialog()

    End Sub
End Class