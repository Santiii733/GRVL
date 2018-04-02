Public Class modloader

    Private Function addDownload(titel As String, desc As String, url As String, img As String)
        Dim dPan As New Panel()
        dPan.Height = 160
        dPan.Width = 500
        dPan.BackColor = Color.LightGray

        Dim dBtn As New Button()
        dBtn.Text = "Install"
        dBtn.Location = New Point(392, 130)
        dBtn.Size = New Point(100, 23)
        dBtn.Tag = url
        AddHandler dBtn.Click, AddressOf Me.Install_Button_Click


        Dim dPic As New PictureBox()
        dPic.Size = New Point(150, 150)
        dPic.Location = New Point(5, 5)
        dPic.SizeMode = PictureBoxSizeMode.Zoom
        dPic.ImageLocation = img

        Dim dTit As New Label()
        dTit.Text = titel
        dTit.Location = New Point(160, 5)
        dTit.Size = New Point(300, 20)

        dTit.Font = New Font("Sans Serif", 10, FontStyle.Bold)

        Dim dDesc As New Label()
        dDesc.Size = New Point(328, 100)
        dDesc.Location = New Point(164, 27)
        dDesc.Text = desc

        dPan.Controls.Add(dBtn)
        dPan.Controls.Add(dPic)
        dPan.Controls.Add(dTit)
        dPan.Controls.Add(dDesc)
        FlowLayoutPanel1.Controls.Add(dPan)
    End Function

    Private Sub modloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mods()
        Using wd As New System.Net.WebClient()
            Dim modData = wd.DownloadString("https://grvl.gingolingoo.de/api.php?action=getMods")
            mods = modData.Split(";")
            For Each mData As String In mods
                If mData <> "" Then
                    Dim mdt() = mData.Split("|")
                    addDownload(mdt(0), mdt(1), mdt(2), mdt(3))
                End If
            Next
        End Using
    End Sub

    Private Sub Install_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MsgBox(sender.tag.ToString)

    End Sub
End Class