Imports System.Security.Principal

Public Class registrationForm

    Public passwordHide As Boolean = True


    Private Sub registrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passwordEye.Image = ImageList1.Images(0)
        capslockindicator()
    End Sub

    Private Sub capslockindicator()
        If My.Computer.Keyboard.CapsLock Then
            lblcapslockIndicator.Visible = True
        Else
            lblcapslockIndicator.Visible = False
        End If
    End Sub

    Private Sub passwordEye_Click(sender As Object, e As EventArgs) Handles passwordEye.Click
        If passwordHide Then
            passwordEye.Image = ImageList1.Images(1)
            passwordHide = False
            txtregisterpassword.PasswordChar = ""
        Else
            passwordEye.Image = ImageList1.Images(0)
            passwordHide = True
            txtregisterpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnsignUp_Click(sender As Object, e As EventArgs) Handles btnsignUp.Click
        Dim username As String = txtregistername.Text
        Dim userpassword As String = txtregisterpassword.Text
        Dim userrole As String = txtregistrationrole.Text
        Dim md5Hash As String = CalculateMD5Hash(userpassword)


        If IsUserAlreadyExists(username) Then
            MessageBox.Show("Username already taken!")
        ElseIf VerifyPassword(userpassword) = False Then
            MessageBox.Show("Password must at least have one capital letter, one small letter, one number and either of these special characters ?!_")
        Else
            registerUser(username, md5Hash, userrole, 0)
            Dim userId As Integer = GetUserId(username)
            InsertAuditRecord(userId, "Registered")
        End If
    End Sub

    Private Sub registrationForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        capslockindicator()
    End Sub

    Private Sub lblsignIN_Click(sender As Object, e As EventArgs) Handles lblsignIN.Click
        Dim frm As New Form1
        frm.Show()
        Me.Close()
    End Sub
End Class