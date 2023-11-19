Public Class manageDoctors
    Private Sub manageDoctors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As New informationSystem
        frm.Show()
        Me.Close()
    End Sub
End Class