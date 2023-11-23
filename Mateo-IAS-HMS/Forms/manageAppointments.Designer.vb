<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manageAppointments
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtdoctorid = New System.Windows.Forms.TextBox()
        Me.txtreason = New System.Windows.Forms.TextBox()
        Me.txtpatientid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnappoint = New System.Windows.Forms.Button()
        Me.btnapprove = New System.Windows.Forms.Button()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Doctor Appointments"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(545, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Appointment's ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Patient ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(234, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Reason"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Doctor's ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(64, 235)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(665, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(145, 404)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 6
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(226, 404)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 7
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnhome
        '
        Me.btnhome.Location = New System.Drawing.Point(654, 404)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(75, 23)
        Me.btnhome.TabIndex = 8
        Me.btnhome.Text = "Home"
        Me.btnhome.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(548, 54)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 22)
        Me.txt_id.TabIndex = 9
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(654, 53)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 10
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtdoctorid
        '
        Me.txtdoctorid.Location = New System.Drawing.Point(64, 182)
        Me.txtdoctorid.Name = "txtdoctorid"
        Me.txtdoctorid.Size = New System.Drawing.Size(156, 22)
        Me.txtdoctorid.TabIndex = 11
        '
        'txtreason
        '
        Me.txtreason.Location = New System.Drawing.Point(237, 124)
        Me.txtreason.Name = "txtreason"
        Me.txtreason.Size = New System.Drawing.Size(223, 22)
        Me.txtreason.TabIndex = 12
        '
        'txtpatientid
        '
        Me.txtpatientid.Location = New System.Drawing.Point(64, 124)
        Me.txtpatientid.Name = "txtpatientid"
        Me.txtpatientid.Size = New System.Drawing.Size(156, 22)
        Me.txtpatientid.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(234, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Date"
        '
        'txtstatus
        '
        Me.txtstatus.Location = New System.Drawing.Point(477, 123)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(223, 22)
        Me.txtstatus.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(474, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Status"
        '
        'btnappoint
        '
        Me.btnappoint.Location = New System.Drawing.Point(64, 404)
        Me.btnappoint.Name = "btnappoint"
        Me.btnappoint.Size = New System.Drawing.Size(75, 23)
        Me.btnappoint.TabIndex = 18
        Me.btnappoint.Text = "Appoint"
        Me.btnappoint.UseVisualStyleBackColor = True
        '
        'btnapprove
        '
        Me.btnapprove.Location = New System.Drawing.Point(307, 404)
        Me.btnapprove.Name = "btnapprove"
        Me.btnapprove.Size = New System.Drawing.Size(75, 23)
        Me.btnapprove.TabIndex = 19
        Me.btnapprove.Text = "Approve"
        Me.btnapprove.UseVisualStyleBackColor = True
        '
        'dtpdate
        '
        Me.dtpdate.Location = New System.Drawing.Point(237, 182)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(223, 22)
        Me.dtpdate.TabIndex = 21
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'manageAppointments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.btnapprove)
        Me.Controls.Add(Me.btnappoint)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtpatientid)
        Me.Controls.Add(Me.txtreason)
        Me.Controls.Add(Me.txtdoctorid)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "manageAppointments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "doctorsAppointment"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnhome As Button
    Friend WithEvents txt_id As TextBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtdoctorid As TextBox
    Friend WithEvents txtreason As TextBox
    Friend WithEvents txtpatientid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtstatus As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnappoint As Button
    Friend WithEvents btnapprove As Button
    Friend WithEvents dtpdate As DateTimePicker
    Friend WithEvents Timer1 As Timer
End Class
