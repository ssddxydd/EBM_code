Public Class frmManageBookings
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
    'need to retest the form
    
    Private Sub ManageBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup))
        FileGet(1, Setup, 1) 'retrieve system information
        FileClose(1)

            LockCustomerFile(Setup.ResourceFolder, CustomerControl)
         
            If CustomerControl.Current <> 0 Then
                FileOpen(1, Setup.ResourceFolder + "\Customer.dat", OpenMode.Random, , , Len(Customer))
                For i As Integer = 1 To CustomerControl.Current
                    FileGet(1, Customer, i)
                    lstCustomer.Items.Add(Unpad(Customer.Name))
                Next
                FileClose(1)
            End If
        UnlockCustomerFile(Setup.ResourceFolder, CustomerControl)
     

      
            LockRoomFile(Setup.ResourceFolder, RoomControl)
            
            If RoomControl.Current <> 0 Then
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
        dtpStartTime.Value = dtpStartTime.MinDate 'set the start time and end time to 0
        dtpDelivery.Value = dtpDelivery.MinDate 'set the delivery time to 0


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

            dgvItem.Rows.Add(Unpad(Item.Name), nudQuantity.Value, dtpDelivery.Value.ToShortTimeString)

            Order(NoOfItems).Name = Unpad(Item.Name)
            Order(NoOfItems).ItemID = Item.ItemID
            Order(NoOfItems).Quantity = nudQuantity.Value
            Order(NoOfItems).DeliveryTime = dtpDelivery.Value
            NoOfItems = NoOfItems + 1
            UnlockItemFile(Setup.ResourceFolder, ItemControl)
            nudQuantity.Value = 0
        End If

    End Sub
    Private Sub btnClearTime_Click(sender As Object, e As EventArgs) Handles btnClearTime.Click
        dtpDelivery.Value = dtpStartTime.Value
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
    Private Sub btnRemoveSelected_Click(sender As Object, e As EventArgs) Handles btnRemoveSelected.Click

        Dim CurrentIndex As Integer = dgvItem.CurrentCellAddress.Y
        If NoOfItems <> 0 Then
            For i As Integer = CurrentIndex To NoOfItems - 1
                Order(i) = Order(i + 1)
            Next
            NoOfItems = NoOfItems - 1
            dgvItem.Rows.Clear()
            For i = 0 To NoOfItems - 1
                dgvItem.Rows.Add(Order(i).Name, Order(i).Quantity, Order(i).DeliveryTime.ToShortTimeString)

            Next
        Else : MessageBox.Show("There are no items left to be removed", "No Items Left", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim NewOrder As OrderData
        Dim ClashingBooking As BookingData
        Dim y As Integer = dgvBookings.CurrentCellAddress.Y
        If cmbRoom.SelectedIndex = -1 Then
            'if the room has not been selected show the message
            MessageBox.Show("Please select a Room", "Room not selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dtpStartTime.Value = dtpStartTime.MinDate Or dtpEndTime.Value = dtpEndTime.MinDate Then 'if the booking time has not been selected
            MessageBox.Show("Please select a time for the booking", "Time not selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dtpEndTime.Value <= dtpStartTime.Value Then
            MessageBox.Show("Please select a valid time for the booking", "Invalid booking time", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            'check if there are any bookings using the same room at the same time
            ClashingBooking = CheckForClashes(dgvBookings.Item(3, y).Value, cmbRoom.SelectedIndex + 1, dtpDate.Value, dtpStartTime.Value,
                                              dtpEndTime.Value, Setup.ResourceFolder, BookingControl)
            'get the information about a booking which clashes with the one currently being processed 

            If ClashingBooking.CustomerID <> 0 Then
                MessageBox.Show("This booking clashes with a booking starting at " &
                                ClashingBooking.StartTime.ToShortTimeString & " and ending at " &
                                 ClashingBooking.EndTime.ToShortTimeString & " on " &
                                 ClashingBooking.BookingDate.ToShortDateString & vbCrLf & "Reference : " &
                                 ClashingBooking.Ref, "Clashing Booking", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else 'if there are no clashes and the booking is unique

                With Booking
                    If cmbStatus.SelectedIndex = 0 Then
                        .Active = True
                    Else : .Active = False
                    End If
                    .BookingDate = dtpDate.Value
                    .StartTime = dtpStartTime.Value
                    .EndTime = dtpEndTime.Value
                    .Ref = txtReference.Text
                    .RoomID = cmbRoom.SelectedIndex + 1
                End With
                FileOpen(1, Setup.ResourceFolder + "\BookingInformation" + "\Request_" + Booking.BookingID.ToString + ".dat", OpenMode.Random, , , Len(Request))
                Request.Details = txtExtraRequest.Text
                FilePut(1, Request, 1)
                FileClose(1)
                FileOpen(1, Setup.ResourceFolder + "\BookingInformation" + "\RoomSetup_" + Booking.BookingID.ToString + ".dat", OpenMode.Random, , , Len(RoomSetup))
                RoomSetup.Layout = txtLayout.Text
                RoomSetup.TechSupport = txtTechSupport.Text
                RoomSetup.Microphones = nudMicrophone.Value
                FilePut(1, RoomSetup, 1)
                FileClose(1)

                FileOpen(1, Setup.ResourceFolder + "\BookingInformation" + "\Order_" + Booking.BookingID.ToString + ".dat", OpenMode.Random, , , Len(NewOrder))
                For i = 0 To NoOfItems - 1
                    NewOrder.ItemID = Order(i).ItemID
                    NewOrder.Quantity = Order(i).Quantity
                    NewOrder.DeliveryTime = Order(i).DeliveryTime
                    FilePut(1, NewOrder, i + 1)
                Next
                FileClose(1)


                LockBookingFile(Setup.ResourceFolder, BookingControl)


                FileOpen(1, Setup.ResourceFolder + "\Booking.dat", OpenMode.Random, , , Len(Booking))
                FilePut(1, Booking, CInt(dgvBookings.Item(3, y).Value))
                FileClose(1)
                UnlockBookingFile(Setup.ResourceFolder, BookingControl)
                MessageBox.Show("The Booking information has been updated", "Booking Information Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
        End If
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lstCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustomer.SelectedIndexChanged
        Dim Pointer As Integer
        If lstCustomer.SelectedIndex = -1 Then
            MessageBox.Show("Please Select a Customer", "Customer not selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            LockCustomerFile(Setup.ResourceFolder, CustomerControl)
            FileOpen(1, Setup.ResourceFolder + "\Customer.dat", OpenMode.Random, , , Len(Customer))
            FileGet(1, Customer, lstCustomer.SelectedIndex + 1)
            FileClose(1)
            UnlockCustomerFile(Setup.ResourceFolder, CustomerControl)

            Pointer = Customer.BookingPointer
            If Pointer = 0 Then
                MessageBox.Show("This Customer does not have any bookings", "No Bookings available", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'change this
            Else


                LockBookingFile(Setup.ResourceFolder, BookingControl)
                LockRoomFile(Setup.ResourceFolder, RoomControl)

                FileOpen(1, Setup.ResourceFolder + "\Booking.dat", OpenMode.Random, , , Len(Booking))

                FileOpen(2, Setup.ResourceFolder + "\RoomControl.dat", OpenMode.Random, , , Len(RoomControl))
                FilePut(2, RoomControl, 1)
                FileClose(2)
                FileOpen(2, Setup.ResourceFolder + "\Room.dat", OpenMode.Random, , , Len(Room))
                dgvBookings.Rows.Clear() 'clear the data grid
                While Pointer <> 0
                    FileGet(1, Booking, Pointer)
                    FileGet(2, Room, Booking.RoomID)
                    Pointer = Booking.NextBooking
                    dgvBookings.Rows.Add(Booking.BookingDate.ToShortDateString, Unpad(Room.Name), Unpad(Booking.Ref), Booking.BookingID)

                End While
                FileClose(1)
                FileClose(2)
                UnlockBookingFile(Setup.ResourceFolder, BookingControl)
                UnlockRoomFile(Setup.ResourceFolder, RoomControl)


            End If
        End If
    End Sub


    Private Sub dgvBookings_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBookings.CellClick
        'Retrieves booking information about the currently selected booking.
        Dim NewOrder As OrderData
        Dim y As Integer = dgvBookings.CurrentCellAddress.Y
        If dgvBookings.CurrentCellAddress.Y <> -1 Then


            LockBookingFile(Setup.ResourceFolder, BookingControl)


            FileOpen(1, Setup.ResourceFolder + "\Booking.dat", OpenMode.Random, , , Len(Booking))
            FileGet(1, Booking, dgvBookings.Item(3, y).Value)
            FileClose(1)
            UnlockBookingFile(Setup.ResourceFolder, BookingControl)

            txtReference.Text = Unpad(Booking.Ref)
            dtpDate.Value = Booking.BookingDate
            dtpStartTime.Value = Booking.StartTime
            dtpEndTime.Value = Booking.EndTime
            cmbRoom.SelectedIndex = Booking.RoomID - 1
            If Room.Active = True Then
                cmbStatus.SelectedIndex = 0
            Else : cmbStatus.SelectedIndex = 1
            End If
            FileOpen(1, Setup.ResourceFolder + "\BookingInformation" + "\Request_" + Booking.BookingID.ToString + ".dat", OpenMode.Random, , , Len(Request))
            FileGet(1, Request, 1)
            FileClose(1)
            txtExtraRequest.Text = Unpad(Request.Details)
            FileOpen(1, Setup.ResourceFolder + "\BookingInformation" + "\RoomSetup_" + Booking.BookingID.ToString + ".dat", OpenMode.Random, , , Len(RoomSetup))
            FileGet(1, RoomSetup, 1)
            FileClose(1)
            txtLayout.Text = Unpad(RoomSetup.Layout)
            txtTechSupport.Text = Unpad(Unpad(RoomSetup.TechSupport))
            nudMicrophone.Value = RoomSetup.Microphones
            LockItemFile(Setup.ResourceFolder, ItemControl)
            FileOpen(1, Setup.ResourceFolder + "\BookingInformation" + "\Order_" + Booking.BookingID.ToString + ".dat", OpenMode.Random, , , Len(NewOrder))


            FileOpen(2, Setup.ResourceFolder + "\Item.dat", OpenMode.Random, , , Len(Item))
            dgvItem.Rows.Clear()
            NoOfItems = 0
            While Not EOF(1)
                FileGet(1, NewOrder, NoOfItems + 1)
                FileGet(2, Item, NewOrder.ItemID)
                Order(NoOfItems).Name = Unpad(Item.Name)
                Order(NoOfItems).ItemID = Item.ItemID
                Order(NoOfItems).Quantity = NewOrder.Quantity
                Order(NoOfItems).DeliveryTime = NewOrder.DeliveryTime
                dgvItem.Rows.Add(Order(NoOfItems).Name, Order(NoOfItems).Quantity, Order(NoOfItems).DeliveryTime.ToShortTimeString)
                NoOfItems = NoOfItems + 1
            End While
            FileClose(1)
            FileClose(2)
            UnlockItemFile(Setup.ResourceFolder, ItemControl)
        End If
    End Sub

    Private Sub dtpStartTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartTime.ValueChanged
        If dtpEndTime.Value = dtpEndTime.MinDate Then
            dtpEndTime.Value = dtpStartTime.Value
        End If
        dtpDelivery.Value = dtpStartTime.Value
    End Sub

   
End Class