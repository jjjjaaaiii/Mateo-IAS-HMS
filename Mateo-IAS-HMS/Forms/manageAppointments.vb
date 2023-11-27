Public Class manageAppointments
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        GoBackToDashboard()
        Me.Close()
    End Sub

    Private Sub manageAppointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        If userData.role = "Patient" Then
            btnappoint.Visible = False
            btnupdate.Visible = False
            btndelete.Visible = False
            btnapprove.Visible = False
            DataGridView1.DataSource = GetAppointmentsByPatientId(userData.roleId)
        Else
            DataGridView1.DataSource = GetAllDataFromTable("tbl_appointment")
        End If

    End Sub

    Dim timervalue As Integer = 0
    Private Sub btnappoint_Click(sender As Object, e As EventArgs) Handles btnappoint.Click
        timervalue = 0
        InsertAppointment(txtpatientid.Text, txtdoctorid.Text, txtreason.Text)
        DataGridView1.DataSource = GetAllDataFromTable("tbl_appointment")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            timervalue = 0
            If e.RowIndex >= 0 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

                'retrieve value 
                txt_id.Text = selectedRow.Cells("appointment_id").Value.ToString()
                txtpatientid.Text = selectedRow.Cells("patient_id").Value.ToString()
                txtdoctorid.Text = selectedRow.Cells("doctor_id").Value.ToString()
                txtreason.Text = selectedRow.Cells("appointment_reason").Value.ToString()
                dtpdate.Text = selectedRow.Cells("appointment_date").Value.ToString()
                txtstatus.Text = selectedRow.Cells("appointment_status").Value.ToString()

            End If
        Catch ex As Exception
            MessageBox.Show("Blank cell not allowed")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timervalue += 1
        If timervalue = 60 Then
            Timer1.Stop()
            MessageBox.Show("Timed out")
            Dim frm As New Login()
            frm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            timervalue = 0
            UpdateAppointmentDetails(txt_id.Text, txtpatientid.Text, txtdoctorid.Text, txtreason.Text, dtpdate.Text)
            DataGridView1.DataSource = GetAllDataFromTable("tbl_appointment")
        Catch ex As Exception
            MessageBox.Show($"Error: {ex}")
        End Try
    End Sub

    Private Sub btnapprove_Click(sender As Object, e As EventArgs) Handles btnapprove.Click
        Try
            timervalue = 0

            AcceptAppointmentById(txt_id.Text)
            AddPaymentData(txt_id.Text, 500, "Unpaid")
            DataGridView1.DataSource = GetAllDataFromTable("tbl_appointment")

        Catch ex As Exception
            MessageBox.Show($"Error: {ex}")
        End Try

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            timervalue = 0

            DeleteAppointmentById(txt_id.Text)
            DataGridView1.DataSource = GetAllDataFromTable("tbl_appointment")

        Catch ex As Exception
            MessageBox.Show($"Error: {ex}")
        End Try

    End Sub
End Class