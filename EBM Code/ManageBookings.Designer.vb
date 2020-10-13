<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageBookings
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
        Me.lblBooking = New System.Windows.Forms.Label()
        Me.lblTechSupport = New System.Windows.Forms.Label()
        Me.lblLayout = New System.Windows.Forms.Label()
        Me.txtTechSupport = New System.Windows.Forms.TextBox()
        Me.txtLayout = New System.Windows.Forms.TextBox()
        Me.lblMicrophone = New System.Windows.Forms.Label()
        Me.nudMicrophone = New System.Windows.Forms.NumericUpDown()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.cmbRoom = New System.Windows.Forms.ComboBox()
        Me.dtpEndTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartTime = New System.Windows.Forms.DateTimePicker()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.lblReference = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.btnClearTime = New System.Windows.Forms.Button()
        Me.lblDeliveryTime = New System.Windows.Forms.Label()
        Me.dtpDelivery = New System.Windows.Forms.DateTimePicker()
        Me.btnRemoveSelected = New System.Windows.Forms.Button()
        Me.lblExtraRequest = New System.Windows.Forms.Label()
        Me.txtExtraRequest = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.dgvItem = New System.Windows.Forms.DataGridView()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDeliveryTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvBookings = New System.Windows.Forms.DataGridView()
        Me.lstCustomer = New System.Windows.Forms.ListBox()
        Me.lstItem = New System.Windows.Forms.ListBox()
        Me.BookingDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingIDColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.nudMicrophone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBooking
        '
        Me.lblBooking.AutoSize = True
        Me.lblBooking.Location = New System.Drawing.Point(10, 12)
        Me.lblBooking.Name = "lblBooking"
        Me.lblBooking.Size = New System.Drawing.Size(79, 13)
        Me.lblBooking.TabIndex = 27
        Me.lblBooking.Text = "Select Booking"
        '
        'lblTechSupport
        '
        Me.lblTechSupport.AutoSize = True
        Me.lblTechSupport.Location = New System.Drawing.Point(180, 236)
        Me.lblTechSupport.Name = "lblTechSupport"
        Me.lblTechSupport.Size = New System.Drawing.Size(72, 13)
        Me.lblTechSupport.TabIndex = 48
        Me.lblTechSupport.Text = "Tech Support"
        '
        'lblLayout
        '
        Me.lblLayout.AutoSize = True
        Me.lblLayout.Location = New System.Drawing.Point(9, 236)
        Me.lblLayout.Name = "lblLayout"
        Me.lblLayout.Size = New System.Drawing.Size(39, 13)
        Me.lblLayout.TabIndex = 47
        Me.lblLayout.Text = "Layout"
        '
        'txtTechSupport
        '
        Me.txtTechSupport.Location = New System.Drawing.Point(183, 250)
        Me.txtTechSupport.Multiline = True
        Me.txtTechSupport.Name = "txtTechSupport"
        Me.txtTechSupport.Size = New System.Drawing.Size(137, 59)
        Me.txtTechSupport.TabIndex = 46
        '
        'txtLayout
        '
        Me.txtLayout.Location = New System.Drawing.Point(12, 250)
        Me.txtLayout.Multiline = True
        Me.txtLayout.Name = "txtLayout"
        Me.txtLayout.Size = New System.Drawing.Size(137, 59)
        Me.txtLayout.TabIndex = 45
        '
        'lblMicrophone
        '
        Me.lblMicrophone.AutoSize = True
        Me.lblMicrophone.Location = New System.Drawing.Point(180, 312)
        Me.lblMicrophone.Name = "lblMicrophone"
        Me.lblMicrophone.Size = New System.Drawing.Size(120, 13)
        Me.lblMicrophone.TabIndex = 44
        Me.lblMicrophone.Text = "Number of Microphones"
        '
        'nudMicrophone
        '
        Me.nudMicrophone.Location = New System.Drawing.Point(183, 330)
        Me.nudMicrophone.Name = "nudMicrophone"
        Me.nudMicrophone.Size = New System.Drawing.Size(51, 20)
        Me.nudMicrophone.TabIndex = 43
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(223, 197)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(68, 13)
        Me.lblRoom.TabIndex = 42
        Me.lblRoom.Text = "Select Room"
        '
        'cmbRoom
        '
        Me.cmbRoom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRoom.FormattingEnabled = True
        Me.cmbRoom.Location = New System.Drawing.Point(225, 212)
        Me.cmbRoom.Name = "cmbRoom"
        Me.cmbRoom.Size = New System.Drawing.Size(95, 21)
        Me.cmbRoom.TabIndex = 41
        '
        'dtpEndTime
        '
        Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEndTime.Location = New System.Drawing.Point(118, 213)
        Me.dtpEndTime.Name = "dtpEndTime"
        Me.dtpEndTime.Size = New System.Drawing.Size(100, 20)
        Me.dtpEndTime.TabIndex = 39
        '
        'dtpStartTime
        '
        Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStartTime.Location = New System.Drawing.Point(12, 213)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.Size = New System.Drawing.Size(100, 20)
        Me.dtpStartTime.TabIndex = 38
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Location = New System.Drawing.Point(115, 197)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(52, 13)
        Me.lblEndTime.TabIndex = 37
        Me.lblEndTime.Text = "End Time"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Location = New System.Drawing.Point(9, 197)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(55, 13)
        Me.lblStartTime.TabIndex = 36
        Me.lblStartTime.Text = "Start Time"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(115, 158)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(72, 13)
        Me.lblDate.TabIndex = 35
        Me.lblDate.Text = "Booking Date"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(118, 174)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(202, 20)
        Me.dtpDate.TabIndex = 34
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(13, 174)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(69, 20)
        Me.txtReference.TabIndex = 33
        '
        'lblReference
        '
        Me.lblReference.AutoSize = True
        Me.lblReference.Location = New System.Drawing.Point(10, 158)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(99, 13)
        Me.lblReference.TabIndex = 32
        Me.lblReference.Text = "Booking Reference"
        '
        'cmbStatus
        '
        Me.cmbStatus.AutoCompleteCustomSource.AddRange(New String() {"Active", "Inactive"})
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cmbStatus.Location = New System.Drawing.Point(12, 330)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(123, 21)
        Me.cmbStatus.TabIndex = 53
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(13, 313)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 52
        Me.lblStatus.Text = "Status"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(273, 359)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(123, 23)
        Me.btnClose.TabIndex = 57
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(400, 359)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(123, 23)
        Me.btnUpdate.TabIndex = 56
        Me.btnUpdate.Text = "Update Booking Details"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(266, 10)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(84, 13)
        Me.lblCustomer.TabIndex = 55
        Me.lblCustomer.Text = "Select Customer"
        '
        'btnClearTime
        '
        Me.btnClearTime.Location = New System.Drawing.Point(637, 70)
        Me.btnClearTime.Name = "btnClearTime"
        Me.btnClearTime.Size = New System.Drawing.Size(75, 22)
        Me.btnClearTime.TabIndex = 29
        Me.btnClearTime.Text = "Clear Time"
        Me.btnClearTime.UseVisualStyleBackColor = True
        '
        'lblDeliveryTime
        '
        Me.lblDeliveryTime.AutoSize = True
        Me.lblDeliveryTime.Location = New System.Drawing.Point(553, 56)
        Me.lblDeliveryTime.Name = "lblDeliveryTime"
        Me.lblDeliveryTime.Size = New System.Drawing.Size(71, 13)
        Me.lblDeliveryTime.TabIndex = 28
        Me.lblDeliveryTime.Text = "Delivery Time"
        '
        'dtpDelivery
        '
        Me.dtpDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpDelivery.Location = New System.Drawing.Point(544, 71)
        Me.dtpDelivery.Name = "dtpDelivery"
        Me.dtpDelivery.Size = New System.Drawing.Size(92, 20)
        Me.dtpDelivery.TabIndex = 27
        '
        'btnRemoveSelected
        '
        Me.btnRemoveSelected.Location = New System.Drawing.Point(544, 92)
        Me.btnRemoveSelected.Name = "btnRemoveSelected"
        Me.btnRemoveSelected.Size = New System.Drawing.Size(144, 23)
        Me.btnRemoveSelected.TabIndex = 24
        Me.btnRemoveSelected.Text = "Remove Selected Item"
        Me.btnRemoveSelected.UseVisualStyleBackColor = True
        '
        'lblExtraRequest
        '
        Me.lblExtraRequest.AutoSize = True
        Me.lblExtraRequest.Location = New System.Drawing.Point(398, 281)
        Me.lblExtraRequest.Name = "lblExtraRequest"
        Me.lblExtraRequest.Size = New System.Drawing.Size(79, 13)
        Me.lblExtraRequest.TabIndex = 21
        Me.lblExtraRequest.Text = "Extra Requests"
        '
        'txtExtraRequest
        '
        Me.txtExtraRequest.Location = New System.Drawing.Point(401, 296)
        Me.txtExtraRequest.Multiline = True
        Me.txtExtraRequest.Name = "txtExtraRequest"
        Me.txtExtraRequest.Size = New System.Drawing.Size(200, 57)
        Me.txtExtraRequest.TabIndex = 20
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(398, 108)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 16
        Me.lblQuantity.Text = "Quantity"
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(398, 9)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(60, 13)
        Me.lblItem.TabIndex = 14
        Me.lblItem.Text = "Select Item"
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(544, 121)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(144, 23)
        Me.btnAddItem.TabIndex = 11
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(401, 124)
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(120, 20)
        Me.nudQuantity.TabIndex = 13
        '
        'dgvItem
        '
        Me.dgvItem.AllowUserToAddRows = False
        Me.dgvItem.AllowUserToDeleteRows = False
        Me.dgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemName, Me.ItemQuantity, Me.ItemDeliveryTime})
        Me.dgvItem.Location = New System.Drawing.Point(401, 148)
        Me.dgvItem.Name = "dgvItem"
        Me.dgvItem.ReadOnly = True
        Me.dgvItem.Size = New System.Drawing.Size(342, 128)
        Me.dgvItem.TabIndex = 59
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Name"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'ItemQuantity
        '
        Me.ItemQuantity.HeaderText = "Quantity"
        Me.ItemQuantity.Name = "ItemQuantity"
        Me.ItemQuantity.ReadOnly = True
        '
        'ItemDeliveryTime
        '
        Me.ItemDeliveryTime.HeaderText = "Delivery Time"
        Me.ItemDeliveryTime.Name = "ItemDeliveryTime"
        Me.ItemDeliveryTime.ReadOnly = True
        '
        'dgvBookings
        '
        Me.dgvBookings.AllowUserToAddRows = False
        Me.dgvBookings.AllowUserToDeleteRows = False
        Me.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingDate, Me.RoomName, Me.BookingRef, Me.BookingIDColumn})
        Me.dgvBookings.Location = New System.Drawing.Point(12, 28)
        Me.dgvBookings.Name = "dgvBookings"
        Me.dgvBookings.ReadOnly = True
        Me.dgvBookings.Size = New System.Drawing.Size(251, 125)
        Me.dgvBookings.TabIndex = 60
        '
        'lstCustomer
        '
        Me.lstCustomer.FormattingEnabled = True
        Me.lstCustomer.Location = New System.Drawing.Point(269, 28)
        Me.lstCustomer.Name = "lstCustomer"
        Me.lstCustomer.Size = New System.Drawing.Size(120, 69)
        Me.lstCustomer.TabIndex = 61
        '
        'lstItem
        '
        Me.lstItem.FormattingEnabled = True
        Me.lstItem.Location = New System.Drawing.Point(401, 28)
        Me.lstItem.Name = "lstItem"
        Me.lstItem.Size = New System.Drawing.Size(120, 69)
        Me.lstItem.TabIndex = 62
        '
        'BookingDate
        '
        Me.BookingDate.HeaderText = "Date"
        Me.BookingDate.Name = "BookingDate"
        Me.BookingDate.ReadOnly = True
        '
        'RoomName
        '
        Me.RoomName.HeaderText = "Room"
        Me.RoomName.Name = "RoomName"
        Me.RoomName.ReadOnly = True
        '
        'BookingRef
        '
        Me.BookingRef.HeaderText = "Reference"
        Me.BookingRef.Name = "BookingRef"
        Me.BookingRef.ReadOnly = True
        '
        'BookingIDColumn
        '
        Me.BookingIDColumn.HeaderText = "ID"
        Me.BookingIDColumn.Name = "BookingIDColumn"
        Me.BookingIDColumn.ReadOnly = True
        Me.BookingIDColumn.Visible = False
        '
        'frmManageBookings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 394)
        Me.Controls.Add(Me.lstItem)
        Me.Controls.Add(Me.lstCustomer)
        Me.Controls.Add(Me.dgvBookings)
        Me.Controls.Add(Me.dgvItem)
        Me.Controls.Add(Me.lblDeliveryTime)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.btnClearTime)
        Me.Controls.Add(Me.dtpDelivery)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.lblExtraRequest)
        Me.Controls.Add(Me.btnRemoveSelected)
        Me.Controls.Add(Me.nudQuantity)
        Me.Controls.Add(Me.txtExtraRequest)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblTechSupport)
        Me.Controls.Add(Me.lblLayout)
        Me.Controls.Add(Me.txtTechSupport)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.txtLayout)
        Me.Controls.Add(Me.lblMicrophone)
        Me.Controls.Add(Me.nudMicrophone)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.cmbRoom)
        Me.Controls.Add(Me.dtpEndTime)
        Me.Controls.Add(Me.dtpStartTime)
        Me.Controls.Add(Me.lblEndTime)
        Me.Controls.Add(Me.lblStartTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.lblReference)
        Me.Controls.Add(Me.lblBooking)
        Me.MaximizeBox = False
        Me.Name = "frmManageBookings"
        Me.Text = "ManageBookings"
        CType(Me.nudMicrophone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBooking As System.Windows.Forms.Label
    Friend WithEvents lblTechSupport As System.Windows.Forms.Label
    Friend WithEvents lblLayout As System.Windows.Forms.Label
    Friend WithEvents txtTechSupport As System.Windows.Forms.TextBox
    Friend WithEvents txtLayout As System.Windows.Forms.TextBox
    Friend WithEvents lblMicrophone As System.Windows.Forms.Label
    Friend WithEvents nudMicrophone As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblRoom As System.Windows.Forms.Label
    Friend WithEvents cmbRoom As System.Windows.Forms.ComboBox
    Friend WithEvents dtpEndTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEndTime As System.Windows.Forms.Label
    Friend WithEvents lblStartTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtReference As System.Windows.Forms.TextBox
    Friend WithEvents lblReference As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents btnClearTime As System.Windows.Forms.Button
    Friend WithEvents lblDeliveryTime As System.Windows.Forms.Label
    Friend WithEvents dtpDelivery As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnRemoveSelected As System.Windows.Forms.Button
    Friend WithEvents lblExtraRequest As System.Windows.Forms.Label
    Friend WithEvents txtExtraRequest As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents dgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents ItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDeliveryTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvBookings As System.Windows.Forms.DataGridView
    Friend WithEvents lstCustomer As System.Windows.Forms.ListBox
    Friend WithEvents lstItem As System.Windows.Forms.ListBox
    Friend WithEvents BookingDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookingRef As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookingIDColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
