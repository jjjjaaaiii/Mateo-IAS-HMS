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
        CType(Me.passwordEye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(267, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registration "
        '
        'txtregistername
        '
        Me.txtregistername.Location = New System.Drawing.Point(230, 115)
        Me.txtregistername.Name = "txtregistername"
        Me.txtregistername.Size = New System.Drawing.Size(196, 22)
        Me.txtregistername.TabIndex = 1
        '
        'txtregisterpassword
        '
        Me.txtregisterpassword.Location = New System.Drawing.Point(230, 270)
        Me.txtregisterpassword.Name = "txtregisterpassword"
        Me.txtregisterpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtregisterpassword.Size = New System.Drawing.Size(196, 22)
        Me.txtregisterpassword.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(164, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Role"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(156, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Name"
        '
        'txtregistrationrole
        '
        Me.txtregistrationrole.FormattingEnabled = True
        Me.txtregistrationrole.Items.AddRange(New Object() {"Admin", "Doctor", "Patient"})
        Me.txtregistrationrole.Location = New System.Drawing.Point(230, 202)
        Me.txtregistrationrole.Name = "txtregistrationrole"
        Me.txtregistrationrole.Size = New System.Drawing.Size(196, 24)
        Me.txtregistrationrole.TabIndex = 9
        '
        'btnsignUp
        '
        Me.btnsignUp.Location = New System.Drawing.Point(282, 328)
        Me.btnsignUp.Name = "btnsignUp"
        Me.btnsignUp.Size = New System.Drawing.Size(77, 28)
        Me.btnsignUp.TabIndex = 10
        Me.btnsignUp.Text = "Sign Up"
        Me.btnsignUp.UseVisualStyleBackColor = True
        '
        'lblcapslockIndicator
        '
        Me.lblcapslockIndicator.AutoSize = True
        Me.lblcapslockIndicator.Location = New System.Drawing.Point(279, 295)
        Me.lblcapslockIndicator.Name = "lblcapslockIndicator"
        Me.lblcapslockIndicator.Size = New System.Drawing.Size(110, 16)
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
        Me.passwordEye.Location = New System.Drawing.Point(396, 270)
        Me.passwordEye.Name = "passwordEye"
        Me.passwordEye.Size = New System.Drawing.Size(33, 22)
        Me.passwordEye.TabIndex = 12
        Me.passwordEye.TabStop = False
        '
        'lblsignIN
        '
        Me.lblsignIN.AutoSize = True
        Me.lblsignIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsignIN.Location = New System.Drawing.Point(355, 411)
        Me.lblsignIN.Name = "lblsignIN"
        Me.lblsignIN.Size = New System.Drawing.Size(47, 16)
        Me.lblsignIN.TabIndex = 14
        Me.lblsignIN.Text = "Sign In"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(245, 411)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Already a User?"
        '
        'registrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        Me.KeyPreview = True
        Me.Name = "registrationForm"
        Me.Text = "registrationForm"
        CType(Me.passwordEye, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
