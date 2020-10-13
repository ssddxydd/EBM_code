<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageUsers
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
        Me.lblReenterPass = New System.Windows.Forms.Label()
        Me.lblAccess = New System.Windows.Forms.Label()
        Me.nudAccess = New System.Windows.Forms.NumericUpDown()
        Me.blbUsername = New System.Windows.Forms.Label()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.mtbReenterPass = New System.Windows.Forms.MaskedTextBox()
        Me.mtbPassword = New System.Windows.Forms.MaskedTextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnNewUser = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lstUser = New System.Windows.Forms.ListBox()
        CType(Me.nudAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblReenterPass
        '
        Me.lblReenterPass.AutoSize = True
        Me.lblReenterPass.Location = New System.Drawing.Point(9, 92)
        Me.lblReenterPass.Name = "lblReenterPass"
        Me.lblReenterPass.Size = New System.Drawing.Size(97, 13)
        Me.lblReenterPass.TabIndex = 16
        Me.lblReenterPass.Text = "Re-enter Password"
        '
        'lblAccess
        '
        Me.lblAccess.AutoSize = True
        Me.lblAccess.Location = New System.Drawing.Point(110, 141)
        Me.lblAccess.Name = "lblAccess"
        Me.lblAccess.Size = New System.Drawing.Size(71, 13)
        Me.lblAccess.TabIndex = 15
        Me.lblAccess.Text = "Access Level"
        '
        'nudAccess
        '
        Me.nudAccess.Location = New System.Drawing.Point(137, 158)
        Me.nudAccess.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudAccess.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudAccess.Name = "nudAccess"
        Me.nudAccess.Size = New System.Drawing.Size(41, 20)
        Me.nudAccess.TabIndex = 5
        Me.nudAccess.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'blbUsername
        '
        Me.blbUsername.AutoSize = True
        Me.blbUsername.Location = New System.Drawing.Point(12, 14)
        Me.blbUsername.Name = "blbUsername"
        Me.blbUsername.Size = New System.Drawing.Size(55, 13)
        Me.blbUsername.TabIndex = 13
        Me.blbUsername.Text = "Username"
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Location = New System.Drawing.Point(12, 53)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(106, 13)
        Me.lblNewPassword.TabIndex = 12
        Me.lblNewPassword.Text = "Enter New Password"
        '
        'mtbReenterPass
        '
        Me.mtbReenterPass.Location = New System.Drawing.Point(12, 108)
        Me.mtbReenterPass.Name = "mtbReenterPass"
        Me.mtbReenterPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mtbReenterPass.Size = New System.Drawing.Size(166, 20)
        Me.mtbReenterPass.TabIndex = 3
        '
        'mtbPassword
        '
        Me.mtbPassword.Location = New System.Drawing.Point(12, 69)
        Me.mtbPassword.Name = "mtbPassword"
        Me.mtbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mtbPassword.Size = New System.Drawing.Size(166, 20)
        Me.mtbPassword.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(12, 30)
        Me.txtUsername.MaxLength = 30
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(166, 20)
        Me.txtUsername.TabIndex = 1
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Location = New System.Drawing.Point(193, 100)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(147, 13)
        Me.lblWarning.TabIndex = 42
        Me.lblWarning.Text = "This User is currently disabled" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblWarning.Visible = False
        '
        'cmbStatus
        '
        Me.cmbStatus.AutoCompleteCustomSource.AddRange(New String() {"Active", "Inactive"})
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cmbStatus.Location = New System.Drawing.Point(12, 158)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(106, 21)
        Me.cmbStatus.TabIndex = 4
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(12, 140)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 44
        Me.lblStatus.Text = "Status"
        '
        'btnNewUser
        '
        Me.btnNewUser.Location = New System.Drawing.Point(196, 116)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(117, 23)
        Me.btnNewUser.TabIndex = 6
        Me.btnNewUser.Text = "Add New User"
        Me.btnNewUser.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(196, 145)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(117, 23)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update User Details"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(196, 174)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(117, 23)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(193, 11)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(62, 13)
        Me.lblUser.TabIndex = 50
        Me.lblUser.Text = "Select User"
        '
        'lstUser
        '
        Me.lstUser.FormattingEnabled = True
        Me.lstUser.Location = New System.Drawing.Point(196, 28)
        Me.lstUser.Name = "lstUser"
        Me.lstUser.Size = New System.Drawing.Size(144, 69)
        Me.lstUser.TabIndex = 51
        '
        'frmManageUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 208)
        Me.Controls.Add(Me.lstUser)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNewUser)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.lblReenterPass)
        Me.Controls.Add(Me.lblAccess)
        Me.Controls.Add(Me.nudAccess)
        Me.Controls.Add(Me.blbUsername)
        Me.Controls.Add(Me.lblNewPassword)
        Me.Controls.Add(Me.mtbReenterPass)
        Me.Controls.Add(Me.mtbPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.MaximizeBox = False
        Me.Name = "frmManageUsers"
        Me.Text = "Manage Users"
        CType(Me.nudAccess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblReenterPass As System.Windows.Forms.Label
    Friend WithEvents lblAccess As System.Windows.Forms.Label
    Friend WithEvents nudAccess As System.Windows.Forms.NumericUpDown
    Friend WithEvents blbUsername As System.Windows.Forms.Label
    Friend WithEvents lblNewPassword As System.Windows.Forms.Label
    Friend WithEvents mtbReenterPass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbPassword As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnNewUser As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lstUser As System.Windows.Forms.ListBox
End Class
