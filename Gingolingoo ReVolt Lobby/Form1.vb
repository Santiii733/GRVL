﻿Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices
Imports System.Text

Public Class MainWindow

    <DllImport("kernel32")>
    Private Shared Function GetPrivateProfileString(ByVal section As String,
                                                    ByVal key As String,
                                                    ByVal def As String,
                                                    ByVal retVal As StringBuilder,
                                                    ByVal size As Integer,
                                                    ByVal filePath As String) As Integer
    End Function

    Public Function GetIniValue(section As String, key As String, filename As String, Optional defaultValue As String = "") As String
        Dim sb As New StringBuilder(500)
        If GetPrivateProfileString(section, key, defaultValue, sb, sb.Capacity, My.Settings.languagefile) > 0 Then
            Return sb.ToString
        Else
            Return defaultValue
        End If
    End Function

    Dim Nodes(4096) As TreeNode
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExecuteParams()
        Me.Hide()
        wanip.Text = GetExternalIP().ToString
        ToolStripStatusLabel4.Text = My.Application.Info.Version.ToString

        console.RichTextBox1.AppendText(My.Computer.Clock.LocalTime.ToString & vbNewLine)
        console.RichTextBox1.AppendText("OS: " & My.Computer.Info.OSFullName & vbNewLine)
        console.RichTextBox1.AppendText("Version: " & My.Computer.Info.OSVersion & vbNewLine)
        console.RichTextBox1.AppendText("Total RAM: " & My.Computer.Info.TotalPhysicalMemory & " bytes" & vbNewLine)
        console.RichTextBox1.AppendText("Total VRAM: " & My.Computer.Info.TotalVirtualMemory & " bytes" & vbNewLine)
        console.RichTextBox1.AppendText("Available RAM: " & My.Computer.Info.AvailablePhysicalMemory & " bytes" & vbNewLine)
        console.RichTextBox1.AppendText("Available VRAM: " & My.Computer.Info.AvailableVirtualMemory & " bytes" & vbNewLine)
        console.RichTextBox1.AppendText("Is connected to a Network: " & My.Computer.Network.IsAvailable.ToString & vbNewLine)

        'Dim friendnode As TreeNode = TreeView1.Nodes.Add("$friends")
        'Dim globalnode As TreeNode = TreeView1.Nodes.Add("$global")

        'use this to flash in taskbar:
        'Dim res = WindowsApi.FlashWindow(Process.GetCurrentProcess().MainWindowHandle, True, True, 5)
        reloadall()
    End Sub

    Public Function reloadall()
        Dim treeview1nodes As TreeNodeCollection = TreeView1.Nodes
        TreeView1.Nodes.Clear()
        Nodes(0) = New TreeNode(GetIniValue("language", "$friends", My.Settings.languagefile, "$friends"))
        Nodes(0).ImageIndex = 0
        Nodes(0).SelectedImageIndex = 0
        Nodes(0).Name = "friends"
        Nodes(1) = New TreeNode(GetIniValue("language", "$global", My.Settings.languagefile, "$global"))
        Nodes(1).ImageIndex = 5
        Nodes(1).SelectedImageIndex = 5
        Nodes(1).Name = "global"
        Nodes(2) = New TreeNode(GetIniValue("language", "$local", My.Settings.languagefile, "$local"))
        Nodes(2).ImageIndex = 6
        Nodes(2).SelectedImageIndex = 6
        Nodes(2).Name = "local"

        TreeView1.Nodes.Add(Nodes(0))
        TreeView1.Nodes.Add(Nodes(1))
        TreeView1.Nodes.Add(Nodes(2))

        Dim tmpNode() As TreeNode = TreeView1.Nodes.Find("global", True)
        tmpNode(0).Nodes.Add(My.Settings.nickname).ToString()
        TreeView1.ExpandAll()

        Return Nothing
    End Function

    Private Shared Function GetExternalIP() As String

        Dim Response As String = String.Empty

        Try

            Dim ExternalIP As String
            ExternalIP = (New WebClient()).DownloadString("http://checkip.dyndns.org/")
            ExternalIP = (New Regex("\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")) _
                     .Matches(ExternalIP)(0).ToString()
            Return ExternalIP

        Catch ex As Exception
            Response = ex.Message.ToString
            console.RichTextBox1.AppendText(ex.Message.ToString)
        End Try

        Return Response

    End Function

    Private Sub SettingsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles settingsmenu.Click
        settings.Show()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            RichTextBox1.AppendText(My.Settings.nickname & ": " + TextBox1.Text & vbNewLine)
            TextBox1.Text = Nothing
        End If

    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles quitmenu.Click
        Application.Exit()
    End Sub

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        Application.Exit()
    End Sub

    Private Sub delchathistory_Click(sender As Object, e As EventArgs) Handles delchathistory.Click
        RichTextBox1.Text = Nothing
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Timer1.Start()
        ToolStripLabel1.Visible = True
        ToolStripLabel1.Text = My.Settings.nickname & " $is_typing"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripLabel1.Text = "$typing"
        ToolStripLabel1.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub refreshall_Click(sender As Object, e As EventArgs) Handles refreshall.Click
        reloadall()
    End Sub

    Private Sub create_server_Click(sender As Object, e As EventArgs) Handles create_server.Click
        createserver.Show()
    End Sub

    Private Sub NewserverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles newservermenu.Click
        createserver.Show()
    End Sub

    Private Sub settings_Click(sender As Object, e As EventArgs) Handles settingstoolstrip.Click
        settings.Show()
    End Sub

    Private Sub savechatas_Click(sender As Object, e As EventArgs) Handles savechatas.Click
        SaveFileDialog1.ShowDialog()
        Try
            RichTextBox1.SaveFile(SaveFileDialog1.FileName)
        Catch exc As Exception
            MsgBox(exc.ToString)
            console.RichTextBox1.AppendText(exc.Message.ToString)
        End Try
    End Sub


    '------- Haupt-Sub -------
    Public Sub ExecuteParams()
        Dim args As String()
        args = Environment.GetCommandLineArgs()

        For i As Integer = 1 To args.Length - 1
            Select Case args(i).ToLower
                Case "dev"
                    devtools.Visible = True

                Case "console"
                    devtools.Visible = True
                    console.Show()

                Case Else
                    MessageBox.Show("Unknown parameter:" & vbCrLf & args(i), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        Next
    End Sub

    Private Sub ConsoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsoleToolStripMenuItem.Click
        console.Show()
    End Sub


    Public Function SetLang()
        'Hier werden die Sprachateien ausgelesen und mit den Werten der INI ersetzt

        'Login
        login.ok.Text = GetIniValue("language", "$ok", My.Settings.languagefile, "$ok")
        login.quit.Text = GetIniValue("language", "$quit", My.Settings.languagefile, "$quit")
        login.nickname.Text = GetIniValue("language", "$nickname", My.Settings.languagefile, "$nickname")
        login.lang.Text = GetIniValue("language", "$language", My.Settings.languagefile, "$language")

        'Main window
        file.Text = GetIniValue("language", "$file", My.Settings.languagefile, "$file")
        newservermenu.Text = GetIniValue("language", "$new_server", My.Settings.languagefile, "$new_server")
        quitmenu.Text = GetIniValue("language", "$quit", My.Settings.languagefile, "$quit")
        quit.ToolTipText = GetIniValue("language", "$quit", My.Settings.languagefile, "$quit")
        create_server.ToolTipText = GetIniValue("language", "$new_server", My.Settings.languagefile, "$new_server")
        connect_server.ToolTipText = GetIniValue("language", "$join_server", My.Settings.languagefile, "$join_server")
        extip.Text = GetIniValue("language", "$your_external_ip", My.Settings.languagefile, "$your_external_ip")
        grvlversion.Text = GetIniValue("language", "$version", My.Settings.languagefile, "$version")
        playercountcol.Text = GetIniValue("language", "$playercount", My.Settings.languagefile, "$playercount")
        servernamecol.Text = GetIniValue("language", "$servername", My.Settings.languagefile, "$servername")
        ipcol.Text = GetIniValue("language", "$ip", My.Settings.languagefile, "$ip")
        refreshserver.ToolTipText = GetIniValue("language", "$refresh", My.Settings.languagefile, "$refresh")
        refreshall.ToolTipText = GetIniValue("language", "$refreshall", My.Settings.languagefile, "$refreshall")
        edit.Text = GetIniValue("language", "$edit", My.Settings.languagefile, "$edit")
        settingsmenu.Text = GetIniValue("language", "$settings", My.Settings.languagefile, "$settings")
        settingstoolstrip.Text = GetIniValue("language", "$settings", My.Settings.languagefile, "$settings")
        playermenu.Text = GetIniValue("language", "$player", My.Settings.languagefile, "$player")
        onlinemenu.Text = GetIniValue("language", "$online", My.Settings.languagefile, "$online")
        ingamemenu.Text = GetIniValue("language", "$ingame", My.Settings.languagefile, "$ingame")
        dndmenu.Text = GetIniValue("language", "$do_not_disturb", My.Settings.languagefile, "$do_not_disturb")
        invismenu.Text = GetIniValue("language", "$show_as_offline", My.Settings.languagefile, "$show_as_offline")
        manage.Text = GetIniValue("language", "$manage", My.Settings.languagefile, "$manage")
        friendlist.Text = GetIniValue("language", "$friendlist", My.Settings.languagefile, "$friendlist")
        FriendlistToolStripMenuItem.Text = GetIniValue("language", "$friendlist", My.Settings.languagefile, "$friendlist")
        savechatas.Text = GetIniValue("language", "$save_chat_log", My.Settings.languagefile, "$save_chat_log")
        delchathistory.Text = GetIniValue("language", "$delete_chat_history", My.Settings.languagefile, "$delete_chat_history")

        'Settings
        settings.Text = GetIniValue("language", "$settings", My.Settings.languagefile, "$settings")
        settings.lang.Text = GetIniValue("language", "$language", My.Settings.languagefile, "$language")
        settings.nickname.Text = GetIniValue("language", "$nickname", My.Settings.languagefile, "$nickname")
        settings.flashonmcmsg.Text = GetIniValue("language", "$flash_on_mainchat_msg", My.Settings.languagefile, "$flash_on_mainchat_msg")
        settings.apply.Text = GetIniValue("language", "$apply", My.Settings.languagefile, "$apply")
        settings.cancel.Text = GetIniValue("language", "$cancel", My.Settings.languagefile, "$cancel")
        settings.chatsettings.Text = GetIniValue("language", "$chatsettings", My.Settings.languagefile, "$chatsettings")
        settings.programsettings.Text = GetIniValue("language", "$programsettings", My.Settings.languagefile, "$programsettings")
        settings.gamesettings.Text = GetIniValue("language", "$gamesettings", My.Settings.languagefile, "$gamesettings")
        settings.pathtoexe.Text = GetIniValue("language", "$path_to_executable", My.Settings.languagefile, "$path_to_executable")
        settings.addparameter.Text = GetIniValue("language", "$additional_parameters", My.Settings.languagefile, "$additional_parameters")
        settings.browsebtn.Text = GetIniValue("language", "$browse", My.Settings.languagefile, "$browse")

        'Multiplayer Lobby
        mplobby.readystate.Text = GetIniValue("language", "$ready_state", My.Settings.languagefile, "$ready_state")
        mplobby.closelobby.ToolTipText = GetIniValue("language", "$close_lobby", My.Settings.languagefile, "$close_lobby")
        mplobby.startgame.ToolTipText = GetIniValue("language", "$start_game", My.Settings.languagefile, "$start_game")
        mplobby.settings.ToolTipText = GetIniValue("language", "$settings", My.Settings.languagefile, "$settings")
        mplobby.invitefriend.ToolTipText = GetIniValue("language", "$invite", My.Settings.languagefile, "$invite")
        mplobby.savelog.ToolTipText = GetIniValue("language", "$save_chat_log", My.Settings.languagefile, "$save_chat_log")
        mplobby.delchathist.ToolTipText = GetIniValue("language", "$delete_chat_history", My.Settings.languagefile, "$delete_chat_history")
        mplobby.readybtn.ToolTipText = GetIniValue("language", "$ready", My.Settings.languagefile, "$ready")

        'New Server
        createserver.Text = GetIniValue("language", "$createserver", My.Settings.languagefile, "$createserver")
        createserver.ok.Text = GetIniValue("language", "$ok", My.Settings.languagefile, "$ok")
        createserver.cancel.Text = GetIniValue("language", "$cancel", My.Settings.languagefile, "$cancel")
        createserver.serverinfo.Text = GetIniValue("language", "$serverinfo", My.Settings.languagefile, "$serverinfo")
        createserver.servername.Text = GetIniValue("language", "$servername", My.Settings.languagefile, "$servername")
        createserver.password.Text = GetIniValue("language", "$password", My.Settings.languagefile, "$password")
        createserver.raceoptions.Text = GetIniValue("language", "$raceoptions", My.Settings.languagefile, "$raceoptions")
        createserver.pickups.Text = GetIniValue("language", "$pickups", My.Settings.languagefile, "$pickups")
        createserver.laps.Text = GetIniValue("language", "$laps", My.Settings.languagefile, "$laps")
        createserver.player.Text = GetIniValue("language", "$player", My.Settings.languagefile, "$player")
        createserver.friendsonly.Text = GetIniValue("language", "$friends_only", My.Settings.languagefile, "$friends_only")
        createserver.gameversion.Text = GetIniValue("language", "$gameversion", My.Settings.languagefile, "$gameversion")
        createserver.allversion.Text = GetIniValue("language", "$all", My.Settings.languagefile, "$all")
        createserver.rev12.Text = GetIniValue("language", "$revolt_1.2", My.Settings.languagefile, "$revolt_1.2")
        createserver.rvgl.Text = GetIniValue("language", "$rvgl", My.Settings.languagefile, "$rvgl")

        Return Nothing
    End Function

    Private Sub about_Click(sender As Object, e As EventArgs) Handles about.Click
        aboutus.Show()
    End Sub

    Public Function GetIniSetting()
        Dim file_stream As System.IO.StreamReader = New System.IO.StreamReader(My.Settings.languagefile)
        Dim inhalt As String = file_stream.ReadToEnd()
        Dim anfang_des_attributs As Integer = InStr(inhalt, "Wert ") + 12
        Dim ende_des_werts As Integer = InStr(anfang_des_attributs, inhalt, vbNewLine)
        Dim länge_des_werts As Integer = ende_des_werts - anfang_des_attributs
        Dim Wert As String = Mid(inhalt, anfang_des_attributs, länge_des_werts)
        MsgBox(Wert)
        Return Nothing
    End Function

End Class

Public Class WindowsApi
    Private Declare Function FlashWindowEx Lib "User32" (ByRef fwInfo As FLASHWINFO) As Boolean

    ' As defined by: http://msdn.microsoft.com/en-us/library/ms679347(v=vs.85).aspx
    Public Enum FlashWindowFlags As UInt32
        ' Stop flashing. The system restores the window to its original state.
        FLASHW_STOP = 0
        ' Flash the window caption.
        FLASHW_CAPTION = 1
        ' Flash the taskbar button.
        FLASHW_TRAY = 2
        ' Flash both the window caption and taskbar button.
        ' This is equivalent to setting the FLASHW_CAPTION | FLASHW_TRAY flags.
        FLASHW_ALL = 3
        ' Flash continuously, until the FLASHW_STOP flag is set.
        FLASHW_TIMER = 4
        ' Flash continuously until the window comes to the foreground.
        FLASHW_TIMERNOFG = 12
    End Enum

    Public Structure FLASHWINFO
        Public cbSize As UInt32
        Public hwnd As IntPtr
        Public dwFlags As FlashWindowFlags
        Public uCount As UInt32
        Public dwTimeout As UInt32
    End Structure

    Public Shared Function FlashWindow(ByRef handle As IntPtr, ByVal FlashTitleBar As Boolean, ByVal FlashTray As Boolean, ByVal FlashCount As Integer) As Boolean
        If handle = Nothing Then Return False

        Try
            Dim fwi As New FLASHWINFO
            With fwi
                .hwnd = handle
                If FlashTitleBar Then .dwFlags = .dwFlags Or FlashWindowFlags.FLASHW_CAPTION
                If FlashTray Then .dwFlags = .dwFlags Or FlashWindowFlags.FLASHW_TRAY
                .uCount = CUInt(FlashCount)
                If FlashCount = 0 Then .dwFlags = .dwFlags Or FlashWindowFlags.FLASHW_TIMERNOFG
                .dwTimeout = 0 ' Use the default cursor blink rate.
                .cbSize = CUInt(System.Runtime.InteropServices.Marshal.SizeOf(fwi))
            End With

            Return FlashWindowEx(fwi)
        Catch ex As exception
            console.RichTextBox1.AppendText(ex.Message.ToString)
            Return False
        End Try
    End Function
End Class