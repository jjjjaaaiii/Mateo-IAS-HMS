Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Form1

    Public passwordHide As Boolean = True
    Private attempts As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passwordEye.Image = ImageList1.Images(0)
        capslockindicator()
    End Sub
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim Uaccount As String = txtuseraccount.Text
        Dim Upassword As String = txtpassword.Text
        Dim md5Hash As String = CalculateMD5Hash(Upassword)

        If attempts >= 3 Then
            MessageBox.Show("Locked! You Already attempted 3 times!")
        ElseIf IsActiveUser(Uaccount) = False Then
            MessageBox.Show("Request approval to admin!")
        ElseIf ValidateUser(Uaccount, md5Hash) Then
            MessageBox.Show("You are now logged in!")
            Dim userId As Integer = GetUserId(Uaccount)
            InsertAuditRecord(userId, "Logged In")
            Dim frm As New informationSystem
            frm.isactiveuser = IsActiveUser(Uaccount)
            frm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub passwordEye_Click(sender As Object, e As EventArgs) Handles passwordEye.Click
        If passwordHide Then
            passwordEye.Image = ImageList1.Images(1)
            passwordHide = False
            txtpassword.PasswordChar = ""
        Else
            passwordEye.Image = ImageList1.Images(0)
            passwordHide = True
            txtpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub capslockindicator()
        If My.Computer.Keyboard.CapsLock Then
            lblcapslockIndicator.Visible = True
        Else
            lblcapslockIndicator.Visible = False
        End If
    End Sub

    Private Sub lblsignUp_Click(sender As Object, e As EventArgs) Handles lblsignUp.Click
        Dim frm As New registrationForm()
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        capslockindicator()
    End Sub
End Class
