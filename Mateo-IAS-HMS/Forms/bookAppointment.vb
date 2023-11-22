Public Class bookAppointment
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New patientDashboard
        frm.Show()
        Me.Close()
    End Sub
End Class