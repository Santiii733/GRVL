Public Class register
    Private Sub register_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        login.Show()
        MainWindow.reloadall()
        Me.Close()
    End Sub

    Private Sub registerButton_Click(sender As Object, e As EventArgs) Handles registerButton.Click
        Dim pass As String = login.GenerateSHA256String(TextBox2.Text)
        Dim repass As String = login.GenerateSHA256String(TextBox3.Text)
        If pass <> repass Then
            MsgBox(MainWindow.GetIniValue("language", "$passwordsNotMatch", My.Settings.languagefile, "$passwordsNotMatch"))
        Else
            Using wd As New System.Net.WebClient()
                Dim loginCheck = wd.DownloadString("https://grvl.gingolingoo.de/api.php?action=register&uname=" + TextBox1.Text + "&pword=" + pass + "&rpword=" + repass)
                If loginCheck <> "0" Then
                    My.Settings.nickname = loginCheck
                    My.Settings.Save()
                    MainWindow.Show()
                    MainWindow.reloadall()
                    Me.Close()
                Else
                    MsgBox(MainWindow.GetIniValue("language", "$usernameUsed", My.Settings.languagefile, "$usernameUsed"))
                End If
            End Using
        End If

    End Sub
End Class