Imports Microsoft.SqlServer
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.ConstrainedExecution
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module functions
    Dim connectionConfig As String = "server=localhost; user=root; password=root; database=db_hospitalproject;"
    Dim connection As New MySqlConnection(connectionConfig)

    Public Function ValidateUser(username As String, password As String) As Boolean

        Dim query As String = "SELECT COUNT(*) FROM tbl_user WHERE username = @username AND password = @password"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)

        Dim result As Integer = 0

        Try
            connection.Open()
            result = CInt(cmd.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try

        Return result > 0

    End Function

    Public Function IsActiveUser(username As String) As Boolean
        Dim query As String = "SELECT isactive FROM tbl_user WHERE username = @username"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@username", username)

        Try
            connection.Open()
            Dim isActive As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            Return isActive = 1
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Sub registerUser(username As String, password As String, userrole As String, isactive As Integer)

        Dim query As String = "INSERT INTO tbl_user(username, password, userrole, isactive) VALUES (@username, @password, @userrole, @isactive)"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)
        cmd.Parameters.AddWithValue("@userrole", userrole)
        cmd.Parameters.AddWithValue("@isactive", isactive)


        Try
            connection.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successful Registered!")

            'catch ex error catches error

        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Public Function IsUserAlreadyExists(username As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM tbl_user WHERE username = @username"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@username", username)

        Try
            connection.Open()
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                ' User with the same username already exists
                Return True
            Else
                ' User with the same username does not exist
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Function CalculateMD5Hash(input As String) As String
        Using md5Hash As MD5 = MD5.Create()
            Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(input)
            Dim hashBytes As Byte() = md5Hash.ComputeHash(inputBytes)
            Dim sb As New StringBuilder()

            For Each b As Byte In hashBytes
                sb.Append(b.ToString("x2"))
            Next

            Return sb.ToString()
        End Using
    End Function

    Function VerifyPassword(password As String) As Boolean
        Dim hasCapital As Boolean = False
        Dim hasSmall As Boolean = False
        Dim hasNumber As Boolean = False
        Dim hasSpecialChar As Boolean = False
        Dim specialChars As String = "?!_"

        For Each c As Char In password
            If Char.IsUpper(c) Then
                hasCapital = True
            ElseIf Char.IsLower(c) Then
                hasSmall = True
            ElseIf Char.IsDigit(c) Then
                hasNumber = True
            ElseIf specialChars.Contains(c) Then
                hasSpecialChar = True
            End If
        Next

        ' Check if all conditions are met
        Return hasCapital AndAlso hasSmall AndAlso hasNumber AndAlso hasSpecialChar
    End Function

    Sub InsertAuditRecord(user_id As Integer, audit_log As String)
        Dim query As String = "INSERT INTO tbl_audit(user_id, audit_log, audit_date) VALUES (@user_id, @audit_log, @audit_date)"
        Dim cmd As New MySqlCommand(query, connection)
        Dim auditDate As DateTime = DateTime.Now
        Dim dateString As String = auditDate.ToString("yyyy-MM-dd HH:mm:ss")

        cmd.Parameters.AddWithValue("@user_id", user_id)
        cmd.Parameters.AddWithValue("@audit_log", audit_log)
        cmd.Parameters.AddWithValue("@audit_date", dateString)

        Try
            connection.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("An error occurred while logging the audit record: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Function GetUserId(username As String) As Integer
        Dim query As String = "SELECT id FROM tbl_user WHERE username = @username"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@username", username)

        Try
            connection.Open()
            Dim userId As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return userId
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
            Return -1 ' Return -1 to indicate an error or that the user was not found.
        Finally
            connection.Close()
        End Try
    End Function

    Public Function GetUserRole(id As Integer) As String
        Dim query As String = "SELECT userrole FROM tbl_user WHERE id = @id"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@id", id)

        Try
            connection.Open()
            Dim userRole As String = Convert.ToString(cmd.ExecuteScalar())
            Return userRole
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
            Return "" ' Return an empty string to indicate an error or that the user role was not found.
        Finally
            connection.Close()
        End Try
    End Function

    Public Sub registerUserAdmin(userid As Integer)

        Dim query As String = "INSERT INTO tbl_admin(user_id) VALUES (@user_id)"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@user_id", userid)

        Try
            connection.Open()
            cmd.ExecuteNonQuery()

            'catch ex error catches error

        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Public Sub registerUserDoctor(userid As Integer)

        Dim query As String = "INSERT INTO tbl_doctor(user_id) VALUES (@userid)"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@userid", userid)


        Try
            connection.Open()
            cmd.ExecuteNonQuery()

            'catch ex error catches error

        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Public Sub registerUserPatient(userid As Integer)

        Dim query As String = "INSERT INTO tbl_patient(user_id) VALUES (@user_id)"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@user_id", userid)


        Try
            connection.Open()
            cmd.ExecuteNonQuery()

            'catch ex error catches error

        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Public Function GetInactiveUserData() As DataTable
        Dim query As String = "SELECT id, username, userrole, isactive FROM tbl_user WHERE isactive = 0"
        Dim cmd As New MySqlCommand(query, connection)
        Dim dt As New DataTable()

        Try
            connection.Open()
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
            Return Nothing ' Return Nothing to indicate an error.
        Finally
            connection.Close()
        End Try
    End Function

    Public Sub ActivateSelectedUser(user_id As Integer)
        Dim query As String = "UPDATE tbl_user SET isactive = 1 WHERE id = @id"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@id", user_id)

        Try
            connection.Open()
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("User with ID " & user_id & " has been activated.")
            Else
                MessageBox.Show("User with ID " & user_id & " not found or could not be activated.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Function GetAllDataFromTable(tableName As String) As DataTable
        Dim query As String = "SELECT * FROM " & tableName
        Dim cmd As New MySqlCommand(query, connection)
        Dim dt As New DataTable()

        Try
            connection.Open()
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
            Return Nothing ' Return Nothing to indicate an error.
        Finally
            connection.Close()
        End Try
    End Function

    Public Sub AddPatient(user_id As Integer, name As String, address As String, contact As Integer)

        Dim query As String = "INSERT INTO tbl_patient (user_id, patient_name, patient_address, patient_contact) VALUES (@user_id, @patient_name, @patient_address, @patient_contact)"
        Dim command As New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@user_id", user_id)
        command.Parameters.AddWithValue("@patient_name", name)
        command.Parameters.AddWithValue("@patient_address", address)
        command.Parameters.AddWithValue("@contact", contact)


        Try
            connection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Patient Registered!")

        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Public Sub DeleteFromTable(tableName As String, PrimaryKeyColumnName As String, PrimaryKeyValue As Integer)

        Dim query As String = $"DELETE FROM {tableName} WHERE {PrimaryKeyColumnName} = @primaryKeyValue"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@primaryKeyValue", PrimaryKeyValue)

        Try
            connection.Open()
            cmd.ExecuteNonQuery()

            'catch ex error catches error

        Catch ex As Exception

            MessageBox.Show("Failed to delete data: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Public Sub UpdatePatient(patient_id As Integer, user_id As Integer, name As String, address As String, contact As Integer)

        Dim query As String = "UPDATE tbl_patient SET user_id = @userid, patient_name = @patient_name, patient_address = @patient_address, patient_contact = @patient_contact WHERE patient_id  = @patient_id"
        Dim command As New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@patient_id", patient_id)
        command.Parameters.AddWithValue("@user_id", user_id)
        command.Parameters.AddWithValue("@patient_name", name)
        command.Parameters.AddWithValue("@patient_address", address)
        command.Parameters.AddWithValue("@patient_contact", contact)

        Try
            connection.Open()
            command.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show("Failed to update data: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Public Sub GoBackToDashboard()
        Dim role As String = userData.role

        If (role = "Admin") Then
            Dim frm As New adminDashboard
            frm.Show()
        ElseIf (role = "Doctor") Then
            Dim frm As New doctorDashboard
            frm.Show()
        Else
            Dim frm As New patientDashboard
            frm.Show()
        End If
    End Sub

    Public Function GetIdByUserIdAndRole(userId As Integer, userRole As String) As Integer
        Dim columnName As String = ""

        ' Determine the column name based on user role and table name
        Select Case userRole.ToLower()
            Case "patient"
                columnName = "patient_id"
            Case "admin"
                columnName = "admin_id"
            Case "doctor"
                columnName = "doctor_id"
            Case Else
                ' Handle the case where the user role is not recognized
                MessageBox.Show("Invalid user role.")
                Return -1 ' Return a value that indicates an error or not found
        End Select

        Dim tableName As String = $"tbl_{userRole.ToLower()}"
        Dim query As String = $"SELECT {columnName} FROM {tableName} WHERE user_id = @userId"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@userId", userId)

        Try
            connection.Open()
            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                ' If the result is not null, return the corresponding ID
                Return Convert.ToInt32(result)
            Else
                ' Handle the case where the user ID is not found
                'MessageBox.Show($"User ID {userId} with role {userRole} not found in {tableName}.")
                Return -1 ' Return a value that indicates an error or not found
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
            Return -1 ' Return a value that indicates an error
        Finally
            connection.Close()
        End Try
    End Function

    Public Function GetNameByUserIdAndRole(userId As Integer, userRole As String) As String
        Dim columnName As String = ""

        ' Determine the column name based on user role and table name
        Select Case userRole.ToLower()
            Case "patient"
                columnName = "patient_name"
            Case "admin"
                columnName = "admin_name"
            Case "doctor"
                columnName = "doctor_name"
            Case Else
                ' Handle the case where the user role is not recognized
                MessageBox.Show("Invalid user role.")
                Return "" ' Return an empty string to indicate an error or not found
        End Select

        Dim tableName As String = $"tbl_{userRole.ToLower()}"
        Dim query As String = $"SELECT {columnName} FROM {tableName} WHERE user_id = @userId"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@userId", userId)

        Try
            connection.Open()
            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                ' If the result is not null, return the corresponding name
                Return Convert.ToString(result)
            Else
                ' Handle the case where the user ID is not found
                'MessageBox.Show($"User ID {userId} with role {userRole} not found in {tableName}.")
                Return "" ' Return an empty string to indicate an error or not found
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
            Return "" ' Return an empty string to indicate an error
        Finally
            connection.Close()
        End Try
    End Function

    Public Sub UpdateUserInfo(userId As Integer, userRole As String, newName As String, newAddress As String, newContact As Integer)
        Dim columnName As String = ""
        Dim addressColumnName As String = ""
        Dim contactColumnName As String = ""

        ' Determine the column names based on user role and table name
        Select Case userRole.ToLower()
            Case "patient"
                columnName = "patient_name"
                addressColumnName = "patient_address"
                contactColumnName = "patient_contact"
            Case "admin"
                columnName = "admin_name"
                addressColumnName = "admin_address"
                contactColumnName = "admin_contact"
            Case "doctor"
                columnName = "doctor_name"
                addressColumnName = "doctor_address"
                contactColumnName = "doctor_contact"
            Case Else
                ' Handle the case where the user role is not recognized
                MessageBox.Show("Invalid user role.")
                Exit Sub ' Exit the function if the user role is not recognized
        End Select

        Dim tableName As String = $"tbl_{userRole.ToLower()}"
        Dim query As String = $"UPDATE {tableName} SET {columnName} = @newName, {addressColumnName} = @newAddress, {contactColumnName} = @newContact WHERE user_id = @userId"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@userId", userId)
        cmd.Parameters.AddWithValue("@newName", newName)
        cmd.Parameters.AddWithValue("@newAddress", newAddress)
        cmd.Parameters.AddWithValue("@newContact", newContact)

        Try
            connection.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show($"Information updated successfully for user ID {userId} and role {userRole}.")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub UpdateUserCredentials(userId As Integer, newUsername As String, newUserpassword As String)
        Dim query As String = "UPDATE tbl_user SET username = @newUsername, userpassword = @newUserpassword WHERE id = @userId"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@userId", userId)
        cmd.Parameters.AddWithValue("@newUsername", newUsername)
        cmd.Parameters.AddWithValue("@newUserpassword", newUserpassword)

        Try
            connection.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show($"Username and password updated successfully for user ID {userId}.")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub UpdateUsername(userId As Integer, newUsername As String)
        Dim query As String = "UPDATE tbl_user SET username = @newUsername WHERE id = @userId"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@userId", userId)
        cmd.Parameters.AddWithValue("@newUsername", newUsername)

        Try
            connection.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show($"Username updated successfully for user ID {userId}.")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Function GetUserContactAndAddressByRole(userId As Integer, userRole As String) As Tuple(Of String, String)
        Dim columnName As String = ""
        Dim addressColumnName As String = ""
        Dim contactColumnName As String = ""

        ' Determine the column names based on user role and table name
        Select Case userRole.ToLower()
            Case "patient"
                columnName = "patient_name"
                addressColumnName = "patient_address"
                contactColumnName = "patient_contact"
            Case "admin"
                columnName = "admin_name"
                addressColumnName = "admin_address"
                contactColumnName = "admin_contact"
            Case "doctor"
                columnName = "doctor_name"
                addressColumnName = "doctor_address"
                contactColumnName = "doctor_contact"
            Case Else
                ' Handle the case where the user role is not recognized
                MessageBox.Show("Invalid user role.")
                Return Tuple.Create("", "") ' Return an empty tuple to indicate an error or not found
        End Select

        Dim tableName As String = $"tbl_{userRole.ToLower()}"
        Dim query As String = $"SELECT {contactColumnName}, {addressColumnName} FROM {tableName} WHERE user_id = @userId"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@userId", userId)

        Dim contact As String = ""
        Dim address As String = ""

        Try
            connection.Open()
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    ' Retrieve the contact and address from the query result
                    contact = If(Not reader.IsDBNull(reader.GetOrdinal(contactColumnName)), reader.GetString(contactColumnName), "")
                    address = If(Not reader.IsDBNull(reader.GetOrdinal(addressColumnName)), reader.GetString(addressColumnName), "")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try

        ' Return the contact and address as a Tuple
        Return Tuple.Create(contact, address)
    End Function

    Public Sub UpdateDoctorInfo(doctorId As Integer, newDoctorName As String, newDoctorAddress As String, newDoctorContact As Integer)
        Dim query As String = "UPDATE tbl_doctor SET doctor_name = @newDoctorName, doctor_address = @newDoctorAddress, doctor_contact = @newDoctorContact WHERE doctor_id = @doctorId"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@doctorId", doctorId)
        cmd.Parameters.AddWithValue("@newDoctorName", newDoctorName)
        cmd.Parameters.AddWithValue("@newDoctorAddress", newDoctorAddress)
        cmd.Parameters.AddWithValue("@newDoctorContact", newDoctorContact)

        Try
            connection.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show($"Doctor information updated successfully for doctor ID {doctorId}.")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub InsertAppointment(patientId As Integer, doctorId As Integer, appointmentReason As String)
        Dim appointmentDate As String = DateTime.Now
        Dim appointmentStatus As String = "inQueue"


        Dim query As String = "INSERT INTO tbl_appointment(patient_id, doctor_id, appointment_reason, appointment_date, appointment_status) VALUES (@patientId, @doctorId, @appointmentReason, @appointmentDate, @appointmentStatus)"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@patientId", patientId)
        cmd.Parameters.AddWithValue("@doctorId", doctorId)
        cmd.Parameters.AddWithValue("@appointmentReason", appointmentReason)
        cmd.Parameters.AddWithValue("@appointmentDate", appointmentDate)
        cmd.Parameters.AddWithValue("@appointmentStatus", appointmentStatus)

        Try
            connection.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Appointment information inserted successfully!")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Function GetAppointmentsByPatientId(patientId As Integer) As DataTable
        Dim query As String = "SELECT * FROM tbl_appointment WHERE patient_id = @patientId"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@patientId", patientId)

        Dim dataTable As New DataTable()

        Try
            connection.Open()
            Using adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(dataTable)
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try

        Return dataTable
    End Function

    Public Function GetPaymentsForAcceptedAppointments(patientId As Integer) As DataTable
        Dim query As String = "SELECT p.pay_id, p.appointment_id, p.pay_total, p.pay_status, a.patient_id " &
                          "FROM tbl_pay p " &
                          "INNER JOIN tbl_appointment a ON p.appointment_id = a.appointment_id " &
                          "WHERE a.patient_id = @patientId AND a.appointment_status = 'accepted'"

        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@patientId", patientId)

        Dim dataTable As New DataTable()

        Try
            connection.Open()
            Using adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(dataTable)
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try

        Return dataTable
    End Function

    Public Sub UpdateAppointmentDetails(appointmentId As Integer, newPatientId As Integer, newDoctorId As Integer, newAppointmentReason As String, newAppointmentDate As Date)
        Dim query As String = "UPDATE tbl_appointment SET patient_id = @newPatientId, doctor_id = @newDoctorId, appointment_reason = @newAppointmentReason, appointment_date = @newAppointmentDate WHERE appointment_id = @appointmentId"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@appointmentId", appointmentId)
        cmd.Parameters.AddWithValue("@newPatientId", newPatientId)
        cmd.Parameters.AddWithValue("@newDoctorId", newDoctorId)
        cmd.Parameters.AddWithValue("@newAppointmentReason", newAppointmentReason)
        cmd.Parameters.AddWithValue("@newAppointmentDate", newAppointmentDate)

        Try
            connection.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show($"Appointment details updated successfully for appointment ID {appointmentId}.")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub AcceptAppointmentById(appointmentId As Integer)
        Dim query As String = "UPDATE tbl_appointment SET appointment_status = 'accepted' WHERE appointment_id = @appointmentId"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@appointmentId", appointmentId)

        Try
            connection.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show($"Appointment status set to 'accepted' for appointment ID {appointmentId}.")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub DeleteAppointmentById(appointmentId As Integer)
        Dim query As String = "DELETE FROM tbl_appointment WHERE appointment_id = @appointmentId"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@appointmentId", appointmentId)

        Try
            connection.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show($"Appointment record deleted successfully for appointment ID {appointmentId}.")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub AddPaymentData(appointmentId As Integer, payTotal As Integer, payStatus As String)
        Dim query As String = "INSERT INTO tbl_pay(appointment_id, pay_total, pay_status) VALUES (@appointmentId, @payTotal, @payStatus)"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@appointmentId", appointmentId)
        cmd.Parameters.AddWithValue("@payTotal", payTotal)
        cmd.Parameters.AddWithValue("@payStatus", payStatus)

        Try
            connection.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Payment data added successfully!")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub UpdatePaymentStatusToPaid(payId As Integer)
        Dim query As String = "UPDATE tbl_pay SET pay_status = 'Paid' WHERE pay_id = @payId"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@payId", payId)

        Try
            connection.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show($"Payment status set to 'Paid' for payment ID {payId}.")
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub BackupDatabase()
        Dim Server As String = "localhost"
        Dim Database As String = "db_hospitalproject"
        Dim User As String = "root"
        Dim Password As String = "root"
        Dim openFileDialog As New OpenFileDialog()
        Dim saveFileDialog As New SaveFileDialog()
        Dim mysqlDumpPath As String = "C:\Program Files\MySQL\MySQL Server 8.0\bin\mysqldump.exe"

        Try
            ' Show the save file dialog to get the backup file path
            saveFileDialog.Filter = "SQL Files (.sql)|*.sql|All Files (.)|*.*"
            saveFileDialog.FileName = "backup.sql"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim backupFilePath As String = saveFileDialog.FileName

                ' Build the mysqldump command
                Dim command As String = $"--host={Server} --user={User} --password={Password} --databases {Database} --routines --result-file={backupFilePath}"

                ' Execute the mysqldump command
                Dim processStartInfo As New ProcessStartInfo(mysqlDumpPath, command) With {
                .CreateNoWindow = True,
                .UseShellExecute = False,
                .RedirectStandardOutput = True
            }

                Dim process As New Process With {
                .StartInfo = processStartInfo
            }

                process.Start()

                Dim output As String = process.StandardOutput.ReadToEnd() ' Read standard output
                process.WaitForExit()

                MessageBox.Show("Backup completed successfully.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error during backup: {ex.Message}")
        End Try
    End Sub

    Public Sub RestoreDatabase()
        Dim Server As String = "localhost"
        Dim Database As String = "db_hospitalproject"
        Dim User As String = "root"
        Dim Password As String = "root"
        Dim openFileDialog As New OpenFileDialog()
        Dim mysqlPath As String = "C:\Program Files\MySQL\MySQL Server 8.0\bin\mysql.exe"

        Try
            openFileDialog.Filter = "SQL Files (.sql)|*.sql|All Files (.)|*.*"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim restoreFilePath As String = openFileDialog.FileName
                Dim command As String = $"--host={Server} --user={User} --password={Password} --database {Database}"

                Dim processStartInfo As New ProcessStartInfo(mysqlPath, command) With {
                    .CreateNoWindow = True,
                    .UseShellExecute = False,
                    .RedirectStandardInput = True
                }

                Dim process As New Process With {
                    .StartInfo = processStartInfo
                }

                process.Start()

                Dim sqlFileContent As String = File.ReadAllText(restoreFilePath)
                process.StandardInput.WriteLine(sqlFileContent)
                process.StandardInput.Close()
                process.WaitForExit()

                MessageBox.Show("Restore completed successfully.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error during restore: {ex.Message}")
        End Try
    End Sub

    Public Function GetPrimaryKeyColumnName(tableName As String) As String
        Dim primaryKeyColumnName As String = Nothing

        Try
            Dim query As String = "SELECT COLUMN_NAME " &
                              "FROM INFORMATION_SCHEMA.COLUMNS " &
                              "WHERE TABLE_SCHEMA = 'db_hospitalproject' " &
                              "AND TABLE_NAME = @tableName " &
                              "AND COLUMN_KEY = 'PRI'"

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@tableName", tableName)

                Dim result As Object = command.ExecuteScalar()

                If result IsNot Nothing Then
                    primaryKeyColumnName = result.ToString()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Return primaryKeyColumnName
    End Function

    Public Function GetDataByPrimaryKey(tableName As String, primaryKeyId As Integer) As DataTable
        Dim dataTable As New DataTable()

        Try
            connection.Open()

            ' Get the primary key column name
            Dim primaryKeyColumnName As String = GetPrimaryKeyColumnName(tableName)

            If String.IsNullOrEmpty(primaryKeyColumnName) Then
                MessageBox.Show($"Table '{tableName}' doesn't have a primary key column.")
                Return dataTable
            End If

            ' Use the primary key column name to fetch data
            ' Dim query As String = $"SELECT * FROM {tableName} WHERE {primaryKeyColumnName} = @primaryKeyId"
            Dim query As String = $"CALL GetDataFromUserId('{tableName}', '{primaryKeyColumnName}', {primaryKeyId})"
            Using command As New MySqlCommand(query, connection)
                ' command.Parameters.AddWithValue("@primaryKeyId", primaryKeyId)

                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            connection.Dispose()
        End Try

        Return dataTable
    End Function

End Module
