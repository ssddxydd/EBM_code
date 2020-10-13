Public Class frmNewItem
    Dim Setup As SystemSetupData
    Dim Item As CateringData
    Dim ItemControl As CateringControlData
    Private Sub frmNewItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup))
        FileGet(1, Setup, 1) 'retrieve system information
        FileClose(1)
        LockItemFile(Setup.ResourceFolder, ItemControl)
        If ItemControl.Current = ItemControl.Max Then 'if the file has no more Item 
            FileOpen(1, Setup.ResourceFolder + "\Item.dat", OpenMode.Random, , , Len(Item))
            FileOpen(2, Setup.ResourceFolder + "\NewItem.dat", OpenMode.Random, , , Len(Item)) 'create a new file
            'open the old Item file then create new Item file
            For i As Integer = 1 To ItemControl.Max
                FileGet(1, Item, i)
                FilePut(2, Item, i)
            Next
            'tranfer all of the Items into the new file
            With Item 'setup a blank record in order to pad out the rest of the file
                .Active = False
                .Price = Nothing
                .Name = Nothing
                .ItemID = Nothing
            End With
            For i As Integer = ItemControl.Max + 1 To (ItemControl.Max + 100) ' add an extra 100 records into the file
                FilePut(2, Item, i)
            Next
            FileClose(1) 'close both files
            FileClose(2)
            'rename the file and delete old file NOTE for now we shall not delete the file simply rename it

            My.Computer.FileSystem.DeleteFile(Setup.ResourceFolder + "\Item.dat")
            My.Computer.FileSystem.RenameFile(Setup.ResourceFolder + "\NewItem.dat", "Item.dat")
            'rename the temporary file 
            'add extra records to the new file
            ItemControl.Max = ItemControl.Max + 100 'add 100 extra records
            FileOpen(1, Setup.ResourceFolder + "\ItemControl.dat", OpenMode.Random, , , Len(ItemControl))
            FilePut(1, ItemControl, 1)
            FileClose(1)
        End If
        UnlockItemFile(Setup.ResourceFolder, ItemControl)
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click

        If txtName.Text = "" Then 'if the name of the item has not been entered
            MessageBox.Show("Please enter an item name", "Missing Item Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtPrice.Text = "" Then ' if the orice of the item has not been entered 
            MessageBox.Show("Please enter a price", "Missing Item Price", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsNumeric(txtPrice.Text) Then 'if the price is not a valid number
            MessageBox.Show("Please enter a valid price", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else 'else add the new item
            With Item
                .ItemID = ItemControl.Current + 1 'create a new item ID
                .Active = True 'set active to true
                .Name = txtName.Text 'set the name
                .Price = txtPrice.Text 'and price of the item
            End With

            LockItemFile(Setup.ResourceFolder, ItemControl)
            ItemControl.Current = ItemControl.Current + 1 'increment the current number of items withing the file
            FileOpen(1, Setup.ResourceFolder + "\ItemControl.dat", OpenMode.Random, , , Len(ItemControl))
            FilePut(1, ItemControl, 1) 'update the control file with a new number of items
            FileClose(1)
            FileOpen(1, Setup.ResourceFolder + "\Item.dat", OpenMode.Random, , , Len(Item))
            FilePut(1, Item, ItemControl.Current)
            FileClose(1)
            UnlockItemFile(Setup.ResourceFolder, ItemControl)
            Me.Close()
        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close() 'close the current form
    End Sub

End Class