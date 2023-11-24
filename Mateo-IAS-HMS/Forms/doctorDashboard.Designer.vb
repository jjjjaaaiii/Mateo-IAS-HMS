<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class doctorDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(doctorDashboard))
        Me.btn_change = New System.Windows.Forms.Button()
        Me.btn_viewdoctor = New System.Windows.Forms.Button()
        Me.btn_manageappointment = New System.Windows.Forms.Button()
        Me.btn_audit = New System.Windows.Forms.Button()
        Me.btn_managepayment = New System.Windows.Forms.Button()
        Me.btn_managepatient = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.currentUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.userRole = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dateAndTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.doctorid = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.doctorname = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_change
        '
        Me.btn_change.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_change.Location = New System.Drawing.Point(284, 157)
        Me.btn_change.Name = "btn_change"
        Me.btn_change.Size = New System.Drawing.Size(210, 38)
        Me.btn_change.TabIndex = 14
        Me.btn_change.Text = "Change Info"
        Me.btn_change.UseVisualStyleBackColor = True
        '
        'btn_viewdoctor
        '
        Me.btn_viewdoctor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_viewdoctor.Location = New System.Drawing.Point(500, 159)
        Me.btn_viewdoctor.Name = "btn_viewdoctor"
        Me.btn_viewdoctor.Size = New System.Drawing.Size(235, 36)
        Me.btn_viewdoctor.TabIndex = 13
        Me.btn_viewdoctor.Text = "View Doctors"
        Me.btn_viewdoctor.UseVisualStyleBackColor = True
        '
        'btn_manageappointment
        '
        Me.btn_manageappointment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manageappointment.Location = New System.Drawing.Point(56, 197)
        Me.btn_manageappointment.Name = "btn_manageappointment"
        Me.btn_manageappointment.Size = New System.Drawing.Size(268, 41)
        Me.btn_manageappointment.TabIndex = 12
        Me.btn_manageappointment.Text = "Manage Appointments"
        Me.btn_manageappointment.UseVisualStyleBackColor = True
        '
        'btn_audit
        '
        Me.btn_audit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_audit.Location = New System.Drawing.Point(330, 201)
        Me.btn_audit.Name = "btn_audit"
        Me.btn_audit.Size = New System.Drawing.Size(164, 37)
        Me.btn_audit.TabIndex = 11
        Me.btn_audit.Text = "Audit"
        Me.btn_audit.UseVisualStyleBackColor = True
        '
        'btn_managepayment
        '
        Me.btn_managepayment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_managepayment.Location = New System.Drawing.Point(56, 154)
        Me.btn_managepayment.Name = "btn_managepayment"
        Me.btn_managepayment.Size = New System.Drawing.Size(222, 41)
        Me.btn_managepayment.TabIndex = 10
        Me.btn_managepayment.Text = "Manage Payments"
        Me.btn_managepayment.UseVisualStyleBackColor = True
        '
        'btn_managepatient
        '
        Me.btn_managepatient.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_managepatient.Location = New System.Drawing.Point(500, 201)
        Me.btn_managepatient.Name = "btn_managepatient"
        Me.btn_managepatient.Size = New System.Drawing.Size(235, 37)
        Me.btn_managepatient.TabIndex = 17
        Me.btn_managepatient.Text = "Manage Patients"
        Me.btn_managepatient.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.Location = New System.Drawing.Point(692, 386)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(96, 35)
        Me.btn_logout.TabIndex = 18
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.currentUser, Me.ToolStripStatusLabel2, Me.userRole, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.dateAndTime, Me.ToolStripStatusLabel5, Me.doctorid, Me.ToolStripStatusLabel6, Me.doctorname})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 424)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 26)
        Me.StatusStrip1.TabIndex = 19
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
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(74, 20)
        Me.ToolStripStatusLabel5.Text = "Doctor ID"
        '
        'doctorid
        '
        Me.doctorid.Name = "doctorid"
        Me.doctorid.Size = New System.Drawing.Size(15, 20)
        Me.doctorid.Text = "-"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(99, 20)
        Me.ToolStripStatusLabel6.Text = "Doctor Name"
        '
        'doctorname
        '
        Me.doctorname.Name = "doctorname"
        Me.doctorname.Size = New System.Drawing.Size(15, 20)
        Me.doctorname.Text = "-"
        '
        'doctorDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_managepatient)
        Me.Controls.Add(Me.btn_change)
        Me.Controls.Add(Me.btn_viewdoctor)
        Me.Controls.Add(Me.btn_manageappointment)
        Me.Controls.Add(Me.btn_audit)
        Me.Controls.Add(Me.btn_managepayment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "doctorDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "doctorDashboard"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_change As Button
    Friend WithEvents btn_viewdoctor As Button
    Friend WithEvents btn_manageappointment As Button
    Friend WithEvents btn_audit As Button
    Friend WithEvents btn_managepayment As Button
    Friend WithEvents btn_managepatient As Button
    Friend WithEvents btn_logout As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents currentUser As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents userRole As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents dateAndTime As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents doctorid As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents doctorname As ToolStripStatusLabel
End Class
