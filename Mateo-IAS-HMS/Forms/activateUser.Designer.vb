<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class activateUser
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_activate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtuserrole = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtisactive = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.testTimer = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 215)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(776, 223)
        Me.DataGridView1.TabIndex = 0
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(12, 178)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(99, 31)
        Me.btn_clear.TabIndex = 1
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_activate
        '
        Me.btn_activate.Location = New System.Drawing.Point(117, 178)
        Me.btn_activate.Name = "btn_activate"
        Me.btn_activate.Size = New System.Drawing.Size(99, 31)
        Me.btn_activate.TabIndex = 2
        Me.btn_activate.Text = "Activate"
        Me.btn_activate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "User ID"
        '
        'txtuserid
        '
        Me.txtuserid.Location = New System.Drawing.Point(12, 29)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(126, 22)
        Me.txtuserid.TabIndex = 4
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(203, 29)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(126, 22)
        Me.txtusername.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(203, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Username"
        '
        'txtuserrole
        '
        Me.txtuserrole.Location = New System.Drawing.Point(366, 29)
        Me.txtuserrole.Name = "txtuserrole"
        Me.txtuserrole.Size = New System.Drawing.Size(126, 22)
        Me.txtuserrole.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(366, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Userrole"
        '
        'txtisactive
        '
        Me.txtisactive.Location = New System.Drawing.Point(538, 29)
        Me.txtisactive.Name = "txtisactive"
        Me.txtisactive.Size = New System.Drawing.Size(126, 22)
        Me.txtisactive.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(538, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Isactive"
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(689, 178)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(99, 31)
        Me.btnback.TabIndex = 11
        Me.btnback.Text = "go back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'testTimer
        '
        Me.testTimer.AutoSize = True
        Me.testTimer.Location = New System.Drawing.Point(777, 9)
        Me.testTimer.Name = "testTimer"
        Me.testTimer.Size = New System.Drawing.Size(11, 16)
        Me.testTimer.TabIndex = 12
        Me.testTimer.Text = "-"
        '
        'activateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.testTimer)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.txtisactive)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtuserrole)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtuserid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_activate)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "activateUser"
        Me.Text = "activateUser"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_activate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtuserid As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtuserrole As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtisactive As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnback As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents testTimer As Label
End Class
