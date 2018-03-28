<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.programsettings = New System.Windows.Forms.TabPage()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.nickname = New System.Windows.Forms.Label()
        Me.chatsettings = New System.Windows.Forms.GroupBox()
        Me.flashonmcmsg = New System.Windows.Forms.CheckBox()
        Me.gamesettings = New System.Windows.Forms.TabPage()
        Me.pathtoexe = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.addparameter = New System.Windows.Forms.Label()
        Me.browsebtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cancel = New System.Windows.Forms.Button()
        Me.apply = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lang = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.programsettings.SuspendLayout()
        Me.chatsettings.SuspendLayout()
        Me.gamesettings.SuspendLayout()
        Me.pathtoexe.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.programsettings)
        Me.TabControl1.Controls.Add(Me.gamesettings)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(284, 220)
        Me.TabControl1.TabIndex = 1
        '
        'programsettings
        '
        Me.programsettings.Controls.Add(Me.lang)
        Me.programsettings.Controls.Add(Me.ComboBox1)
        Me.programsettings.Controls.Add(Me.TextBox3)
        Me.programsettings.Controls.Add(Me.nickname)
        Me.programsettings.Controls.Add(Me.chatsettings)
        Me.programsettings.Location = New System.Drawing.Point(4, 22)
        Me.programsettings.Name = "programsettings"
        Me.programsettings.Padding = New System.Windows.Forms.Padding(3)
        Me.programsettings.Size = New System.Drawing.Size(276, 194)
        Me.programsettings.TabIndex = 0
        Me.programsettings.Text = "$programsettings"
        Me.programsettings.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(9, 19)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(259, 20)
        Me.TextBox3.TabIndex = 1
        '
        'nickname
        '
        Me.nickname.AutoSize = True
        Me.nickname.Location = New System.Drawing.Point(6, 3)
        Me.nickname.Name = "nickname"
        Me.nickname.Size = New System.Drawing.Size(59, 13)
        Me.nickname.TabIndex = 2
        Me.nickname.Text = "$nickname"
        '
        'chatsettings
        '
        Me.chatsettings.Controls.Add(Me.flashonmcmsg)
        Me.chatsettings.Location = New System.Drawing.Point(8, 89)
        Me.chatsettings.Name = "chatsettings"
        Me.chatsettings.Size = New System.Drawing.Size(260, 99)
        Me.chatsettings.TabIndex = 1
        Me.chatsettings.TabStop = False
        Me.chatsettings.Text = "$chatsettings"
        '
        'flashonmcmsg
        '
        Me.flashonmcmsg.AutoSize = True
        Me.flashonmcmsg.Location = New System.Drawing.Point(6, 19)
        Me.flashonmcmsg.Name = "flashonmcmsg"
        Me.flashonmcmsg.Size = New System.Drawing.Size(146, 17)
        Me.flashonmcmsg.TabIndex = 2
        Me.flashonmcmsg.Text = "$flash_on_mainchat_msg"
        Me.flashonmcmsg.UseVisualStyleBackColor = True
        '
        'gamesettings
        '
        Me.gamesettings.Controls.Add(Me.pathtoexe)
        Me.gamesettings.Location = New System.Drawing.Point(4, 22)
        Me.gamesettings.Name = "gamesettings"
        Me.gamesettings.Padding = New System.Windows.Forms.Padding(3)
        Me.gamesettings.Size = New System.Drawing.Size(276, 194)
        Me.gamesettings.TabIndex = 1
        Me.gamesettings.Text = "$gamesettings"
        Me.gamesettings.UseVisualStyleBackColor = True
        '
        'pathtoexe
        '
        Me.pathtoexe.Controls.Add(Me.TextBox2)
        Me.pathtoexe.Controls.Add(Me.addparameter)
        Me.pathtoexe.Controls.Add(Me.browsebtn)
        Me.pathtoexe.Controls.Add(Me.TextBox1)
        Me.pathtoexe.Location = New System.Drawing.Point(8, 6)
        Me.pathtoexe.Name = "pathtoexe"
        Me.pathtoexe.Size = New System.Drawing.Size(260, 89)
        Me.pathtoexe.TabIndex = 1
        Me.pathtoexe.TabStop = False
        Me.pathtoexe.Text = "$path_to_executable"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(248, 20)
        Me.TextBox2.TabIndex = 3
        '
        'addparameter
        '
        Me.addparameter.AutoSize = True
        Me.addparameter.Location = New System.Drawing.Point(6, 47)
        Me.addparameter.Name = "addparameter"
        Me.addparameter.Size = New System.Drawing.Size(116, 13)
        Me.addparameter.TabIndex = 2
        Me.addparameter.Text = "$additional_parameters"
        '
        'browsebtn
        '
        Me.browsebtn.Location = New System.Drawing.Point(179, 17)
        Me.browsebtn.Name = "browsebtn"
        Me.browsebtn.Size = New System.Drawing.Size(75, 23)
        Me.browsebtn.TabIndex = 1
        Me.browsebtn.Text = "$browse"
        Me.browsebtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 20)
        Me.TextBox1.TabIndex = 0
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(197, 226)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 2
        Me.cancel.Text = "$cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'apply
        '
        Me.apply.Location = New System.Drawing.Point(116, 226)
        Me.apply.Name = "apply"
        Me.apply.Size = New System.Drawing.Size(75, 23)
        Me.apply.TabIndex = 3
        Me.apply.Text = "$apply"
        Me.apply.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(77, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'lang
        '
        Me.lang.AutoSize = True
        Me.lang.Location = New System.Drawing.Point(11, 48)
        Me.lang.Name = "lang"
        Me.lang.Size = New System.Drawing.Size(60, 13)
        Me.lang.TabIndex = 5
        Me.lang.Text = "$language:"
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.apply)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "$settings"
        Me.TabControl1.ResumeLayout(False)
        Me.programsettings.ResumeLayout(False)
        Me.programsettings.PerformLayout()
        Me.chatsettings.ResumeLayout(False)
        Me.chatsettings.PerformLayout()
        Me.gamesettings.ResumeLayout(False)
        Me.pathtoexe.ResumeLayout(False)
        Me.pathtoexe.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents programsettings As TabPage
    Friend WithEvents flashonmcmsg As CheckBox
    Friend WithEvents gamesettings As TabPage
    Friend WithEvents pathtoexe As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents addparameter As Label
    Friend WithEvents browsebtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cancel As Button
    Friend WithEvents apply As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents nickname As Label
    Friend WithEvents chatsettings As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lang As Label
End Class
