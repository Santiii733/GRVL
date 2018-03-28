Imports System
Imports System.IO
Imports System.Collections


Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.nickname
        ComboBox1.Text = My.Settings.language
        Dim di As New IO.DirectoryInfo(Application.StartupPath & "\languages\")
        Dim diar1 As IO.FileInfo() = di.GetFiles("*.ini")
        Dim dra As IO.FileInfo
        'list the names of all files in the specified directory
        For Each dra In diar1
            ComboBox1.Items.Add(dra)
        Next

    End Sub

    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        My.Settings.nickname = TextBox1.Text
        My.Settings.Save()
        MainWindow.Show()
        MainWindow.reloadall()
        Me.Close()
    End Sub

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        Application.Exit()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        My.Settings.languagefile = Application.StartupPath & "\languages\" & ComboBox1.Text
        My.Settings.language = ComboBox1.Text
        My.Settings.Save()
        MainWindow.SetLang()
    End Sub
End Class

