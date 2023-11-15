<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class managePatients
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gb_patient_number = New System.Windows.Forms.GroupBox()
        Me.btnSearch_patient = New System.Windows.Forms.Button()
        Me.txtpatient_id = New System.Windows.Forms.TextBox()
        Me.gb_name_patient = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmi_patient = New System.Windows.Forms.TextBox()
        Me.txtfirstname_patient = New System.Windows.Forms.TextBox()
        Me.Txtlastname_patient = New System.Windows.Forms.TextBox()
        Me.gb_address_patient = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtprovince_patient = New System.Windows.Forms.TextBox()
        Me.txtmunicipality_patient = New System.Windows.Forms.TextBox()
        Me.txtbarangay_patient = New System.Windows.Forms.TextBox()
        Me.gb_gender_patient = New System.Windows.Forms.GroupBox()
        Me.cmbgender_patient = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtcontactnumber_patient = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtage_patient = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.dtpbirthday_patient = New System.Windows.Forms.DateTimePicker()
        Me.btnNew_patient = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdd_patient = New System.Windows.Forms.Button()
        Me.btnUpdate_patient = New System.Windows.Forms.Button()
        Me.btndelete_patient = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.testTimer = New System.Windows.Forms.Label()
        Me.gb_patient_number.SuspendLayout()
        Me.gb_name_patient.SuspendLayout()
        Me.gb_address_patient.SuspendLayout()
        Me.gb_gender_patient.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Register Patient"
        '
        'gb_patient_number
        '
        Me.gb_patient_number.Controls.Add(Me.btnSearch_patient)
        Me.gb_patient_number.Controls.Add(Me.txtpatient_id)
        Me.gb_patient_number.Location = New System.Drawing.Point(673, 33)
        Me.gb_patient_number.Name = "gb_patient_number"
        Me.gb_patient_number.Size = New System.Drawing.Size(256, 65)
        Me.gb_patient_number.TabIndex = 1
        Me.gb_patient_number.TabStop = False
        Me.gb_patient_number.Text = "Patient Number"
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
        'gb_name_patient
        '
        Me.gb_name_patient.Controls.Add(Me.Label4)
        Me.gb_name_patient.Controls.Add(Me.Label3)
        Me.gb_name_patient.Controls.Add(Me.Label2)
        Me.gb_name_patient.Controls.Add(Me.txtmi_patient)
        Me.gb_name_patient.Controls.Add(Me.txtfirstname_patient)
        Me.gb_name_patient.Controls.Add(Me.Txtlastname_patient)
        Me.gb_name_patient.Location = New System.Drawing.Point(46, 102)
        Me.gb_name_patient.Name = "gb_name_patient"
        Me.gb_name_patient.Size = New System.Drawing.Size(678, 81)
        Me.gb_name_patient.TabIndex = 2
        Me.gb_name_patient.TabStop = False
        Me.gb_name_patient.Text = "Name of Patient"
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
        'gb_address_patient
        '
        Me.gb_address_patient.Controls.Add(Me.Label5)
        Me.gb_address_patient.Controls.Add(Me.Label6)
        Me.gb_address_patient.Controls.Add(Me.Label7)
        Me.gb_address_patient.Controls.Add(Me.txtprovince_patient)
        Me.gb_address_patient.Controls.Add(Me.txtmunicipality_patient)
        Me.gb_address_patient.Controls.Add(Me.txtbarangay_patient)
        Me.gb_address_patient.Location = New System.Drawing.Point(46, 189)
        Me.gb_address_patient.Name = "gb_address_patient"
        Me.gb_address_patient.Size = New System.Drawing.Size(883, 80)
        Me.gb_address_patient.TabIndex = 6
        Me.gb_address_patient.TabStop = False
        Me.gb_address_patient.Text = "Addess "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(690, 28)
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
        Me.txtprovince_patient.Location = New System.Drawing.Point(693, 47)
        Me.txtprovince_patient.Name = "txtprovince_patient"
        Me.txtprovince_patient.Size = New System.Drawing.Size(161, 22)
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
        'gb_gender_patient
        '
        Me.gb_gender_patient.Controls.Add(Me.cmbgender_patient)
        Me.gb_gender_patient.Location = New System.Drawing.Point(730, 104)
        Me.gb_gender_patient.Name = "gb_gender_patient"
        Me.gb_gender_patient.Size = New System.Drawing.Size(199, 79)
        Me.gb_gender_patient.TabIndex = 7
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
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtcontactnumber_patient)
        Me.GroupBox5.Location = New System.Drawing.Point(116, 276)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(280, 58)
        Me.GroupBox5.TabIndex = 8
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
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtage_patient)
        Me.GroupBox6.Location = New System.Drawing.Point(422, 275)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(74, 58)
        Me.GroupBox6.TabIndex = 9
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
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.dtpbirthday_patient)
        Me.GroupBox7.Location = New System.Drawing.Point(519, 276)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(332, 58)
        Me.GroupBox7.TabIndex = 10
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
        'btnNew_patient
        '
        Me.btnNew_patient.Location = New System.Drawing.Point(46, 512)
        Me.btnNew_patient.Name = "btnNew_patient"
        Me.btnNew_patient.Size = New System.Drawing.Size(124, 23)
        Me.btnNew_patient.TabIndex = 11
        Me.btnNew_patient.Text = "New Patient"
        Me.btnNew_patient.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(46, 339)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(883, 150)
        Me.DataGridView1.TabIndex = 12
        '
        'btnAdd_patient
        '
        Me.btnAdd_patient.Location = New System.Drawing.Point(176, 512)
        Me.btnAdd_patient.Name = "btnAdd_patient"
        Me.btnAdd_patient.Size = New System.Drawing.Size(112, 23)
        Me.btnAdd_patient.TabIndex = 13
        Me.btnAdd_patient.Text = "Add patient"
        Me.btnAdd_patient.UseVisualStyleBackColor = True
        '
        'btnUpdate_patient
        '
        Me.btnUpdate_patient.Location = New System.Drawing.Point(294, 512)
        Me.btnUpdate_patient.Name = "btnUpdate_patient"
        Me.btnUpdate_patient.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate_patient.TabIndex = 14
        Me.btnUpdate_patient.Text = "Update"
        Me.btnUpdate_patient.UseVisualStyleBackColor = True
        '
        'btndelete_patient
        '
        Me.btndelete_patient.Location = New System.Drawing.Point(375, 512)
        Me.btndelete_patient.Name = "btndelete_patient"
        Me.btndelete_patient.Size = New System.Drawing.Size(75, 23)
        Me.btndelete_patient.TabIndex = 15
        Me.btndelete_patient.Text = "Delete"
        Me.btndelete_patient.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.Location = New System.Drawing.Point(854, 512)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(75, 23)
        Me.btn_home.TabIndex = 16
        Me.btn_home.Text = "Home"
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'testTimer
        '
        Me.testTimer.AutoSize = True
        Me.testTimer.Location = New System.Drawing.Point(923, 9)
        Me.testTimer.Name = "testTimer"
        Me.testTimer.Size = New System.Drawing.Size(11, 16)
        Me.testTimer.TabIndex = 17
        Me.testTimer.Text = "-"
        '
        'managePatients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 556)
        Me.Controls.Add(Me.testTimer)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.btndelete_patient)
        Me.Controls.Add(Me.btnUpdate_patient)
        Me.Controls.Add(Me.btnAdd_patient)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnNew_patient)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.gb_gender_patient)
        Me.Controls.Add(Me.gb_address_patient)
        Me.Controls.Add(Me.gb_name_patient)
        Me.Controls.Add(Me.gb_patient_number)
        Me.Controls.Add(Me.Label1)
        Me.Name = "managePatients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "managePatients"
        Me.gb_patient_number.ResumeLayout(False)
        Me.gb_patient_number.PerformLayout()
        Me.gb_name_patient.ResumeLayout(False)
        Me.gb_name_patient.PerformLayout()
        Me.gb_address_patient.ResumeLayout(False)
        Me.gb_address_patient.PerformLayout()
        Me.gb_gender_patient.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gb_patient_number As GroupBox
    Friend WithEvents btnSearch_patient As Button
    Friend WithEvents txtpatient_id As TextBox
    Friend WithEvents gb_name_patient As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmi_patient As TextBox
    Friend WithEvents txtfirstname_patient As TextBox
    Friend WithEvents Txtlastname_patient As TextBox
    Friend WithEvents gb_address_patient As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtprovince_patient As TextBox
    Friend WithEvents txtmunicipality_patient As TextBox
    Friend WithEvents txtbarangay_patient As TextBox
    Friend WithEvents gb_gender_patient As GroupBox
    Friend WithEvents cmbgender_patient As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtcontactnumber_patient As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtage_patient As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents dtpbirthday_patient As DateTimePicker
    Friend WithEvents btnNew_patient As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd_patient As Button
    Friend WithEvents btnUpdate_patient As Button
    Friend WithEvents btndelete_patient As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents testTimer As Label
End Class
