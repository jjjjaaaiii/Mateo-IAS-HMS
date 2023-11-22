<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class patientDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.currentUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.userRole = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dateAndTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_pay = New System.Windows.Forms.Button()
        Me.btn_book = New System.Windows.Forms.Button()
        Me.btn_viewappoint = New System.Windows.Forms.Button()
        Me.btn_viewdoctor = New System.Windows.Forms.Button()
        Me.btn_change = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.currentUser, Me.ToolStripStatusLabel2, Me.userRole, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.dateAndTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 424)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 26)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(93, 20)
        Me.ToolStripStatusLabel1.Text = "Current User:"
        '
        'currentUser
        '
        Me.currentUser.Name = "currentUser"
        Me.currentUser.Size = New System.Drawing.Size(15, 20)
        Me.currentUser.Text = "-"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(75, 20)
        Me.ToolStripStatusLabel2.Text = "User Role:"
        '
        'userRole
        '
        Me.userRole.Name = "userRole"
        Me.userRole.Size = New System.Drawing.Size(15, 20)
        Me.userRole.Text = "-"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(0, 20)
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(107, 20)
        Me.ToolStripStatusLabel4.Text = "Date and Time"
        Me.ToolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'dateAndTime
        '
        Me.dateAndTime.Name = "dateAndTime"
        Me.dateAndTime.Size = New System.Drawing.Size(15, 20)
        Me.dateAndTime.Text = "-"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btn_pay
        '
        Me.btn_pay.Location = New System.Drawing.Point(113, 217)
        Me.btn_pay.Name = "btn_pay"
        Me.btn_pay.Size = New System.Drawing.Size(132, 23)
        Me.btn_pay.TabIndex = 3
        Me.btn_pay.Text = "Pay"
        Me.btn_pay.UseVisualStyleBackColor = True
        '
        'btn_book
        '
        Me.btn_book.Location = New System.Drawing.Point(113, 154)
        Me.btn_book.Name = "btn_book"
        Me.btn_book.Size = New System.Drawing.Size(132, 23)
        Me.btn_book.TabIndex = 4
        Me.btn_book.Text = "Book Appointment"
        Me.btn_book.UseVisualStyleBackColor = True
        '
        'btn_viewappoint
        '
        Me.btn_viewappoint.Location = New System.Drawing.Point(322, 154)
        Me.btn_viewappoint.Name = "btn_viewappoint"
        Me.btn_viewappoint.Size = New System.Drawing.Size(132, 23)
        Me.btn_viewappoint.TabIndex = 5
        Me.btn_viewappoint.Text = "View Appointments"
        Me.btn_viewappoint.UseVisualStyleBackColor = True
        '
        'btn_viewdoctor
        '
        Me.btn_viewdoctor.Location = New System.Drawing.Point(520, 154)
        Me.btn_viewdoctor.Name = "btn_viewdoctor"
        Me.btn_viewdoctor.Size = New System.Drawing.Size(132, 23)
        Me.btn_viewdoctor.TabIndex = 6
        Me.btn_viewdoctor.Text = "View Doctors"
        Me.btn_viewdoctor.UseVisualStyleBackColor = True
        '
        'btn_change
        '
        Me.btn_change.Location = New System.Drawing.Point(322, 217)
        Me.btn_change.Name = "btn_change"
        Me.btn_change.Size = New System.Drawing.Size(132, 23)
        Me.btn_change.TabIndex = 7
        Me.btn_change.Text = "Change Info"
        Me.btn_change.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(322, 299)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(132, 23)
        Me.btn_logout.TabIndex = 8
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'patientDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_change)
        Me.Controls.Add(Me.btn_viewdoctor)
        Me.Controls.Add(Me.btn_viewappoint)
        Me.Controls.Add(Me.btn_book)
        Me.Controls.Add(Me.btn_pay)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "patientDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "informationSystem"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents currentUser As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents userRole As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents dateAndTime As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_pay As Button
    Friend WithEvents btn_book As Button
    Friend WithEvents btn_viewappoint As Button
    Friend WithEvents btn_viewdoctor As Button
    Friend WithEvents btn_change As Button
    Friend WithEvents btn_logout As Button
End Class
