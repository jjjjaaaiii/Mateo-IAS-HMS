Public Class auditLog
    Private Sub auditLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = GetAllDataFromTable("tbl_audit")
    End Sub
    ' uwu
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        GoBackToDashboard()
        Me.Close()
    End Sub
End Class
