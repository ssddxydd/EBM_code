Public Class frmNewBooking
    Structure OrderDetails 'this file is also optional
        Dim ItemID As Integer
        <VBFixedString(50)> Public Name As String
        Dim Quantity As Integer
        Dim DeliveryTime As Date
    End Structure
    Dim Order(200) As OrderDetails
    Dim NoOfItems As Integer = 0
    Dim Item As CateringData
    Dim ItemControl As CateringControlData
    Dim Setup As SystemSetupData
    Dim Booking As BookingData
    Dim BookingControl As BookingControlData
    Dim Customer As CustomerData
    Dim CustomerControl As CustomerControlData
    Dim Room As RoomData
    Dim RoomControl As RoomControlData
    Dim RoomSetup As RoomSetupData
    Dim Request As ExtraRequestData
   
   
    Private Sub frmNewBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup))
        FileGet(1, Setup, 1) 'retrieve system information
        FileClose(1)



        LockBookingFile(Setup.ResourceFolder, BookingControl)

        If BookingControl.Current = BookingControl.Max Then 'if the file has no more room 
            FileOpen(1, Setup.ResourceFolder + "\Booking.dat", OpenMode.Random, , , Len(Booking))
            FileOpen(2, Setup.ResourceFolder + "\NewBooking.dat", OpenMode.Random, , , Len(Booking))
            'open the old Booking file then create new Booking file
            For i As Integer = 1 To BookingControl.Max
                FileGet(1, Booking, i)
                FilePut(2, Booking, i)
            Next
            'tranfer all of the Bookings into the new file
            With Booking 'setup a blank record in order to pad out the rest of the file
                .Active = False
                .BookingDate = Nothing
                .BookingID = Nothing
                .CustomerID = Nothing
                .CustomerOrderFile = Nothing
                .EndTime = Nothing
                .StartTime = Nothing
                .RoomLayoutFile = Nothing
                .RequestFile = Nothing
                .CustomerOrderFile = Nothing
                .NextBooking = 0
            End With
            For i As Integer = BookingControl.Max + 1 To (BookingControl.Max + 100) ' add an extra 100 records into the file
                FilePut(2, Booking, i)
            Next
            FileClose(1) 'close both files
            FileClose(2)
            'rename the file and delete old file NOTE for now we shall not delete the file simply rename it
            My.Computer.FileSystem.DeleteFile(Setup.ResourceFolder + "\Booking.dat")
            My.Computer.FileSystem.RenameFile(Setup.ResourceFolder + "\NewBooking.dat", "Booking.dat")
            'rename file to Booking
            'update the  file with a new maximum number of records
            BookingControl.Max = BookingControl.Max + 100
            FileOpen(1, Setup.ResourceFolder + "\BookingControl.dat", OpenMode.Random, , , Len(BookingControl))
            FilePut(1, BookingControl, 1)
            FileClose(1)
        End If

        UnlockBookingFile(Setup.ResourceFolder, BookingControl)


        'Retrive data from Customer file and load it into the combo box

        LockCustomerFile(Setup.ResourceFolder, CustomerControl)
        If CustomerControl.Current <> 0 Then
            FileOpen(1, Setup.ResourceFolder + "\Customer.dat", OpenMode.Random, , , Len(Customer))
            For i As Integer = 1 To CustomerControl.Current
                FileGet(1, Customer, i)
                lstCustomer.Items.Add(Unpad(Customer.Name))
            Next
            FileClose(1)
        End If
        If CustomerControl.Current = CustomerControl.Max Then 'if the file has no more room 
            FileOpen(1, Setup.ResourceFolder + "\Customer.dat", OpenMode.Random, , , Len(Customer))
            FileOpen(2, Setup.ResourceFolder + "\NewCustomer.dat", OpenMode.Random, , , Len(Customer))
            'open the old Customer file then create new Customer file
            For i As Integer = 1 To CustomerControl.Max
                FileGet(1, Customer, i)
                FilePut(2, Customer, i)
            Next
            'tranfer all of the Customers into the new file
            With Customer 'setup a blank record in order to pad out the rest of the file
                .Active = False
                .BookingPointer = 0
                .CustomerID = Nothing
                .Email = Nothing
                .IEmail = Nothing
                .IMobilePhone = Nothing
                .IName = Nothing
                .IPostalAddress = Nothing
                .IPostCode = Nothing
                .ITelephone = Nothing
                .MobilePhone = Nothing
                .Name = Nothing
                .PostalAddress = Nothing
                .PostCode = Nothing
                .Telephone = Nothing
            End With
            For i As Integer = CustomerControl.Max + 1 To (CustomerControl.Max + 100) ' add an extra 100 records into the file
                FilePut(2, Customer, i)
            Next
            FileClose(1) 'close both files
            FileClose(2)
            'rename the file and delete old file NOTE for now we shall not delete the file simply rename it
            If My.Computer.FileSystem.FileExists(Setup.ResourceFolder + "\OldCustomer.dat") Then
                My.Computer.FileSystem.DeleteFile(Setup.ResourceFolder + "\OldCustomer.dat")
            End If

            My.Computer.FileSystem.RenameFile(Setup.ResourceFolder + "\Customer.dat", "OldCustomer.dat")
            My.Computer.FileSystem.RenameFile(Setup.ResourceFolder + "\NewCustomer.dat", "Customer.dat")
            'rename file to Customer
            'update the  file with a new maximum number of records
            CustomerControl.Max = CustomerControl.Max + 100
            FileOpen(1, Setup.ResourceFolder + "\CustomerControl.dat", OpenMode.Random, , , Len(CustomerControl))
            FilePut(1, CustomerControl, 1)
            FileClose(1)
        End If
        UnlockCustomerFile(Setup.ResourceFolder, CustomerControl)
        ''''

        LockRoomFile(Setup.ResourceFolder, RoomControl)

        If RoomControl.Current <> 0 Then 'populates cmbRoom
            FileOpen(1, Setup.ResourceFolder + "\Room.dat", OpenMode.Random, , , Len(Room))
            For i As Integer = 1 To RoomControl.Current
                FileGet(1, Room, i)
                cmbRoom.Items.Add(Unpad(Room.Name))
            Next
            FileClose(1)
        End If
        UnlockRoomFile(Setup.ResourceFolder, RoomControl)
        LockItemFile(Setup.ResourceFolder, ItemControl)
        If ItemControl.Current <> 0 Then
            FileOpen(1, Setup.ResourceFolder + "\Item.dat", OpenMode.Random, , , Len(Item))
            For i As Integer = 1 To ItemControl.Current
                FileGet(1, Item, i)
                lstItem.Items.Add(Unpad(Item.Name))
            Next
            FileClose(1)
        End If
        UnlockItemFile(Setup.ResourceFolder, ItemControl)
        dtpEndTime.Value = dtpEndTime.MinDate
        dtpStartTime.Value = dtpStartTime.MinDate 'set the start time and end time to 
        dtpDelivery.Value = dtpDelivery.MinDate 'set the delivery time to 0

    End Sub

    Private Sub btnAddBooking_Click(sender As Object, e As EventArgs) Handles btnAddBooking.Click 'adds a new booking to the file
        Dim i As Integer ' temporary pointer variable
        Dim LastBooking As Integer 'the pointer to the last booking placed by the customer
        Dim NewOrder As OrderData 'variable storing the order details which will be entered into the file
        Dim ClashingBooking As BookingData
        If lstCustomer.SelectedIndex = -1 And cbxNewCustomer.Checked = False Then 'if the customer has not been selected show the message
            MessageBox.Show("Please select a Customer or add a new customer", "Customer not selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbRoom.SelectedIndex = -1 Then 'if the room has not been selected show the message
            MessageBox.Show("Please select a Room", "Room not selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dtpStartTime.Value = dtpStartTime.MinDate Or dtpEndTime.Value = dtpEndTime.MinDate Then 'if the booking time has not been selected
            MessageBox.Show("Please select a time for the booking", "Time not selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dtpEndTime.Value <= dtpStartTime.Value Then
            MessageBox.Show("Please select a valid time for the booking", "Invalid booking time", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else 'else proceed adding the new booking

            FileOpen(1, Setup.ResourceFolder + "\BookingControl.dat", OpenMode.Random, , , Len(BookingControl))
            FileGet(1, BookingControl, 1)
            FileClose(1)
            'check if there are any bookings using the same room at the same time
            ClashingBooking = CheckForClashes(BookingControl.Current + 1, cmbRoom.SelectedIndex + 1, dtpDate.Value, dtpStartTime.Value,
                                              dtpEndTime.Value, Setup.ResourceFolder, BookingControl)

            'get the information about a booking which clashes with the one currently being processed   
            If ClashingBooking.CustomerID <> 0 Then
                MessageBox.Show("This booking clashes with a booking starting at " &
                                ClashingBooking.StartTime.ToShortTimeString & " and ending at " &
                                 ClashingBooking.EndTime.ToShortTimeString & " on " &
                                 ClashingBooking.BookingDate.ToShortDateString & vbCrLf & "Reference : " &
                                 ClashingBooking.Ref, "Clashing Booking", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else 'if there are no clashes and the booking is unique

                If cbxNewCustomer.Checked = True Then 'if a new customer has been selected 
                    With Customer 'transfer data from the text boxes into the customer variable
                        .Name = txtName.Text
                        .Telephone = txtTelephone.Text
                        .MobilePhone = txtMobile.Text
                        .PostalAddress = txtAddress.Text
                        .PostCode = txtPostcode.Text
                        .Email = txtEmail.Text
                        .Active = True
                        .IName = txtInvoiceName.Text
                        .ITelephone = txtInvoiceTelephone.Text
                        .IMobilePhone = txtInvoiceMobile.Text
                        .IPostalAddress = txtInvoiceAddress.Text
                        .IPostCode = txtInvoicePostcode.Text
                        .BookingPointer = BookingControl.Current + 1
                        .CustomerID = CustomerControl.Current + 1
                    End With

                    LockCustomerFile(Setup.ResourceFolder, CustomerControl)
                    CustomerControl.Current = CustomerControl.Current + 1 'update the current number of customers in the file 
                    FileOpen(1, Setup.ResourceFolder + "\CustomerControl.dat", OpenMode.Random, , , Len(CustomerControl))
                    FilePut(1, CustomerControl, 1) 'open control file and update the InUse field andthe current number of customers
                    FileClose(1) ' close the control file
                    FileOpen(1, Setup.ResourceFolder + "\Customer.dat", OpenMode.Random, , , Len(Customer))
                    FilePut(1, Customer, CustomerControl.Current) 'add new customer to the file
                    FileClose(1) 'close the customer file
                    UnlockCustomerFile(Setup.ResourceFolder, CustomerControl)

                ElseIf cbxNewCustomer.Checked = False Then 'if an existing customer has been selected

                    LockCustomerFile(Setup.ResourceFolder, CustomerControl)
                    FileOpen(1, Setup.ResourceFolder + "\Customer.dat", OpenMode.Random, , , Len(Customer))
                    FileGet(1, Customer, lstCustomer.SelectedIndex + 1)
                    FileClose(1)
                    If Customer.BookingPointer = 0 Then 'If Oldest Booking Pointer = 0 then
                        Customer.BookingPointer = BookingControl.Current + 1 'Set Customer.BookingPointer  = Number of bookings +1
                        FileOpen(1, Setup.ResourceFolder + "\Customer.dat", OpenMode.Random, , , Len(Customer))
                        FilePut(1, Customer, lstCustomer.SelectedIndex + 1)
                        FileClose(1)
                        UnlockCustomerFile(Setup.ResourceFolder, CustomerControl)
                    ElseIf Customer.BookingPointer <> 0 Then 'Else Oldest Booking Pointer <> 0 then
                        i = Customer.BookingPointer 'i = Oldest Booking Pointer
                        FileOpen(1, Setup.ResourceFolder + "\Booking.dat", OpenMode.Random, , , Len(Booking)) ' Open Booking File
                        While i <> 0
                            FileGet(1, Booking, i) 'Retrieve Booking from file at position i
                            LastBooking = i 'LastBookingPointer = i
                            i = Booking.NextBooking 'i = NextBookingPointer
                        End While
                        Booking.NextBooking = BookingControl.Current + 1 'Set NextBookingPointer = Number of bookings +1
                        FilePut(1, Booking, LastBooking)
                        'Update booking file at position LastBookingPointer with new NextBookingPointer
                        FileClose(1)
                        UnlockCustomerFile(Setup.ResourceFolder, CustomerControl)
                    End If

                End If
                With Booking
                    .Active = True
                    .BookingDate = dtpDate.Value
                    .EndTime = dtpEndTime.Value
                    .StartTime = dtpStartTime.Value
                    .RoomID = cmbRoom.SelectedIndex + 1
                    .Ref = txtReference.Text
                    .UserID = UserID
                    .CustomerID = Customer.CustomerID
                    .BookingID = BookingControl.Current + 1
                    .RoomLayoutFile = Setup.ResourceFolder + "\BookingInformation" + "\RoomSetup_" + Booking.BookingID.ToString + ".dat"
                    .RequestFile = Setup.ResourceFolder + "\BookingInformation" + "\Request_" + Booking.BookingID.ToString + ".dat"
                    .CustomerOrderFile = Setup.ResourceFolder + "\BookingInformation" + "\Order_" + Booking.BookingID.ToString + ".dat"
                    .NextBooking = 0
                End With
                BookingControl.Current = BookingControl.Current + 1
                FileOpen(1, Setup.ResourceFolder + "\BookingControl.dat", OpenMode.Random, , , Len(BookingControl))
                FilePut(1, BookingControl, 1)
                FileClose(1) ' close the control file
                FileOpen(1, Setup.ResourceFolder + "\Booking.dat", OpenMode.Random, , , Len(Booking))
                FilePut(1, Booking, BookingControl.Current)
                FileClose(1) ' close the booking file
                With RoomSetup
                    .Layout = txtLayout.Text
                    .Microphones = nudMicrophones.Value
                    .TechSupport = txtTechSupport.Text
                End With
                FileOpen(1, Setup.ResourceFolder + "\BookingInformation" + "\RoomSetup_" + Booking.BookingID.ToString + ".dat", OpenMode.Random, , , Len(RoomSetup))
                FilePut(1, RoomSetup, 1)
                FileClose(1)
                'create the order file and put in the ordered items
                FileOpen(1, Setup.ResourceFolder + "\BookingInformation" + "\Order_" + Booking.BookingID.ToString + ".dat", OpenMode.Random, , , Len(NewOrder))
                For i = 0 To NoOfItems - 1
                    NewOrder.ItemID = Order(i).ItemID
                    NewOrder.Quantity = Order(i).Quantity
                    NewOrder.DeliveryTime = Order(i).DeliveryTime
                    FilePut(1, NewOrder, i + 1)
                Next
                FileClose(1)
                Request.Details = txtExtraRequest.Text
                FileOpen(1, Setup.ResourceFolder + "\BookingInformation" + "\Request_" + Booking.BookingID.ToString + ".dat", OpenMode.Random, , , Len(Request))
                FilePut(1, Request, 1)
                FileClose(1)
                MessageBox.Show("The new booking has ben created succesfully", "Booking Created", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
    End Sub
    Private Sub cbxNewCustomer_CheckedChanged(sender As Object, e As EventArgs) Handles cbxNewCustomer.CheckedChanged
        lstCustomer.SelectedIndex = -1
        If cbxNewCustomer.Checked = True Then

            pnlNewCustomer.Visible = True
        Else : pnlNewCustomer.Visible = False
        End If
    End Sub


    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If NoOfItems = 200 Then
            MessageBox.Show("The maximum number of items has been reached.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf nudQuantity.Value = 0 Then
            MessageBox.Show("Please enter a quantity", "Quantity missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf lstItem.SelectedIndex = -1 Then
            MessageBox.Show("Please select an item you would like to order", "No item has been selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf nudQuantity.Value = 0 Then
            MessageBox.Show("Please select a quantity", "Quantity has not been declared", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dtpDelivery.Value < dtpStartTime.Value Or dtpDelivery.Value > dtpEndTime.Value Then
            dtpDelivery.Value = dtpStartTime.Value
            MessageBox.Show("Please choose a valid delivery time", "Invalid Delivery Time", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            LockItemFile(Setup.ResourceFolder, ItemControl)

            FileOpen(1, Setup.ResourceFolder + "\Item.dat", OpenMode.Random, , , Len(Item))
            FileGet(1, Item, lstItem.SelectedIndex + 1)
            FileClose(1)

            dgvItems.Rows.Add(Unpad(Item.Name), nudQuantity.Value, dtpDelivery.Value.ToShortTimeString)
            Order(NoOfItems).Name = Unpad(Item.Name)
            Order(NoOfItems).ItemID = Item.ItemID
            Order(NoOfItems).Quantity = nudQuantity.Value
            Order(NoOfItems).DeliveryTime = dtpDelivery.Value
            NoOfItems = NoOfItems + 1
            UnlockItemFile(Setup.ResourceFolder, ItemControl)
            nudQuantity.Value = 0
        End If

    End Sub

    Private Sub btnRemoveSelected_Click(sender As Object, e As EventArgs) Handles btnRemoveSelected.Click

        Dim CurrentIndex As Integer = dgvItems.CurrentCellAddress.Y
        If NoOfItems <> 0 Then
            For i As Integer = CurrentIndex To NoOfItems - 1
                Order(i) = Order(i + 1)
            Next
            NoOfItems = NoOfItems - 1
            dgvItems.Rows.Clear()
            For i = 0 To NoOfItems - 1
                dgvItems.Rows.Add(Order(i).Name, Order(i).Quantity, Order(i).DeliveryTime.ToShortTimeString)
            Next
        Else : MessageBox.Show("There are no items left to be removed", "No Items Left", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnClearTime_Click(sender As Object, e As EventArgs) Handles btnClearTime.Click
        dtpDelivery.Value = dtpStartTime.Value
    End Sub

    Private Sub lstCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustomer.SelectedIndexChanged, lstItem.SelectedIndexChanged
        If lstCustomer.SelectedIndex <> -1 Then

            LockCustomerFile(Setup.ResourceFolder, CustomerControl)
            FileOpen(1, Setup.ResourceFolder + "\Customer.dat", OpenMode.Random, , , Len(Customer))
            FileGet(1, Customer, lstCustomer.SelectedIndex + 1)
            FileClose(1)
            UnlockCustomerFile(Setup.ResourceFolder, CustomerControl)
            If Customer.Active = False Then
                MessageBox.Show("This customer is not active and therefore no bookings can be made in their name If you would like to reactivate them,please seek the permission of the system administartor",
                            "Inactive customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lstCustomer.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub cmbRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRoom.SelectedIndexChanged
        If cmbRoom.SelectedIndex <> -1 Then

         
            LockRoomFile(Setup.ResourceFolder, RoomControl)
               
            FileOpen(1, Setup.ResourceFolder + "\Room.dat", OpenMode.Random, , , Len(Room))
            FileGet(1, Room, cmbRoom.SelectedIndex + 1)
            FileClose(1)
            UnlockRoomFile(Setup.ResourceFolder, RoomControl)
            If Room.Active = False Then
                MessageBox.Show("This Room is currently unavailable",
                            "Inactive Room", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbRoom.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub lstItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstItem.SelectedIndexChanged
        If lstItem.SelectedIndex <> -1 Then
            LockItemFile(Setup.ResourceFolder, ItemControl)
            FileOpen(1, Setup.ResourceFolder + "\Item.dat", OpenMode.Random, , , Len(Item))
            FileGet(1, Item, lstItem.SelectedIndex + 1)
            FileClose(1)
            UnlockItemFile(Setup.ResourceFolder, ItemControl)
            If Item.Active = False Then
                MessageBox.Show("This Item is currently unavailable",
                            "Inactive Item", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lstItem.SelectedIndex = -1

            End If
        End If
    End Sub
   
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub dtpStartTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartTime.ValueChanged
        If dtpEndTime.Value = dtpEndTime.MinDate Then
            dtpEndTime.Value = dtpStartTime.Value
        End If
        dtpDelivery.Value = dtpStartTime.Value
      
    End Sub

  
End Class