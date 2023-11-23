Public Class manageUsers
    Public userName As String
    Public userRoleText As String
    Private userID As Integer
    Private timerValue As Integer = 0
    Private PreviousMousePosition As Point
    Private SensitivityThreshold As Integer = 500


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timerValue += 1
        If timerValue = 60 Then
            Dim frm As New Login()
            frm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub manageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        DataGridView1.DataSource = GetAllDataFromTable("tbl_user")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GoBackToDashboard()
        Me.Close()
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Try
            timerValue = 0

            If txtusername.Text <> userData.username And IsUserAlreadyExists(txtusername.Text) = False Then
                MessageBox.Show("Username already taken!")
            ElseIf VerifyPassword(txt_password.Text) = False And txt_password.Text.Length > 0 Then
                MessageBox.Show("Password must at least have one capital letter, one small letter, one number and either of these special characters ?!_")
            Else
                Dim md5Hash As String = CalculateMD5Hash(txt_password.Text)
                registerUser(txtusername.Text, md5Hash, txt_role.Text, 0)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex}")
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            timerValue = 0
            If txtusername.Text <> userData.username And IsUserAlreadyExists(txtusername.Text) = False Then
                MessageBox.Show("Username already taken!")
            ElseIf txt_password.Text = "" Then
                UpdateUsername(txt_id.Text, txtusername.Text)
            ElseIf VerifyPassword(txt_password.Text) = False And txt_password.Text.Length > 0 Then
                MessageBox.Show("Password must at least have one capital letter, one small letter, one number and either of these special characters ?!_")
            Else
                Dim md5Hash As String = CalculateMD5Hash(txt_password.Text)
                UpdateUserCredentials(txt_id.Text, txtusername.Text, md5Hash)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex}")
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            timerValue = 0
            If e.RowIndex >= 0 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

                'retrieve value 
                txt_id.Text = selectedRow.Cells("id").Value.ToString()
                txtusername.Text = selectedRow.Cells("username").Value.ToString()
                txt_password.Text = selectedRow.Cells("password").Value.ToString()
                txtactive.Text = selectedRow.Cells("isactive").Value.ToString()
                txt_role.Text = selectedRow.Cells("userrole").Value.ToString()

            End If
        Catch ex As Exception
            MessageBox.Show("Blank cell not allowed")
        End Try
    End Sub
End Class