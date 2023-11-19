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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.testTimer = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.dtpbirthday_patient = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtage_patient = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtcontactnumber_patient = New System.Windows.Forms.TextBox()
        Me.gb_gender_patient = New System.Windows.Forms.GroupBox()
        Me.cmbgender_patient = New System.Windows.Forms.ComboBox()
        Me.gb_address_patient = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtprovince_patient = New System.Windows.Forms.TextBox()
        Me.txtmunicipality_patient = New System.Windows.Forms.TextBox()
        Me.txtbarangay_patient = New System.Windows.Forms.TextBox()
        Me.gb_name_patient = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmi_patient = New System.Windows.Forms.TextBox()
        Me.txtfirstname_patient = New System.Windows.Forms.TextBox()
        Me.Txtlastname_patient = New System.Windows.Forms.TextBox()
        Me.gb_patient_number = New System.Windows.Forms.GroupBox()
        Me.btnSearch_patient = New System.Windows.Forms.Button()
        Me.txtpatient_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.gb_gender_patient.SuspendLayout()
        Me.gb_address_patient.SuspendLayout()
        Me.gb_name_patient.SuspendLayout()
        Me.gb_patient_number.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(82, 565)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add Doctor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(226, 565)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(333, 565)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(774, 565)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Home"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'testTimer
        '
        Me.testTimer.AutoSize = True
        Me.testTimer.Location = New System.Drawing.Point(892, -1)
        Me.testTimer.Name = "testTimer"
        Me.testTimer.Size = New System.Drawing.Size(11, 16)
        Me.testTimer.TabIndex = 26
        Me.testTimer.Text = "-"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.dtpbirthday_patient)
        Me.GroupBox7.Location = New System.Drawing.Point(493, 280)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(332, 58)
        Me.GroupBox7.TabIndex = 25
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Birthday"
        '
        'dtpbirthday_patient
        '
        Me.dtpbirthday_patient.Location = New System.Drawing.Point(19, 22)
        Me.dtpbirthday_patient.Name = "dtpbirthday_patient"
        Me.dtpbirthday_patient.Size = New System.Drawing.Size(293, 22)
        Me.dtpbirthday_patient.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtage_patient)
        Me.GroupBox6.Location = New System.Drawing.Point(396, 279)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(74, 58)
        Me.GroupBox6.TabIndex = 24
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Age"
        '
        'txtage_patient
        '
        Me.txtage_patient.Location = New System.Drawing.Point(7, 21)
        Me.txtage_patient.Name = "txtage_patient"
        Me.txtage_patient.Size = New System.Drawing.Size(58, 22)
        Me.txtage_patient.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtcontactnumber_patient)
        Me.GroupBox5.Location = New System.Drawing.Point(90, 280)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(280, 58)
        Me.GroupBox5.TabIndex = 23
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Contact Number"
        '
        'txtcontactnumber_patient
        '
        Me.txtcontactnumber_patient.Location = New System.Drawing.Point(17, 22)
        Me.txtcontactnumber_patient.Name = "txtcontactnumber_patient"
        Me.txtcontactnumber_patient.Size = New System.Drawing.Size(247, 22)
        Me.txtcontactnumber_patient.TabIndex = 0
        '
        'gb_gender_patient
        '
        Me.gb_gender_patient.Controls.Add(Me.cmbgender_patient)
        Me.gb_gender_patient.Location = New System.Drawing.Point(704, 108)
        Me.gb_gender_patient.Name = "gb_gender_patient"
        Me.gb_gender_patient.Size = New System.Drawing.Size(199, 79)
        Me.gb_gender_patient.TabIndex = 22
        Me.gb_gender_patient.TabStop = False
        Me.gb_gender_patient.Text = "Gender"
        '
        'cmbgender_patient
        '
        Me.cmbgender_patient.FormattingEnabled = True
        Me.cmbgender_patient.Items.AddRange(New Object() {"Male ", "Female"})
        Me.cmbgender_patient.Location = New System.Drawing.Point(9, 40)
        Me.cmbgender_patient.Name = "cmbgender_patient"
        Me.cmbgender_patient.Size = New System.Drawing.Size(121, 24)
        Me.cmbgender_patient.TabIndex = 0
        '
        'gb_address_patient
        '
        Me.gb_address_patient.Controls.Add(Me.Label5)
        Me.gb_address_patient.Controls.Add(Me.Label6)
        Me.gb_address_patient.Controls.Add(Me.Label7)
        Me.gb_address_patient.Controls.Add(Me.txtprovince_patient)
        Me.gb_address_patient.Controls.Add(Me.txtmunicipality_patient)
        Me.gb_address_patient.Controls.Add(Me.txtbarangay_patient)
        Me.gb_address_patient.Location = New System.Drawing.Point(20, 193)
        Me.gb_address_patient.Name = "gb_address_patient"
        Me.gb_address_patient.Size = New System.Drawing.Size(883, 80)
        Me.gb_address_patient.TabIndex = 21
        Me.gb_address_patient.TabStop = False
        Me.gb_address_patient.Text = "Addess "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(681, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Province"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(336, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Municipality"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Barangay "
        '
        'txtprovince_patient
        '
        Me.txtprovince_patient.Location = New System.Drawing.Point(684, 47)
        Me.txtprovince_patient.Name = "txtprovince_patient"
        Me.txtprovince_patient.Size = New System.Drawing.Size(168, 22)
        Me.txtprovince_patient.TabIndex = 2
        '
        'txtmunicipality_patient
        '
        Me.txtmunicipality_patient.Location = New System.Drawing.Point(339, 47)
        Me.txtmunicipality_patient.Name = "txtmunicipality_patient"
        Me.txtmunicipality_patient.Size = New System.Drawing.Size(285, 22)
        Me.txtmunicipality_patient.TabIndex = 1
        '
        'txtbarangay_patient
        '
        Me.txtbarangay_patient.Location = New System.Drawing.Point(14, 47)
        Me.txtbarangay_patient.Name = "txtbarangay_patient"
        Me.txtbarangay_patient.Size = New System.Drawing.Size(250, 22)
        Me.txtbarangay_patient.TabIndex = 0
        '
        'gb_name_patient
        '
        Me.gb_name_patient.Controls.Add(Me.Label4)
        Me.gb_name_patient.Controls.Add(Me.Label3)
        Me.gb_name_patient.Controls.Add(Me.Label2)
        Me.gb_name_patient.Controls.Add(Me.txtmi_patient)
        Me.gb_name_patient.Controls.Add(Me.txtfirstname_patient)
        Me.gb_name_patient.Controls.Add(Me.Txtlastname_patient)
        Me.gb_name_patient.Location = New System.Drawing.Point(20, 106)
        Me.gb_name_patient.Name = "gb_name_patient"
        Me.gb_name_patient.Size = New System.Drawing.Size(678, 81)
        Me.gb_name_patient.TabIndex = 20
        Me.gb_name_patient.TabStop = False
        Me.gb_name_patient.Text = "Name of Doctor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(566, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "MI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(272, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Firstname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Lastname"
        '
        'txtmi_patient
        '
        Me.txtmi_patient.Location = New System.Drawing.Point(569, 44)
        Me.txtmi_patient.Name = "txtmi_patient"
        Me.txtmi_patient.Size = New System.Drawing.Size(59, 22)
        Me.txtmi_patient.TabIndex = 2
        '
        'txtfirstname_patient
        '
        Me.txtfirstname_patient.Location = New System.Drawing.Point(275, 44)
        Me.txtfirstname_patient.Name = "txtfirstname_patient"
        Me.txtfirstname_patient.Size = New System.Drawing.Size(285, 22)
        Me.txtfirstname_patient.TabIndex = 1
        '
        'Txtlastname_patient
        '
        Me.Txtlastname_patient.Location = New System.Drawing.Point(14, 46)
        Me.Txtlastname_patient.Name = "Txtlastname_patient"
        Me.Txtlastname_patient.Size = New System.Drawing.Size(250, 22)
        Me.Txtlastname_patient.TabIndex = 0
        '
        'gb_patient_number
        '
        Me.gb_patient_number.Controls.Add(Me.btnSearch_patient)
        Me.gb_patient_number.Controls.Add(Me.txtpatient_id)
        Me.gb_patient_number.Location = New System.Drawing.Point(647, 37)
        Me.gb_patient_number.Name = "gb_patient_number"
        Me.gb_patient_number.Size = New System.Drawing.Size(256, 65)
        Me.gb_patient_number.TabIndex = 19
        Me.gb_patient_number.TabStop = False
        Me.gb_patient_number.Text = "Doctor ID"
        '
        'btnSearch_patient
        '
        Me.btnSearch_patient.Location = New System.Drawing.Point(152, 20)
        Me.btnSearch_patient.Name = "btnSearch_patient"
        Me.btnSearch_patient.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch_patient.TabIndex = 1
        Me.btnSearch_patient.Text = "Search"
        Me.btnSearch_patient.UseVisualStyleBackColor = True
        '
        'txtpatient_id
        '
        Me.txtpatient_id.Location = New System.Drawing.Point(16, 21)
        Me.txtpatient_id.Name = "txtpatient_id"
        Me.txtpatient_id.Size = New System.Drawing.Size(121, 22)
        Me.txtpatient_id.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Register Doctor"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 357)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(883, 183)
        Me.DataGridView1.TabIndex = 27
        '
        'manageDoctors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 600)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.testTimer)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.gb_gender_patient)
        Me.Controls.Add(Me.gb_address_patient)
        Me.Controls.Add(Me.gb_name_patient)
        Me.Controls.Add(Me.gb_patient_number)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "manageDoctors"
        Me.Text = "manageDoctors"
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.gb_gender_patient.ResumeLayout(False)
        Me.gb_address_patient.ResumeLayout(False)
        Me.gb_address_patient.PerformLayout()
        Me.gb_name_patient.ResumeLayout(False)
        Me.gb_name_patient.PerformLayout()
        Me.gb_patient_number.ResumeLayout(False)
        Me.gb_patient_number.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents testTimer As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents dtpbirthday_patient As DateTimePicker
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtage_patient As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtcontactnumber_patient As TextBox
    Friend WithEvents gb_gender_patient As GroupBox
    Friend WithEvents cmbgender_patient As ComboBox
    Friend WithEvents gb_address_patient As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtprovince_patient As TextBox
    Friend WithEvents txtmunicipality_patient As TextBox
    Friend WithEvents txtbarangay_patient As TextBox
    Friend WithEvents gb_name_patient As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmi_patient As TextBox
    Friend WithEvents txtfirstname_patient As TextBox
    Friend WithEvents Txtlastname_patient As TextBox
    Friend WithEvents gb_patient_number As GroupBox
    Friend WithEvents btnSearch_patient As Button
    Friend WithEvents txtpatient_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
