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
        Me.txtsearch_patient = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.testTimer = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcontact_patient = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtaddress_patient = New System.Windows.Forms.TextBox()
        Me.txtname_patient = New System.Windows.Forms.TextBox()
        Me.gb_patient_number.SuspendLayout()
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
        Me.gb_patient_number.Controls.Add(Me.txtsearch_patient)
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
        'txtsearch_patient
        '
        Me.txtsearch_patient.Location = New System.Drawing.Point(16, 21)
        Me.txtsearch_patient.Name = "txtsearch_patient"
        Me.txtsearch_patient.Size = New System.Drawing.Size(121, 22)
        Me.txtsearch_patient.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(46, 240)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(883, 150)
        Me.DataGridView1.TabIndex = 12
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(46, 418)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 14
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.Location = New System.Drawing.Point(854, 418)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Contact"
        '
        'txtcontact_patient
        '
        Me.txtcontact_patient.Location = New System.Drawing.Point(46, 187)
        Me.txtcontact_patient.Name = "txtcontact_patient"
        Me.txtcontact_patient.Size = New System.Drawing.Size(247, 22)
        Me.txtcontact_patient.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(311, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Name"
        '
        'txtaddress_patient
        '
        Me.txtaddress_patient.Location = New System.Drawing.Point(311, 113)
        Me.txtaddress_patient.Name = "txtaddress_patient"
        Me.txtaddress_patient.Size = New System.Drawing.Size(250, 22)
        Me.txtaddress_patient.TabIndex = 30
        '
        'txtname_patient
        '
        Me.txtname_patient.Location = New System.Drawing.Point(46, 112)
        Me.txtname_patient.Name = "txtname_patient"
        Me.txtname_patient.Size = New System.Drawing.Size(250, 22)
        Me.txtname_patient.TabIndex = 31
        '
        'managePatients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 459)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcontact_patient)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtaddress_patient)
        Me.Controls.Add(Me.txtname_patient)
        Me.Controls.Add(Me.testTimer)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.gb_patient_number)
        Me.Controls.Add(Me.Label1)
        Me.Name = "managePatients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "managePatients"
        Me.gb_patient_number.ResumeLayout(False)
        Me.gb_patient_number.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gb_patient_number As GroupBox
    Friend WithEvents btnSearch_patient As Button
    Friend WithEvents txtsearch_patient As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnupdate As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents testTimer As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcontact_patient As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtaddress_patient As TextBox
    Friend WithEvents txtname_patient As TextBox
End Class
