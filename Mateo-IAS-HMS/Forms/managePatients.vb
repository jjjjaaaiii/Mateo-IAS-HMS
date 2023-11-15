Imports System.Drawing.Text

Public Class managePatients
    Public isactiveuser As Boolean
    Private timerValue As Integer = 0
    Private PreviousMousePosition As Point
    Private SensitivityThreshold As Integer = 500
    Private Sub btndelete_patient_Click(sender As Object, e As EventArgs) Handles btndelete_patient.Click
        Dim patientID As String = txtpatient_id.Text
        Dim patientIDInt As Integer

        If Integer.TryParse(patientID, patientIDInt) = False Then
            MessageBox.Show("COnversion of Int patientID failed")
        Else
            DeletePatient("tbl_patient", "patientID", patientIDInt)

            disableTxtBoxes()
            clearTxtBoxes()
            DataGridView1.DataSource = GetAllDataFromTable("tbl_patient")
        End If
    End Sub



    Private Sub disableTxtBoxes()
        txtpatient_id.Text = False
        txtfirstname_patient.Text = False
        Txtlastname_patient.Text = False
        txtmi_patient.Text = False
        txtbarangay_patient.Text = False
        txtmunicipality_patient.Text = False
        txtprovince_patient.Text = False
        txtcontactnumber_patient.Text = False
        txtage_patient.Text = False
        dtpbirthday_patient.Text = False
    End Sub

    Private Sub clearTxtBoxes()
        txtpatient_id.Text = False
        txtfirstname_patient.Text = False
        Txtlastname_patient.Text = False
        txtmi_patient.Text = False
        txtbarangay_patient.Text = False
        txtmunicipality_patient.Text = False
        txtprovince_patient.Text = False
        txtcontactnumber_patient.Text = False
        txtage_patient.Text = False
        dtpbirthday_patient.Text = False
    End Sub

    Private Sub managePatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Dim frm As New informationSystem
        frm.Show()
        Me.Close()
    End Sub
End Class