Public Class adminDashboard

    Dim timerValue As Integer = 0

    Private Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        currentUser.Text = userData.username
        userRole.Text = userData.role
        dateAndTime.Text = DateTime.Now
        adminid.Text = userData.roleId
        adminname.Text = userData.roleName

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timerValue += 1
        dateAndTime.Text = DateTime.Now

        If (timerValue > 60) Then
            Timer1.Stop()
            MessageBox.Show("timed out")
            SwitchToForm(Login)
            Me.Close()
        End If
    End Sub

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
        SwitchToForm(info)
    End Sub

    Private Sub btn_backup_Click(sender As Object, e As EventArgs) Handles btn_backup.Click
        MessageBox.Show("WALAA PAAAA")
    End Sub

    Private Sub btn_restore_Click(sender As Object, e As EventArgs) Handles btn_restore.Click
        MessageBox.Show("WALAA PAAAA")
    End Sub


End Class