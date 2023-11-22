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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timerValue += 1
        If timerValue = 60 Then
            Timer1.Stop()
            MessageBox.Show("Timed out")
            Dim frm As New Login()
            frm.Show()
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
End Class