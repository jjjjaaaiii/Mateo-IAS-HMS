<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminDashboard))
        Me.btn_change = New System.Windows.Forms.Button()
        Me.btn_managedoctor = New System.Windows.Forms.Button()
        Me.btn_manageappointment = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.currentUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.userRole = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dateAndTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.adminid = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.adminname = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btn_managepayment = New System.Windows.Forms.Button()
        Me.btn_manageuser = New System.Windows.Forms.Button()
        Me.btn_managepatient = New System.Windows.Forms.Button()
        Me.btn_backup = New System.Windows.Forms.Button()
        Me.btn_restore = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_activate = New System.Windows.Forms.Button()
        Me.btn_audit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_change
        '
        Me.btn_change.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_change.Location = New System.Drawing.Point(164, 384)
        Me.btn_change.Name = "btn_change"
        Me.btn_change.Size = New System.Drawing.Size(661, 52)
        Me.btn_change.TabIndex = 13
        Me.btn_change.Text = "Change Info"
        Me.btn_change.UseVisualStyleBackColor = True
        '
        'btn_managedoctor
        '
        Me.btn_managedoctor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_managedoctor.Location = New System.Drawing.Point(611, 153)
        Me.btn_managedoctor.Name = "btn_managedoctor"
        Me.btn_managedoctor.Size = New System.Drawing.Size(214, 52)
        Me.btn_managedoctor.TabIndex = 12
        Me.btn_managedoctor.Text = "Manage Doctors"
        Me.btn_managedoctor.UseVisualStyleBackColor = True
        '
        'btn_manageappointment
        '
        Me.btn_manageappointment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manageappointment.Location = New System.Drawing.Point(374, 210)
        Me.btn_manageappointment.Name = "btn_manageappointment"
        Me.btn_manageappointment.Size = New System.Drawing.Size(451, 52)
        Me.btn_manageappointment.TabIndex = 11
        Me.btn_manageappointment.Text = "Manage Appointments"
        Me.btn_manageappointment.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.currentUser, Me.ToolStripStatusLabel2, Me.userRole, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.dateAndTime, Me.ToolStripStatusLabel5, Me.adminid, Me.ToolStripStatusLabel6, Me.adminname})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 558)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(998, 26)
        Me.StatusStrip1.TabIndex = 8
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
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(70, 20)
        Me.ToolStripStatusLabel5.Text = "admin ID"
        '
        'adminid
        '
        Me.adminid.Name = "adminid"
        Me.adminid.Size = New System.Drawing.Size(15, 20)
        Me.adminid.Text = "-"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(97, 20)
        Me.ToolStripStatusLabel6.Text = "Admin Name"
        '
        'adminname
        '
        Me.adminname.Name = "adminname"
        Me.adminname.Size = New System.Drawing.Size(15, 20)
        Me.adminname.Text = "-"
        '
        'btn_managepayment
        '
        Me.btn_managepayment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_managepayment.Location = New System.Drawing.Point(374, 153)
        Me.btn_managepayment.Name = "btn_managepayment"
        Me.btn_managepayment.Size = New System.Drawing.Size(231, 52)
        Me.btn_managepayment.TabIndex = 15
        Me.btn_managepayment.Text = "Manage Payments"
        Me.btn_managepayment.UseVisualStyleBackColor = True
        '
        'btn_manageuser
        '
        Me.btn_manageuser.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manageuser.Location = New System.Drawing.Point(374, 268)
        Me.btn_manageuser.Name = "btn_manageuser"
        Me.btn_manageuser.Size = New System.Drawing.Size(451, 52)
        Me.btn_manageuser.TabIndex = 16
        Me.btn_manageuser.Text = "Manage Users"
        Me.btn_manageuser.UseVisualStyleBackColor = True
        '
        'btn_managepatient
        '
        Me.btn_managepatient.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_managepatient.Location = New System.Drawing.Point(374, 326)
        Me.btn_managepatient.Name = "btn_managepatient"
        Me.btn_managepatient.Size = New System.Drawing.Size(451, 52)
        Me.btn_managepatient.TabIndex = 17
        Me.btn_managepatient.Text = "Manage Patients"
        Me.btn_managepatient.UseVisualStyleBackColor = True
        '
        'btn_backup
        '
        Me.btn_backup.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backup.Location = New System.Drawing.Point(164, 442)
        Me.btn_backup.Name = "btn_backup"
        Me.btn_backup.Size = New System.Drawing.Size(343, 52)
        Me.btn_backup.TabIndex = 18
        Me.btn_backup.Text = "Backup"
        Me.btn_backup.UseVisualStyleBackColor = True
        '
        'btn_restore
        '
        Me.btn_restore.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_restore.Location = New System.Drawing.Point(513, 442)
        Me.btn_restore.Name = "btn_restore"
        Me.btn_restore.Size = New System.Drawing.Size(312, 52)
        Me.btn_restore.TabIndex = 19
        Me.btn_restore.Text = "Restore"
        Me.btn_restore.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.Location = New System.Drawing.Point(854, 505)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(132, 41)
        Me.btn_logout.TabIndex = 20
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btn_activate
        '
        Me.btn_activate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_activate.Location = New System.Drawing.Point(164, 153)
        Me.btn_activate.Name = "btn_activate"
        Me.btn_activate.Size = New System.Drawing.Size(204, 109)
        Me.btn_activate.TabIndex = 21
        Me.btn_activate.Text = "Activate User"
        Me.btn_activate.UseVisualStyleBackColor = True
        '
        'btn_audit
        '
        Me.btn_audit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_audit.Location = New System.Drawing.Point(164, 268)
        Me.btn_audit.Name = "btn_audit"
        Me.btn_audit.Size = New System.Drawing.Size(204, 110)
        Me.btn_audit.TabIndex = 22
        Me.btn_audit.Text = "Audit Log"
        Me.btn_audit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(76, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 49)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "HELLO ADMIN! "
        '
        'adminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(998, 584)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_audit)
        Me.Controls.Add(Me.btn_activate)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_restore)
        Me.Controls.Add(Me.btn_backup)
        Me.Controls.Add(Me.btn_managepatient)
        Me.Controls.Add(Me.btn_manageuser)
        Me.Controls.Add(Me.btn_managepayment)
        Me.Controls.Add(Me.btn_change)
        Me.Controls.Add(Me.btn_managedoctor)
        Me.Controls.Add(Me.btn_manageappointment)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminDashboard"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_change As Button
    Friend WithEvents btn_managedoctor As Button
    Friend WithEvents btn_manageappointment As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents currentUser As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents userRole As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents dateAndTime As ToolStripStatusLabel
    Friend WithEvents btn_managepayment As Button
    Friend WithEvents btn_manageuser As Button
    Friend WithEvents btn_managepatient As Button
    Friend WithEvents btn_backup As Button
    Friend WithEvents btn_restore As Button
    Friend WithEvents btn_logout As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_activate As Button
    Friend WithEvents btn_audit As Button
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents adminid As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents adminname As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
End Class
