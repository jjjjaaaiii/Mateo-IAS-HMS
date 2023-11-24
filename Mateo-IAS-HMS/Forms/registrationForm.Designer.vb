<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registrationForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtregistername = New System.Windows.Forms.TextBox()
        Me.txtregisterpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtregistrationrole = New System.Windows.Forms.ComboBox()
        Me.btnsignUp = New System.Windows.Forms.Button()
        Me.lblcapslockIndicator = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.passwordEye = New System.Windows.Forms.PictureBox()
        Me.lblsignIN = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.passwordEye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(473, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME!"
        '
        'txtregistername
        '
        Me.txtregistername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtregistername.Location = New System.Drawing.Point(480, 115)
        Me.txtregistername.Name = "txtregistername"
        Me.txtregistername.Size = New System.Drawing.Size(240, 32)
        Me.txtregistername.TabIndex = 1
        '
        'txtregisterpassword
        '
        Me.txtregisterpassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtregisterpassword.Location = New System.Drawing.Point(480, 258)
        Me.txtregisterpassword.Name = "txtregisterpassword"
        Me.txtregisterpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtregisterpassword.Size = New System.Drawing.Size(240, 32)
        Me.txtregisterpassword.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(389, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(389, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Role"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(389, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Name"
        '
        'txtregistrationrole
        '
        Me.txtregistrationrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtregistrationrole.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtregistrationrole.FormattingEnabled = True
        Me.txtregistrationrole.Items.AddRange(New Object() {"Admin", "Doctor", "Patient"})
        Me.txtregistrationrole.Location = New System.Drawing.Point(480, 190)
        Me.txtregistrationrole.Name = "txtregistrationrole"
        Me.txtregistrationrole.Size = New System.Drawing.Size(240, 31)
        Me.txtregistrationrole.TabIndex = 9
        '
        'btnsignUp
        '
        Me.btnsignUp.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignUp.Location = New System.Drawing.Point(535, 334)
        Me.btnsignUp.Name = "btnsignUp"
        Me.btnsignUp.Size = New System.Drawing.Size(144, 34)
        Me.btnsignUp.TabIndex = 10
        Me.btnsignUp.Text = "Sign Up"
        Me.btnsignUp.UseVisualStyleBackColor = True
        '
        'lblcapslockIndicator
        '
        Me.lblcapslockIndicator.AutoSize = True
        Me.lblcapslockIndicator.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcapslockIndicator.Location = New System.Drawing.Point(516, 293)
        Me.lblcapslockIndicator.Name = "lblcapslockIndicator"
        Me.lblcapslockIndicator.Size = New System.Drawing.Size(173, 23)
        Me.lblcapslockIndicator.TabIndex = 11
        Me.lblcapslockIndicator.Text = "Caps Lock is ON!"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "close.png")
        Me.ImageList1.Images.SetKeyName(1, "view.png")
        '
        'passwordEye
        '
        Me.passwordEye.Location = New System.Drawing.Point(678, 258)
        Me.passwordEye.Name = "passwordEye"
        Me.passwordEye.Size = New System.Drawing.Size(42, 32)
        Me.passwordEye.TabIndex = 12
        Me.passwordEye.TabStop = False
        '
        'lblsignIN
        '
        Me.lblsignIN.AutoSize = True
        Me.lblsignIN.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsignIN.Location = New System.Drawing.Point(640, 410)
        Me.lblsignIN.Name = "lblsignIN"
        Me.lblsignIN.Size = New System.Drawing.Size(49, 17)
        Me.lblsignIN.TabIndex = 14
        Me.lblsignIN.Text = "Sign In"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(530, 410)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Already a User?"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(361, 452)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'registrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(809, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblsignIN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.passwordEye)
        Me.Controls.Add(Me.lblcapslockIndicator)
        Me.Controls.Add(Me.btnsignUp)
        Me.Controls.Add(Me.txtregistrationrole)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtregisterpassword)
        Me.Controls.Add(Me.txtregistername)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "registrationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registrationForm"
        CType(Me.passwordEye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtregistername As TextBox
    Friend WithEvents txtregisterpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtregistrationrole As ComboBox
    Friend WithEvents btnsignUp As Button
    Friend WithEvents lblcapslockIndicator As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents passwordEye As PictureBox
    Friend WithEvents lblsignIN As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
