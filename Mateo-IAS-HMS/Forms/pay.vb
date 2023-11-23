Public Class pay
    Private Sub pay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = GetPaymentsForAcceptedAppointments(userData.roleId)
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        GoBackToDashboard()
        Me.Close()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click

    End Sub

    Private Sub btnpay_Click(sender As Object, e As EventArgs) Handles btnpay.Click
        UpdatePaymentStatusToPaid(txt_id.Text)
        DataGridView1.DataSource = GetPaymentsForAcceptedAppointments(userData.roleId)
    End Sub
End Class