<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class info
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(info))
        Me.randomasslabel = New System.Windows.Forms.Label()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtrolename = New System.Windows.Forms.TextBox()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.btnupdaterole = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtroleid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtrole = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.btnupdateuser = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'randomasslabel
        '
        Me.randomasslabel.AutoSize = True
        Me.randomasslabel.BackColor = System.Drawing.Color.Transparent
        Me.randomasslabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.randomasslabel.ForeColor = System.Drawing.SystemColors.Control
        Me.randomasslabel.Location = New System.Drawing.Point(37, 61)
        Me.randomasslabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.randomasslabel.Name = "randomasslabel"
        Me.randomasslabel.Size = New System.Drawing.Size(76, 23)
        Me.randomasslabel.TabIndex = 47
        Me.randomasslabel.Text = "User ID"
        '
        'txtuserid
        '
        Me.txtuserid.Enabled = False
        Me.txtuserid.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuserid.Location = New System.Drawing.Point(38, 85)
        Me.txtuserid.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(118, 32)
        Me.txtuserid.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(30, 347)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 23)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Contact"
        '
        'txtcontact
        '
        Me.txtcontact.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontact.Location = New System.Drawing.Point(34, 375)
        Me.txtcontact.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(246, 32)
        Me.txtcontact.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(300, 347)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 23)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(302, 269)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Role Name"
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(306, 375)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(318, 32)
        Me.txtaddress.TabIndex = 41
        '
        'txtrolename
        '
        Me.txtrolename.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrolename.Location = New System.Drawing.Point(304, 296)
        Me.txtrolename.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtrolename.Name = "txtrolename"
        Me.txtrolename.Size = New System.Drawing.Size(318, 32)
        Me.txtrolename.TabIndex = 42
        '
        'btn_home
        '
        Me.btn_home.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.Location = New System.Drawing.Point(777, 424)
        Me.btn_home.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(119, 39)
        Me.btn_home.TabIndex = 39
        Me.btn_home.Text = "Home"
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'btnupdaterole
        '
        Me.btnupdaterole.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdaterole.Location = New System.Drawing.Point(34, 424)
        Me.btnupdaterole.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnupdaterole.Name = "btnupdaterole"
        Me.btnupdaterole.Size = New System.Drawing.Size(152, 39)
        Me.btnupdaterole.TabIndex = 38
        Me.btnupdaterole.Text = "Update"
        Me.btnupdaterole.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(174, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 23)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Username"
        '
        'txtroleid
        '
        Me.txtroleid.Enabled = False
        Me.txtroleid.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtroleid.Location = New System.Drawing.Point(38, 296)
        Me.txtroleid.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtroleid.Name = "txtroleid"
        Me.txtroleid.Size = New System.Drawing.Size(250, 32)
        Me.txtroleid.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(650, 61)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 23)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Password"
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(654, 85)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(246, 32)
        Me.txtpassword.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(434, 61)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 23)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Role"
        '
        'txtrole
        '
        Me.txtrole.Enabled = False
        Me.txtrole.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrole.Location = New System.Drawing.Point(438, 85)
        Me.txtrole.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtrole.Name = "txtrole"
        Me.txtrole.Size = New System.Drawing.Size(188, 32)
        Me.txtrole.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(34, 269)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 23)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Role ID"
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(176, 85)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(246, 32)
        Me.txtusername.TabIndex = 56
        '
        'btnupdateuser
        '
        Me.btnupdateuser.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdateuser.Location = New System.Drawing.Point(38, 136)
        Me.btnupdateuser.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnupdateuser.Name = "btnupdateuser"
        Me.btnupdateuser.Size = New System.Drawing.Size(118, 34)
        Me.btnupdateuser.TabIndex = 58
        Me.btnupdateuser.Text = "Update"
        Me.btnupdateuser.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(924, 485)
        Me.Controls.Add(Me.btnupdateuser)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtrole)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtroleid)
        Me.Controls.Add(Me.randomasslabel)
        Me.Controls.Add(Me.txtuserid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtrolename)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.btnupdaterole)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents randomasslabel As Label
    Friend WithEvents txtuserid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtrolename As TextBox
    Friend WithEvents btn_home As Button
    Friend WithEvents btnupdaterole As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtroleid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtrole As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents btnupdateuser As Button
    Friend WithEvents Timer1 As Timer
End Class
