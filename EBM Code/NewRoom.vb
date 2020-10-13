Public Class frmNewRoom
    Dim Setup As SystemSetupData
    Dim Room As RoomData
    Dim RoomControl As RoomControlData
    Private Sub frmNewRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup))
        FileGet(1, Setup, 1) 'retrieve system information
        FileClose(1)
        LockRoomFile(Setup.ResourceFolder, RoomControl)

        If RoomControl.Current = RoomControl.Max Then 'if the file has no more room 
            FileOpen(1, Setup.ResourceFolder + "\Room.dat", OpenMode.Random, , , Len(Room))
            FileOpen(2, Setup.ResourceFolder + "\NewRoom.dat", OpenMode.Random, , , Len(Room))
            'open the old Room file then create new Room file
            For i As Integer = 1 To RoomControl.Max
                FileGet(1, Room, i)
                FilePut(2, Room, i)
            Next
            'tranfer all of the Rooms into the new file
            With Room 'setup a blank record in order to pad out the rest of the file
                .Active = False
                .Details = Nothing
                .Name = Nothing
                .RoomID = Nothing
            End With
            For i As Integer = RoomControl.Max + 1 To (RoomControl.Max + 100) ' add an extra 100 records into the file
                FilePut(2, Room, i)
            Next
            FileClose(1) 'close both files
            FileClose(2)
            'rename the file and delete old file NOTE for now we shall not delete the file simply rename it

            My.Computer.FileSystem.DeleteFile(Setup.ResourceFolder + "\Room.dat")
            My.Computer.FileSystem.RenameFile(Setup.ResourceFolder + "\NewRoom.dat", "Room.dat")
            'rename file to User
            'update the  file with a new maximum number of records
            RoomControl.Max = RoomControl.Max + 100
            FileOpen(1, Setup.ResourceFolder + "\RoomControl.dat", OpenMode.Random, , , Len(RoomControl))
            FilePut(1, RoomControl, 1)
            FileClose(1)
        End If
        UnlockRoomFile(Setup.ResourceFolder, RoomControl)
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        If txtName.Text = "" Then
            MessageBox.Show("Please enter a room name", "Missing Room Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            With Room
                .RoomID = RoomControl.Current + 1
                .Active = True
                .Name = txtName.Text
                .Details = txtDetails.Text
            End With

            LockRoomFile(Setup.ResourceFolder, RoomControl)
            RoomControl.Current = RoomControl.Current + 1
            FileOpen(1, Setup.ResourceFolder + "\RoomControl.dat", OpenMode.Random, , , Len(RoomControl))
            FilePut(1, RoomControl, 1)
            FileClose(1)
            FileOpen(1, Setup.ResourceFolder + "\Room.dat", OpenMode.Random, , , Len(Room))
            FilePut(1, Room, RoomControl.Current)
            FileClose(1)
            UnlockRoomFile(Setup.ResourceFolder, RoomControl)
            Me.Close()
        End If
       

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class