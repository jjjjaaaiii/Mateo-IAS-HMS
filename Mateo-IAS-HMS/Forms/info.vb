Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.VisualBasic.ApplicationServices

Public Class info
    Private Sub info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        txtuserid.Text = userData.id
        txtusername.Text = userData.username
        txtrole.Text = userData.role
        txtroleid.Text = userData.roleId
        txtrolename.Text = userData.roleName

        Dim result As Tuple(Of String, String) = GetUserContactAndAddressByRole(userData.id, userData.role)

        Dim contact As String = result.Item1
        Dim address As String = result.Item2

        txtcontact.Text = contact
        txtaddress.Text = address
        capslockindicator()
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        GoBackToDashboard()
        Me.Close()
    End Sub

    Private Sub btnupdateuser_Click(sender As Object, e As EventArgs) Handles btnupdateuser.Click
        Try

            If txtusername.Text <> userData.username And IsUserAlreadyExists(txtusername.Text) Then
                MessageBox.Show("Username already taken!")
            ElseIf txtpassword.Text = "" Then
                UpdateUsername(txtuserid.Text, txtusername.Text)
            ElseIf VerifyPassword(txtpassword.Text) = False And txtpassword.Text.Length > 0 Then
                MessageBox.Show("Password must at least have one capital letter, one small letter, one number and either of these special characters ?!_")
            Else
                Dim md5Hash As String = CalculateMD5Hash(txtpassword.Text)
                UpdateUserCredentials(txtuserid.Text, txtusername.Text, md5Hash)
                userData.username = txtusername.Text
                InsertAuditRecord(txtuserid.Text, "Updated their account credentials")

            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex}")
        End Try
    End Sub

    Private Sub btnupdaterole_Click(sender As Object, e As EventArgs) Handles btnupdaterole.Click
        Try
            UpdateUserInfo(txtuserid.Text, userData.role, txtrolename.Text, txtaddress.Text, txtcontact.Text)
            userData.roleName = txtrolename.Text

            InsertAuditRecord(txtuserid.Text, "Updated their info")
        Catch ex As Exception
            MessageBox.Show($"Error: {ex}")
        End Try
    End Sub

    Dim timerValue As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timerValue += 1

        If (timerValue > 60) Then
            Timer1.Stop()
            MessageBox.Show("timed out")
            Dim frm As New Login
            frm.Show()
            Me.Close()
        End If
    End Sub
End Class