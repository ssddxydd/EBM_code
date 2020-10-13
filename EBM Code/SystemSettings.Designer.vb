<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemSettings
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
        Me.btnManageUsers = New System.Windows.Forms.Button()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnBackUp = New System.Windows.Forms.Button()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.lblNoOfBookings = New System.Windows.Forms.Label()
        Me.fbdBackup = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnManageUsers
        '
        Me.btnManageUsers.Location = New System.Drawing.Point(12, 12)
        Me.btnManageUsers.Name = "btnManageUsers"
        Me.btnManageUsers.Size = New System.Drawing.Size(120, 23)
        Me.btnManageUsers.TabIndex = 0
        Me.btnManageUsers.Text = "Manage Users"
        Me.btnManageUsers.UseVisualStyleBackColor = True
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(12, 41)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(120, 23)
        Me.btnSetup.TabIndex = 1
        Me.btnSetup.Text = "System Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(12, 70)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(120, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "System Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnBackUp
        '
        Me.btnBackUp.Location = New System.Drawing.Point(12, 99)
        Me.btnBackUp.Name = "btnBackUp"
        Me.btnBackUp.Size = New System.Drawing.Size(120, 23)
        Me.btnBackUp.TabIndex = 4
        Me.btnBackUp.Text = "Back-up System Files"
        Me.btnBackUp.UseVisualStyleBackColor = True
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(172, 17)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(39, 13)
        Me.lblCustomer.TabIndex = 5
        Me.lblCustomer.Text = "Label1"
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(172, 53)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(39, 13)
        Me.lblRoom.TabIndex = 6
        Me.lblRoom.Text = "Label2"
        '
        'lblNoOfBookings
        '
        Me.lblNoOfBookings.AutoSize = True
        Me.lblNoOfBookings.Location = New System.Drawing.Point(172, 92)
        Me.lblNoOfBookings.Name = "lblNoOfBookings"
        Me.lblNoOfBookings.Size = New System.Drawing.Size(39, 13)
        Me.lblNoOfBookings.TabIndex = 7
        Me.lblNoOfBookings.Text = "Label3"
        '
        'fbdBackup
        '
        Me.fbdBackup.Description = "Please choose a location for the system back up"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 128)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 23)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSystemSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 164)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblNoOfBookings)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.btnBackUp)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSetup)
        Me.Controls.Add(Me.btnManageUsers)
        Me.MaximizeBox = False
        Me.Name = "frmSystemSettings"
        Me.Text = "System Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnManageUsers As System.Windows.Forms.Button
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnBackUp As System.Windows.Forms.Button
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblRoom As System.Windows.Forms.Label
    Friend WithEvents lblNoOfBookings As System.Windows.Forms.Label
    Friend WithEvents fbdBackup As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
