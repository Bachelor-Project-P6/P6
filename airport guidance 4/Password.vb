Public Class Password
    Dim idleTimer As DateTime
    Private Sub key2_Click(sender As Object, e As EventArgs) Handles key2.Click
        txtPasswordbox.Text += "2"
    End Sub

    Private Sub key7_Click(sender As Object, e As EventArgs) Handles key7.Click
        txtPasswordbox.Text += "7"
    End Sub

    Private Sub key3_Click(sender As Object, e As EventArgs) Handles key3.Click
        txtPasswordbox.Text += "3"
    End Sub

    Private Sub keyO_Click(sender As Object, e As EventArgs) Handles keyO.Click
        txtPasswordbox.Text += "O"
    End Sub

    Private Sub keyZ_Click(sender As Object, e As EventArgs) Handles keyZ.Click
        txtPasswordbox.Text += "Z"
    End Sub

    Private Sub keyB_Click(sender As Object, e As EventArgs) Handles keyB.Click
        txtPasswordbox.Text += "B"
    End Sub

    Private Sub btnEnterPassword_Click(sender As Object, e As EventArgs) Handles btnEnterPassword.Click
        If txtPasswordbox.Text = "TEMPPASS" Then
            Dim open As New SetLocationMap
            open.ShowDialog()
            Close()
        Else
            Dim open As New BadPassword
            open.ShowDialog()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim open As New MapWindow
        open.ShowDialog()
        Close()
    End Sub

    Private Sub key1_Click(sender As Object, e As EventArgs) Handles key1.Click
        txtPasswordbox.Text += "1"
    End Sub

    Private Sub key0_Click(sender As Object, e As EventArgs) Handles key0.Click
        txtPasswordbox.Text += "0"
    End Sub

    Private Sub keyW_Click(sender As Object, e As EventArgs) Handles keyW.Click
        txtPasswordbox.Text += "W"
    End Sub

    Private Sub key4_Click(sender As Object, e As EventArgs) Handles key4.Click
        txtPasswordbox.Text += "4"
    End Sub

    Private Sub key5_Click(sender As Object, e As EventArgs) Handles key5.Click
        txtPasswordbox.Text += "5"
    End Sub

    Private Sub key6_Click(sender As Object, e As EventArgs) Handles key6.Click
        txtPasswordbox.Text += "6"
    End Sub

    Private Sub key8_Click(sender As Object, e As EventArgs) Handles key8.Click
        txtPasswordbox.Text += "8"
    End Sub

    Private Sub key9_Click(sender As Object, e As EventArgs) Handles key9.Click
        txtPasswordbox.Text += "9"
    End Sub

    Private Sub keyQ_Click(sender As Object, e As EventArgs) Handles keyQ.Click
        txtPasswordbox.Text += "Q"
    End Sub

    Private Sub keyE_Click(sender As Object, e As EventArgs) Handles keyE.Click
        txtPasswordbox.Text += "E"
    End Sub

    Private Sub keyR_Click(sender As Object, e As EventArgs) Handles keyR.Click
        txtPasswordbox.Text += "R"
    End Sub

    Private Sub keyT_Click(sender As Object, e As EventArgs) Handles keyT.Click
        txtPasswordbox.Text += "T"
    End Sub

    Private Sub keyY_Click(sender As Object, e As EventArgs) Handles keyY.Click
        txtPasswordbox.Text += "Y"
    End Sub

    Private Sub keyU_Click(sender As Object, e As EventArgs) Handles keyU.Click
        txtPasswordbox.Text += "U"
    End Sub

    Private Sub keyI_Click(sender As Object, e As EventArgs) Handles keyI.Click
        txtPasswordbox.Text += "I"
    End Sub

    Private Sub keyP_Click(sender As Object, e As EventArgs) Handles keyP.Click
        txtPasswordbox.Text += "P"
    End Sub

    Private Sub keyA_Click(sender As Object, e As EventArgs) Handles keyA.Click
        txtPasswordbox.Text += "A"
    End Sub

    Private Sub keyS_Click(sender As Object, e As EventArgs) Handles keyS.Click
        txtPasswordbox.Text += "S"
    End Sub

    Private Sub keyD_Click(sender As Object, e As EventArgs) Handles keyD.Click
        txtPasswordbox.Text += "D"
    End Sub

    Private Sub keyF_Click(sender As Object, e As EventArgs) Handles keyF.Click
        txtPasswordbox.Text += "F"
    End Sub

    Private Sub keyG_Click(sender As Object, e As EventArgs) Handles keyG.Click
        txtPasswordbox.Text += "G"
    End Sub

    Private Sub keyH_Click(sender As Object, e As EventArgs) Handles keyH.Click
        txtPasswordbox.Text += "H"
    End Sub

    Private Sub keyJ_Click(sender As Object, e As EventArgs) Handles keyJ.Click
        txtPasswordbox.Text += "J"
    End Sub

    Private Sub keyK_Click(sender As Object, e As EventArgs) Handles keyK.Click
        txtPasswordbox.Text += "K"
    End Sub

    Private Sub keyL_Click(sender As Object, e As EventArgs) Handles keyL.Click
        txtPasswordbox.Text += "L"
    End Sub

    Private Sub keyX_Click(sender As Object, e As EventArgs) Handles keyX.Click
        txtPasswordbox.Text += "X"
    End Sub

    Private Sub keyC_Click(sender As Object, e As EventArgs) Handles keyC.Click
        txtPasswordbox.Text += "C"
    End Sub

    Private Sub keyV_Click(sender As Object, e As EventArgs) Handles keyV.Click
        txtPasswordbox.Text += "V"
    End Sub

    Private Sub keyN_Click(sender As Object, e As EventArgs) Handles keyN.Click
        txtPasswordbox.Text += "N"
    End Sub

    Private Sub keyM_Click(sender As Object, e As EventArgs) Handles keyM.Click
        txtPasswordbox.Text += "M"
    End Sub

    Private Sub keyBack_Click(sender As Object, e As EventArgs) Handles keyBack.Click
        txtPasswordbox.Text = txtPasswordbox.Text.Remove(txtPasswordbox.Text.Length - 1)
    End Sub

    Private Sub Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If span.Seconds > 10 Then
            Dim open As New MapWindow
            Timer1.Stop()
            open.ShowDialog()
            Close()
            Dispose(True)
        End If
    End Sub

    Private Sub TxtPasswordbox_TextChanged(sender As Object, e As EventArgs) Handles txtPasswordbox.TextChanged

    End Sub
End Class