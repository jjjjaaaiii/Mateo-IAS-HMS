<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manageDoctors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manageDoctors))
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.testTimer = New System.Windows.Forms.Label()
        Me.txtcontact_doctor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtaddress_doctor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtname_doctor = New System.Windows.Forms.TextBox()
        Me.gb_patient_number = New System.Windows.Forms.GroupBox()
        Me.btnSearch_patient = New System.Windows.Forms.Button()
        Me.txtsearch_doctor = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.randomasslabel = New System.Windows.Forms.Label()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.gb_patient_number.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(20, 446)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(123, 32)
        Me.btn_update.TabIndex = 1
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.Location = New System.Drawing.Point(797, 446)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(106, 32)
        Me.btn_home.TabIndex = 3
        Me.btn_home.Text = "Home"
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'testTimer
        '
        Me.testTimer.AutoSize = True
        Me.testTimer.BackColor = System.Drawing.Color.Transparent
        Me.testTimer.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.testTimer.ForeColor = System.Drawing.Color.White
        Me.testTimer.Location = New System.Drawing.Point(892, 9)
        Me.testTimer.Name = "testTimer"
        Me.testTimer.Size = New System.Drawing.Size(17, 23)
        Me.testTimer.TabIndex = 26
        Me.testTimer.Text = "-"
        '
        'txtcontact_doctor
        '
        Me.txtcontact_doctor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontact_doctor.Location = New System.Drawing.Point(512, 198)
        Me.txtcontact_doctor.Name = "txtcontact_doctor"
        Me.txtcontact_doctor.Size = New System.Drawing.Size(247, 32)
        Me.txtcontact_doctor.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(16, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 23)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Address"
        '
        'txtaddress_doctor
        '
        Me.txtaddress_doctor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress_doctor.Location = New System.Drawing.Point(17, 200)
        Me.txtaddress_doctor.Name = "txtaddress_doctor"
        Me.txtaddress_doctor.Size = New System.Drawing.Size(471, 32)
        Me.txtaddress_doctor.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(284, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name"
        '
        'txtname_doctor
        '
        Me.txtname_doctor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname_doctor.Location = New System.Drawing.Point(288, 124)
        Me.txtname_doctor.Name = "txtname_doctor"
        Me.txtname_doctor.Size = New System.Drawing.Size(467, 32)
        Me.txtname_doctor.TabIndex = 0
        '
        'gb_patient_number
        '
        Me.gb_patient_number.BackColor = System.Drawing.Color.Transparent
        Me.gb_patient_number.Controls.Add(Me.btnSearch_patient)
        Me.gb_patient_number.Controls.Add(Me.txtsearch_doctor)
        Me.gb_patient_number.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_patient_number.ForeColor = System.Drawing.SystemColors.Control
        Me.gb_patient_number.Location = New System.Drawing.Point(604, 37)
        Me.gb_patient_number.Name = "gb_patient_number"
        Me.gb_patient_number.Size = New System.Drawing.Size(299, 65)
        Me.gb_patient_number.TabIndex = 19
        Me.gb_patient_number.TabStop = False
        Me.gb_patient_number.Text = "Doctor ID"
        '
        'btnSearch_patient
        '
        Me.btnSearch_patient.Location = New System.Drawing.Point(152, 20)
        Me.btnSearch_patient.Name = "btnSearch_patient"
        Me.btnSearch_patient.Size = New System.Drawing.Size(119, 33)
        Me.btnSearch_patient.TabIndex = 1
        Me.btnSearch_patient.Text = "Search"
        Me.btnSearch_patient.UseVisualStyleBackColor = True
        '
        'txtsearch_doctor
        '
        Me.txtsearch_doctor.Location = New System.Drawing.Point(16, 21)
        Me.txtsearch_doctor.Name = "txtsearch_doctor"
        Me.txtsearch_doctor.Size = New System.Drawing.Size(121, 32)
        Me.txtsearch_doctor.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 241)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(883, 199)
        Me.DataGridView1.TabIndex = 27
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(508, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 23)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Contact"
        '
        'randomasslabel
        '
        Me.randomasslabel.AutoSize = True
        Me.randomasslabel.BackColor = System.Drawing.Color.Transparent
        Me.randomasslabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.randomasslabel.ForeColor = System.Drawing.SystemColors.Control
        Me.randomasslabel.Location = New System.Drawing.Point(16, 98)
        Me.randomasslabel.Name = "randomasslabel"
        Me.randomasslabel.Size = New System.Drawing.Size(76, 23)
        Me.randomasslabel.TabIndex = 38
        Me.randomasslabel.Text = "User ID"
        '
        'txtuserid
        '
        Me.txtuserid.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuserid.Location = New System.Drawing.Point(17, 124)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(250, 32)
        Me.txtuserid.TabIndex = 37
        '
        'manageDoctors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(920, 490)
        Me.Controls.Add(Me.randomasslabel)
        Me.Controls.Add(Me.txtuserid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcontact_doctor)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.testTimer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtaddress_doctor)
        Me.Controls.Add(Me.txtname_doctor)
        Me.Controls.Add(Me.gb_patient_number)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.btn_update)
        Me.Name = "manageDoctors"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "manageDoctors"
        Me.gb_patient_number.ResumeLayout(False)
        Me.gb_patient_number.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents testTimer As Label
    Friend WithEvents txtcontact_doctor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtaddress_doctor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtname_doctor As TextBox
    Friend WithEvents gb_patient_number As GroupBox
    Friend WithEvents btnSearch_patient As Button
    Friend WithEvents txtsearch_doctor As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents randomasslabel As Label
    Friend WithEvents txtuserid As TextBox
End Class
