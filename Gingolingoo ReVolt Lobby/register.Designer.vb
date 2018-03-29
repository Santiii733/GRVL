<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.repassword = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.Label()
        Me.registerButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 77)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(148, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 120)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(148, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(12, 163)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(148, 20)
        Me.TextBox4.TabIndex = 3
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Location = New System.Drawing.Point(9, 18)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(59, 13)
        Me.username.TabIndex = 4
        Me.username.Text = "$username"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Location = New System.Drawing.Point(9, 61)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(58, 13)
        Me.password.TabIndex = 5
        Me.password.Text = "$password"
        '
        'repassword
        '
        Me.repassword.AutoSize = True
        Me.repassword.Location = New System.Drawing.Point(9, 104)
        Me.repassword.Name = "repassword"
        Me.repassword.Size = New System.Drawing.Size(68, 13)
        Me.repassword.TabIndex = 6
        Me.repassword.Text = "$rePassword"
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Location = New System.Drawing.Point(9, 147)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(37, 13)
        Me.email.TabIndex = 7
        Me.email.Text = "$email"
        '
        'registerButton
        '
        Me.registerButton.Location = New System.Drawing.Point(12, 189)
        Me.registerButton.Name = "registerButton"
        Me.registerButton.Size = New System.Drawing.Size(148, 23)
        Me.registerButton.TabIndex = 8
        Me.registerButton.Text = "$register"
        Me.registerButton.UseVisualStyleBackColor = True
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(173, 224)
        Me.Controls.Add(Me.registerButton)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.repassword)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "register"
        Me.Text = "register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents username As Label
    Friend WithEvents password As Label
    Friend WithEvents repassword As Label
    Friend WithEvents email As Label
    Friend WithEvents registerButton As Button
End Class
