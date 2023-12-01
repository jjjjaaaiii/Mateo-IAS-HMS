Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Login

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
            Dim role As String = GetUserRole(userId)
            Dim roleId As Integer = GetIdByUserIdAndRole(userId, role)
            Dim roleName As String = GetNameByUserIdAndRole(userId, role)

            userData.id = userId
            userData.username = Uaccount
            userData.role = role
            userData.roleId = roleId
            userData.roleName = roleName

            InsertAuditRecord(userId, "Logged In")

            GoBackToDashboard()
            Me.Close()

            Me.Close()
        Else
            attempts += 1
            Dim attemptMessage = String.Format("Wrong password! You have {0} attempt/s left.", (3 - attempts))
            MessageBox.Show(attemptMessage)
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

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
    End Sub

    Private Sub Login_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Label5.ForeColor = Color.Blue
    End Sub

    Private Sub Login_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Label5.ForeColor = SystemColors.ControlText
    End Sub
End Class
