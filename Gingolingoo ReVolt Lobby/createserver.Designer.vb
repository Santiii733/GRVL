<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createserver
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
        Me.serverinfo = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.servername = New System.Windows.Forms.Label()
        Me.cancel = New System.Windows.Forms.Button()
        Me.ok = New System.Windows.Forms.Button()
        Me.gameversion = New System.Windows.Forms.GroupBox()
        Me.rvgl = New System.Windows.Forms.RadioButton()
        Me.rev12 = New System.Windows.Forms.RadioButton()
        Me.allversion = New System.Windows.Forms.RadioButton()
        Me.raceoptions = New System.Windows.Forms.GroupBox()
        Me.playercnt = New System.Windows.Forms.NumericUpDown()
        Me.player = New System.Windows.Forms.Label()
        Me.lapcnt = New System.Windows.Forms.NumericUpDown()
        Me.laps = New System.Windows.Forms.Label()
        Me.pickups = New System.Windows.Forms.CheckBox()
        Me.friendsonly = New System.Windows.Forms.CheckBox()
        Me.serverinfo.SuspendLayout()
        Me.gameversion.SuspendLayout()
        Me.raceoptions.SuspendLayout()
        CType(Me.playercnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lapcnt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'serverinfo
        '
        Me.serverinfo.Controls.Add(Me.TextBox2)
        Me.serverinfo.Controls.Add(Me.password)
        Me.serverinfo.Controls.Add(Me.TextBox1)
        Me.serverinfo.Controls.Add(Me.servername)
        Me.serverinfo.Location = New System.Drawing.Point(12, 12)
        Me.serverinfo.Name = "serverinfo"
        Me.serverinfo.Size = New System.Drawing.Size(260, 111)
        Me.serverinfo.TabIndex = 0
        Me.serverinfo.TabStop = False
        Me.serverinfo.Text = "$serverinfo"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(9, 75)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(245, 20)
        Me.TextBox2.TabIndex = 3
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Location = New System.Drawing.Point(6, 59)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(58, 13)
        Me.password.TabIndex = 2
        Me.password.Text = "$password"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(245, 20)
        Me.TextBox1.TabIndex = 1
        '
        'servername
        '
        Me.servername.AutoSize = True
        Me.servername.Location = New System.Drawing.Point(6, 16)
        Me.servername.Name = "servername"
        Me.servername.Size = New System.Drawing.Size(68, 13)
        Me.servername.TabIndex = 0
        Me.servername.Text = "$servername"
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(197, 223)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 1
        Me.cancel.Text = "$cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(116, 223)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(75, 23)
        Me.ok.TabIndex = 2
        Me.ok.Text = "$ok"
        Me.ok.UseVisualStyleBackColor = True
        '
        'gameversion
        '
        Me.gameversion.Controls.Add(Me.rvgl)
        Me.gameversion.Controls.Add(Me.rev12)
        Me.gameversion.Controls.Add(Me.allversion)
        Me.gameversion.Location = New System.Drawing.Point(150, 129)
        Me.gameversion.Name = "gameversion"
        Me.gameversion.Size = New System.Drawing.Size(122, 88)
        Me.gameversion.TabIndex = 3
        Me.gameversion.TabStop = False
        Me.gameversion.Text = "$gameversion"
        '
        'rvgl
        '
        Me.rvgl.AutoSize = True
        Me.rvgl.Checked = True
        Me.rvgl.Location = New System.Drawing.Point(6, 65)
        Me.rvgl.Name = "rvgl"
        Me.rvgl.Size = New System.Drawing.Size(48, 17)
        Me.rvgl.TabIndex = 2
        Me.rvgl.TabStop = True
        Me.rvgl.Text = "$rvgl"
        Me.rvgl.UseVisualStyleBackColor = True
        '
        'rev12
        '
        Me.rev12.AutoSize = True
        Me.rev12.Enabled = False
        Me.rev12.Location = New System.Drawing.Point(6, 42)
        Me.rev12.Name = "rev12"
        Me.rev12.Size = New System.Drawing.Size(78, 17)
        Me.rev12.TabIndex = 1
        Me.rev12.Text = "$revolt_1.2"
        Me.rev12.UseVisualStyleBackColor = True
        '
        'allversion
        '
        Me.allversion.AutoSize = True
        Me.allversion.Enabled = False
        Me.allversion.Location = New System.Drawing.Point(6, 19)
        Me.allversion.Name = "allversion"
        Me.allversion.Size = New System.Drawing.Size(41, 17)
        Me.allversion.TabIndex = 0
        Me.allversion.Text = "$all"
        Me.allversion.UseVisualStyleBackColor = True
        '
        'raceoptions
        '
        Me.raceoptions.Controls.Add(Me.playercnt)
        Me.raceoptions.Controls.Add(Me.player)
        Me.raceoptions.Controls.Add(Me.lapcnt)
        Me.raceoptions.Controls.Add(Me.laps)
        Me.raceoptions.Controls.Add(Me.pickups)
        Me.raceoptions.Location = New System.Drawing.Point(12, 129)
        Me.raceoptions.Name = "raceoptions"
        Me.raceoptions.Size = New System.Drawing.Size(132, 88)
        Me.raceoptions.TabIndex = 4
        Me.raceoptions.TabStop = False
        Me.raceoptions.Text = "$raceoptions"
        '
        'playercnt
        '
        Me.playercnt.Location = New System.Drawing.Point(70, 60)
        Me.playercnt.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.playercnt.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.playercnt.Name = "playercnt"
        Me.playercnt.Size = New System.Drawing.Size(56, 20)
        Me.playercnt.TabIndex = 5
        Me.playercnt.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'player
        '
        Me.player.AutoSize = True
        Me.player.Location = New System.Drawing.Point(67, 44)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(41, 13)
        Me.player.TabIndex = 3
        Me.player.Text = "$player"
        '
        'lapcnt
        '
        Me.lapcnt.Location = New System.Drawing.Point(6, 60)
        Me.lapcnt.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.lapcnt.Name = "lapcnt"
        Me.lapcnt.Size = New System.Drawing.Size(58, 20)
        Me.lapcnt.TabIndex = 2
        Me.lapcnt.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'laps
        '
        Me.laps.AutoSize = True
        Me.laps.Location = New System.Drawing.Point(3, 44)
        Me.laps.Name = "laps"
        Me.laps.Size = New System.Drawing.Size(32, 13)
        Me.laps.TabIndex = 1
        Me.laps.Text = "$laps"
        '
        'pickups
        '
        Me.pickups.AutoSize = True
        Me.pickups.Location = New System.Drawing.Point(9, 20)
        Me.pickups.Name = "pickups"
        Me.pickups.Size = New System.Drawing.Size(69, 17)
        Me.pickups.TabIndex = 0
        Me.pickups.Text = "$pickups"
        Me.pickups.UseVisualStyleBackColor = True
        '
        'friendsonly
        '
        Me.friendsonly.AutoSize = True
        Me.friendsonly.Location = New System.Drawing.Point(12, 227)
        Me.friendsonly.Name = "friendsonly"
        Me.friendsonly.Size = New System.Drawing.Size(88, 17)
        Me.friendsonly.TabIndex = 5
        Me.friendsonly.Text = "$friends_only"
        Me.friendsonly.UseVisualStyleBackColor = True
        '
        'createserver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 258)
        Me.Controls.Add(Me.friendsonly)
        Me.Controls.Add(Me.raceoptions)
        Me.Controls.Add(Me.gameversion)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.serverinfo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "createserver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "$createserver"
        Me.serverinfo.ResumeLayout(False)
        Me.serverinfo.PerformLayout()
        Me.gameversion.ResumeLayout(False)
        Me.gameversion.PerformLayout()
        Me.raceoptions.ResumeLayout(False)
        Me.raceoptions.PerformLayout()
        CType(Me.playercnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lapcnt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents serverinfo As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents password As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents servername As Label
    Friend WithEvents cancel As Button
    Friend WithEvents ok As Button
    Friend WithEvents gameversion As GroupBox
    Friend WithEvents rvgl As RadioButton
    Friend WithEvents rev12 As RadioButton
    Friend WithEvents allversion As RadioButton
    Friend WithEvents raceoptions As GroupBox
    Friend WithEvents playercnt As NumericUpDown
    Friend WithEvents player As Label
    Friend WithEvents lapcnt As NumericUpDown
    Friend WithEvents laps As Label
    Friend WithEvents pickups As CheckBox
    Friend WithEvents friendsonly As CheckBox
End Class
