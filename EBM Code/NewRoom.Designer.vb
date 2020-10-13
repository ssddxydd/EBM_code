<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewRoom
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(12, 25)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 0
        '
        'txtDetails
        '
        Me.txtDetails.Location = New System.Drawing.Point(12, 64)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(230, 81)
        Me.txtDetails.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(9, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(66, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Room Name"
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Location = New System.Drawing.Point(9, 48)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(70, 13)
        Me.lblDetails.TabIndex = 3
        Me.lblDetails.Text = "Room Details"
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(12, 151)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(75, 23)
        Me.btnFinish.TabIndex = 4
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(93, 151)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmNewRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 180)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtDetails)
        Me.Controls.Add(Me.txtName)
        Me.MaximizeBox = False
        Me.Name = "frmNewRoom"
        Me.Text = "Add New Room"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtDetails As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblDetails As System.Windows.Forms.Label
    Friend WithEvents btnFinish As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
