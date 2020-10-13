Public Class frmManageRooms

    Dim Setup As SystemSetupData

    Dim Room As RoomData
    Dim RoomControl As RoomControlData
    Private Sub frmRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup))
        FileGet(1, Setup, 1) 'retrieve system information
        FileClose(1)
        LockRoomFile(Setup.ResourceFolder, RoomControl)
        If RoomControl.Current <> 0 Then
            FileOpen(1, Setup.ResourceFolder + "\Room.dat", OpenMode.Random, , , Len(Room))
            For i As Integer = 1 To RoomControl.Current
                FileGet(1, Room, i)
                lstRoom.Items.Add(Unpad(Room.Name))
            Next
            FileClose(1)
        End If
        UnlockRoomFile(Setup.ResourceFolder, RoomControl)

    End Sub



    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub



    Private Sub lstRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRoom.SelectedIndexChanged
        If lstRoom.SelectedIndex <> -1 Then
          
           LockRoomFile(Setup.ResourceFolder,RoomControl)
            FileOpen(1, Setup.ResourceFolder + "\RoomControl.dat", OpenMode.Random, , , Len(RoomControl))
            FilePut(1, RoomControl, 1) 'open control file and update the InUse field
            FileClose(1) ' close the control file
            FileOpen(1, Setup.ResourceFolder + "\Room.dat", OpenMode.Random, , , Len(Room))
            FileGet(1, Room, lstRoom.SelectedIndex + 1)
            FileClose(1)
                UnlockRoomFile(Setup.ResourceFolder, RoomControl)
            If Room.Active = False Then
                lblWarning.Visible = True
            Else : lblWarning.Visible = False
            End If
            txtName.Text = Unpad(Room.Name)
            txtDetails.Text = Unpad(Room.Details)

            If Room.Active = True Then
                cmbStatus.SelectedIndex = 0
            Else : cmbStatus.SelectedIndex = 1
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If lstRoom.SelectedIndex <> -1 Then
            Room.Details = txtDetails.Text
            Room.Name = txtName.Text

            If cmbStatus.SelectedIndex = 0 Then
                Room.Active = True
            Else : Room.Active = False
            End If
           
            LockRoomFile(Setup.ResourceFolder, RoomControl)
            FileOpen(1, Setup.ResourceFolder + "\RoomControl.dat", OpenMode.Random, , , Len(RoomControl))
            FilePut(1, RoomControl, 1) 'open control file and update the InUse field
            FileClose(1) ' close the control file
            FileOpen(1, Setup.ResourceFolder + "\Room.dat", OpenMode.Random, , , Len(Room))
            FilePut(1, Room, lstRoom.SelectedIndex + 1)
            lstRoom.Items.Clear() 'clear the list box
            For i As Integer = 1 To RoomControl.Current 'populate the list box with updated data
                FileGet(1, Room, i)
                lstRoom.Items.Add(Unpad(Room.Name))
            Next
            FileClose(1)
            UnlockRoomFile(Setup.ResourceFolder, RoomControl)
            MessageBox.Show("The Room information has been updated", "Room Information Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else : MessageBox.Show("Please Select a Room", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Private Sub btnAddNewRoom_Click(sender As Object, e As EventArgs) Handles btnNewRoom.Click
        Dim AddNewRoom As New frmNewRoom
        AddNewRoom.ShowDialog()
        lstRoom.Items.Clear()

     
       LockRoomFile(Setup.ResourceFolder,RoomControl)
        FileOpen(1, Setup.ResourceFolder + "\RoomControl.dat", OpenMode.Random, , , Len(RoomControl))
        FilePut(1, RoomControl, 1) 'open control file and update the InUse field
        FileClose(1) ' close the  file
        If RoomControl.Current <> 0 Then
            FileOpen(1, Setup.ResourceFolder + "\Room.dat", OpenMode.Random, , , Len(Room))
            For i As Integer = 1 To RoomControl.Current
                FileGet(1, Room, i)
                lstRoom.Items.Add(Unpad(Room.Name))
            Next
            FileClose(1)
        End If
        UnlockRoomFile(Setup.ResourceFolder, RoomControl)
    End Sub
End Class