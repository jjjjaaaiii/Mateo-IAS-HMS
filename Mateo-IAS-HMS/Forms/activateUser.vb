Public Class activateUser
    Public isactiveuser As Boolean
    Private timerValue As Integer = 0
    Private PreviousMousePosition As Point
    Private SensitivityThreshold As Integer = 500
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Populate the textboxes with data from the selected row
            txtuserid.Text = selectedRow.Cells("id").Value.ToString()
            txtusername.Text = selectedRow.Cells("username").Value.ToString()
            txtuserrole.Text = selectedRow.Cells("userrole").Value.ToString()
            txtisactive.Text = selectedRow.Cells("isactive").Value.ToString()
        End If
    End Sub

    Private Sub activateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = GetInactiveUserData()
        Timer1.Start()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txtuserid.Text = ""
        txtusername.Text = ""
        txtuserrole.Text = ""
        txtisactive.Text = ""
    End Sub

    Private Sub btn_activate_Click(sender As Object, e As EventArgs) Handles btn_activate.Click
        Try
            Dim userId As Integer = txtuserid.Text
            ActivateSelectedUser(userId)
            DataGridView1.DataSource = GetInactiveUserData()

            Dim userRole As String = GetUserRole(userId)

            If userRole = "Admin" Then
                registerUserAdmin(userId)
            ElseIf userRole = "Doctor" Then
                registerUserDoctor(userId)
            ElseIf userRole = "Patient" Then
                registerUserPatient(userId)
            End If
        Catch ex As Exception
            MessageBox.Show("Data insufficient")
        End Try
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim frm As New patientDashboard
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timerValue += 1
        If timerValue = 60 Then
            Dim frm As New Login()
            frm.Show()
            Me.Close()
        End If
        testTimer.Text = timerValue
    End Sub

    Private Sub activateUser_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        timerValue = 0
    End Sub

    Private Sub activateUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        timerValue = 0
    End Sub
End Class