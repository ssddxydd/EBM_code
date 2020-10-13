Public Class frmManageCatering
    Dim Setup As SystemSetupData
    Dim Item As CateringData
    Dim ItemControl As CateringControlData
    Private Sub frmManageCatering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "Setup.dat", OpenMode.Random, , , Len(Setup))
        FileGet(1, Setup, 1) 'retrieve system information
        FileClose(1)
        LockItemFile(Setup.ResourceFolder, ItemControl)
        If ItemControl.Current <> 0 Then
            FileOpen(1, Setup.ResourceFolder + "\Item.dat", OpenMode.Random, , , Len(Item))
            For i As Integer = 1 To ItemControl.Current
                FileGet(1, Item, i)

                lstItem.Items.Add(Unpad(Item.Name))
            Next
            FileClose(1)
        End If

        UnlockItemFile(Setup.ResourceFolder, ItemControl)

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close() 'close the form
    End Sub
    Private Sub lstItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstItem.SelectedIndexChanged
        If lstItem.SelectedIndex <> -1 Then 'if the index of the list box does not change to -1 then

            LockItemFile(Setup.ResourceFolder, ItemControl) 'lock item file
            FileOpen(1, Setup.ResourceFolder + "\Item.dat", OpenMode.Random, , , Len(Item))
            FileGet(1, Item, lstItem.SelectedIndex + 1) 'retrieve information concerning the currently selected item
            FileClose(1)

            UnlockItemFile(Setup.ResourceFolder, ItemControl) 'unlock item file
            If Item.Active = False Then 'if the item is inactive then show a warning in a label 
                lblWarning.Visible = True
            Else : lblWarning.Visible = False
            End If
            txtName.Text = Unpad(Item.Name)
            txtPrice.Text = Item.Price
            If Item.Active = True Then
                cmbStatus.SelectedIndex = 0
            Else : cmbStatus.SelectedIndex = 1
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not IsNumeric(txtPrice.Text) Then 'if the price is not a valid number
            MessageBox.Show("Please enter a valid price", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf lstItem.SelectedIndex <> -1 Then
            Item.Price = Val(txtPrice.Text)
            Item.Name = txtName.Text

            If cmbStatus.SelectedIndex = 0 Then
                Item.Active = True
            Else : Item.Active = False
            End If
            LockItemFile(Setup.ResourceFolder, ItemControl)
            FileOpen(1, Setup.ResourceFolder + "\Item.dat", OpenMode.Random, , , Len(Item))
            FilePut(1, Item, lstItem.SelectedIndex + 1)
            lstItem.Items.Clear() 'clear the list box
            For i As Integer = 1 To ItemControl.Current 'populate the list box with updated information
                FileGet(1, Item, i)
                lstItem.Items.Add(Unpad(Item.Name))
            Next
            FileClose(1)
            UnlockItemFile(Setup.ResourceFolder, ItemControl)
            MessageBox.Show("The Item information has been updated", "Item Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf lstItem.SelectedIndex = -1 Then : MessageBox.Show("Please Select an Item", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnNewItem_Click(sender As Object, e As EventArgs) Handles btnNewItem.Click
        Dim AddNewItem As New frmNewItem
        AddNewItem.ShowDialog()
        lstItem.Items.Clear()

        LockItemFile(Setup.ResourceFolder, ItemControl)
        If ItemControl.Current <> 0 Then
            FileOpen(1, Setup.ResourceFolder + "\Item.dat", OpenMode.Random, , , Len(Item))
            For i As Integer = 1 To ItemControl.Current
                FileGet(1, Item, i)
                lstItem.Items.Add(Unpad(Item.Name))
            Next
            FileClose(1)
        End If
        UnlockItemFile(Setup.ResourceFolder, ItemControl)
    End Sub
End Class