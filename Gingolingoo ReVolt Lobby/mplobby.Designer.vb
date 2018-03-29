<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mplobby
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mplobby))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.userimagelist = New System.Windows.Forms.ImageList(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.closelobby = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.startgame = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.settings = New System.Windows.Forms.ToolStripButton()
        Me.invitefriend = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.savelog = New System.Windows.Forms.ToolStripButton()
        Me.delchathist = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.readybtn = New System.Windows.Forms.ToolStripButton()
        Me.readystate = New System.Windows.Forms.ToolStripLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RichTextBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(639, 218)
        Me.SplitContainer1.SplitterDistance = 150
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.userimagelist
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(150, 218)
        Me.TreeView1.TabIndex = 0
        '
        'userimagelist
        '
        Me.userimagelist.ImageStream = CType(resources.GetObject("userimagelist.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.userimagelist.TransparentColor = System.Drawing.Color.Transparent
        Me.userimagelist.Images.SetKeyName(0, "user.png")
        Me.userimagelist.Images.SetKeyName(1, "user_gray.png")
        Me.userimagelist.Images.SetKeyName(2, "user_green.png")
        Me.userimagelist.Images.SetKeyName(3, "user_orange.png")
        Me.userimagelist.Images.SetKeyName(4, "user_red.png")
        Me.userimagelist.Images.SetKeyName(5, "world.png")
        Me.userimagelist.Images.SetKeyName(6, "house.png")
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox1.Location = New System.Drawing.Point(0, 198)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(485, 20)
        Me.TextBox1.TabIndex = 1
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(485, 198)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.closelobby, Me.ToolStripSeparator3, Me.startgame, Me.ToolStripSeparator1, Me.settings, Me.invitefriend, Me.ToolStripSeparator2, Me.savelog, Me.delchathist, Me.ToolStripSeparator4, Me.readybtn, Me.readystate})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(639, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'closelobby
        '
        Me.closelobby.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.closelobby.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.cancel
        Me.closelobby.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.closelobby.Name = "closelobby"
        Me.closelobby.Size = New System.Drawing.Size(23, 22)
        Me.closelobby.Text = "$close_lobby"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'startgame
        '
        Me.startgame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.startgame.Enabled = False
        Me.startgame.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.action_go
        Me.startgame.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.startgame.Name = "startgame"
        Me.startgame.Size = New System.Drawing.Size(23, 22)
        Me.startgame.Text = "$start_game"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'settings
        '
        Me.settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.settings.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.cog
        Me.settings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(23, 22)
        Me.settings.Text = "$settings"
        '
        'invitefriend
        '
        Me.invitefriend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.invitefriend.Enabled = False
        Me.invitefriend.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.user_add
        Me.invitefriend.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.invitefriend.Name = "invitefriend"
        Me.invitefriend.Size = New System.Drawing.Size(23, 22)
        Me.invitefriend.Text = "$invite"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'savelog
        '
        Me.savelog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.savelog.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.script_save
        Me.savelog.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.savelog.Name = "savelog"
        Me.savelog.Size = New System.Drawing.Size(23, 22)
        Me.savelog.Text = "$save_chat_log"
        '
        'delchathist
        '
        Me.delchathist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.delchathist.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.script_delete
        Me.delchathist.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.delchathist.Name = "delchathist"
        Me.delchathist.Size = New System.Drawing.Size(23, 22)
        Me.delchathist.Text = "ToolStripButton2"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'readybtn
        '
        Me.readybtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.readybtn.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.accept
        Me.readybtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.readybtn.Name = "readybtn"
        Me.readybtn.Size = New System.Drawing.Size(23, 22)
        Me.readybtn.Text = "$ready"
        '
        'readystate
        '
        Me.readystate.Name = "readystate"
        Me.readystate.Size = New System.Drawing.Size(72, 22)
        Me.readystate.Text = "$ready_state"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 243)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(639, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(88, 20)
        Me.ToolStripLabel2.Text = "ToolStripLabel2"
        Me.ToolStripLabel2.Visible = False
        '
        'mplobby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 265)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mplobby"
        Me.Text = "$mplobby"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents closelobby As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents settings As ToolStripButton
    Friend WithEvents invitefriend As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents savelog As ToolStripButton
    Friend WithEvents delchathist As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents startgame As ToolStripButton
    Friend WithEvents readybtn As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents userimagelist As ImageList
    Friend WithEvents readystate As ToolStripLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
End Class
