Public Class frmLogin
    Dim Setup As SystemSetupData
    Dim UserControl As UserControlData
    Dim User As UserData
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SetupForm As New frmSetup
        If Not (My.Computer.FileSystem.FileExists("Setup.dat")) Then
            SetupForm.ShowDialog()
        End If
        FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup)) 'Retrieve System information
        FileGet(1, Setup, 1)
        FileClose(1)
        While Unpad(Setup.ResourceFolder) = "*" 'makes sure that the user cannot gain access to the login form until the setup file has been created succesfully 
            MessageBox.Show("Missing resource folder location. Please setup the system with the correct resource folder location", "Missing Resourcce Folder", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SetupForm.ShowDialog()
            FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup))
            FileGet(1, Setup, 1)
            FileClose(1)
        End While

    End Sub
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim MenuForm As New frmMenu
        Dim Found As Boolean = False
        Dim i As Integer = 1
        FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup))
        FileGet(1, Setup, 1)
        FileClose(1)
        If txtUserName.Text = "" Then
            MessageBox.Show("The User Name has not been entered. Please enter a User Name", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf mtbPassword.Text = "" Then
            MessageBox.Show("The Password has not been entered. Please enter a Password", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else 'if everything has been filled in
            LockUserFile(Setup.ResourceFolder, UserControl)
            FileOpen(1, Setup.ResourceFolder + "\User.dat", OpenMode.Random, , , Len(User))
            'open user file
            While Found = False And i <= UserControl.Current
                'while user not found And i <= Total number of users 
                FileGet(1, User, i) 'Retrieve each user from the file from at position i in the user file
                If Unpad(User.Name) <> txtUserName.Text Or Unpad(User.Password) <> mtbPassword.Text Then
                    Found = False 'User not found
                ElseIf User.Active = True Then 'else if the username and password do not match the input data
                    Found = True 'User found
                    AccessLevel = User.AccessLevel 'Set Access level = User.AccessLevel
                    UserID = User.UserID 'Set UserID = User.UserID
                End If
                i = i + 1
            End While
            FileClose(1) 'close User file
            UnlockUserFile(Setup.ResourceFolder, UserControl)
            If Found = True Then 'if a match has been found 
                'Set reset text box values to default
                txtUserName.Text = ""
                mtbPassword.Text = ""
                Me.Hide() 'hide the log-in form 
                MenuForm.ShowDialog() ' show the menu form
            Else 'if user not found 
                'Display Error Message telling the User to try again
                MessageBox.Show("Invalid Log-in credentials. Please try again", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub


End Class
