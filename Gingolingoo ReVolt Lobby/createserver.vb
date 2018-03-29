Public Class createserver
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        Dim str(3) As String
        Dim itm As ListViewItem
        str(0) = TextBox1.Text
        str(1) = playercnt.Text.ToString
        str(2) = MainWindow.wanip.ToString
        itm = New ListViewItem(str)
        MainWindow.serverlist.Items.Add(itm)
        Me.Close()
        mplobby.Show()
    End Sub

    Private Sub createserver_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class