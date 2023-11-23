Public Class doctorDashboard
    Dim timervalue As Integer = 0
    Public Sub SwitchToForm(frm As Form)
        frm.Show()
        Me.Close()
    End Sub

    Private Sub doctorDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        currentUser.Text = userData.username
        userRole.Text = userData.role
        dateAndTime.Text = DateTime.Now
        doctorid.Text = userData.roleId
        doctorname.Text = userData.roleName
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

    Private Sub btn_managepayment_Click(sender As Object, e As EventArgs) Handles btn_managepayment.Click
        SwitchToForm(pay)
    End Sub

    Private Sub btn_manageappointment_Click(sender As Object, e As EventArgs) Handles btn_manageappointment.Click
        SwitchToForm(manageAppointments)
    End Sub

    Private Sub btn_change_Click(sender As Object, e As EventArgs) Handles btn_change.Click
        SwitchToForm(info)
    End Sub

    Private Sub btn_audit_Click(sender As Object, e As EventArgs) Handles btn_audit.Click
        SwitchToForm(auditLog)
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        SwitchToForm(Login)
    End Sub

    Private Sub btn_viewdoctor_Click(sender As Object, e As EventArgs) Handles btn_viewdoctor.Click
        SwitchToForm(manageDoctors)
    End Sub

    Private Sub btn_managepatient_Click(sender As Object, e As EventArgs) Handles btn_managepatient.Click
        SwitchToForm(managePatients)
    End Sub
End Class