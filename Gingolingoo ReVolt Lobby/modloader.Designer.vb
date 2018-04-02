<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modloader
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.modlist = New System.Windows.Forms.TabControl()
        Me.allmods = New System.Windows.Forms.TabPage()
        Me.installed = New System.Windows.Forms.TabPage()
        Me.modlist.SuspendLayout()
        Me.allmods.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 6)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(530, 630)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'modlist
        '
        Me.modlist.Controls.Add(Me.allmods)
        Me.modlist.Controls.Add(Me.installed)
        Me.modlist.Dock = System.Windows.Forms.DockStyle.Top
        Me.modlist.Location = New System.Drawing.Point(0, 0)
        Me.modlist.Name = "modlist"
        Me.modlist.SelectedIndex = 0
        Me.modlist.Size = New System.Drawing.Size(544, 668)
        Me.modlist.TabIndex = 0
        '
        'allmods
        '
        Me.allmods.Controls.Add(Me.FlowLayoutPanel1)
        Me.allmods.Location = New System.Drawing.Point(4, 22)
        Me.allmods.Name = "allmods"
        Me.allmods.Padding = New System.Windows.Forms.Padding(3)
        Me.allmods.Size = New System.Drawing.Size(536, 642)
        Me.allmods.TabIndex = 0
        Me.allmods.Text = "All"
        Me.allmods.UseVisualStyleBackColor = True
        '
        'installed
        '
        Me.installed.Location = New System.Drawing.Point(4, 22)
        Me.installed.Name = "installed"
        Me.installed.Padding = New System.Windows.Forms.Padding(3)
        Me.installed.Size = New System.Drawing.Size(536, 642)
        Me.installed.TabIndex = 1
        Me.installed.Text = "Installiert"
        Me.installed.UseVisualStyleBackColor = True
        '
        'modloader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 680)
        Me.Controls.Add(Me.modlist)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "modloader"
        Me.Text = "modloader"
        Me.modlist.ResumeLayout(False)
        Me.allmods.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents modlist As TabControl
    Friend WithEvents allmods As TabPage
    Friend WithEvents installed As TabPage
End Class
