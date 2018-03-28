Public Class mplobby
    Dim Nodes(4096) As TreeNode
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles readybtn.Click
        If readybtn.CheckState = CheckState.Checked Then
            readybtn.CheckState = CheckState.Unchecked
            startgame.Enabled = False
            readystate.ForeColor = Color.Red
            readystate.Text = MainWindow.GetIniValue("language", "$not_ready", My.Settings.languagefile, "$not_ready")
        Else
            readybtn.CheckState = CheckState.Checked
            startgame.Enabled = True
            readystate.ForeColor = Color.Green
            readystate.Text = MainWindow.GetIniValue("language", "$ready", My.Settings.languagefile, "$ready")
        End If
    End Sub

    Private Sub closelobby_Click(sender As Object, e As EventArgs) Handles closelobby.Click
        Me.Close()
    End Sub

    Private Sub mplobby_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripLabel2.Text = (MainWindow.ListView2.SelectedItems.ToString)
        Dim treeview1nodes As TreeNodeCollection = TreeView1.Nodes
        TreeView1.Nodes.Clear()
        Nodes(0) = New TreeNode(MainWindow.GetIniValue("language", "$friends", My.Settings.languagefile, "$friends"))
        Nodes(0).ImageIndex = 0
        Nodes(0).SelectedImageIndex = 0
        Nodes(0).Name = "friends"
        Nodes(1) = New TreeNode(MainWindow.GetIniValue("language", "$global", My.Settings.languagefile, "$global"))
        Nodes(1).ImageIndex = 5
        Nodes(1).SelectedImageIndex = 5
        Nodes(1).Name = "global"
        Nodes(2) = New TreeNode(MainWindow.GetIniValue("language", "$local", My.Settings.languagefile, "$local"))
        Nodes(2).ImageIndex = 6
        Nodes(2).SelectedImageIndex = 6
        Nodes(2).Name = "local"

        TreeView1.Nodes.Add(Nodes(0))
        TreeView1.Nodes.Add(Nodes(1))
        TreeView1.Nodes.Add(Nodes(2))
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            RichTextBox1.AppendText(My.Settings.nickname & ": " + TextBox1.Text & vbNewLine)
            TextBox1.Text = Nothing
        End If
    End Sub

    Private Sub startgame_Click(sender As Object, e As EventArgs) Handles startgame.Click
        Process.Start(My.Settings.revolt_path, My.Settings.parameters & " -lobby")
    End Sub
End Class