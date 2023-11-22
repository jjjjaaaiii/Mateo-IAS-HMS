Imports System.Drawing.Text

Public Class managePatients
    Public isactiveuser As Boolean
    Private timerValue As Integer = 0
    Private PreviousMousePosition As Point
    Private SensitivityThreshold As Integer = 500
    Private Sub btndelete_patient_Click(sender As Object, e As EventArgs)
        Dim patientID As String = txtsearch_patient.Text
        Dim patientIDInt As Integer

        If Integer.TryParse(patientID, patientIDInt) = False Then
            MessageBox.Show("COnversion of Int patientID failed")
        Else
            DeletePatient("tbl_patient", "patientID", patientIDInt)

            disableTxtBoxes()
            clearTxtBoxes()
            DataGridView1.DataSource = GetAllDataFromTable("tbl_patient")
        End If

        timerValue = 0
    End Sub

    Private Sub btnUpdate_patient_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim patientId As String = txtsearch_patient.Text
        Dim lastname As String = Txtlastname_patient.Text
        Dim firstname As String = txtfirstname_patient.Text
        Dim mi As String = txtmi_patient.Text
        Dim barangay As String = txtbarangay_patient.Text
        Dim municipality As String = txtmunicipality_patient.Text
        Dim province As String = txtprovince_patient.Text
        Dim contact As String = txtcontactnumber_patient.Text
        Dim age As String = txtage_patient.Text
        Dim birthday As String = dtpbirthday_patient.Text

        Dim patientIdInt As Integer

        If Integer.TryParse(patientId, patientIdInt) = False Then
            MessageBox.Show("Conversion of Int patientID failed")
        End If
        UpdatePatient(
        patientIdInt,
        lastname,
        firstname,
        mi,
        barangay,
        municipality,
        province,
        contact,
        age,
        birthday
        )

        disableTxtBoxes()
        clearTxtBoxes()
        DataGridView1.DataSource = GetAllDataFromTable("tbl_patient")

        timerValue = 0
    End Sub

    Private Sub btnAdd_patient_Click(sender As Object, e As EventArgs) 
        Dim userid As String = txtsearch_patient.Text
        Dim lastname As String = Txtlastname_patient.Text
        Dim firstname As String = txtfirstname_patient.Text
        Dim mi As String = txtmi_patient.Text
        Dim barangay As String = txtbarangay_patient.Text
        Dim municipality As String = txtmunicipality_patient.Text
        Dim province As String = txtprovince_patient.Text
        Dim contact As String = txtcontactnumber_patient.Text
        Dim age As String = txtage_patient.Text
        Dim birthday As String = dtpbirthday_patient.Text

        Dim useridInt As Integer

        If Integer.TryParse(userid, useridInt) = False Then
            MessageBox.Show("Conversion of Int userID failed")
        End If
        AddPatient(
        useridInt,
        lastname,
        firstname,
        mi,
        barangay,
        municipality,
        province,
        contact,
        age,
        birthday
        )

        disableTxtBoxes()
        clearTxtBoxes()
        DataGridView1.DataSource = GetAllDataFromTable("tbl_patient")


        timerValue = 0
    End Sub



    Private Sub managePatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        DataGridView1.DataSource = GetPatientRegistration()
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
            Dim id As Integer = selectedRow.Cells("patient_id").Value.ToString()
            Dim lastname As Integer = selectedRow.Cells("lastname").Value.ToString()
            Dim firstname As Integer = selectedRow.Cells("firstname").Value.ToString()
            Dim mi As Integer = selectedRow.Cells("mi").Value.ToString()
            Dim barangay As Integer = selectedRow.Cells("barangay").Value.ToString()
            Dim municipal As Integer = selectedRow.Cells("municipal").Value.ToString()
            Dim province As Integer = selectedRow.Cells("province").Value.ToString()
            Dim contact As Integer = selectedRow.Cells("contactnumber").Value.ToString()
            Dim age As Integer = selectedRow.Cells("age").Value.ToString()
            Dim birthday As Integer = selectedRow.Cells("birthday").Value.ToString()

            ' Populate the textboxes with data from the selected row
            txtsearch_patient.Text = selectedRow.Cells("id").Value.ToString()
            Txtlastname_patient.Text = selectedRow.Cells("lastname").Value.ToString()
            txtfirstname_patient.Text = selectedRow.Cells("firstname").Value.ToString()
            txtmi_patient.Text = selectedRow.Cells("mi").Value.ToString()
            txtbarangay_patient.Text = selectedRow.Cells("barangay").Value.ToString()
            txtmunicipality_patient.Text = selectedRow.Cells("municipal").Value.ToString()
            txtprovince_patient.Text = selectedRow.Cells("province").Value.ToString()
            txtcontactnumber_patient.Text = selectedRow.Cells("contactnumber").Value.ToString()
            txtage_patient.Text = selectedRow.Cells("age").Value.ToString()
            dtpbirthday_patient.Text = selectedRow.Cells("birthday").Value.ToString()

        End If
    End Sub

    Private Sub enableTxtBoxes()
        txtsearch_patient.Text = True
        Txtlastname_patient.Text = True
        txtfirstname_patient.Text = True
        txtmi_patient.Text = True
        txtbarangay_patient.Text = True
        txtmunicipality_patient.Text = True
        txtprovince_patient.Text = True
        txtcontactnumber_patient.Text = True
        txtage_patient.Text = True
        dtpbirthday_patient.Text = True
    End Sub

    Private Sub disableTxtBoxes()
        txtsearch_patient.Text = False
        Txtlastname_patient.Text = False
        txtfirstname_patient.Text = False
        txtmi_patient.Text = False
        txtbarangay_patient.Text = False
        txtmunicipality_patient.Text = False
        txtprovince_patient.Text = False
        txtcontactnumber_patient.Text = False
        txtage_patient.Text = False
        'dtpbirthday_patient.Text = False
    End Sub

    Private Sub clearTxtBoxes()
        txtsearch_patient.Text = String.Empty
        Txtlastname_patient.Text = String.Empty
        txtfirstname_patient.Text = String.Empty
        txtmi_patient.Text = String.Empty
        txtbarangay_patient.Text = String.Empty
        txtmunicipality_patient.Text = String.Empty
        txtprovince_patient.Text = String.Empty
        txtcontactnumber_patient.Text = String.Empty
        txtage_patient.Text = String.Empty
        dtpbirthday_patient.Text = String.Empty
    End Sub

    Private Sub btnNew_patient_Click(sender As Object, e As EventArgs) 
        enableTxtBoxes()
        clearTxtBoxes()
    End Sub

    Private Sub managePatients_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        timerValue = 0
    End Sub

    Private Sub managePatients_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        timerValue = 0
    End Sub
End Class