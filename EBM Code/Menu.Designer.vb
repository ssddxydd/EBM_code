<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnNewBooking = New System.Windows.Forms.Button()
        Me.btnManageRooms = New System.Windows.Forms.Button()
        Me.btnSystemSettings = New System.Windows.Forms.Button()
        Me.btnManageCatering = New System.Windows.Forms.Button()
        Me.btnManageBookings = New System.Windows.Forms.Button()
        Me.btnBookingCalendar = New System.Windows.Forms.Button()
        Me.btnLog_out = New System.Windows.Forms.Button()
        Me.btnManageCustomers = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNewBooking
        '
        Me.btnNewBooking.Location = New System.Drawing.Point(138, 12)
        Me.btnNewBooking.Name = "btnNewBooking"
        Me.btnNewBooking.Size = New System.Drawing.Size(120, 32)
        Me.btnNewBooking.TabIndex = 0
        Me.btnNewBooking.Text = "New Booking"
        Me.btnNewBooking.UseVisualStyleBackColor = True
        '
        'btnManageRooms
        '
        Me.btnManageRooms.Location = New System.Drawing.Point(12, 12)
        Me.btnManageRooms.Name = "btnManageRooms"
        Me.btnManageRooms.Size = New System.Drawing.Size(120, 32)
        Me.btnManageRooms.TabIndex = 1
        Me.btnManageRooms.Text = "Manage Rooms"
        Me.btnManageRooms.UseVisualStyleBackColor = True
        '
        'btnSystemSettings
        '
        Me.btnSystemSettings.Location = New System.Drawing.Point(138, 88)
        Me.btnSystemSettings.Name = "btnSystemSettings"
        Me.btnSystemSettings.Size = New System.Drawing.Size(120, 32)
        Me.btnSystemSettings.TabIndex = 2
        Me.btnSystemSettings.Text = "System Settings"
        Me.btnSystemSettings.UseVisualStyleBackColor = True
        '
        'btnManageCatering
        '
        Me.btnManageCatering.Location = New System.Drawing.Point(138, 50)
        Me.btnManageCatering.Name = "btnManageCatering"
        Me.btnManageCatering.Size = New System.Drawing.Size(120, 32)
        Me.btnManageCatering.TabIndex = 3
        Me.btnManageCatering.Text = "Catering"
        Me.btnManageCatering.UseVisualStyleBackColor = True
        '
        'btnManageBookings
        '
        Me.btnManageBookings.Location = New System.Drawing.Point(12, 88)
        Me.btnManageBookings.Name = "btnManageBookings"
        Me.btnManageBookings.Size = New System.Drawing.Size(120, 32)
        Me.btnManageBookings.TabIndex = 4
        Me.btnManageBookings.Text = "Manage Bookings"
        Me.btnManageBookings.UseVisualStyleBackColor = True
        '
        'btnBookingCalendar
        '
        Me.btnBookingCalendar.Location = New System.Drawing.Point(12, 126)
        Me.btnBookingCalendar.Name = "btnBookingCalendar"
        Me.btnBookingCalendar.Size = New System.Drawing.Size(120, 32)
        Me.btnBookingCalendar.TabIndex = 6
        Me.btnBookingCalendar.Text = "Booking Calendar"
        Me.btnBookingCalendar.UseVisualStyleBackColor = True
        '
        'btnLog_out
        '
        Me.btnLog_out.Location = New System.Drawing.Point(138, 126)
        Me.btnLog_out.Name = "btnLog_out"
        Me.btnLog_out.Size = New System.Drawing.Size(120, 32)
        Me.btnLog_out.TabIndex = 7
        Me.btnLog_out.Text = "Log Out"
        Me.btnLog_out.UseVisualStyleBackColor = True
        '
        'btnManageCustomers
        '
        Me.btnManageCustomers.Location = New System.Drawing.Point(12, 50)
        Me.btnManageCustomers.Name = "btnManageCustomers"
        Me.btnManageCustomers.Size = New System.Drawing.Size(120, 32)
        Me.btnManageCustomers.TabIndex = 8
        Me.btnManageCustomers.Text = "Manage Customers"
        Me.btnManageCustomers.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 178)
        Me.Controls.Add(Me.btnManageCustomers)
        Me.Controls.Add(Me.btnLog_out)
        Me.Controls.Add(Me.btnBookingCalendar)
        Me.Controls.Add(Me.btnManageBookings)
        Me.Controls.Add(Me.btnManageCatering)
        Me.Controls.Add(Me.btnSystemSettings)
        Me.Controls.Add(Me.btnManageRooms)
        Me.Controls.Add(Me.btnNewBooking)
        Me.MaximizeBox = False
        Me.Name = "frmMenu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNewBooking As System.Windows.Forms.Button
    Friend WithEvents btnManageRooms As System.Windows.Forms.Button
    Friend WithEvents btnSystemSettings As System.Windows.Forms.Button
    Friend WithEvents btnManageCatering As System.Windows.Forms.Button
    Friend WithEvents btnManageBookings As System.Windows.Forms.Button
    Friend WithEvents btnBookingCalendar As System.Windows.Forms.Button
    Friend WithEvents btnLog_out As System.Windows.Forms.Button
    Friend WithEvents btnManageCustomers As System.Windows.Forms.Button
End Class
