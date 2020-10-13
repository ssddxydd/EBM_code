Public Class frmManageCustomers
    Dim Setup As SystemSetupData
    Dim Customer As CustomerData
    Dim CustomerControl As CustomerControlData
    Private Sub frmManageCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup))
        FileGet(1, Setup, 1) 'retrieve system information
        FileClose(1)
        FileOpen(1, Setup.ResourceFolder + "\CustomerControl.dat", OpenMode.Random, , , Len(CustomerControl))
        FileGet(1, CustomerControl, 1) 'open control file and retrieve the InUse field
        FileClose(1) ' close the control file

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

    End Sub



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close() 'closes the form
    End Sub



    Private Sub lstCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustomer.SelectedIndexChanged
        If lstCustomer.SelectedIndex <> -1 Then

            LockCustomerFile(Setup.ResourceFolder, CustomerControl)
            FileOpen(1, Setup.ResourceFolder + "\Customer.dat", OpenMode.Random, , , Len(Customer))
            FileGet(1, Customer, lstCustomer.SelectedIndex + 1)
            FileClose(1)
            UnlockCustomerFile(Setup.ResourceFolder, CustomerControl)
            If Customer.Active = False Then
                lblWarning.Visible = True
            Else : lblWarning.Visible = False
            End If
            With Customer
                txtName.Text = Unpad(.Name)
                txtTelephone.Text = Unpad(.Telephone)
                txtMobile.Text = Unpad(.MobilePhone)
                txtAddress.Text = Unpad(.PostalAddress)
                txtPostcode.Text = Unpad(.PostCode)
                txtEmail.Text = Unpad(.Email)
                txtInvoiceName.Text = Unpad(.IName)
                txtInvoiceTelephone.Text = Unpad(.ITelephone)
                txtInvoiceMobile.Text = Unpad(.IMobilePhone)
                txtInvoiceAddress.Text = Unpad(.IPostalAddress)
                txtInvoicePostcode.Text = Unpad(.IPostCode)
                txtInvoiceEmail.Text = Unpad(.IEmail)
            End With


            If Customer.Active = True Then
                cmbStatus.SelectedIndex = 0
            Else : cmbStatus.SelectedIndex = 1
            End If
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If lstCustomer.SelectedIndex <> -1 Then
            With Customer
                .Name = txtName.Text
                .Telephone = txtTelephone.Text
                .MobilePhone = txtMobile.Text
                .PostalAddress = txtAddress.Text
                .PostCode = txtPostcode.Text
                .Email = txtEmail.Text
                If cmbStatus.SelectedIndex = 0 Then
                    .Active = True
                Else : .Active = False
                End If
                .IName = txtInvoiceName.Text
                .ITelephone = txtInvoiceTelephone.Text
                .IMobilePhone = txtInvoiceMobile.Text
                .IPostalAddress = txtInvoiceAddress.Text
                .IPostCode = txtInvoicePostcode.Text
                .IEmail = txtInvoiceEmail.Text
            End With

            LockCustomerFile(Setup.ResourceFolder, CustomerControl)
            FileOpen(1, Setup.ResourceFolder + "\Customer.dat", OpenMode.Random, , , Len(Customer))
            FilePut(1, Customer, lstCustomer.SelectedIndex + 1)
            lstCustomer.Items.Clear() 'clear the list box
            For i As Integer = 1 To CustomerControl.Current 'populate the lsit box with updated data
                FileGet(1, Customer, i)
                lstCustomer.Items.Add(Unpad(Customer.Name))
            Next
            FileClose(1)
            UnlockCustomerFile(Setup.ResourceFolder, CustomerControl)
            MessageBox.Show("The Customer information has been updated", "Customer Information Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
         
        Else : MessageBox.Show("Please Select a Customer", "No Customer selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnAddNewCustomer_Click(sender As Object, e As EventArgs) Handles btnAddNewCustomer.Click
        Dim AddNewCustomer As New frmNewCustomer
        AddNewCustomer.ShowDialog()
        lstCustomer.Items.Clear()

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
    End Sub
End Class