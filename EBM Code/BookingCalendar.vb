Imports Word = Microsoft.Office.Interop.Word
Public Class frmBookingCalendar
  
    Dim User As UserData
    Dim UserControl As UserControlData
    Dim Item As CateringData
    Dim ItemControl As CateringControlData
    Dim Setup As SystemSetupData
    Dim Booking As BookingData
    Dim BookingControl As BookingControlData
    Dim Customer As CustomerData
    Dim CustomerControl As CustomerControlData
    Dim Room As RoomData
    Dim RoomControl As RoomControlData
    Dim Order As OrderData
    Dim RoomSetup As RoomSetupData
    Dim Request As ExtraRequestData

    'Do not know whther the index of the booking id has changed
    'might crash or give bad results 
    Private Sub calBooking_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calBooking.DateChanged

        dgvBookingResults.Rows.Clear() 'Clear Information in the data grid
        LockBookingFile(Setup.ResourceFolder, BookingControl)
        FileOpen(1, Setup.ResourceFolder + "\Booking.dat", OpenMode.Random, , , Len(Booking))
        'Open booking file
        For i As Integer = 1 To BookingControl.Current
            FileGet(1, Booking, i)

            If Booking.BookingDate >= calBooking.SelectionStart And Booking.BookingDate <= calBooking.SelectionEnd Then
                FileOpen(2, Setup.ResourceFolder + "\Room.dat", OpenMode.Random, , , Len(Room))
                'Open room file
                FileGet(2, Room, Booking.RoomID) 'Get Room Name for the Room specified in the booking 
                FileClose(2) 'Close room file
                FileOpen(2, Setup.ResourceFolder + "\Customer.dat", OpenMode.Random, , , Len(Customer))
                'Open customer file
                FileGet(2, Customer, Booking.CustomerID)
                FileClose(2) 'close customer file
                dgvBookingResults.Rows.Add(Unpad(Customer.Name), Unpad(Booking.Ref), Booking.StartTime.ToShortTimeString & "-" & Booking.EndTime.ToShortTimeString, Unpad(Room.Name), Booking.BookingID, Booking.BookingDate.ToShortDateString)
                'Add the Customer Name, Booking reference, Start time, End Time and End Time to data grid Close Customer File
            End If
        Next
        FileClose(1) 'Close booking file
        UnlockBookingFile(Setup.ResourceFolder, BookingControl)


    End Sub

    Private Sub frmBookingCalendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup))
        FileGet(1, Setup, 1) 'retrieve system information   
        FileClose(1)


        LockBookingFile(Setup.ResourceFolder, BookingControl)


        FileOpen(1, Setup.ResourceFolder + "\Booking.dat", OpenMode.Random, , , Len(Booking))

        For i As Integer = 1 To BookingControl.Current
            FileGet(1, Booking, i)

            If Booking.BookingDate.Month = calBooking.TodayDate.Month Then

                FileOpen(2, Setup.ResourceFolder + "\Room.dat", OpenMode.Random, , , Len(Room))
                FileGet(2, Room, Booking.RoomID)
                FileClose(2)
                FileOpen(2, Setup.ResourceFolder + "\Customer.dat", OpenMode.Random, , , Len(Customer))
                FileGet(2, Customer, Booking.CustomerID)
                FileClose(2)
                dgvBookingResults.Rows.Add(Unpad(Customer.Name), Unpad(Booking.Ref), Booking.StartTime.ToShortTimeString & "-" & Booking.EndTime.ToShortTimeString, Unpad(Room.Name), Booking.BookingID, Booking.BookingDate.ToShortDateString)

            End If

        Next

        FileClose(1)
        UnlockBookingFile(Setup.ResourceFolder, BookingControl)



    End Sub



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvBookingResults_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBookingResults.CellClick
        Dim i As Integer = 0
        Dim y As Integer = dgvBookingResults.CurrentCellAddress.Y
        dgvOrder.Rows.Clear()


        LockBookingFile(Setup.ResourceFolder, BookingControl)

        FileOpen(1, Setup.ResourceFolder + "\Booking.dat", OpenMode.Random, , , Len(Booking))
        FileGet(1, Booking, dgvBookingResults.Item(4, y).Value)
        FileClose(1)
        UnlockBookingFile(Setup.ResourceFolder, BookingControl)

        FileOpen(1, Setup.ResourceFolder + "\BookingInformation" + "\Request_" + Booking.BookingID.ToString + ".dat", OpenMode.Random, , , Len(Request))
        FileGet(1, Request, 1)
        FileClose(1)
        txtExtraRequest.Text = Unpad(Request.Details)
        FileOpen(1, Setup.ResourceFolder + "\BookingInformation" + "\RoomSetup_" + Booking.BookingID.ToString + ".dat", OpenMode.Random, , , Len(RoomSetup))
        FileGet(1, RoomSetup, 1)
        FileClose(1)


        LockUserFile(Setup.ResourceFolder, UserControl)

        FileOpen(1, Setup.ResourceFolder + "\User.dat", OpenMode.Random, , , Len(User))
        FileGet(1, User, Booking.UserID)
        FileClose(1)
        txtUser.Text = Unpad(User.Name)
        UnlockUserFile(Setup.ResourceFolder, UserControl)

        txtLayout.Text = Unpad(Unpad(RoomSetup.Layout))
        txtTechSupport.Text = Unpad(Unpad(RoomSetup.TechSupport))
        txtMicrophone.Text = RoomSetup.Microphones
        FileOpen(1, Setup.ResourceFolder + "\BookingInformation" + "\Order_" + Booking.BookingID.ToString + ".dat", OpenMode.Random, , , Len(Order))


        LockItemFile(Setup.ResourceFolder, ItemControl)

        FileOpen(2, Setup.ResourceFolder + "\Item.dat", OpenMode.Random, , , Len(Item))
        While Not EOF(1)
            FileGet(1, Order, i + 1)
            FileGet(2, Item, Order.ItemID)
            dgvOrder.Rows.Add(Unpad(Item.Name), Order.Quantity, Order.DeliveryTime.ToShortTimeString)
            i = i + 1
        End While
        FileClose(1)
        FileClose(2)
        UnlockItemFile(Setup.ResourceFolder, ItemControl)

    End Sub


    Private Sub btnCreateReport_Click(sender As Object, e As EventArgs) Handles btnCreateReport.Click
        Dim WordApp As Word.Application
        Dim WordDoc As Word.Document
        Dim WordParagraph As Word.Paragraph
        Dim WordTable As Word.Table
        Dim y As Integer = dgvBookingResults.CurrentCellAddress.Y


        If Len(User.Name) = 0 Then
            MessageBox.Show("No valid bookings have been selected", "No Booking Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            WordApp = CreateObject("Word.Application")
            WordApp.Visible = False

            WordDoc = WordApp.Documents.Add
            WordParagraph = WordDoc.Content.Paragraphs.Add
            WordParagraph.Range.Bold = True
            WordParagraph.Range.Font.Size = 12

            WordParagraph.Range.Text = "Booking Report for " & dgvBookingResults.Item(0, y).Value & " on " & Booking.BookingDate.ToShortDateString & " at " & Booking.StartTime.ToShortTimeString
            WordParagraph.Format.SpaceAfter = 12
            WordParagraph.Range.InsertParagraphAfter()


            WordParagraph.Range.Font.Bold = False
            WordParagraph.Range.Text = "This booking was created by " & Unpad(User.Name)
            WordParagraph.Format.SpaceAfter = 3

            WordParagraph.Range.InsertParagraphAfter()
            WordParagraph.Range.Text = "Preferred Room Layout"
            WordParagraph.Range.Bold = True
            WordParagraph.Range.InsertParagraphAfter()
            WordParagraph.Range.Font.Bold = False
            If txtLayout.Text = "" Then
                WordParagraph.Range.Text = "The customer has not specified the room layout"
            Else
                WordParagraph.Range.Text = txtLayout.Text
            End If
            WordParagraph.Range.InsertParagraphAfter()
            WordParagraph.Range.Text = "Technical Support"
            WordParagraph.Range.Bold = True
            WordParagraph.Range.InsertParagraphAfter()
            WordParagraph.Range.Font.Bold = False
            If txtMicrophone.Text <> "" Then
                WordParagraph.Range.Text = "The customer has requested " & txtMicrophone.Text & " microphone/s "
                WordParagraph.Range.InsertParagraphAfter()
            End If

            If txtTechSupport.Text = "" Then
                WordParagraph.Range.Text = "The customer does not require any technical assistance"
            Else
                WordParagraph.Range.Text = txtTechSupport.Text
            End If
            WordParagraph.Range.InsertParagraphAfter()
            If dgvOrder.RowCount <> 0 Then
                WordParagraph.Range.Text = "Catering"
                WordParagraph.Range.Bold = True
                WordParagraph.Range.InsertParagraphAfter()
                WordParagraph.Range.Bold = False
                WordTable = WordDoc.Tables.Add(WordDoc.Bookmarks.Item("\endofdoc").Range, dgvOrder.RowCount + 1, 3)
                WordTable.Cell(1, 1).Range.Text = "Name"
                WordTable.Cell(1, 2).Range.Text = "Quantity"
                WordTable.Cell(1, 3).Range.Text = "Delivery Time"
                For i As Integer = 0 To dgvOrder.RowCount - 1
                    WordTable.Cell(i + 2, 1).Range.Text = dgvOrder.Item(0, i).Value
                    WordTable.Cell(i + 2, 2).Range.Text = dgvOrder.Item(1, i).Value
                    WordTable.Cell(i + 2, 3).Range.Text = dgvOrder.Item(2, i).Value
                Next
                WordTable.Rows.Item(1).Range.Bold = True
                WordTable.Borders.Enable = True
                WordTable.Borders.InsideColor = Word.WdColor.wdColorBlack
                If txtExtraRequest.Text <> "" Then
                    WordParagraph.Range.Bold = True
                    WordParagraph.Range.Text = "Extra Request"
                    WordParagraph.Range.InsertParagraphAfter()
                    WordParagraph.Range.Bold = False
                    WordParagraph.Range.Text = txtExtraRequest.Text
                    WordParagraph.Range.InsertParagraphAfter()
                End If
            End If
            WordApp.Visible = True

        End If

    End Sub


    Private Sub btnMonth_Click(sender As Object, e As EventArgs) Handles btnMonth.Click
        dgvBookingResults.Rows.Clear()
       LockBookingFile(Setup.ResourceFolder,BookingControl)

      
        FileOpen(1, Setup.ResourceFolder + "\Booking.dat", OpenMode.Random, , , Len(Booking))

        For i As Integer = 1 To BookingControl.Current
            FileGet(1, Booking, i)

            If Booking.BookingDate.Month = calBooking.SelectionEnd.Month Then 'if the 

                FileOpen(2, Setup.ResourceFolder + "\Room.dat", OpenMode.Random, , , Len(Room))
                FileGet(2, Room, Booking.RoomID)
                FileClose(2)
                FileOpen(2, Setup.ResourceFolder + "\Customer.dat", OpenMode.Random, , , Len(Customer))
                FileGet(2, Customer, Booking.CustomerID)
                FileClose(2)
                dgvBookingResults.Rows.Add(Unpad(Customer.Name), Unpad(Booking.Ref), Booking.StartTime.ToShortTimeString & "-" & Booking.EndTime.ToShortTimeString, Unpad(Room.Name), Booking.BookingID, Booking.BookingDate.ToShortDateString)

            End If

        Next

        FileClose(1)
        UnlockBookingFile(Setup.ResourceFolder,BookingControl)

    End Sub

    Private Sub btnYear_Click(sender As Object, e As EventArgs) Handles btnYear.Click
        dgvBookingResults.Rows.Clear()
       LockBookingFile(Setup.ResourceFolder,BookingControl)
       
        FileOpen(1, Setup.ResourceFolder + "\Booking.dat", OpenMode.Random, , , Len(Booking))

        For i As Integer = 1 To BookingControl.Current
            FileGet(1, Booking, i)

            If Booking.BookingDate.Year = calBooking.SelectionEnd.Year Then

                FileOpen(2, Setup.ResourceFolder + "\Room.dat", OpenMode.Random, , , Len(Room))
                FileGet(2, Room, Booking.RoomID)
                FileClose(2)
                FileOpen(2, Setup.ResourceFolder + "\Customer.dat", OpenMode.Random, , , Len(Customer))
                FileGet(2, Customer, Booking.CustomerID)
                FileClose(2)
                dgvBookingResults.Rows.Add(Unpad(Customer.Name), Unpad(Booking.Ref), Booking.StartTime.ToShortTimeString & "-" & Booking.EndTime.ToShortTimeString, Unpad(Room.Name), Booking.BookingID, Booking.BookingDate.ToShortDateString)

            End If

        Next

        FileClose(1)
        UnlockBookingFile(Setup.ResourceFolder,BookingControl)

    End Sub
End Class