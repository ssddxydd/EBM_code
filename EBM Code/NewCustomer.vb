Public Class frmNewCustomer

    Dim Setup As SystemSetupData
    Dim Customer As CustomerData
    Dim CustomerControl As CustomerControlData
    Private Sub frmNewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup))
        FileGet(1, Setup, 1) 'retrieve system information
        FileClose(1)
        LockCustomerFile(Setup.ResourceFolder, CustomerControl)


        If CustomerControl.Current = CustomerControl.Max Then 'if the file has no more Customer 
            FileOpen(1, Setup.ResourceFolder + "\Customer.dat", OpenMode.Random, , , Len(Customer))
            FileOpen(2, Setup.ResourceFolder + "\NewCustomer.dat", OpenMode.Random, , , Len(Customer))
            'open the old Customer file then create new Customer file
            For i As Integer = 1 To CustomerControl.Max
                FileGet(1, Customer, i)
                FilePut(2, Customer, i)
            Next
            'tranfer all of the Customers into the new file
            With Customer 'setup a blank record in order to pad out the rest of the file
                With Customer 'transfer data from the text boxes into the customer variable
                    .Name = Nothing
                    .Telephone = Nothing
                    .MobilePhone = Nothing
                    .PostalAddress = Nothing
                    .PostCode = Nothing
                    .Email = Nothing
                    .Active = False
                    .IName = Nothing
                    .ITelephone = Nothing
                    .IMobilePhone = Nothing
                    .IPostalAddress = Nothing
                    .IPostCode = Nothing
                    .BookingPointer = Nothing
                    .CustomerID = Nothing
                    .IEmail = Nothing
                End With
            End With
            For i As Integer = CustomerControl.Max + 1 To (CustomerControl.Max + 100) ' add an extra 100 records into the file
                FilePut(2, Customer, i)
            Next
            FileClose(1) 'close both files
            FileClose(2)
            'rename the file and delete old file NOTE for now we shall not delete the file simply rename it

            My.Computer.FileSystem.DeleteFile(Setup.ResourceFolder + "\Customer.dat")
            My.Computer.FileSystem.RenameFile(Setup.ResourceFolder + "\NewCustomer.dat", "Customer.dat")
            'rename file to User
            'update the  file with a new maximum number of records
            CustomerControl.Max = CustomerControl.Max + 100
            FileOpen(1, Setup.ResourceFolder + "\CustomerControl.dat", OpenMode.Random, , , Len(CustomerControl))
            FilePut(1, CustomerControl, 1)
            FileClose(1)
        End If
        UnlockCustomerFile(Setup.ResourceFolder, CustomerControl)
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        If txtName.Text = "" Then
            MessageBox.Show("Please enter a Customer name", "Missing Customer Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            With Customer
                .Name = txtName.Text
                .Telephone = txtTelephone.Text
                .MobilePhone = txtMobile.Text
                .PostalAddress = txtAddress.Text
                .PostCode = txtPostcode.Text
                .Email = txtEmail.Text
                .Active = True
                .IName = txtInvoiceName.Text
                .ITelephone = txtInvoiceTelephone.Text
                .IMobilePhone = txtInvoiceMobile.Text
                .IPostalAddress = txtInvoiceAddress.Text
                .IPostCode = txtInvoicePostcode.Text
                .BookingPointer = 0
                .CustomerID = CustomerControl.Current + 1
                .IEmail = txtInvoiceEmail.Text
            End With

            LockCustomerFile(Setup.ResourceFolder, CustomerControl)
            CustomerControl.Current = CustomerControl.Current + 1
            FileOpen(1, Setup.ResourceFolder + "\CustomerControl.dat", OpenMode.Random, , , Len(CustomerControl))
            FilePut(1, CustomerControl, 1)
            FileClose(1)
            FileOpen(1, Setup.ResourceFolder + "\Customer.dat", OpenMode.Random, , , Len(Customer))
            FilePut(1, Customer, CustomerControl.Current)
            FileClose(1)
            UnlockCustomerFile(Setup.ResourceFolder, CustomerControl)

            Me.Close()
        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class