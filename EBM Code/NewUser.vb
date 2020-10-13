Public Class frmNewUser
    Dim Setup As SystemSetupData
    Dim UserControl As UserControlData
    Dim User As UserData
    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup))
        FileGet(1, Setup, 1) 'retrieve setup information from setup file
        FileClose(1) 'close setup file


        LockUserFile(Setup.ResourceFolder, UserControl)

        If UserControl.Current = 0 Then 'if there are no current users
            nudAccess.Enabled = False 'enforce the creation of an admin account
            nudAccess.Value = 1

        End If


        If UserControl.Current = UserControl.Max Then 'if the file has no more room 

            FileOpen(1, Setup.ResourceFolder + "\User.dat", OpenMode.Random, , , Len(User))
            FileOpen(2, Setup.ResourceFolder + "\NewUser.dat", OpenMode.Random, , , Len(User))
            'open the old user file then create new user file
            For i As Integer = 1 To UserControl.Max
                FileGet(1, User, i)
                FilePut(2, User, i)
            Next
            'tranfer all of the users into the new file
            With User 'setup a blank record in order to pad out the rest of the file
                .Active = False
                .AccessLevel = Nothing
                .Name = Nothing
                .Password = Nothing
                .UserID = Nothing

            End With
            For i As Integer = UserControl.Max + 1 To (UserControl.Max + 100) ' add an extra 100 records into the file
                FilePut(2, User, i)
            Next
            FileClose(1) 'close both files
            FileClose(2)
            'rename the file and delete old file NOTE for now we shall not delete the file simply rename it

            My.Computer.FileSystem.DeleteFile(Setup.ResourceFolder + "\User.dat")
            My.Computer.FileSystem.RenameFile(Setup.ResourceFolder + "\NewUser.dat", "User.dat")
            'rename file to User
            'update the  file with a new maximum number of records
            UserControl.Max = UserControl.Max + 100
            FileOpen(1, Setup.ResourceFolder + "\UserControl.dat", OpenMode.Random, , , Len(UserControl))
            FilePut(1, UserControl, 1)
            FileClose(1)
        End If


        UnlockUserFile(Setup.ResourceFolder, UserControl)

    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        If Len(txtUsername.Text) < 5 Or Len(mtbPassword.Text) > 50 Then
            'if the username contains fewer than 5 characters or more than 50 characters then display an error message
            MessageBox.Show("The User Name should be between  5 and 50 characters long", "Invalid Username Lenght", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ((Len(mtbPassword.Text) < 5 Or Len(mtbPassword.Text) > 50 Or Len(mtbReenterPass.Text) < 5 Or Len(mtbReenterPass.Text) > 50)) Then
            'if the password has been entered and is less than 5 characters long or greater than 50 characters long then display an error message
            MessageBox.Show("The Password should be between  5 and 50 characters long", "Invalid Password Lenght", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf mtbPassword.Text <> mtbReenterPass.Text Then
            'if the password do not match then display an error message
            MessageBox.Show("The entered passwords do not match. Please try again", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'if everything is correct
        Else
            With User
                .AccessLevel = nudAccess.Value
                .Active = True
                .Name = txtUsername.Text
                .Password = mtbPassword.Text
                .UserID = UserControl.Current + 1
            End With

            LockUserFile(Setup.ResourceFolder, UserControl)
            UserControl.Current = UserControl.Current + 1
            FileOpen(1, Setup.ResourceFolder + "\UserControl.dat", OpenMode.Random, , , Len(UserControl))
            FilePut(1, UserControl, 1) 'open  file and update the InUse field
            FileClose(1) ' close the  file
            FileOpen(1, Setup.ResourceFolder + "\User.dat", OpenMode.Random, , , Len(User))
            FilePut(1, User, UserControl.Current) ' open the user f add new user
            FileClose(1) ' close file
            UnlockUserFile(Setup.ResourceFolder, UserControl) 'make the user file accesible to other users


            Me.Close()
        End If
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class