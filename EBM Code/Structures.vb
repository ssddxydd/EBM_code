Module Structures 'all of the structures within this module should probably be made local
    'Global variables
    <VBFixedString(50)> Public Name As String
    Public AccessLevel As Integer 'Current user's access level
    Public UserID As Integer 'the User ID of the current user
    ''DATA FILES   
    Structure SystemSetupData
        <VBFixedString(50)> Public CompanyName As String 'Name of the company using the system
        <VBFixedString(100)> Public ResourceFolder As String 'Filepath of the resource folder
    End Structure
    Structure UserData 'structure holding user data
        Dim UserID As Integer
        <VBFixedString(50)> Public Name As String 'name of the user
        <VBFixedString(50)> Public Password As String 'password of the user
        Dim AccessLevel As Integer
        Dim Active As Boolean
    End Structure
    Structure CustomerData
        Dim CustomerID As Integer
        <VBFixedString(50)> Public Name As String
        <VBFixedString(11)> Public Telephone As String
        <VBFixedString(11)> Public MobilePhone As String
        <VBFixedString(320)> Public Email As String
        <VBFixedString(50)> Public PostalAddress As String
        <VBFixedString(7)> Public PostCode As String
        <VBFixedString(50)> Public IName As String
        <VBFixedString(11)> Public ITelephone As String
        <VBFixedString(11)> Public IMobilePhone As String
        <VBFixedString(320)> Public IEmail As String
        <VBFixedString(50)> Public IPostalAddress As String
        <VBFixedString(7)> Public IPostCode As String
        Dim BookingPointer As Integer
        Dim Active As Boolean
    End Structure
    Structure RoomData
        Dim RoomID As Integer
        <VBFixedString(50)> Public Name As String
        <VBFixedString(100)> Public Details As String
        Dim Active As Boolean
    End Structure
    Structure CateringData
        Dim ItemID As Integer
        <VBFixedString(50)> Public Name As String
        Dim Price As Single
        Dim Active As Boolean
    End Structure
    Structure OrderData 'this file is also optional
        Dim ItemID As Integer
        Dim Quantity As Integer
        Dim DeliveryTime As Date
    End Structure
    Structure ExtraRequestData 'this file is optional
        <VBFixedString(1000)> Public Details As String 'Consider making this a local variable
    End Structure
    Structure RoomSetupData 'this file is generated every time a booking is made
        <VBFixedString(1000)> Public Layout As String
        Dim Microphones As Integer
        <VBFixedString(1000)> Public TechSupport As String
    End Structure
    Structure BookingData
        Dim BookingID As Integer
        Dim CustomerID As Integer
        Dim RoomID As Integer
        Dim UserID As Integer
        <VBFixedString(20)> Public Ref As String
        Dim BookingDate As Date
        Dim StartTime As Date
        Dim EndTime As Date
        <VBFixedString(200)> Public CustomerOrderFile As String
        <VBFixedString(200)> Public RoomLayoutFile As String
        <VBFixedString(200)> Public RequestFile As String
        Dim Active As Boolean
        Dim NextBooking As Integer
    End Structure

    ''CONTROL FILES
    Structure CustomerControlData
        Dim InUse As Boolean
        Dim Max As Integer
        Dim Current As Integer
    End Structure
    Structure RoomControlData
        Dim InUse As Boolean
        Dim Max As Integer
        Dim Current As Integer
    End Structure
    Structure BookingControlData
        Dim InUse As Boolean
        Dim Max As Integer
        Dim Current As Integer
    End Structure
    Structure CateringControlData
        Dim InUse As Boolean
        Dim Max As Integer
        Dim Current As Integer
    End Structure
    Structure UserControlData
        Dim InUse As Boolean
        Dim Max As Integer
        Dim Current As Integer
    End Structure
    Public Function Unpad(ByVal Word As String) As String
        Dim i, NewLenght As Integer
        Dim NewWord As String = ""
        i = Len(Word) - 1
        While i <> 0 And Word(i) = " "
            i = i - 1
        End While

        If i = 0 And Word(0) = " " Then
            NewWord = ""
        ElseIf i = 0 And Word(0) <> " " Then 'if the string only contains one character
            NewWord = Word(0)
        Else
            NewLenght = i
            For i = 0 To NewLenght
                NewWord = NewWord + Word(i)
            Next
        End If
        Return (NewWord)
    End Function
    Public Sub LockCustomerFile(ByVal ResourceFolder As String, ByRef Control As CustomerControlData)
        Do  'check if the file is being used by a different user
            Threading.Thread.Sleep(10) 'Sleep for 10 milliseconds
            FileOpen(3, ResourceFolder + "\CustomerControl.dat", OpenMode.Random, , , Len(Control)) 'Open control file
            FileGet(3, Control, 1) 'Retrieve control data
            FileClose(3) ' close the control file
        Loop Until Control.InUse = False
        Control.InUse = True
        FileOpen(3, ResourceFolder + "\CustomerControl.dat", OpenMode.Random, , , Len(Control)) 'Open control file
        FilePut(3, Control, 1) 'open control file and update the InUse field
        FileClose(3) ' close the control file
    End Sub
    Public Sub UnlockCustomerFile(ByVal ResourceFolder As String, ByRef Control As CustomerControlData)
        Control.InUse = False
        FileOpen(3, ResourceFolder + "\CustomerControl.dat", OpenMode.Random, , , Len(Control)) 'Open control file
        FilePut(3, Control, 1) 'open control file and update the InUse field
        FileClose(3) ' close the control file
    End Sub

    Public Sub LockBookingFile(ByVal ResourceFolder As String, ByRef Control As BookingControlData)
        Do  'check if the file is being used by a different user
            Threading.Thread.Sleep(10) 'Sleep for 10 milliseconds
            FileOpen(3, ResourceFolder + "\BookingControl.dat", OpenMode.Random, , , Len(Control)) 'Open control file
            FileGet(3, Control, 1) 'Retrieve control data
            FileClose(3) ' close the control file
        Loop Until Control.InUse = False
        Control.InUse = True
        FileOpen(3, ResourceFolder + "\BookingControl.dat", OpenMode.Random, , , Len(Control)) 'Open control file
        FilePut(3, Control, 1) 'open control file and update the InUse field
        FileClose(3) ' close the control file
    End Sub
    Public Sub UnlockBookingFile(ByVal ResourceFolder As String, ByRef Control As BookingControlData)
        Control.InUse = False
        FileOpen(3, ResourceFolder + "\BookingControl.dat", OpenMode.Random, , , Len(Control)) 'Open control file
        FilePut(3, Control, 1) 'open control file and update the InUse field
        FileClose(3) ' close the control file
    End Sub

    Public Sub LockUserFile(ByVal ResourceFolder As String, ByRef Control As UserControlData)
        Do  'check if the file is being used by a different user
            Threading.Thread.Sleep(10) 'Sleep for 10 milliseconds
            FileOpen(3, ResourceFolder + "\UserControl.dat", OpenMode.Random, , , Len(Control)) 'Open control file
            FileGet(3, Control, 1) 'Retrieve control data
            FileClose(3) ' close the control file
        Loop Until Control.InUse = False
        Control.InUse = True
        FileOpen(3, ResourceFolder + "\UserControl.dat", OpenMode.Random, , , Len(Control)) 'Open control file
        FilePut(3, Control, 1) 'open control file and update the InUse field
        FileClose(3) ' close the control file
    End Sub
    Public Sub UnlockUserFile(ByVal ResourceFolder As String, Control As UserControlData)
        Control.InUse = False
        FileOpen(3, ResourceFolder + "\UserControl.dat", OpenMode.Random, , , Len(Control)) 'Open control file
        FilePut(3, Control, 1) 'open control file and update the InUse field
        FileClose(3) ' close the control file
    End Sub

    Public Sub LockRoomFile(ByVal ResourceFolder As String, ByRef Control As RoomControlData)
        Do  'check if the file is being used by a different user
            Threading.Thread.Sleep(10) 'Sleep for 10 milliseconds
            FileOpen(3, ResourceFolder + "\RoomControl.dat", OpenMode.Random, , , Len(Control)) 'Open control file
            FileGet(3, Control, 1) 'Retrieve control data
            FileClose(3) ' close the control file
        Loop Until Control.InUse = False
        Control.InUse = True
        FileOpen(3, ResourceFolder + "\RoomControl.dat", OpenMode.Random, , , Len(Control)) 'Open control file
        FilePut(3, Control, 1) 'open control file and update the InUse field
        FileClose(3) ' close the control file
    End Sub
    Public Sub UnlockRoomFile(ByVal ResourceFolder As String, ByRef Control As RoomControlData)
        Control.InUse = False
        FileOpen(3, ResourceFolder + "\RoomControl.dat", OpenMode.Random, , , Len(Control)) 'Open control file
        FilePut(3, Control, 1) 'open control file and update the InUse field
        FileClose(3) ' close the control file
    End Sub

    Public Sub LockItemFile(ByVal ResourceFolder As String, ByRef Control As CateringControlData)
        Do  'check if the file is being used by a different user
            Threading.Thread.Sleep(10) 'Sleep for 10 milliseconds
            FileOpen(3, ResourceFolder + "\ItemControl.dat", OpenMode.Random, , , Len(Control)) 'Open control file
            FileGet(3, Control, 1) 'Retrieve control data
            FileClose(3) ' close the control file
        Loop Until Control.InUse = False
        Control.InUse = True
        FileOpen(3, ResourceFolder + "\ItemControl.dat", OpenMode.Random, , , Len(Control)) 'Open control file
        FilePut(3, Control, 1) 'open control file and update the InUse field
        FileClose(3) ' close the control file
    End Sub
    Public Sub UnlockItemFile(ByVal ResourceFolder As String, ByRef Control As CateringControlData)
        Control.InUse = False
        FileOpen(3, ResourceFolder + "\ItemControl.dat", OpenMode.Random, , , Len(Control)) 'Open control file
        FilePut(3, Control, 1) 'open control file and update the InUse field
        FileClose(3) ' close the control file
    End Sub

    Public Function CheckForClashes(ByVal BookingID As Integer, ByVal RoomID As Integer, ByVal BookingDate As Date, ByVal StartTime As Date, ByVal EndTime As Date,
                                    ByVal ResourceFolder As String, ByVal BookingControl As BookingControlData) As BookingData
        Dim i As Integer
        Dim Booking As BookingData = Nothing
        Dim NumberOfClashes As Integer = 0
        Dim ClashingBooking(20) As BookingData
        Dim Clash As Boolean = False
        LockBookingFile(ResourceFolder, BookingControl)
        'Retrieve booking information 
        FileOpen(1, ResourceFolder + "\Booking.dat", OpenMode.Random, , , Len(Booking))
        For i = 1 To BookingControl.Current 'For i = 1 to NumberOfBookings
            FileGet(1, Booking, i) 'Retrieve Booking Information from position i in the file
            'check for bookings taking place on the same day and in the same room 
            If Booking.RoomID = RoomID And Booking.BookingDate.ToShortDateString = BookingDate.ToShortDateString And Booking.Active = True And BookingID <> Booking.BookingID Then
                'If the Room ID =Current Room ID and the Booking date = Current Booking Date then
                NumberOfClashes = NumberOfClashes + 1
                ClashingBooking(NumberOfClashes - 1) = Booking
            End If
        Next
        FileClose(1) ' close the Booking file
        UnlockBookingFile(ResourceFolder, BookingControl)
        i = 0
        'Check if any of the times clash with each other 
        Do While NumberOfClashes <> 0 And (i <> NumberOfClashes) And Clash <> True
            'While( Number Of clashes) <>0 and (Clash <>True) and (i<>Number  of Clashes) do
            If (StartTime.TimeOfDay >= ClashingBooking(i).StartTime.TimeOfDay And StartTime.TimeOfDay < ClashingBooking(i).EndTime.TimeOfDay) Or
                (EndTime.TimeOfDay > ClashingBooking(i).StartTime.TimeOfDay And EndTime.TimeOfDay <= ClashingBooking(i).EndTime.TimeOfDay) Or
                 (StartTime.TimeOfDay <= ClashingBooking(i).StartTime.TimeOfDay And EndTime.TimeOfDay >= ClashingBooking(i).EndTime.TimeOfDay) Then
                'If the time period for ClashingBooking(i) lies within that of the Current Booking 	
                Clash = True
            End If
            i = i + 1
        Loop
        Booking = Nothing
        Booking.BookingID = 0
        If Clash = True Then
            Return ClashingBooking(i - 1)
        Else
            Return Booking 'return empty booking
        End If
    End Function
End Module
