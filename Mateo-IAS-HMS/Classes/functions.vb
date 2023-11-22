Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
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


End Module
