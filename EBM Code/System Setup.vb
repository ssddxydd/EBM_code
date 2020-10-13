Public Class frmSetup
    Dim Setup As SystemSetupData 'Setup.dat
    Dim Customer As CustomerData 'Customer.dat
    Dim User As UserData 'User.dat
    Dim Room As RoomData 'Room.dat
    Dim Catering As CateringData 'Item.dat
    Dim Booking As BookingData 'Booking.dat
    Dim CustomerControl As CustomerControlData
    Dim RoomControl As RoomControlData
    Dim BookingControl As BookingControlData
    Dim UserControl As UserControlData
    Dim ItemControl As CateringControlData 'ItemControl.dat

    Private Sub frmSystem_Setup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Computer.FileSystem.FileExists("Setup.dat") Then
            FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup))
            Setup.CompanyName = "*"
            Setup.ResourceFolder = "*" 'set a blank resource folder location
            FilePut(1, Setup, 1) 'update the setup file
            FileClose(1)
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        fbdResource.ShowDialog()
        txtResourceFolder.Text = fbdResource.SelectedPath
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Dim Filepath As String
        Dim i As Integer
        Dim AddUser As New frmNewUser
        If txtCompanyName.Text = "" Then 'if company name is blank then warn user
            MessageBox.Show("Please enter the company name", "Missing company name", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtResourceFolder.Text = "" Then ' if recourcefolder location is blank warn user
            MessageBox.Show("Please enter the filepath of the resource folder", "Missing filepath", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbSetupType.SelectedIndex = -1 Then 'if setup type is not chosen then warn user 
            MessageBox.Show("Please select the setup type", "Missing setup type", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not My.Computer.FileSystem.DirectoryExists(txtResourceFolder.Text) Then
            MessageBox.Show("Resource folder location does not exist. Please try again", "Invalid Pathname", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else 'else everything is completed 


            Setup.CompanyName = txtCompanyName.Text 'update the new setup file with the comapny name
            Setup.ResourceFolder = txtResourceFolder.Text ' and the resource folder location   
            If cmbSetupType.SelectedIndex = 1 Then ' check if the system setup option has been chosen
                'if this is the case then create a new folder to hold all of the files
                ' create the files
                Filepath = Setup.ResourceFolder + "\Room Hire System" 'create the resource folder path 
                My.Computer.FileSystem.CreateDirectory(Filepath) ' create resource system folder
                My.Computer.FileSystem.CreateDirectory(Filepath + "\BookingInformation") 'create Booking Information folder
                Setup.ResourceFolder = Filepath
                FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup))
                FilePut(1, Setup, 1) 'udate the setup form with the resource folder location and the company name
                FileClose(1)
                If Not My.Computer.FileSystem.FileExists(Filepath + "\User.dat") Then ' if the User file does not exist then proceed in creating all of the files
                    FileOpen(1, Filepath + "\Booking.dat", OpenMode.Random, , , Len(Booking))
                    With Booking
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
                    For i = 1 To 50
                        FilePut(1, Booking, i)
                    Next
                    FileClose(1)
                    FileOpen(1, Filepath + "\BookingControl.dat", OpenMode.Random, , , Len(BookingControl))
                    With BookingControl
                        .Current = 0
                        .InUse = False
                        .Max = 50
                    End With
                    FilePut(1, BookingControl, 1)
                    FileClose(1)

                    FileOpen(1, Filepath + "\Customer.dat", OpenMode.Random, , , Len(Customer)) 'new file Customer.dat
                    With Customer
                        .Active = False
                        .BookingPointer = Nothing
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
                    For i = 1 To 50
                        FilePut(1, Customer, i)
                    Next
                    FileClose(1)
                    FileOpen(1, Filepath + "\CustomerControl.dat", OpenMode.Random, , , Len(CustomerControl))
                    With CustomerControl
                        .Current = 0
                        .InUse = False
                        .Max = 50
                    End With
                    FilePut(1, CustomerControl, 1)
                    FileClose(1)

                    FileOpen(1, Filepath + "\User.dat", OpenMode.Random, , , Len(User)) 'new file User.dat
                    With User
                        .Active = False
                        .AccessLevel = Nothing
                        .Name = Nothing
                        .Password = Nothing
                        .UserID = Nothing

                    End With
                    For i = 1 To 50
                        FilePut(1, User, i)
                    Next
                    FileClose(1)
                    FileOpen(1, Filepath + "\UserControl.dat", OpenMode.Random, , , Len(UserControl))
                    With UserControl
                        .Current = 0
                        .InUse = False
                        .Max = 50
                    End With
                    FilePut(1, UserControl, 1)
                    FileClose(1)

                    FileOpen(1, Filepath + "\Room.dat", OpenMode.Random, , , Len(Room)) 'new file Room.dat
                    With Room
                        .Active = False
                        .Details = Nothing
                        .Name = Nothing
                        .RoomID = Nothing

                    End With
                    For i = 1 To 50
                        FilePut(1, Room, i)
                    Next
                    FileClose(1)
                    FileOpen(1, Filepath + "\RoomControl.dat", OpenMode.Random, , , Len(RoomControl))
                    With RoomControl
                        .Current = 0
                        .InUse = False
                        .Max = 50
                    End With
                    FilePut(1, RoomControl, 1)
                    FileClose(1)

                    FileOpen(1, Filepath + "\Item.dat", OpenMode.Random, , , Len(Room)) 'new Catering Room.dat
                    With Catering
                        .Active = False
                        .ItemID = Nothing
                        .Name = Nothing
                        .Price = Nothing

                    End With
                    For i = 1 To 50
                        FilePut(1, Catering, i)
                    Next
                    FileClose(1)
                    FileOpen(1, Filepath + "\ItemControl.dat", OpenMode.Random, , , Len(ItemControl))
                    With ItemControl
                        .Current = 0
                        .InUse = False
                        .Max = 50
                    End With
                    FilePut(1, ItemControl, 1)
                    FileClose(1)

                    'Show the Add new User form
                    AddUser.ShowDialog()
                    FileOpen(1, Filepath + "\UserControl.dat", OpenMode.Random, , , Len(UserControl))
                    FileGet(1, UserControl, 1)
                    FileClose(1)

                    While UserControl.Current = 0 'if there are no users then loop until the administrator adds one
                        AddUser.ShowDialog()
                        FileOpen(1, Filepath + "\UserControl.dat", OpenMode.Random, , , Len(UserControl))
                        FileGet(1, UserControl, 1)
                        FileClose(1)
                    End While
                    Me.Close() ' close the form if the system setup is completed

                ElseIf My.Computer.FileSystem.FileExists(Filepath + "\User.dat") Then 'tell the user that the system has already been setup
                    'this could still be fixed by changing the resourcce folder location in the setup file
                    MessageBox.Show("The system has already been setup. Please choose the user setup and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If




            ElseIf cmbSetupType.SelectedIndex = 0 Then 'if the user setup type is chosen

                If Not My.Computer.FileSystem.FileExists(Setup.ResourceFolder & "\User.dat") Then
                    MessageBox.Show("Please change the resource folder location", "Invalid Resource folder location", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else 'else if the system files do exist
                    FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup))
                    FilePut(1, Setup, 1) 'update setup files with the location of the resource folder and the company name
                    FileClose(1)
                    Me.Close() 'close the form if the user setup is completed
                End If
                '
            End If 'end of if statement which deals with the user and system setup


        End If'end of if statement which validates user input

    End Sub
End Class