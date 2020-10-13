<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewBooking
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
        Me.cbxNewCustomer = New System.Windows.Forms.CheckBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.pnlNewCustomer = New System.Windows.Forms.Panel()
        Me.txtInvoicePostcode = New System.Windows.Forms.TextBox()
        Me.txtInvoiceAddress = New System.Windows.Forms.TextBox()
        Me.txtInvoiceEmail = New System.Windows.Forms.TextBox()
        Me.lblInvoicePostcode = New System.Windows.Forms.Label()
        Me.lblInvoiceAddress = New System.Windows.Forms.Label()
        Me.lblInvoiceEmail = New System.Windows.Forms.Label()
        Me.txtInvoiceMobile = New System.Windows.Forms.TextBox()
        Me.txtInvoiceTelephone = New System.Windows.Forms.TextBox()
        Me.txtInvoiceName = New System.Windows.Forms.TextBox()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.lblInvoiceMobile = New System.Windows.Forms.Label()
        Me.lblInvoiceTelephone = New System.Windows.Forms.Label()
        Me.lblInvoiceName = New System.Windows.Forms.Label()
        Me.lblPostcode = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblReference = New System.Windows.Forms.Label()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.dtpStartTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndTime = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbRoom = New System.Windows.Forms.ComboBox()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.btnAddBooking = New System.Windows.Forms.Button()
        Me.nudMicrophones = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLayout = New System.Windows.Forms.TextBox()
        Me.txtTechSupport = New System.Windows.Forms.TextBox()
        Me.lblLayout = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClearTime = New System.Windows.Forms.Button()
        Me.lblDeliveryTime = New System.Windows.Forms.Label()
        Me.dtpDelivery = New System.Windows.Forms.DateTimePicker()
        Me.btnRemoveSelected = New System.Windows.Forms.Button()
        Me.lblItemsOrdered = New System.Windows.Forms.Label()
        Me.lblExtraRequest = New System.Windows.Forms.Label()
        Me.txtExtraRequest = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDeliveryTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lstCustomer = New System.Windows.Forms.ListBox()
        Me.lstItem = New System.Windows.Forms.ListBox()
        Me.pnlNewCustomer.SuspendLayout()
        CType(Me.nudMicrophones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxNewCustomer
        '
        Me.cbxNewCustomer.AutoSize = True
        Me.cbxNewCustomer.Location = New System.Drawing.Point(496, 113)
        Me.cbxNewCustomer.Name = "cbxNewCustomer"
        Me.cbxNewCustomer.Size = New System.Drawing.Size(95, 17)
        Me.cbxNewCustomer.TabIndex = 0
        Me.cbxNewCustomer.Text = "New Customer"
        Me.cbxNewCustomer.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(12, 23)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'pnlNewCustomer
        '
        Me.pnlNewCustomer.Controls.Add(Me.txtInvoicePostcode)
        Me.pnlNewCustomer.Controls.Add(Me.txtInvoiceAddress)
        Me.pnlNewCustomer.Controls.Add(Me.txtInvoiceEmail)
        Me.pnlNewCustomer.Controls.Add(Me.lblInvoicePostcode)
        Me.pnlNewCustomer.Controls.Add(Me.lblInvoiceAddress)
        Me.pnlNewCustomer.Controls.Add(Me.lblInvoiceEmail)
        Me.pnlNewCustomer.Controls.Add(Me.txtInvoiceMobile)
        Me.pnlNewCustomer.Controls.Add(Me.txtInvoiceTelephone)
        Me.pnlNewCustomer.Controls.Add(Me.txtInvoiceName)
        Me.pnlNewCustomer.Controls.Add(Me.txtPostcode)
        Me.pnlNewCustomer.Controls.Add(Me.lblInvoiceMobile)
        Me.pnlNewCustomer.Controls.Add(Me.lblInvoiceTelephone)
        Me.pnlNewCustomer.Controls.Add(Me.lblInvoiceName)
        Me.pnlNewCustomer.Controls.Add(Me.lblPostcode)
        Me.pnlNewCustomer.Controls.Add(Me.txtAddress)
        Me.pnlNewCustomer.Controls.Add(Me.lblAddress)
        Me.pnlNewCustomer.Controls.Add(Me.lblEmail)
        Me.pnlNewCustomer.Controls.Add(Me.txtEmail)
        Me.pnlNewCustomer.Controls.Add(Me.lblMobile)
        Me.pnlNewCustomer.Controls.Add(Me.txtMobile)
        Me.pnlNewCustomer.Controls.Add(Me.txtTelephone)
        Me.pnlNewCustomer.Controls.Add(Me.lblTelephone)
        Me.pnlNewCustomer.Controls.Add(Me.lblName)
        Me.pnlNewCustomer.Controls.Add(Me.txtName)
        Me.pnlNewCustomer.Location = New System.Drawing.Point(12, 41)
        Me.pnlNewCustomer.Name = "pnlNewCustomer"
        Me.pnlNewCustomer.Size = New System.Drawing.Size(465, 179)
        Me.pnlNewCustomer.TabIndex = 2
        Me.pnlNewCustomer.Visible = False
        '
        'txtInvoicePostcode
        '
        Me.txtInvoicePostcode.Location = New System.Drawing.Point(308, 149)
        Me.txtInvoicePostcode.Name = "txtInvoicePostcode"
        Me.txtInvoicePostcode.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoicePostcode.TabIndex = 24
        '
        'txtInvoiceAddress
        '
        Me.txtInvoiceAddress.Location = New System.Drawing.Point(154, 149)
        Me.txtInvoiceAddress.Name = "txtInvoiceAddress"
        Me.txtInvoiceAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoiceAddress.TabIndex = 23
        '
        'txtInvoiceEmail
        '
        Me.txtInvoiceEmail.Location = New System.Drawing.Point(12, 150)
        Me.txtInvoiceEmail.Name = "txtInvoiceEmail"
        Me.txtInvoiceEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoiceEmail.TabIndex = 22
        '
        'lblInvoicePostcode
        '
        Me.lblInvoicePostcode.AutoSize = True
        Me.lblInvoicePostcode.Location = New System.Drawing.Point(308, 132)
        Me.lblInvoicePostcode.Name = "lblInvoicePostcode"
        Me.lblInvoicePostcode.Size = New System.Drawing.Size(96, 13)
        Me.lblInvoicePostcode.TabIndex = 21
        Me.lblInvoicePostcode.Text = "Invocing Postcode"
        '
        'lblInvoiceAddress
        '
        Me.lblInvoiceAddress.AutoSize = True
        Me.lblInvoiceAddress.Location = New System.Drawing.Point(151, 132)
        Me.lblInvoiceAddress.Name = "lblInvoiceAddress"
        Me.lblInvoiceAddress.Size = New System.Drawing.Size(123, 13)
        Me.lblInvoiceAddress.TabIndex = 20
        Me.lblInvoiceAddress.Text = "Invoicing Postal Address"
        '
        'lblInvoiceEmail
        '
        Me.lblInvoiceEmail.AutoSize = True
        Me.lblInvoiceEmail.Location = New System.Drawing.Point(12, 133)
        Me.lblInvoiceEmail.Name = "lblInvoiceEmail"
        Me.lblInvoiceEmail.Size = New System.Drawing.Size(117, 13)
        Me.lblInvoiceEmail.TabIndex = 19
        Me.lblInvoiceEmail.Text = "Invocing Email Address"
        '
        'txtInvoiceMobile
        '
        Me.txtInvoiceMobile.Location = New System.Drawing.Point(308, 105)
        Me.txtInvoiceMobile.Name = "txtInvoiceMobile"
        Me.txtInvoiceMobile.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoiceMobile.TabIndex = 18
        '
        'txtInvoiceTelephone
        '
        Me.txtInvoiceTelephone.Location = New System.Drawing.Point(154, 105)
        Me.txtInvoiceTelephone.Name = "txtInvoiceTelephone"
        Me.txtInvoiceTelephone.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoiceTelephone.TabIndex = 17
        '
        'txtInvoiceName
        '
        Me.txtInvoiceName.Location = New System.Drawing.Point(12, 105)
        Me.txtInvoiceName.Name = "txtInvoiceName"
        Me.txtInvoiceName.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoiceName.TabIndex = 16
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(308, 62)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(100, 20)
        Me.txtPostcode.TabIndex = 15
        '
        'lblInvoiceMobile
        '
        Me.lblInvoiceMobile.AutoSize = True
        Me.lblInvoiceMobile.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblInvoiceMobile.Location = New System.Drawing.Point(305, 89)
        Me.lblInvoiceMobile.Name = "lblInvoiceMobile"
        Me.lblInvoiceMobile.Size = New System.Drawing.Size(158, 13)
        Me.lblInvoiceMobile.TabIndex = 14
        Me.lblInvoiceMobile.Text = "Invoicing Mobile Phone Number"
        '
        'lblInvoiceTelephone
        '
        Me.lblInvoiceTelephone.AutoSize = True
        Me.lblInvoiceTelephone.Location = New System.Drawing.Point(154, 89)
        Me.lblInvoiceTelephone.Name = "lblInvoiceTelephone"
        Me.lblInvoiceTelephone.Size = New System.Drawing.Size(144, 13)
        Me.lblInvoiceTelephone.TabIndex = 13
        Me.lblInvoiceTelephone.Text = "Invoicing Telephone Number"
        '
        'lblInvoiceName
        '
        Me.lblInvoiceName.AutoSize = True
        Me.lblInvoiceName.Location = New System.Drawing.Point(9, 89)
        Me.lblInvoiceName.Name = "lblInvoiceName"
        Me.lblInvoiceName.Size = New System.Drawing.Size(121, 13)
        Me.lblInvoiceName.TabIndex = 12
        Me.lblInvoiceName.Text = "Invoicing Contact Name"
        '
        'lblPostcode
        '
        Me.lblPostcode.AutoSize = True
        Me.lblPostcode.Location = New System.Drawing.Point(305, 46)
        Me.lblPostcode.Name = "lblPostcode"
        Me.lblPostcode.Size = New System.Drawing.Size(52, 13)
        Me.lblPostcode.TabIndex = 11
        Me.lblPostcode.Text = "Postcode"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(154, 62)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddress.TabIndex = 10
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(151, 46)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(77, 13)
        Me.lblAddress.TabIndex = 9
        Me.lblAddress.Text = "Postal Address"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(9, 46)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(73, 13)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email Address"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(12, 62)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 7
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(305, 7)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(112, 13)
        Me.lblMobile.TabIndex = 6
        Me.lblMobile.Text = "Mobile Phone Number"
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(308, 23)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(100, 20)
        Me.txtMobile.TabIndex = 5
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(154, 23)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(100, 20)
        Me.txtTelephone.TabIndex = 4
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(151, 7)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(98, 13)
        Me.lblTelephone.TabIndex = 3
        Me.lblTelephone.Text = "Telephone Number"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(9, 7)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'lblReference
        '
        Me.lblReference.AutoSize = True
        Me.lblReference.Location = New System.Drawing.Point(13, 237)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(99, 13)
        Me.lblReference.TabIndex = 3
        Me.lblReference.Text = "Booking Reference"
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(16, 253)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(69, 20)
        Me.txtReference.TabIndex = 4
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(122, 253)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 5
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(118, 235)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(72, 13)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "Booking Date"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Location = New System.Drawing.Point(13, 278)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(55, 13)
        Me.lblStartTime.TabIndex = 7
        Me.lblStartTime.Text = "Start Time"
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Location = New System.Drawing.Point(119, 278)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(52, 13)
        Me.lblEndTime.TabIndex = 7
        Me.lblEndTime.Text = "End Time"
        '
        'dtpStartTime
        '
        Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStartTime.Location = New System.Drawing.Point(16, 294)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.Size = New System.Drawing.Size(100, 20)
        Me.dtpStartTime.TabIndex = 8
        '
        'dtpEndTime
        '
        Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEndTime.Location = New System.Drawing.Point(122, 294)
        Me.dtpEndTime.Name = "dtpEndTime"
        Me.dtpEndTime.Size = New System.Drawing.Size(100, 20)
        Me.dtpEndTime.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(16, 325)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 13)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "Room Setup"
        '
        'cmbRoom
        '
        Me.cmbRoom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRoom.FormattingEnabled = True
        Me.cmbRoom.Location = New System.Drawing.Point(228, 293)
        Me.cmbRoom.Name = "cmbRoom"
        Me.cmbRoom.Size = New System.Drawing.Size(127, 21)
        Me.cmbRoom.TabIndex = 21
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(225, 278)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(68, 13)
        Me.lblRoom.TabIndex = 22
        Me.lblRoom.Text = "Select Room"
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(493, 22)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(84, 13)
        Me.lblCustomer.TabIndex = 23
        Me.lblCustomer.Text = "Select Customer"
        '
        'btnAddBooking
        '
        Me.btnAddBooking.Location = New System.Drawing.Point(16, 427)
        Me.btnAddBooking.Name = "btnAddBooking"
        Me.btnAddBooking.Size = New System.Drawing.Size(75, 23)
        Me.btnAddBooking.TabIndex = 24
        Me.btnAddBooking.Text = "Finish"
        Me.btnAddBooking.UseVisualStyleBackColor = True
        '
        'nudMicrophones
        '
        Me.nudMicrophones.Location = New System.Drawing.Point(324, 401)
        Me.nudMicrophones.Name = "nudMicrophones"
        Me.nudMicrophones.Size = New System.Drawing.Size(51, 20)
        Me.nudMicrophones.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 372)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Number of Microphones"
        '
        'txtLayout
        '
        Me.txtLayout.Location = New System.Drawing.Point(16, 362)
        Me.txtLayout.Multiline = True
        Me.txtLayout.Name = "txtLayout"
        Me.txtLayout.Size = New System.Drawing.Size(137, 59)
        Me.txtLayout.TabIndex = 27
        '
        'txtTechSupport
        '
        Me.txtTechSupport.Location = New System.Drawing.Point(170, 362)
        Me.txtTechSupport.Multiline = True
        Me.txtTechSupport.Name = "txtTechSupport"
        Me.txtTechSupport.Size = New System.Drawing.Size(137, 59)
        Me.txtTechSupport.TabIndex = 28
        '
        'lblLayout
        '
        Me.lblLayout.AutoSize = True
        Me.lblLayout.Location = New System.Drawing.Point(13, 348)
        Me.lblLayout.Name = "lblLayout"
        Me.lblLayout.Size = New System.Drawing.Size(39, 13)
        Me.lblLayout.TabIndex = 29
        Me.lblLayout.Text = "Layout"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(170, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Tech Support"
        '
        'btnClearTime
        '
        Me.btnClearTime.Location = New System.Drawing.Point(628, 193)
        Me.btnClearTime.Name = "btnClearTime"
        Me.btnClearTime.Size = New System.Drawing.Size(75, 23)
        Me.btnClearTime.TabIndex = 29
        Me.btnClearTime.Text = "Clear Time"
        Me.btnClearTime.UseVisualStyleBackColor = True
        '
        'lblDeliveryTime
        '
        Me.lblDeliveryTime.AutoSize = True
        Me.lblDeliveryTime.Location = New System.Drawing.Point(491, 140)
        Me.lblDeliveryTime.Name = "lblDeliveryTime"
        Me.lblDeliveryTime.Size = New System.Drawing.Size(71, 13)
        Me.lblDeliveryTime.TabIndex = 28
        Me.lblDeliveryTime.Text = "Delivery Time"
        '
        'dtpDelivery
        '
        Me.dtpDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpDelivery.Location = New System.Drawing.Point(494, 159)
        Me.dtpDelivery.Name = "dtpDelivery"
        Me.dtpDelivery.Size = New System.Drawing.Size(92, 20)
        Me.dtpDelivery.TabIndex = 27
        '
        'btnRemoveSelected
        '
        Me.btnRemoveSelected.Location = New System.Drawing.Point(727, 164)
        Me.btnRemoveSelected.Name = "btnRemoveSelected"
        Me.btnRemoveSelected.Size = New System.Drawing.Size(144, 23)
        Me.btnRemoveSelected.TabIndex = 24
        Me.btnRemoveSelected.Text = "Remove Selected Item"
        Me.btnRemoveSelected.UseVisualStyleBackColor = True
        '
        'lblItemsOrdered
        '
        Me.lblItemsOrdered.AutoSize = True
        Me.lblItemsOrdered.Location = New System.Drawing.Point(675, 343)
        Me.lblItemsOrdered.Name = "lblItemsOrdered"
        Me.lblItemsOrdered.Size = New System.Drawing.Size(73, 13)
        Me.lblItemsOrdered.TabIndex = 23
        Me.lblItemsOrdered.Text = "Items Ordered"
        '
        'lblExtraRequest
        '
        Me.lblExtraRequest.AutoSize = True
        Me.lblExtraRequest.Location = New System.Drawing.Point(493, 359)
        Me.lblExtraRequest.Name = "lblExtraRequest"
        Me.lblExtraRequest.Size = New System.Drawing.Size(79, 13)
        Me.lblExtraRequest.TabIndex = 21
        Me.lblExtraRequest.Text = "Extra Requests"
        '
        'txtExtraRequest
        '
        Me.txtExtraRequest.Location = New System.Drawing.Point(496, 384)
        Me.txtExtraRequest.Multiline = True
        Me.txtExtraRequest.Name = "txtExtraRequest"
        Me.txtExtraRequest.Size = New System.Drawing.Size(246, 57)
        Me.txtExtraRequest.TabIndex = 20
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(492, 180)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 16
        Me.lblQuantity.Text = "Quantity"
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(685, 25)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(60, 13)
        Me.lblItem.TabIndex = 14
        Me.lblItem.Text = "Select Item"
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(727, 193)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(144, 23)
        Me.btnAddItem.TabIndex = 11
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(494, 196)
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(120, 20)
        Me.nudQuantity.TabIndex = 13
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(97, 428)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 35
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dgvItems
        '
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.AllowUserToDeleteRows = False
        Me.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemName, Me.ItemQuantity, Me.ItemDeliveryTime})
        Me.dgvItems.Location = New System.Drawing.Point(495, 227)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.ReadOnly = True
        Me.dgvItems.Size = New System.Drawing.Size(376, 127)
        Me.dgvItems.TabIndex = 0
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
        'lstCustomer
        '
        Me.lstCustomer.FormattingEnabled = True
        Me.lstCustomer.Location = New System.Drawing.Point(496, 41)
        Me.lstCustomer.Name = "lstCustomer"
        Me.lstCustomer.Size = New System.Drawing.Size(120, 69)
        Me.lstCustomer.TabIndex = 36
        '
        'lstItem
        '
        Me.lstItem.FormattingEnabled = True
        Me.lstItem.Location = New System.Drawing.Point(688, 41)
        Me.lstItem.Name = "lstItem"
        Me.lstItem.Size = New System.Drawing.Size(183, 69)
        Me.lstItem.TabIndex = 36
        '
        'frmNewBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(892, 465)
        Me.Controls.Add(Me.lstItem)
        Me.Controls.Add(Me.lstCustomer)
        Me.Controls.Add(Me.dgvItems)
        Me.Controls.Add(Me.btnClearTime)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblDeliveryTime)
        Me.Controls.Add(Me.dtpDelivery)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblItemsOrdered)
        Me.Controls.Add(Me.btnRemoveSelected)
        Me.Controls.Add(Me.lblLayout)
        Me.Controls.Add(Me.lblExtraRequest)
        Me.Controls.Add(Me.txtTechSupport)
        Me.Controls.Add(Me.txtExtraRequest)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtLayout)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudMicrophones)
        Me.Controls.Add(Me.nudQuantity)
        Me.Controls.Add(Me.btnAddBooking)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.cmbRoom)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.dtpEndTime)
        Me.Controls.Add(Me.dtpStartTime)
        Me.Controls.Add(Me.lblEndTime)
        Me.Controls.Add(Me.lblStartTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.lblReference)
        Me.Controls.Add(Me.pnlNewCustomer)
        Me.Controls.Add(Me.cbxNewCustomer)
        Me.MaximizeBox = False
        Me.Name = "frmNewBooking"
        Me.Text = "New Booking"
        Me.pnlNewCustomer.ResumeLayout(False)
        Me.pnlNewCustomer.PerformLayout()
        CType(Me.nudMicrophones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxNewCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents pnlNewCustomer As System.Windows.Forms.Panel
    Friend WithEvents txtInvoiceMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoiceTelephone As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoiceName As System.Windows.Forms.TextBox
    Friend WithEvents txtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents lblInvoiceMobile As System.Windows.Forms.Label
    Friend WithEvents lblInvoiceTelephone As System.Windows.Forms.Label
    Friend WithEvents lblInvoiceName As System.Windows.Forms.Label
    Friend WithEvents lblPostcode As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtInvoicePostcode As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoiceAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoiceEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblInvoicePostcode As System.Windows.Forms.Label
    Friend WithEvents lblInvoiceAddress As System.Windows.Forms.Label
    Friend WithEvents lblInvoiceEmail As System.Windows.Forms.Label
    Friend WithEvents lblReference As System.Windows.Forms.Label
    Friend WithEvents txtReference As System.Windows.Forms.TextBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblStartTime As System.Windows.Forms.Label
    Friend WithEvents lblEndTime As System.Windows.Forms.Label
    Friend WithEvents dtpStartTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmbRoom As System.Windows.Forms.ComboBox
    Friend WithEvents lblRoom As System.Windows.Forms.Label
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents btnAddBooking As System.Windows.Forms.Button
    Friend WithEvents nudMicrophones As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLayout As System.Windows.Forms.TextBox
    Friend WithEvents txtTechSupport As System.Windows.Forms.TextBox
    Friend WithEvents lblLayout As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnClearTime As System.Windows.Forms.Button
    Friend WithEvents lblDeliveryTime As System.Windows.Forms.Label
    Friend WithEvents dtpDelivery As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnRemoveSelected As System.Windows.Forms.Button
    Friend WithEvents lblItemsOrdered As System.Windows.Forms.Label
    Friend WithEvents lblExtraRequest As System.Windows.Forms.Label
    Friend WithEvents txtExtraRequest As System.Windows.Forms.TextBox
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents dgvItems As System.Windows.Forms.DataGridView
    Friend WithEvents ItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDeliveryTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lstCustomer As System.Windows.Forms.ListBox
    Friend WithEvents lstItem As System.Windows.Forms.ListBox
End Class
