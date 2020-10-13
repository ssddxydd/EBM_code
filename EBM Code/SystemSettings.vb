Public Class frmSystemSettings
    Dim Setup As SystemSetupData 'Setup.dat
    Dim Booking As BookingData
    Dim BookingControl As BookingControlData
    Dim Room As RoomData
    Dim RoomControl As RoomControlData
    Dim Customer As CustomerData
    Dim CustomerControl As CustomerControlData
    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click
        Dim ManageUsersForm As New frmManageUsers
        ManageUsersForm.ShowDialog()
    End Sub

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        Dim SetupForm As New frmSetup
        SetupForm.ShowDialog()
    End Sub



    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim Result As Integer = MessageBox.Show("It is advisable that the system data is backed up before performing a system reset." + vbCrLf + "Would you like to perform a system reset?", "System Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
        Dim SetupForm As New frmSetup
        If Result = DialogResult.Yes Then
            FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup))
            Setup.ResourceFolder = "*"
            FilePut(1, Setup, 1)
            FileClose(1)

            My.Computer.FileSystem.DeleteDirectory(Setup.ResourceFolder, FileIO.DeleteDirectoryOption.DeleteAllContents)

            Do
                FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup))
                FileGet(1, Setup, 1)
                FileClose(1)
                SetupForm.ShowDialog()
            Loop Until Setup.ResourceFolder <> "*"

        End If

    End Sub

    Private Sub frmSystemSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CustomerID As Integer = -1 'the ID of the customer with the highest number of booking in the cusrrent month 
        Dim NoOfBookings As Integer = 0 'the number of bookings made within the current month 
        Dim RoomID As Integer = -1 ' the ID of the most frequently used room in the current month 

        Dim HighestNoB As Integer = -1 'Highest Number of Bookings
        Dim HighestNoRU As Integer = -1 'Highest Number of Room Uses
        Dim i As Integer ' counter variable
        FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup))
        FileGet(1, Setup, 1) 'retrieve system information
        FileClose(1)
        FileOpen(1, Setup.ResourceFolder + "\RoomControl.dat", OpenMode.Random, , , Len(RoomControl))
        FileGet(1, RoomControl, 1)
        FileClose(1) ' close the  file


        LockBookingFile(Setup.ResourceFolder, BookingControl)


        FileOpen(1, Setup.ResourceFolder + "\CustomerControl.dat", OpenMode.Random, , , Len(CustomerControl))
        FileGet(1, CustomerControl, 1) 'open control file 
        FileClose(1) ' close the  file

        Dim CustomerArray(CustomerControl.Current) As Integer
        Dim RoomArray(RoomControl.Current) As Integer
        FileOpen(1, Setup.ResourceFolder + "\Booking.dat", OpenMode.Random, , , Len(Booking))

        For i = 1 To BookingControl.Current
            FileGet(1, Booking, i)
            If Booking.BookingDate.Month = Date.Now.Month And Booking.BookingDate.Year = Date.Now.Year Then
                'if the booking has occured whithin the current month
                'then record the customer who made the booking and the room in which it takes place 
                CustomerArray(Booking.CustomerID - 1) = CustomerArray(Booking.CustomerID - 1) + 1 'add 1 to the number of bookings created by a particular customer this month 
                RoomArray(Booking.RoomID - 1) = RoomArray(Booking.RoomID - 1) + 1 'add 1 to the number of times a particular room was used this month
                NoOfBookings = NoOfBookings + 1 'add 1 to the total number of bookings this month

            End If

        Next 'repeat until all of the bookings in the file have been checked
        FileClose(1)
        UnlockBookingFile(Setup.ResourceFolder, BookingControl)

        For i = 0 To CustomerControl.Current - 1 'code which tries to find the customer with the highest number of bookings in this month
            If CustomerArray(i) > HighestNoB Then 'if the number bookings is higher than the previous highest number of bookings 
                CustomerID = i + 1 'then set the CustomerID variable to equal i+1 which is the actual ID of a customer
                HighestNoB = CustomerArray(i) 'set the new highest number of bookings 

            End If

        Next

        For i = 0 To RoomControl.Current - 1 'code which tries to find the most frequently used room in the current month 
            If RoomArray(i) > HighestNoRU Then 'if the number bookings which used the room is higher than the previous highest number of bookings 
                RoomID = i + 1 'then set the RoomID variable to equal i+1 which is the actual ID of a room
                HighestNoRU = RoomArray(i) 'set the new highest number of room uses
            End If
        Next 'repeat until all bookings have been checked

        If NoOfBookings <> 0 Then
            LockCustomerFile(Setup.ResourceFolder, CustomerControl)
            FileOpen(1, Setup.ResourceFolder + "\Customer.dat", OpenMode.Random, , , Len(Customer))
            FileGet(1, Customer, CustomerID) 'get the Name of the customer 
            FileClose(1)
            UnlockCustomerFile(Setup.ResourceFolder, CustomerControl)



            LockRoomFile(Setup.ResourceFolder, RoomControl)

            FileOpen(1, Setup.ResourceFolder + "\Room.dat", OpenMode.Random, , , Len(Room))
            FileGet(1, Room, RoomID) ' get the name of the most frequently used room
            FileClose(1)
            UnlockRoomFile(Setup.ResourceFolder, RoomControl)
        Else
            lblCustomer.Text = "There have been no bookings this month"
            lblNoOfBookings.Text = ""
            lblRoom.Text = ""
        End If
        If HighestNoB = 1 Then
            lblCustomer.Text = "All customers have only had one booking"
            lblNoOfBookings.Text = "The number of bookings made this month is : " & NoOfBookings
        ElseIf HighestNoB > 1 Then
            lblCustomer.Text = "The most frequent customer is " & Customer.Name & " with " & HighestNoB & " bookings this month"
            lblNoOfBookings.Text = "The number of bookings made this month is : " & NoOfBookings
        End If
        If HighestNoRU = 1 Then
            lblRoom.Text = "All rooms have been used once this month"
        ElseIf HighestNoRU > 1 Then
            lblRoom.Text = "The most popular this month room is " & Room.Name
        End If


    End Sub

    Private Sub btnBackUp_Click(sender As Object, e As EventArgs) Handles btnBackUp.Click
        Dim Filepath As String
        fbdBackup.ShowDialog()
        If fbdBackup.SelectedPath <> "" Then
            Filepath = fbdBackup.SelectedPath & "\BackUp  " & Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year & "\Room Hire System\"
            My.Computer.FileSystem.CreateDirectory(Filepath)
            My.Computer.FileSystem.CopyDirectory(Setup.ResourceFolder, Filepath)
            MessageBox.Show("Back-up successful", "System Back-up has been created", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else : MessageBox.Show("Back-up failed", "No location has been chosen", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class