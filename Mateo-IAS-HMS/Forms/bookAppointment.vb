Public Class bookAppointment
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GoBackToDashboard()
        Me.Close()
    End Sub

    Private Sub bookAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = GetAppointmentsByPatientId(userData.roleId)
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Try
            timervalue = 0
            InsertAppointment(txtpatientid.Text, txtdoctorid.Text, txtreason.Text)
            DataGridView1.DataSource = GetAppointmentsByPatientId(userData.roleId)
        Catch ex As Exception
            MessageBox.Show($"Error: {ex}")
        End Try
    End Sub

    Dim timervalue As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timerValue += 1
        If timerValue = 60 Then
            Timer1.Stop()
            MessageBox.Show("Timed out")
            Dim frm As New Login()
            frm.Show()
            Me.Close()
        End If
    End Sub
End Class