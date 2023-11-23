<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pay
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
        Me.btnpay = New System.Windows.Forms.Button()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtappointmentid = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnpay
        '
        Me.btnpay.Location = New System.Drawing.Point(39, 317)
        Me.btnpay.Name = "btnpay"
        Me.btnpay.Size = New System.Drawing.Size(75, 23)
        Me.btnpay.TabIndex = 39
        Me.btnpay.Text = "Pay"
        Me.btnpay.UseVisualStyleBackColor = True
        '
        'txtstatus
        '
        Me.txtstatus.Location = New System.Drawing.Point(452, 109)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(223, 22)
        Me.txtstatus.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(449, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Status"
        '
        'txtappointmentid
        '
        Me.txtappointmentid.Location = New System.Drawing.Point(39, 110)
        Me.txtappointmentid.Name = "txtappointmentid"
        Me.txtappointmentid.Size = New System.Drawing.Size(156, 22)
        Me.txtappointmentid.TabIndex = 33
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(212, 110)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(223, 22)
        Me.txttotal.TabIndex = 32
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(629, 39)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 30
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(523, 40)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 22)
        Me.txt_id.TabIndex = 29
        '
        'btnhome
        '
        Me.btnhome.Location = New System.Drawing.Point(629, 317)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(75, 23)
        Me.btnhome.TabIndex = 28
        Me.btnhome.Text = "Home"
        Me.btnhome.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(39, 152)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(665, 150)
        Me.DataGridView1.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(209, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Pay_total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(520, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Pay_ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Appointment's ID"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'pay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 382)
        Me.Controls.Add(Me.btnpay)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtappointmentid)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "pay"
        Me.Text = "pay"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnpay As Button
    Friend WithEvents txtstatus As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtappointmentid As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents txt_id As TextBox
    Friend WithEvents btnhome As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
End Class
