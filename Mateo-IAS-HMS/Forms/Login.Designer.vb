<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtuseraccount = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblsignUp = New System.Windows.Forms.Label()
        Me.passwordEye = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblcapslockIndicator = New System.Windows.Forms.Label()
        CType(Me.passwordEye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(369, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LogIn"
        '
        'txtuseraccount
        '
        Me.txtuseraccount.Location = New System.Drawing.Point(304, 167)
        Me.txtuseraccount.Name = "txtuseraccount"
        Me.txtuseraccount.Size = New System.Drawing.Size(200, 22)
        Me.txtuseraccount.TabIndex = 1
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(304, 245)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(200, 22)
        Me.txtpassword.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(233, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(347, 318)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(104, 30)
        Me.btnLogIn.TabIndex = 5
        Me.btnLogIn.Text = "Login"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(301, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Doesn't have an account?"
        '
        'lblsignUp
        '
        Me.lblsignUp.AutoSize = True
        Me.lblsignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsignUp.Location = New System.Drawing.Point(468, 412)
        Me.lblsignUp.Name = "lblsignUp"
        Me.lblsignUp.Size = New System.Drawing.Size(55, 16)
        Me.lblsignUp.TabIndex = 7
        Me.lblsignUp.Text = "Sign Up"
        '
        'passwordEye
        '
        Me.passwordEye.Location = New System.Drawing.Point(471, 245)
        Me.passwordEye.Name = "passwordEye"
        Me.passwordEye.Size = New System.Drawing.Size(33, 22)
        Me.passwordEye.TabIndex = 8
        Me.passwordEye.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "close.png")
        Me.ImageList1.Images.SetKeyName(1, "view.png")
        '
        'lblcapslockIndicator
        '
        Me.lblcapslockIndicator.AutoSize = True
        Me.lblcapslockIndicator.Location = New System.Drawing.Point(341, 270)
        Me.lblcapslockIndicator.Name = "lblcapslockIndicator"
        Me.lblcapslockIndicator.Size = New System.Drawing.Size(110, 16)
        Me.lblcapslockIndicator.TabIndex = 9
        Me.lblcapslockIndicator.Text = "Caps Lock Is ON!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblcapslockIndicator)
        Me.Controls.Add(Me.passwordEye)
        Me.Controls.Add(Me.lblsignUp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtuseraccount)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.passwordEye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtuseraccount As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogIn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblsignUp As Label
    Friend WithEvents passwordEye As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lblcapslockIndicator As Label
End Class
