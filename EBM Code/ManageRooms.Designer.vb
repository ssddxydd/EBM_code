<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageRooms
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
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.btnNewRoom = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lstRoom = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cmbStatus
        '
        Me.cmbStatus.AutoCompleteCustomSource.AddRange(New String() {"Active", "Inactive"})
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cmbStatus.Location = New System.Drawing.Point(10, 200)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(123, 21)
        Me.cmbStatus.TabIndex = 3
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(12, 184)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 42
        Me.lblStatus.Text = "Status"
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Location = New System.Drawing.Point(164, 35)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(148, 13)
        Me.lblWarning.TabIndex = 41
        Me.lblWarning.Text = "This room is currently disabled" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblWarning.Visible = False
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(7, 9)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(68, 13)
        Me.lblRoom.TabIndex = 40
        Me.lblRoom.Text = "Select Room"
        '
        'btnNewRoom
        '
        Me.btnNewRoom.Location = New System.Drawing.Point(10, 158)
        Me.btnNewRoom.Name = "btnNewRoom"
        Me.btnNewRoom.Size = New System.Drawing.Size(123, 23)
        Me.btnNewRoom.TabIndex = 6
        Me.btnNewRoom.Text = "Add New Room"
        Me.btnNewRoom.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(10, 129)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(123, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(10, 100)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(123, 23)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update Room Details"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Location = New System.Drawing.Point(164, 103)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(70, 13)
        Me.lblDetails.TabIndex = 47
        Me.lblDetails.Text = "Room Details"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(164, 58)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(66, 13)
        Me.lblName.TabIndex = 46
        Me.lblName.Text = "Room Name"
        '
        'txtDetails
        '
        Me.txtDetails.Location = New System.Drawing.Point(167, 123)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(188, 81)
        Me.txtDetails.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(167, 74)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'lstRoom
        '
        Me.lstRoom.FormattingEnabled = True
        Me.lstRoom.Location = New System.Drawing.Point(10, 25)
        Me.lstRoom.Name = "lstRoom"
        Me.lstRoom.Size = New System.Drawing.Size(148, 69)
        Me.lstRoom.TabIndex = 48
        '
        'frmManageRooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 228)
        Me.Controls.Add(Me.lstRoom)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtDetails)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.btnNewRoom)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpdate)
        Me.MaximizeBox = False
        Me.Name = "frmManageRooms"
        Me.Text = "Manage Rooms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents lblRoom As System.Windows.Forms.Label
    Friend WithEvents btnNewRoom As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblDetails As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtDetails As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lstRoom As System.Windows.Forms.ListBox
End Class
