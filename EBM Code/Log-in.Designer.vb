<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mtbPassword = New System.Windows.Forms.MaskedTextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mtbPassword
        '
        Me.mtbPassword.Location = New System.Drawing.Point(12, 82)
        Me.mtbPassword.Name = "mtbPassword"
        Me.mtbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mtbPassword.Size = New System.Drawing.Size(170, 20)
        Me.mtbPassword.TabIndex = 1
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(12, 43)
        Me.txtUserName.MaxLength = 30
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(170, 20)
        Me.txtUserName.TabIndex = 0
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(9, 27)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(60, 13)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "User Name"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(9, 66)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(12, 108)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(75, 23)
        Me.btnLogIn.TabIndex = 2
        Me.btnLogIn.Text = "Log-In"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 147)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.mtbPassword)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.Text = "Log-in"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtbPassword As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents btnLogIn As System.Windows.Forms.Button

End Class
