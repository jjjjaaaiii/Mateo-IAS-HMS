Imports System.Security.Principal
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Org.BouncyCastle.Pqc.Crypto.Frodo

Public Class patientDashboard
    Private timerValue As Integer = 0
    Private PreviousMousePosition As Point
    Private SensitivityThreshold As Integer = 500
    Private Sub informationSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentUser.Text = userData.username
        userRole.Text = userData.role
        Timer1.Start()
    End Sub

    Public Sub SwitchToForm(frm As Form)
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timerValue += 1
        If timerValue > 60 Then
            Timer1.Stop()
            MessageBox.Show("Timed out")
            SwitchToForm(Login)
            Me.Close()
        End If
        dateAndTime.Text = DateTime.Now.ToString()
    End Sub

    Private Sub informationSystem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        timerValue = 0
    End Sub

    Private Sub informationSystem_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        timerValue = 0
    End Sub

    Private Sub btn_book_Click(sender As Object, e As EventArgs) Handles btn_book.Click
        SwitchToForm(bookAppointment)
    End Sub

    Private Sub btn_pay_Click(sender As Object, e As EventArgs) Handles btn_pay.Click
        SwitchToForm(pay)
    End Sub

    Private Sub btn_viewappoint_Click(sender As Object, e As EventArgs) Handles btn_viewappoint.Click
        SwitchToForm(manageAppointments)
    End Sub

    Private Sub btn_change_Click(sender As Object, e As EventArgs) Handles btn_change.Click
        SwitchToForm(info)
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        SwitchToForm(Login)
    End Sub

    Private Sub btn_viewdoctor_Click(sender As Object, e As EventArgs) Handles btn_viewdoctor.Click
        SwitchToForm(manageDoctors)
    End Sub
End Class