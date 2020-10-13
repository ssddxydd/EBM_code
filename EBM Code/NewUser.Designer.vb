<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewUser
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
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.mtbPassword = New System.Windows.Forms.MaskedTextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.blbUsername = New System.Windows.Forms.Label()
        Me.nudAccess = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtbReenterPass = New System.Windows.Forms.MaskedTextBox()
        Me.lblReenterPass = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.nudAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(190, 116)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(75, 23)
        Me.btnFinish.TabIndex = 0
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(12, 41)
        Me.txtUsername.MaxLength = 30
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(166, 20)
        Me.txtUsername.TabIndex = 1
        '
        'mtbPassword
        '
        Me.mtbPassword.Location = New System.Drawing.Point(12, 80)
        Me.mtbPassword.Name = "mtbPassword"
        Me.mtbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mtbPassword.Size = New System.Drawing.Size(166, 20)
        Me.mtbPassword.TabIndex = 2
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 64)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        '
        'blbUsername
        '
        Me.blbUsername.AutoSize = True
        Me.blbUsername.Location = New System.Drawing.Point(12, 25)
        Me.blbUsername.Name = "blbUsername"
        Me.blbUsername.Size = New System.Drawing.Size(55, 13)
        Me.blbUsername.TabIndex = 4
        Me.blbUsername.Text = "Username"
        '
        'nudAccess
        '
        Me.nudAccess.Location = New System.Drawing.Point(218, 42)
        Me.nudAccess.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudAccess.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudAccess.Name = "nudAccess"
        Me.nudAccess.Size = New System.Drawing.Size(40, 20)
        Me.nudAccess.TabIndex = 5
        Me.nudAccess.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(187, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Access Level"
        '
        'mtbReenterPass
        '
        Me.mtbReenterPass.Location = New System.Drawing.Point(12, 119)
        Me.mtbReenterPass.Name = "mtbReenterPass"
        Me.mtbReenterPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mtbReenterPass.Size = New System.Drawing.Size(166, 20)
        Me.mtbReenterPass.TabIndex = 2
        '
        'lblReenterPass
        '
        Me.lblReenterPass.AutoSize = True
        Me.lblReenterPass.Location = New System.Drawing.Point(9, 103)
        Me.lblReenterPass.Name = "lblReenterPass"
        Me.lblReenterPass.Size = New System.Drawing.Size(97, 13)
        Me.lblReenterPass.TabIndex = 7
        Me.lblReenterPass.Text = "Re-enter Password"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(190, 80)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 165)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblReenterPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudAccess)
        Me.Controls.Add(Me.blbUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.mtbReenterPass)
        Me.Controls.Add(Me.mtbPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnFinish)
        Me.MaximizeBox = False
        Me.Name = "frmNewUser"
        Me.Text = "Add New User"
        CType(Me.nudAccess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFinish As System.Windows.Forms.Button
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents mtbPassword As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents blbUsername As System.Windows.Forms.Label
    Friend WithEvents nudAccess As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtbReenterPass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblReenterPass As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
