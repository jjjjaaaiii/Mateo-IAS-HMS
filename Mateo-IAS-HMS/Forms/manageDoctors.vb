Public Class manageDoctors
    Private timerValue As Integer = 0
    Private PreviousMousePosition As Point
    Private SensitivityThreshold As Integer = 500
    Private Sub manageDoctors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        DataGridView1.DataSource = GetAllDataFromTable("tbl_doctor")

        If userData.role = "Patient" Then
            btn_update.Visible = False
        End If
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        GoBackToDashboard()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timerValue += 1
        If timerValue > 60 Then
            Timer1.Stop()
            MessageBox.Show("Timed out")
            Dim frm As New Login()
            frm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub manageDoctors_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        timerValue = 0
    End Sub

    Private Sub manageDoctors_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        timerValue = 0
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            timerValue = 0
            If e.RowIndex >= 0 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

                'retrieve value 
                txtsearch_doctor.Text = selectedRow.Cells("doctor_id").Value.ToString()
                txtuserid.Text = selectedRow.Cells("user_id").Value.ToString()
                txtname_doctor.Text = selectedRow.Cells("doctor_name").Value.ToString()
                txtaddress_doctor.Text = selectedRow.Cells("doctor_address").Value.ToString()
                txtcontact_doctor.Text = selectedRow.Cells("doctor_contact").Value.ToString()

            End If
        Catch ex As Exception
            MessageBox.Show("Blank cell not allowed")
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            timerValue = 0
            UpdateDoctorInfo(txtsearch_doctor.Text, txtname_doctor.Text, txtaddress_doctor.Text, txtcontact_doctor.Text)
            DataGridView1.DataSource = GetAllDataFromTable("tbl_doctor")
        Catch ex As Exception
            MessageBox.Show($"Error: {ex}")
        End Try
    End Sub

End Class