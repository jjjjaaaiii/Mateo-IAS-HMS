Imports System.Drawing.Text

Public Class managePatients
    Public isactiveuser As Boolean
    Private timerValue As Integer = 0
    Private PreviousMousePosition As Point
    Private SensitivityThreshold As Integer = 500

    Private Sub btnUpdate_patient_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            Dim patientId As Integer = txtsearch_patient.Text
            Dim userId As Integer = txtuserid.Text
            Dim name As String = txtname_patient.Text
            Dim address As String = txtaddress_patient.Text
            Dim contact As Integer = txtcontact_patient.Text

            DataGridView1.DataSource = GetAllDataFromTable("tbl_patient")

            timerValue = 0
        Catch ex As Exception
            MessageBox.Show($"Error: {ex}")
        End Try

    End Sub

    Private Sub managePatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        DataGridView1.DataSource = GetAllDataFromTable("tbl_patient")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timerValue += 1
        If timerValue = 60 Then
            Dim frm As New Login()
            frm.Show()
            Me.Close()
        End If
        testTimer.Text = timerValue
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Dim frm As New patientDashboard
        frm.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            'retrieve value 
            txtsearch_patient.Text = selectedRow.Cells("patient_id").Value.ToString()
            txtuserid.Text = selectedRow.Cells("user_id").Value.ToString()
            txtname_patient.Text = selectedRow.Cells("patient_name").Value.ToString()
            txtaddress_patient.Text = selectedRow.Cells("patient_address").Value.ToString()
            txtcontact_patient.Text = selectedRow.Cells("patient_contact").Value.ToString()

        End If
    End Sub

    Private Sub managePatients_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        timerValue = 0
    End Sub

    Private Sub btnSearch_patient_Click(sender As Object, e As EventArgs) Handles btnSearch_patient.Click
        timerValue = 0
    End Sub
End Class