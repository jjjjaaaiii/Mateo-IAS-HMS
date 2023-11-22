Public Class manageAppointments
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Dim frm As New patientDashboard
        frm.Show()
        Me.Close()
    End Sub
End Class