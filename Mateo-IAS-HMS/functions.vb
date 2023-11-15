Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Runtime.ConstrainedExecution
Imports System.Security.Cryptography
Imports System.Text

Module functions
    Dim connectionConfig As String = "server=localhost; user=root; password=root; database=db_hospitalproject;"
    Dim connection As New MySqlConnection(connectionConfig)

    Public Sub connectDB()
        connection.Open()
        MessageBox.Show("Succesful Connection")
    End Sub

    Public Sub closeDB()
        connection.Close()
        MessageBox.Show("Closed Connection")
    End Sub

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

    'crude to patient
    'delete
    Public Sub DeletePatient(tableName As String, PrimaryKeyColumnName As String, PrimaryKeyValue As Integer)
        Try
            Dim query As String = $"DELETE FROM {tableName} WHERE {PrimaryKeyColumnName} = @primaryKeyValue"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@primaryKeyValue", PrimaryKeyValue)

            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Failed to delete data: " & ex.Message)

        End Try
    End Sub

    'update
    Public Sub UpdatePatient(primaryKeyValue As Integer, lastname As String, firstname As String, mi As String, barangay As String, municipality As String, province As String, contact As String, age As String, birthday As String)
        Dim query As String = "UPDATE tbl_patient SET firstname = @firstname, lastname = @lastname, mi = @mi, barangay = @barangay, municipality = @municipality, province = @province, contactnumber = @contact, @age = age, birthday = @birthday WHERE patient_id  = @PrimaryKeyValue"
        Dim command As New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@lastname", lastname)
        command.Parameters.AddWithValue("@firstname", firstname)
        command.Parameters.AddWithValue("@mi", mi)
        command.Parameters.AddWithValue("@barangay", barangay)
        command.Parameters.AddWithValue("@municipality", municipality)
        command.Parameters.AddWithValue("@province", province)
        command.Parameters.AddWithValue("@contact", contact)
        command.Parameters.AddWithValue("@age", age)
        command.Parameters.AddWithValue("@birthday", birthday)
        Dim rowAffected As Integer = command.ExecuteNonQuery()

        If rowAffected > 0 Then
            Console.WriteLine("Data Updated succesfully!")
        Else
            Console.WriteLine("No data found for the given primary key.")
        End If
    End Sub

    'search
    Public Function SearchPatient(primaryKeyValue As Integer)
        Dim id As Integer
        Dim lastname As String
        Dim firstname As String
        Dim mi As String
        Dim barangay As String
        Dim municipality As String
        Dim province As String
        Dim contact As String
        Dim age As String
        Dim birthday As String

        Dim query As String = $"SELECT * FROM tbl_patient WHERE patient_id = @primaryKeyValue"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue)

        Dim reader As MySqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            id = reader("patient_id")
            lastname = reader("lastname").ToString
            firstname = reader("firstname").ToString
            mi = reader("mi").ToString
            barangay = reader("barangay").ToString
            municipality = reader("municipality").ToString
            province = reader("province").ToString
            contact = reader("contactnumber").ToString
            age = reader("age").ToString
            birthday = reader("birthday").ToString
        Else
            MessageBox.Show("No data fround for the given primary key")
        End If

        reader.Close()

        Return Tuple.Create(id, firstname, lastname, mi, barangay)
        Return Tuple.Create(municipality, province, contact, age, birthday)
    End Function

    'add

    Public Sub AddPatient(id As Integer, lastname As String, firstname As String, mi As String, barangay As String, municipality As String, province As String, contact As String, age As String, birthday As String)
        Try
            Dim query As String = "INSERT INTO tbl_patient (patient_id, lastname, firstname, mi, barangay, municipality, province, contactnumber, age, birthday) VALUES (@id, @lastname, @firstname, @mi, @barangay, @municipality, @province, @contact, @age, @birthday)"
            Dim command As New MySqlCommand(query, connection)

            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@lastname", lastname)
            command.Parameters.AddWithValue("@firstname", firstname)
            command.Parameters.AddWithValue("@mi", mi)
            command.Parameters.AddWithValue("@barangay", barangay)
            command.Parameters.AddWithValue("@municipality", municipality)
            command.Parameters.AddWithValue("@province", province)
            command.Parameters.AddWithValue("@contact", contact)
            command.Parameters.AddWithValue("@age", age)
            command.Parameters.AddWithValue("@birthday", birthday)

            command.ExecuteNonQuery()
        Catch ex As Exception

            MessageBox.Show("Failed to insert data: " & ex.Message)
        End Try
    End Sub
End Module
