Public Class frmManageUsers
    Dim Setup As SystemSetupData
    Dim User As UserData
    Dim UserControl As UserControlData
    Private Sub frmManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup))
        FileGet(1, Setup, 1) 'retrieve system information
        FileClose(1)
        LockUserFile(Setup.ResourceFolder, UserControl)
        If UserControl.Current <> 0 Then
            FileOpen(1, Setup.ResourceFolder + "\User.dat", OpenMode.Random, , , Len(User))
            For i As Integer = 1 To UserControl.Current
                FileGet(1, User, i)
                lstUser.Items.Add(Unpad(User.Name))
            Next
            FileClose(1)
        End If
        UnlockUserFile(Setup.ResourceFolder, UserControl)
    End Sub
    Private Sub lstUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUser.SelectedIndexChanged
        If lstUser.SelectedIndex <> -1 Then

          
            LockUserFile(Setup.ResourceFolder,UserControl)
         
            FileOpen(1, Setup.ResourceFolder + "\User.dat", OpenMode.Random, , , Len(User))
            FileGet(1, User, lstUser.SelectedIndex + 1)
            FileClose(1)
            UnlockUserFile(Setup.ResourceFolder, UserControl)
          
            If User.Active = False Then
                lblWarning.Visible = True
            Else : lblWarning.Visible = False
            End If
            With User
                nudAccess.Value = .AccessLevel
                txtUsername.Text = Unpad(.Name)

            End With
            If User.Active = True Then
                cmbStatus.SelectedIndex = 0
            Else : cmbStatus.SelectedIndex = 1
            End If
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Len(txtUsername.Text) < 5 Or Len(mtbPassword.Text) > 50 Then
            'if the username contains fewer than 5 characters or more than 50 characters then display an error message
            MessageBox.Show("The User Name should be between  5 and 50 characters long", "Invalid Username Lenght", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ((Len(mtbPassword.Text) < 5 Or Len(mtbPassword.Text) > 50 Or Len(mtbReenterPass.Text) < 5 Or Len(mtbReenterPass.Text) > 50)) And Len(mtbPassword.Text) <> 0 Then
            'if the password has been entered and is less than 5 characters long or greater than 50 characters long then display an error message
            MessageBox.Show("The Password should be between  5 and 50 characters long", "Invalid Password Lenght", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf mtbPassword.Text <> mtbReenterPass.Text Then
            'if the password do not match then display an error message
            MessageBox.Show("The entered passwords do not match. Please try again", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf lstUser.SelectedIndex <> -1 Then
            'if a user has actually been selected then transfer data entered into the form into the user file
            With User
                .Name = txtUsername.Text
                .AccessLevel = nudAccess.Value
                If cmbStatus.SelectedIndex = 0 Then
                    .Active = True
                Else : .Active = False
                End If
                If Len(mtbPassword.Text) <> 0 Then
                    .Password = mtbPassword.Text
                End If
            End With


            LockUserFile(Setup.ResourceFolder, UserControl)

            FileOpen(1, Setup.ResourceFolder + "\User.dat", OpenMode.Random, , , Len(User))
            FilePut(1, User, lstUser.SelectedIndex + 1)
            lstUser.Items.Clear() 'Clear the items from the list box
            For i As Integer = 1 To UserControl.Current
                FileGet(1, User, i)
                lstUser.Items.Add(Unpad(User.Name))
            Next
            FileClose(1)
            UnlockUserFile(Setup.ResourceFolder, UserControl)

            txtUsername.Text = ""
            mtbPassword.Text = ""
            mtbReenterPass.Text = ""
            nudAccess.Value = 1
            MessageBox.Show("The User information has been updated", "User Information Updated", MessageBoxButtons.OK, MessageBoxIcon.Information
                            )

        Else : MessageBox.Show("Please Select a User", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnAddNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        Dim AddNewUser As New frmNewUser
        AddNewUser.ShowDialog() ' display the Add New User Form
        lstUser.Items.Clear() 'Clear the items from the combo box

      
        LockUserFile(Setup.ResourceFolder,UserControl)
        
        If UserControl.Current <> 0 Then ' the current number of users in the file is not 0 then
            FileOpen(1, Setup.ResourceFolder + "\User.dat", OpenMode.Random, , , Len(User))
            For i As Integer = 1 To UserControl.Current 'populate the user combo box with the names of the users
                FileGet(1, User, i)
                lstUser.Items.Add(Unpad(User.Name))
            Next
            FileClose(1)
        End If
        UnlockUserFile(Setup.ResourceFolder, UserControl)
      
    End Sub
End Class