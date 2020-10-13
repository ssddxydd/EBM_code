Public Class frmMenu

    Private Sub btnNewBooking_Click(sender As Object, e As EventArgs) Handles btnNewBooking.Click
        'Displays the New Booking form
        Dim NewBookingForm As New frmNewBooking
        NewBookingForm.ShowDialog()
    End Sub

    Private Sub btnManageRooms_Click(sender As Object, e As EventArgs) Handles btnManageRooms.Click
        'Displays the Manage Rooms Form
        Dim ManageRoomsForm As New frmManageRooms
        ManageRoomsForm.ShowDialog()
    End Sub

    Private Sub btnManageCatering_Click(sender As Object, e As EventArgs) Handles btnManageCatering.Click
        'Displays the Catering Form
        Dim CateringForm As New frmManageCatering
        CateringForm.ShowDialog() 'rename this as well
    End Sub

    Private Sub btnLog_out_Click(sender As Object, e As EventArgs) Handles btnLog_out.Click
        'Closes the Menu form
        Me.Close()
    End Sub

    Private Sub btnManageCustomers_Click(sender As Object, e As EventArgs) Handles btnManageCustomers.Click
        'Displays the Manage Customers form
        Dim ManageCustomersForm As New frmManageCustomers
        ManageCustomersForm.ShowDialog()
    End Sub

    Private Sub btnManageBookings_Click(sender As Object, e As EventArgs) Handles btnManageBookings.Click
        'Displays the Manage Bookings Form
        Dim ManageBookingsForm As New frmManageBookings
        ManageBookingsForm.ShowDialog()
    End Sub



    Private Sub btnBookingCalendar_Click(sender As Object, e As EventArgs) Handles btnBookingCalendar.Click
        'Displays the Booking calendar form
        Dim BookinCalendarForm As New frmBookingCalendar
        BookinCalendarForm.ShowDialog()
    End Sub
    Private Sub CloseMenu(sender As Object, e As EventArgs) Handles Me.FormClosed
        'When the form is closed the Access level and the current User Id are set to 0 
        'indicating that the user has been logged out
        'finally the event causes the login form to be displayed
        AccessLevel = 0
        UserID = 0
        frmLogin.Show()
    End Sub
    Private Sub btnSystemSettings_Click(sender As Object, e As EventArgs) Handles btnSystemSettings.Click
        'Displays the system settings form
        Dim SystemSettingsForm As New frmSystemSettings
        SystemSettingsForm.ShowDialog()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        Select Case AccessLevel
            Case 1
                Me.Text = "Menu - Administrator"
            Case 2
                btnSystemSettings.Enabled = False
            Case 3
                btnNewBooking.Enabled = False
                btnManageBookings.Enabled = False
                btnManageCatering.Enabled = False
                btnSystemSettings.Enabled = False
                btnManageCustomers.Enabled = False
                btnManageRooms.Enabled = False

        End Select

    End Sub
End Class