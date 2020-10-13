<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetup
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
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.fbdResource = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtResourceFolder = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblResourceFolder = New System.Windows.Forms.Label()
        Me.lblSetupType = New System.Windows.Forms.Label()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.cmbSetupType = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(32, 29)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(151, 20)
        Me.txtCompanyName.TabIndex = 0
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Location = New System.Drawing.Point(29, 13)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(82, 13)
        Me.lblCompanyName.TabIndex = 3
        Me.lblCompanyName.Text = "Company Name"
        '
        'txtResourceFolder
        '
        Me.txtResourceFolder.Location = New System.Drawing.Point(34, 115)
        Me.txtResourceFolder.Name = "txtResourceFolder"
        Me.txtResourceFolder.Size = New System.Drawing.Size(167, 20)
        Me.txtResourceFolder.TabIndex = 6
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(200, 114)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 22)
        Me.btnBrowse.TabIndex = 7
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lblResourceFolder
        '
        Me.lblResourceFolder.AutoSize = True
        Me.lblResourceFolder.Location = New System.Drawing.Point(31, 99)
        Me.lblResourceFolder.Name = "lblResourceFolder"
        Me.lblResourceFolder.Size = New System.Drawing.Size(118, 13)
        Me.lblResourceFolder.TabIndex = 5
        Me.lblResourceFolder.Text = "Select Resource Folder"
        '
        'lblSetupType
        '
        Me.lblSetupType.AutoSize = True
        Me.lblSetupType.Location = New System.Drawing.Point(31, 55)
        Me.lblSetupType.Name = "lblSetupType"
        Me.lblSetupType.Size = New System.Drawing.Size(62, 13)
        Me.lblSetupType.TabIndex = 10
        Me.lblSetupType.Text = "Setup Type"
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(200, 156)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(75, 23)
        Me.btnFinish.TabIndex = 8
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'cmbSetupType
        '
        Me.cmbSetupType.FormattingEnabled = True
        Me.cmbSetupType.Items.AddRange(New Object() {"User", "System"})
        Me.cmbSetupType.Location = New System.Drawing.Point(33, 71)
        Me.cmbSetupType.Name = "cmbSetupType"
        Me.cmbSetupType.Size = New System.Drawing.Size(83, 21)
        Me.cmbSetupType.TabIndex = 9
        '
        'frmSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 205)
        Me.Controls.Add(Me.lblSetupType)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.cmbSetupType)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.txtResourceFolder)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.lblResourceFolder)
        Me.Controls.Add(Me.btnBrowse)
        Me.MaximizeBox = False
        Me.Name = "frmSetup"
        Me.Text = "System Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents fbdResource As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtResourceFolder As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lblResourceFolder As System.Windows.Forms.Label
    Friend WithEvents btnFinish As System.Windows.Forms.Button
    Friend WithEvents cmbSetupType As System.Windows.Forms.ComboBox
    Friend WithEvents lblSetupType As System.Windows.Forms.Label
End Class
