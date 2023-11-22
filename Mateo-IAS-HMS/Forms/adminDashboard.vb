Public Class adminDashboard
    Public Sub SwitchToForm(frm As Form)
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btn_activate_Click(sender As Object, e As EventArgs) Handles btn_activate.Click
        SwitchToForm(activateUser)
    End Sub

    Private Sub btn_audit_Click(sender As Object, e As EventArgs) Handles btn_audit.Click
        SwitchToForm(auditLog)
    End Sub

    Private Sub btn_managepayment_Click(sender As Object, e As EventArgs) Handles btn_managepayment.Click
        SwitchToForm(pay)
    End Sub

    Private Sub btn_manageappointment_Click(sender As Object, e As EventArgs) Handles btn_manageappointment.Click
        SwitchToForm(manageAppointments)
    End Sub

    Private Sub btn_managedoctor_Click(sender As Object, e As EventArgs) Handles btn_managedoctor.Click
        SwitchToForm(manageDoctors)
    End Sub

    Private Sub btn_manageuser_Click(sender As Object, e As EventArgs) Handles btn_manageuser.Click
        SwitchToForm(manageUsers)
    End Sub

    Private Sub btn_managepatient_Click(sender As Object, e As EventArgs) Handles btn_managepatient.Click
        SwitchToForm(managePatients)
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        SwitchToForm(Login)
    End Sub

    Private Sub btn_change_Click(sender As Object, e As EventArgs) Handles btn_change.Click
        SwitchToForm(manageUsers)
    End Sub

    Private Sub btn_backup_Click(sender As Object, e As EventArgs) Handles btn_backup.Click
        MessageBox.Show("WALAA PAAAA")
    End Sub

    Private Sub btn_restore_Click(sender As Object, e As EventArgs) Handles btn_restore.Click
        MessageBox.Show("WALAA PAAAA")
    End Sub

    Private Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class