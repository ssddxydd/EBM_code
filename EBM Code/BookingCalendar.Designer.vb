<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookingCalendar
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
        Me.btnCreateReport = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTechSupport = New System.Windows.Forms.Label()
        Me.lblLayout = New System.Windows.Forms.Label()
        Me.txtExtraRequest = New System.Windows.Forms.TextBox()
        Me.txtLayout = New System.Windows.Forms.TextBox()
        Me.txtTechSupport = New System.Windows.Forms.TextBox()
        Me.calBooking = New System.Windows.Forms.MonthCalendar()
        Me.lblMicrophones = New System.Windows.Forms.Label()
        Me.txtMicrophone = New System.Windows.Forms.TextBox()
        Me.lblRequest = New System.Windows.Forms.Label()
        Me.dgvBookingResults = New System.Windows.Forms.DataGridView()
        Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvOrder = New System.Windows.Forms.DataGridView()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.btnMonth = New System.Windows.Forms.Button()
        Me.btnYear = New System.Windows.Forms.Button()
        Me.lblShowBooking = New System.Windows.Forms.Label()
        CType(Me.dgvBookingResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreateReport
        '
        Me.btnCreateReport.Location = New System.Drawing.Point(267, 315)
        Me.btnCreateReport.Name = "btnCreateReport"
        Me.btnCreateReport.Size = New System.Drawing.Size(102, 23)
        Me.btnCreateReport.TabIndex = 31
        Me.btnCreateReport.Text = "Create Report"
        Me.btnCreateReport.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(267, 344)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(102, 23)
        Me.btnClose.TabIndex = 30
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblTechSupport
        '
        Me.lblTechSupport.AutoSize = True
        Me.lblTechSupport.Location = New System.Drawing.Point(201, 217)
        Me.lblTechSupport.Name = "lblTechSupport"
        Me.lblTechSupport.Size = New System.Drawing.Size(97, 13)
        Me.lblTechSupport.TabIndex = 28
        Me.lblTechSupport.Text = "Technical Support "
        '
        'lblLayout
        '
        Me.lblLayout.AutoSize = True
        Me.lblLayout.Location = New System.Drawing.Point(28, 217)
        Me.lblLayout.Name = "lblLayout"
        Me.lblLayout.Size = New System.Drawing.Size(70, 13)
        Me.lblLayout.TabIndex = 27
        Me.lblLayout.Text = "Room Layout"
        '
        'txtExtraRequest
        '
        Me.txtExtraRequest.Location = New System.Drawing.Point(31, 317)
        Me.txtExtraRequest.Multiline = True
        Me.txtExtraRequest.Name = "txtExtraRequest"
        Me.txtExtraRequest.ReadOnly = True
        Me.txtExtraRequest.Size = New System.Drawing.Size(166, 60)
        Me.txtExtraRequest.TabIndex = 24
        '
        'txtLayout
        '
        Me.txtLayout.Location = New System.Drawing.Point(31, 233)
        Me.txtLayout.Multiline = True
        Me.txtLayout.Name = "txtLayout"
        Me.txtLayout.ReadOnly = True
        Me.txtLayout.Size = New System.Drawing.Size(166, 60)
        Me.txtLayout.TabIndex = 25
        '
        'txtTechSupport
        '
        Me.txtTechSupport.Location = New System.Drawing.Point(203, 233)
        Me.txtTechSupport.Multiline = True
        Me.txtTechSupport.Name = "txtTechSupport"
        Me.txtTechSupport.ReadOnly = True
        Me.txtTechSupport.Size = New System.Drawing.Size(166, 60)
        Me.txtTechSupport.TabIndex = 26
        '
        'calBooking
        '
        Me.calBooking.Location = New System.Drawing.Point(601, 12)
        Me.calBooking.MaxSelectionCount = 20
        Me.calBooking.Name = "calBooking"
        Me.calBooking.TabIndex = 22
        '
        'lblMicrophones
        '
        Me.lblMicrophones.AutoSize = True
        Me.lblMicrophones.Location = New System.Drawing.Point(200, 301)
        Me.lblMicrophones.Name = "lblMicrophones"
        Me.lblMicrophones.Size = New System.Drawing.Size(68, 13)
        Me.lblMicrophones.TabIndex = 32
        Me.lblMicrophones.Text = "Microphones"
        '
        'txtMicrophone
        '
        Me.txtMicrophone.Location = New System.Drawing.Point(204, 320)
        Me.txtMicrophone.Name = "txtMicrophone"
        Me.txtMicrophone.ReadOnly = True
        Me.txtMicrophone.Size = New System.Drawing.Size(39, 20)
        Me.txtMicrophone.TabIndex = 25
        '
        'lblRequest
        '
        Me.lblRequest.AutoSize = True
        Me.lblRequest.Location = New System.Drawing.Point(28, 301)
        Me.lblRequest.Name = "lblRequest"
        Me.lblRequest.Size = New System.Drawing.Size(79, 13)
        Me.lblRequest.TabIndex = 32
        Me.lblRequest.Text = "Extra Requests"
        '
        'dgvBookingResults
        '
        Me.dgvBookingResults.AllowUserToAddRows = False
        Me.dgvBookingResults.AllowUserToDeleteRows = False
        Me.dgvBookingResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBookingResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookingResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerName, Me.Ref, Me.BookingTime, Me.RoomName, Me.BookingID, Me.DateColumn})
        Me.dgvBookingResults.Location = New System.Drawing.Point(31, 12)
        Me.dgvBookingResults.Name = "dgvBookingResults"
        Me.dgvBookingResults.ReadOnly = True
        Me.dgvBookingResults.Size = New System.Drawing.Size(558, 162)
        Me.dgvBookingResults.TabIndex = 33
        '
        'CustomerName
        '
        Me.CustomerName.HeaderText = "Customer Name"
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.ReadOnly = True
        '
        'Ref
        '
        Me.Ref.HeaderText = "Reference"
        Me.Ref.Name = "Ref"
        Me.Ref.ReadOnly = True
        '
        'BookingTime
        '
        Me.BookingTime.HeaderText = "Time"
        Me.BookingTime.Name = "BookingTime"
        Me.BookingTime.ReadOnly = True
        '
        'RoomName
        '
        Me.RoomName.HeaderText = "Room Name"
        Me.RoomName.Name = "RoomName"
        Me.RoomName.ReadOnly = True
        '
        'BookingID
        '
        Me.BookingID.HeaderText = "BookingID"
        Me.BookingID.Name = "BookingID"
        Me.BookingID.ReadOnly = True
        Me.BookingID.Visible = False
        '
        'DateColumn
        '
        Me.DateColumn.HeaderText = "Date"
        Me.DateColumn.Name = "DateColumn"
        Me.DateColumn.ReadOnly = True
        '
        'dgvOrder
        '
        Me.dgvOrder.AllowUserToAddRows = False
        Me.dgvOrder.AllowUserToDeleteRows = False
        Me.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemName, Me.Quantity, Me.DeliveryTime})
        Me.dgvOrder.Location = New System.Drawing.Point(483, 248)
        Me.dgvOrder.Name = "dgvOrder"
        Me.dgvOrder.ReadOnly = True
        Me.dgvOrder.Size = New System.Drawing.Size(345, 107)
        Me.dgvOrder.TabIndex = 34
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Name"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'DeliveryTime
        '
        Me.DeliveryTime.HeaderText = "Delivery Time"
        Me.DeliveryTime.Name = "DeliveryTime"
        Me.DeliveryTime.ReadOnly = True
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(31, 194)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(130, 20)
        Me.txtUser.TabIndex = 26
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(28, 178)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(74, 13)
        Me.lblUser.TabIndex = 35
        Me.lblUser.Text = "Processed by:"
        '
        'btnMonth
        '
        Me.btnMonth.Location = New System.Drawing.Point(517, 204)
        Me.btnMonth.Name = "btnMonth"
        Me.btnMonth.Size = New System.Drawing.Size(75, 23)
        Me.btnMonth.TabIndex = 37
        Me.btnMonth.Text = "Month"
        Me.btnMonth.UseVisualStyleBackColor = True
        '
        'btnYear
        '
        Me.btnYear.Location = New System.Drawing.Point(601, 204)
        Me.btnYear.Name = "btnYear"
        Me.btnYear.Size = New System.Drawing.Size(75, 23)
        Me.btnYear.TabIndex = 38
        Me.btnYear.Text = "Year"
        Me.btnYear.UseVisualStyleBackColor = True
        '
        'lblShowBooking
        '
        Me.lblShowBooking.AutoSize = True
        Me.lblShowBooking.Location = New System.Drawing.Point(514, 188)
        Me.lblShowBooking.Name = "lblShowBooking"
        Me.lblShowBooking.Size = New System.Drawing.Size(134, 13)
        Me.lblShowBooking.TabIndex = 39
        Me.lblShowBooking.Text = "Show bookings for current:"
        '
        'frmBookingCalendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 380)
        Me.Controls.Add(Me.lblShowBooking)
        Me.Controls.Add(Me.btnYear)
        Me.Controls.Add(Me.btnMonth)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.dgvOrder)
        Me.Controls.Add(Me.dgvBookingResults)
        Me.Controls.Add(Me.lblRequest)
        Me.Controls.Add(Me.lblMicrophones)
        Me.Controls.Add(Me.btnCreateReport)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblTechSupport)
        Me.Controls.Add(Me.lblLayout)
        Me.Controls.Add(Me.txtExtraRequest)
        Me.Controls.Add(Me.txtMicrophone)
        Me.Controls.Add(Me.txtLayout)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtTechSupport)
        Me.Controls.Add(Me.calBooking)
        Me.MaximizeBox = False
        Me.Name = "frmBookingCalendar"
        Me.Text = "Booking Calendar"
        CType(Me.dgvBookingResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreateReport As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblTechSupport As System.Windows.Forms.Label
    Friend WithEvents lblLayout As System.Windows.Forms.Label
    Friend WithEvents txtExtraRequest As System.Windows.Forms.TextBox
    Friend WithEvents txtLayout As System.Windows.Forms.TextBox
    Friend WithEvents txtTechSupport As System.Windows.Forms.TextBox

    Friend WithEvents calBooking As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblMicrophones As System.Windows.Forms.Label
    Friend WithEvents txtMicrophone As System.Windows.Forms.TextBox
    Friend WithEvents lblRequest As System.Windows.Forms.Label
    Friend WithEvents dgvBookingResults As System.Windows.Forms.DataGridView
    Friend WithEvents CustomerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ref As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookingTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvOrder As System.Windows.Forms.DataGridView
    Friend WithEvents ItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliveryTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookingID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents DateColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnMonth As System.Windows.Forms.Button
    Friend WithEvents btnYear As System.Windows.Forms.Button
    Friend WithEvents lblShowBooking As System.Windows.Forms.Label
End Class
