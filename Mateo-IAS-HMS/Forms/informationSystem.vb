Imports Org.BouncyCastle.Pqc.Crypto.Frodo

Public Class informationSystem
    Public userName As String
    Public userRoleText As String
    Private userID As Integer
    Private timerValue As Integer = 0
    Private PreviousMousePosition As Point
    Private SensitivityThreshold As Integer = 500
    Private Sub informationSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userID = GetUserId(userName)
        userRoleText = GetUserRole(userID)
        currentUser.Text = userName
        userRole.Text = userRoleText
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timerValue += 1
        If timerValue = 60 Then
            Dim frm As New Form1()
            frm.Show()
            Me.Close()
        End If
        testTimer.Text = timerValue
        dateAndTime.Text = DateTime.Now.ToString()
    End Sub



    Private Sub ManageUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUsersToolStripMenuItem.Click
        Dim frm As New manageUsers
        frm.Show()
        Me.Close()
    End Sub

    Private Sub ManagePatientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagePatientsToolStripMenuItem.Click
        Dim frm As New managePatients
        frm.Show()
        Me.Close()
    End Sub

    Private Sub DoctorAppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoctorAppointmentToolStripMenuItem.Click
        Dim frm As New doctorsAppointment
        frm.Show()
        Me.Close()
    End Sub

    Private Sub BookAppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookAppointmentToolStripMenuItem.Click
        Dim frm As New bookAppointment
        frm.Show()
        Me.Close()
    End Sub

    Private Sub AuditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuditToolStripMenuItem.Click
        Dim frm As New auditLog
        frm.Show()
        Me.Close()
    End Sub

    Private Sub ActivateUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivateUserToolStripMenuItem.Click
        Dim frm As New activateUser
        frm.Show()
        Me.Close()
    End Sub

    Private Sub LogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem.Click
        Dim frm As New Form1
        frm.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class