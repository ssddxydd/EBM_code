<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageCatering
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
        Me.btnNewItem = New System.Windows.Forms.Button()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lstItem = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnNewItem
        '
        Me.btnNewItem.Location = New System.Drawing.Point(12, 167)
        Me.btnNewItem.Name = "btnNewItem"
        Me.btnNewItem.Size = New System.Drawing.Size(144, 23)
        Me.btnNewItem.TabIndex = 16
        Me.btnNewItem.Text = "Add New Item"
        Me.btnNewItem.UseVisualStyleBackColor = True
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(9, 8)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(60, 13)
        Me.lblItem.TabIndex = 14
        Me.lblItem.Text = "Select Item"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(162, 167)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 116)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 26
        Me.lblName.Text = "Name"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(115, 116)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(46, 13)
        Me.lblPrice.TabIndex = 27
        Me.lblPrice.Text = "Price (£)"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(221, 116)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 28
        Me.lblStatus.Text = "Status"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(12, 132)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 29
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(118, 132)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 30
        '
        'cmbStatus
        '
        Me.cmbStatus.AutoCompleteCustomSource.AddRange(New String() {"Active", "Inactive"})
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cmbStatus.Location = New System.Drawing.Point(224, 132)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(99, 21)
        Me.cmbStatus.TabIndex = 31
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Location = New System.Drawing.Point(204, 27)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(144, 13)
        Me.lblWarning.TabIndex = 32
        Me.lblWarning.Text = "This item is currently disabled" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblWarning.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(329, 131)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 33
        Me.btnUpdate.Text = "Update Item"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lstItem
        '
        Me.lstItem.FormattingEnabled = True
        Me.lstItem.HorizontalScrollbar = True
        Me.lstItem.Location = New System.Drawing.Point(12, 27)
        Me.lstItem.Name = "lstItem"
        Me.lstItem.Size = New System.Drawing.Size(186, 82)
        Me.lstItem.TabIndex = 34
        '
        'frmManageCatering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 201)
        Me.Controls.Add(Me.lstItem)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnNewItem)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblItem)
        Me.MaximizeBox = False
        Me.Name = "frmManageCatering"
        Me.Text = "Catering"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNewItem As System.Windows.Forms.Button
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lstItem As System.Windows.Forms.ListBox
End Class
