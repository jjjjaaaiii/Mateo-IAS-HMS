Public Class manageUsers
    Public userName As String
    Public userRoleText As String
    Private userID As Integer
    Private timerValue As Integer = 0
    Private PreviousMousePosition As Point
    Private SensitivityThreshold As Integer = 500


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timerValue += 1
        If timerValue = 60 Then
            Dim frm As New Form1()
            frm.Show()
            Me.Close()
        End If
        testTimer.Text = timerValue
    End Sub

    Private Sub manageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

End Class