Public Class pay
    Public isactiveuser As Boolean
    Private timerValue As Integer = 0
    Private PreviousMousePosition As Point
    Private SensitivityThreshold As Integer = 500
    Private Sub pay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        If (userData.role = "Patient") Then
            DataGridView1.DataSource = GetUnpaidPaymentsForSpecificPatient(userData.roleId)
        Else
            DataGridView1.DataSource = GetAllDataFromTable("tbl_pay")
        End If
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        GoBackToDashboard()
        Me.Close()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click

    End Sub

    Private Sub btnpay_Click(sender As Object, e As EventArgs) Handles btnpay.Click
        UpdatePaymentStatusToPaid(txt_id.Text)
        If (userData.role = "Patient") Then
            DataGridView1.DataSource = GetUnpaidPaymentsForSpecificPatient(userData.roleId)
        Else
            DataGridView1.DataSource = GetAllDataFromTable("tbl_pay")
        End If
    End Sub

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

    Private Sub pay_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        timerValue = 0
    End Sub

    Private Sub pay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        timerValue = 0
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            timerValue = 0
            If e.RowIndex >= 0 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

                'retrieve value 
                txt_id.Text = selectedRow.Cells("pay_id").Value.ToString()
                txtappointmentid.Text = selectedRow.Cells("appointment_id").Value.ToString()
                txttotal.Text = selectedRow.Cells("pay_total").Value.ToString()
                txtstatus.Text = selectedRow.Cells("pay_status").Value.ToString()

            End If
        Catch ex As Exception
            MessageBox.Show("Blank cell not allowed")
        End Try
    End Sub
End Class