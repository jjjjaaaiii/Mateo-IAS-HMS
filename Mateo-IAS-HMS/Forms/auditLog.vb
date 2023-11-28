Public Class auditLog
    Private timerValue As Integer = 0
    Private PreviousMousePosition As Point
    Private SensitivityThreshold As Integer = 500
    Private Sub auditLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = GetAllDataFromTable("tbl_audit")
    End Sub
    ' uwu
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
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

    Private Sub btnsearch_audit_Click(sender As Object, e As EventArgs) Handles btnsearch_audit.Click
        timerValue = 0
        Try
            DataGridView1.DataSource = GetDataByPrimaryKey("tbl_audit", txtaudit_id.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class
