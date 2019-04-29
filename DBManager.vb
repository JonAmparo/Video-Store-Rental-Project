Imports MySql.Data.MySqlClient

Public Class DBManager
    Private connectionString As String = "server=localhost;user id=root;password=;database=database;sslmode=none;"
    Private con As MySqlConnection

    Public Sub New()
        Try
            Me.con = New MySqlConnection(connectionString)
            Me.con.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed - SQL initial connection Failed!")
        End Try
    End Sub

    'Use Case 0: Login
    'Signs the employee in and then takes the user to the dashboard
    Public Function Logon(ByVal username As String, ByVal password As String)
        Dim login As EmployeeLogin = Nothing
        Dim data As New DataSet()

        Try
            Dim query As String = "SELECT user_id, employee_number, username, password, fname, lname, level, status
                                   FROM users 
                                   WHERE username = @username AND password = @password"
            Dim cmd As New MySqlCommand(query, con)
            Dim adapter As New MySqlDataAdapter(cmd)

            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            adapter.Fill(data, "user")

            If data.Tables("user").Rows.Count > 0 Then

                For Each row As DataRow In data.Tables("user").Rows
                    login = New EmployeeLogin(row("user_id"), row("employee_number"), row("username"), row("password"), row("fname"), row("lname"), row("level"), row("status"))
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Login Screen Error!")
        End Try

        Return login
    End Function


    'Use Case 1: Change default password
    Public Sub PasswordChange(ByVal login As EmployeeLogin)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.con
            cmd.CommandText = "UPDATE users
                               SET password = @password
                               WHERE user_id = @user_id"
            Dim changedPassword = (login.Password)

            cmd.Parameters.AddWithValue("@password", changedPassword)
            cmd.Parameters.AddWithValue("@user_id", login.User_id)

            Dim rowAffected = cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Password Change Error!")
        End Try
    End Sub

    'Use Case 2: List of Employee
    'Gets Employee List from database and displays it in order by last added
    Public Sub GetEmployeeList()
        Dim data As New DataTable()

        Try
            Dim query As String = "SELECT user_id,
                                    employee_number,
                                    username, 
                                    fname,
                                    lname,
                                    dob,
                                    address,
                                    city,
                                    province,
                                    postal_code,
                                    home_phone,
                                    cell_phone,
                                    start_date,
                                    sin,
                                    hourly_pay,
                                    education,
                                    level,
                                    status
                                    FROM users 
                                    ORDER BY user_id DESC"

            Dim cmd As New MySqlCommand(query, con)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(data)

            With EmployeeList.DGV_employeeList
                .DataSource = data

                .Columns(0).HeaderText = "User ID"
                .Columns(1).HeaderText = "Employee number"
                .Columns(2).HeaderText = "Username"
                .Columns(3).HeaderText = "First name"
                .Columns(4).HeaderText = "Last name"
                .Columns(5).HeaderText = "Date of Birth"
                .Columns(6).HeaderText = "Address"
                .Columns(7).HeaderText = "City"
                .Columns(8).HeaderText = "Province"
                .Columns(9).HeaderText = "Postal Code"
                .Columns(10).HeaderText = "Home Phone"
                .Columns(11).HeaderText = "Cell Phone"
                .Columns(12).HeaderText = "Start Date"
                .Columns(13).HeaderText = "SIN"
                .Columns(14).HeaderText = "Hourly Pay"
                .Columns(15).HeaderText = "Education"
                .Columns(16).HeaderText = "Level"
                .Columns(17).HeaderText = "Status"


                'Make columns width to appropiate size for dataset
                '.Columns(0).Width = 30
                '.Columns(1).Width = 60
                '.Columns(2).Width = 60
                '.Columns(3).Width = 29
                '.Columns(4).Width = 47
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Get Employee List Error!")
        End Try

    End Sub

    'Use Case 3: Add new Employee
    Public Sub AddNewEmployee(ByVal newEmployee As Employee)
        Dim cmd As New MySqlCommand

        Try
            'con.Open() 'already open
            cmd.Connection = Me.con
            cmd.CommandText = "INSERT INTO users
                               VALUES(DEFAULT, @employee_number, @username, @password, @fname, @lname, @dob, @address, @city, @province, @postal_code, @home_phone, @cell_phone,@start_date, @sin, @hourly_pay, @education, @level, @status)"

            cmd.Parameters.AddWithValue("@employee_number", newEmployee.Employee_number)
            cmd.Parameters.AddWithValue("@username", newEmployee.Username)
            cmd.Parameters.AddWithValue("@password", newEmployee.Password)
            cmd.Parameters.AddWithValue("@fname", newEmployee.Fname)
            cmd.Parameters.AddWithValue("@lname", newEmployee.Lname)
            cmd.Parameters.AddWithValue("@dob", newEmployee.Dob)
            cmd.Parameters.AddWithValue("@address", newEmployee.Address)
            cmd.Parameters.AddWithValue("@city", newEmployee.City)
            cmd.Parameters.AddWithValue("@province", newEmployee.Province)
            cmd.Parameters.AddWithValue("@postal_code", newEmployee.Postal_code)
            cmd.Parameters.AddWithValue("@home_phone", newEmployee.Home_phone)
            cmd.Parameters.AddWithValue("@cell_phone", newEmployee.Cell_phone)
            cmd.Parameters.AddWithValue("@start_date", newEmployee.Start_date)
            cmd.Parameters.AddWithValue("@sin", newEmployee.Sin)
            cmd.Parameters.AddWithValue("@hourly_pay", newEmployee.Hourly_pay)
            cmd.Parameters.AddWithValue("@education", newEmployee.Education)
            cmd.Parameters.AddWithValue("@level", newEmployee.Level)
            cmd.Parameters.AddWithValue("@status", newEmployee.Status)

            Dim rowAffected = cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Add New Employee Error!")
            'Finally
            'con.Close()
        End Try
    End Sub

    'Use Case 4: Edit employee
    Public Sub EditEmployee(ByVal editEmployee As Employee)
        Dim cmd As New MySqlCommand

        Try
            'con.Open() 'already open
            cmd.Connection = Me.con
            cmd.CommandText = "UPDATE users
                               SET employee_number = @employee_number,
                                    username = @username,
                                    password = @password,
                                    fname = @fname,
                                    lname = @lname,
                                    dob = @dob,
                                    address = @address,
                                    city = @city,
                                    province = @province,
                                    postal_code = @postal_code,
                                    home_phone = @home_phone,
                                    cell_phone = @cell_phone,
                                    start_date = @start_date,
                                    sin = @sin,
                                    hourly_pay = @hourly_pay,
                                    education = @education,
                                    level = @level,
                                    status = @status
                               WHERE employee_number = @EmployeeID;"

            cmd.Parameters.AddWithValue("@employee_number", editEmployee.Employee_number)
            cmd.Parameters.AddWithValue("@username", editEmployee.Username)
            cmd.Parameters.AddWithValue("@password", editEmployee.Password)
            cmd.Parameters.AddWithValue("@fname", editEmployee.Fname)
            cmd.Parameters.AddWithValue("@lname", editEmployee.Lname)
            cmd.Parameters.AddWithValue("@dob", editEmployee.Dob)
            cmd.Parameters.AddWithValue("@address", editEmployee.Address)
            cmd.Parameters.AddWithValue("@city", editEmployee.City)
            cmd.Parameters.AddWithValue("@province", editEmployee.Province)
            cmd.Parameters.AddWithValue("@postal_code", editEmployee.Postal_code)
            cmd.Parameters.AddWithValue("@home_phone", editEmployee.Home_phone)
            cmd.Parameters.AddWithValue("@cell_phone", editEmployee.Cell_phone)
            cmd.Parameters.AddWithValue("@start_date", editEmployee.Start_date)
            cmd.Parameters.AddWithValue("@sin", editEmployee.Sin)
            cmd.Parameters.AddWithValue("@hourly_pay", editEmployee.Hourly_pay)
            cmd.Parameters.AddWithValue("@education", editEmployee.Education)
            cmd.Parameters.AddWithValue("@level", editEmployee.Level)
            cmd.Parameters.AddWithValue("@status", editEmployee.Status)
            cmd.Parameters.AddWithValue("@EmployeeID", editEmployee.Employee_number)

            Dim rowAffected = cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Edit Employee Error!")
            'Finally
            'con.Close()
        End Try
    End Sub

    Public Function SelectEmployee()
        Dim ListEmployee As New List(Of User)

        Try
            Dim query As String = "SELECT username, fname, lname, employee_number
                                   FROM users 
                                   WHERE username <> 'admin'"
            Dim cmd As New MySqlCommand(query, con)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim data As New DataSet()

            adapter.Fill(data, "users")
            If data.Tables("users").Rows.Count > 0 Then

                For Each row As DataRow In data.Tables("users").Rows
                    Dim displayEmployees As New User With {
                        .DisplayRows = row("employee_number"),
                        .DisplayColumns = row("username") & "   (" & row("fname") & " " & row("lname") & ")  -  " & row("employee_number")
                    }

                    ListEmployee.Add(displayEmployees)

                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Select Employee Error!")
        End Try

        Return ListEmployee
    End Function

    Public Function GetEmployeeNum(ByVal EmployeeNum As String)
        Dim EditEmployee As Employee = Nothing

        Try
            Dim query As String = "SELECT *
                                   FROM users
                                   WHERE employee_number = " & "'" & EmployeeNum & "'"
            Dim cmd As New MySqlCommand(query, con)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim data As New DataSet()

            adapter.Fill(data, "users")

            If data.Tables("users").Rows.Count > 0 Then

                For Each row As DataRow In data.Tables("users").Rows
                    EditEmployee = (New Employee(row("employee_number"), row("username"), row("password"), row("fname"), row("lname"), row("dob"), row("address"), row("city"), row("province"), row("postal_code"), row("home_phone"), row("cell_phone"), row("start_date"), row("sin"), row("hourly_pay"), row("education"), row("level"), row("status")))
                    EditEmployee.Status = row("status")
                    EditEmployee.User_id = row("user_id")
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Get Employee Number Error!")
        End Try

        Return EditEmployee
    End Function

    'Use  Case  5:  Delete  employee
    Public Sub DeleteEmployee(ByVal EmployeeNum As String)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.con
            cmd.CommandText = "DELETE FROM users
                               WHERE employee_number = @employee_number"
            cmd.Parameters.AddWithValue("@employee_number", EmployeeNum)

            Dim rowAffected = cmd.ExecuteNonQuery()
            MsgBox("Row affected: " & rowAffected)

            'con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Delete Employee Error!")

        End Try
    End Sub

    'Use  Case  6:  List  of  Client
    Public Sub GetClientList()

        Try
            Dim query As String = "SELECT * 
                                   FROM clients
                                   ORDER BY client_id DESC"
            Dim cmd As New MySqlCommand(query, con)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim data As New DataTable()
            adapter.Fill(data)

            With ClientList.DGV_clientList
                .DataSource = data

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Get Client List Error!")
        End Try

    End Sub

    'Use  Case  7:  Add  new  Client
    Public Sub AddNewClient(ByVal newClient As Client)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.con
            cmd.CommandText = "INSERT INTO clients
                               VALUES(DEFAULT,
                               @client_number,
                                @fname,
                                @lname,
                                @email,
                                @phone,
                                @dob,
                                @address,
                                @city,
                                @province,
                                @postal_code,
                                @status)"

            cmd.Parameters.AddWithValue("@client_number", newClient.Client_number)
            cmd.Parameters.AddWithValue("@fname", newClient.Fname)
            cmd.Parameters.AddWithValue("@lname", newClient.Lname)
            cmd.Parameters.AddWithValue("@email", newClient.Email)
            cmd.Parameters.AddWithValue("@phone", newClient.Phone)
            cmd.Parameters.AddWithValue("@dob", newClient.Dob)
            cmd.Parameters.AddWithValue("@address", newClient.Address)
            cmd.Parameters.AddWithValue("@city", newClient.City)
            cmd.Parameters.AddWithValue("@province", newClient.Province)
            cmd.Parameters.AddWithValue("@postal_code", newClient.Postal_code)
            cmd.Parameters.AddWithValue("@status", newClient.Status)

            Dim rowAffected = cmd.ExecuteNonQuery()
            MsgBox("Row affected: " & rowAffected)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Add New Client Error!")
            'Finally
            'con.Close()
        End Try
    End Sub

    'Use  Case  8:  Edit Client
    Public Sub EditClient(ByVal editClient As Client)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.con
            cmd.CommandText = "UPDATE clients
                               SET client_number = @client_number,
                                   fname = @fname,
                                   lname = @lname,
                                   email = @email,
                                   phone = @phone,
                                   dob = @dob,
                                   address = @address,
                                   city = @city,
                                   province = @province,
                                   postal_code = @postal_code,
                                   status = @status
                                WHERE client_id = @client_id;"

            cmd.Parameters.AddWithValue("@client_number", editClient.Client_number)
            cmd.Parameters.AddWithValue("@fname", editClient.Fname)
            cmd.Parameters.AddWithValue("@lname", editClient.Lname)
            cmd.Parameters.AddWithValue("@email", editClient.Email)
            cmd.Parameters.AddWithValue("@phone", editClient.Phone)
            cmd.Parameters.AddWithValue("@dob", editClient.Dob)
            cmd.Parameters.AddWithValue("@address", editClient.Address)
            cmd.Parameters.AddWithValue("@city", editClient.City)
            cmd.Parameters.AddWithValue("@province", editClient.Province)
            cmd.Parameters.AddWithValue("@postal_code", editClient.Postal_code)
            cmd.Parameters.AddWithValue("@status", editClient.Status)
            cmd.Parameters.AddWithValue("@client_id", editClient.Client_id)

            Dim rowAffected = cmd.ExecuteNonQuery()
            MsgBox("Row affected: " & rowAffected)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Edit Client Error!")

        End Try
    End Sub

    Public Function SelectClient()
        Dim ListClient As New List(Of User)

        Try
            Dim query As String = "SELECT client_number, fname, lname, email
                                   FROM clients
                                   ORDER BY client_id DESC"

            Dim cmd As New MySqlCommand(query, con)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim data As New DataSet()

            adapter.Fill(data, "clients")
            If data.Tables("clients").Rows.Count > 0 Then

                For Each row As DataRow In data.Tables("clients").Rows
                    Dim displayClients As New User With {
                        .DisplayRows = row("client_number"),
                        .DisplayColumns = row("fname") & " " & row("lname") & " - " & row("client_number") 'row("client_number") & "   (" & 
                    }


                    ListClient.Add(displayClients)

                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Select Client Error!")
        End Try

        Return ListClient
    End Function

    Public Function GetClientNum(ByVal clientId As String)
        Dim Edit_Client As Client = Nothing

        Try
            Dim query As String = "SELECT * 
                                   FROM clients       
                                   WHERE client_number = @clientId"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@clientId", clientId)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim data As New DataSet()

            adapter.Fill(data, "clients")

            If data.Tables("clients").Rows.Count > 0 Then

                For Each row As DataRow In data.Tables("clients").Rows
                    Edit_Client = (New Client(row("client_number"), row("fname"), row("lname"), row("email"), row("phone"), row("dob"), row("address"), row("city"), row("province"), row("postal_code"), row("status")))
                    Edit_Client.Status = row("status")
                    Edit_Client.Client_id = row("client_id")


                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Get Client Number Error")
        End Try

        Return Edit_Client
    End Function

    'Use  Case  9:  Delete Client
    Public Sub DeleteClient(ByVal ClientNum As String)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.con
            cmd.CommandText = "DELETE FROM clients
                               WHERE client_number = @client_number"
            cmd.Parameters.AddWithValue("@client_number", ClientNum)

            Dim rowAffected = cmd.ExecuteNonQuery()
            MsgBox("Row affected: " & rowAffected)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Delete Client Error!")

        End Try
    End Sub


    'Use  Case  10:  List  of  Video
    Public Sub GetVideoList()

        Try
            Dim query As String = "SELECT * 
                                   FROM videos
                                   ORDER BY video_id DESC"
            Dim cmd As New MySqlCommand(query, con)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim data As New DataTable()
            adapter.Fill(data)

            With VideoList.DGV_videoList
                .DataSource = data

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Get Client List Error!")
        End Try

    End Sub

    'Use  Case  11:  Add new Video
    Public Sub AddNewVideo(ByVal newVideo As Video)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.con
            cmd.CommandText = "INSERT INTO videos
                               VALUES(DEFAULT,
                                @photo,
                                @title,
                                @year,
                                @country,
                                @language,
                                @length,
                                @resume,
                                @genre,
                                @actors,
                                @director,
                                @status)"

            cmd.Parameters.AddWithValue("@photo", newVideo.Photo)
            cmd.Parameters.AddWithValue("@title", newVideo.Title)
            cmd.Parameters.AddWithValue("@year", newVideo.Year)
            cmd.Parameters.AddWithValue("@country", newVideo.Country)
            cmd.Parameters.AddWithValue("@language", newVideo.Language)
            cmd.Parameters.AddWithValue("@length", newVideo.Length)
            cmd.Parameters.AddWithValue("@resume", newVideo.ResumeVideo)
            cmd.Parameters.AddWithValue("@genre", newVideo.Genre)
            cmd.Parameters.AddWithValue("@actors", newVideo.Actors)
            cmd.Parameters.AddWithValue("@director", newVideo.Director)
            cmd.Parameters.AddWithValue("@status", newVideo.Status)

            Dim rowAffected = cmd.ExecuteNonQuery()
            MsgBox("Row affected: " & rowAffected)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Add New Video Error!")
            'Finally
            'con.Close()
        End Try
    End Sub

    'Use  Case  12:  Edit  Video
    Public Sub EditVideo(ByVal editVideo As Video)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.con
            cmd.CommandText = "UPDATE videos
                               SET photo = @photo,
                                   title = @title,
                                   year = @year,
                                   country = @country,
                                   language = @language,
                                   length = @length,
                                   resume = @resume,
                                   genre = @genre,
                                   actors = @actors,
                                   director = @director
                                WHERE video_id = @video_id;"
            ',
            '                       status = @status

            cmd.Parameters.AddWithValue("@photo", editVideo.Photo)
            cmd.Parameters.AddWithValue("@title", editVideo.Title)
            cmd.Parameters.AddWithValue("@year", editVideo.Year)
            cmd.Parameters.AddWithValue("@country", editVideo.Country)
            cmd.Parameters.AddWithValue("@language", editVideo.Language)
            cmd.Parameters.AddWithValue("@length", editVideo.Length)
            cmd.Parameters.AddWithValue("@resume", editVideo.ResumeVideo)
            cmd.Parameters.AddWithValue("@genre", editVideo.Genre)
            cmd.Parameters.AddWithValue("@actors", editVideo.Actors)
            cmd.Parameters.AddWithValue("@director", editVideo.Director)
            cmd.Parameters.AddWithValue("@status", editVideo.Status)
            'cmd.Parameters.AddWithValue("@status", editVideo.Status)
            cmd.Parameters.AddWithValue("@video_id", editVideo.Video_id)


            Dim rowAffected = cmd.ExecuteNonQuery()
            MsgBox("Row affected: " & rowAffected)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Edit Video Error!")
        End Try
    End Sub

    Public Function SelectVideo()
        Dim ListVideo As New List(Of User)

        Try
            Dim query As String = "SELECT video_id, title, genre, actors
                                   FROM videos
                                   ORDER BY video_id DESC"

            Dim cmd As New MySqlCommand(query, con)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim data As New DataSet()

            adapter.Fill(data, "videos")
            If data.Tables("videos").Rows.Count > 0 Then

                For Each row As DataRow In data.Tables("videos").Rows
                    Dim displayVideos As New User With {
                        .DisplayRows = row("video_id"),
                        .DisplayColumns = row("video_id") & " " & row("title") & " - " & row("genre")
                    }

                    ListVideo.Add(displayVideos)

                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Select Video Error!")
        End Try

        Return ListVideo
    End Function

    Public Function GetVideoID(ByVal videoID As String)
        Dim EditVideo As Video = Nothing

        Try
            Dim query As String = "SELECT * 
                                   FROM videos       
                                   WHERE video_id = @videoID"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@videoID", videoID)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim data As New DataSet()

            adapter.Fill(data, "videos")

            If data.Tables("videos").Rows.Count > 0 Then

                For Each row As DataRow In data.Tables("videos").Rows
                    EditVideo = (New Video(row("photo"), row("title"), row("year"), row("country"), row("language"), row("length"), row("resume"), row("genre"), row("actors"), row("director"), row("status")))
                    EditVideo.Status = row("status")
                    EditVideo.Video_id = row("video_id")

                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Get Video ID Error! ")
        End Try

        Return EditVideo
    End Function

    'Use  Case  13:  Delete  Video
    Public Sub DeleteVideo(ByVal videoID As String)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.con
            cmd.CommandText = "DELETE FROM videos
                               WHERE video_id = @videoID"
            cmd.Parameters.AddWithValue("@videoID", videoID)

            Dim rowAffected = cmd.ExecuteNonQuery()
            MsgBox("Row affected: " & rowAffected)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Delete Video Error!")

        End Try
    End Sub

    'Use  Case  14:  Quick  Search
    Public Function QuickSearch(ByVal dbSearch As SearchClass)
        Dim data As New DataTable()
        Dim cmd As New MySqlCommand

        Dim bool As Boolean = False

        Try
            cmd.Connection = Me.con
            Dim query As String = "SELECT video_id, title, genre, actors, director, length, language, year, country, resume, photo       
                                   FROM videos 
                                   WHERE "
            If dbSearch.Title IsNot Nothing Then
                query = query & " title LIKE '%" & dbSearch.Title & "%'"

                bool = True
            End If

            If dbSearch.VideoID IsNot Nothing Then

                If bool = True Then
                    query = query & " AND " & "video_id LIKE '%" & dbSearch.VideoID & "%'"
                Else
                    query = query & " video_id LIKE '%" & dbSearch.VideoID & "%'"
                End If

                bool = True
            End If


            cmd.CommandText = query
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(data)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Quick Search Error!")
        End Try

        Return data
    End Function


    'Use  Case  15:  Advanced  Search
    Public Function AdvancedSearch(ByVal dbSearch As SearchClass)
        Dim data As New DataTable()
        Dim cmd As New MySqlCommand

        Dim bool As Boolean = False

        Try
            cmd.Connection = Me.con
            Dim query As String = "SELECT video_id, title, genre, actors, director, length, language, year, country, resume, photo       
                                   FROM videos 
                                   WHERE "
            If dbSearch.Title IsNot Nothing Then
                query = query & " title LIKE '%" & dbSearch.Title & "%'"

                bool = True
            End If

            If dbSearch.Genre IsNot Nothing Then

                If bool = True Then
                    query = query & " AND " & "genre LIKE '%" & dbSearch.Genre & "%'"
                Else
                    query = query & " genre LIKE '%" & dbSearch.Genre & "%'"
                End If

                bool = True
            End If

            If dbSearch.Year IsNot Nothing Then

                If bool = True Then
                    query = query & " AND " & "year LIKE '%" & dbSearch.Year & "%'"
                Else
                    query = query & " year LIKE '%" & dbSearch.Year & "%'"
                End If

                bool = True
            End If

            If dbSearch.Language IsNot Nothing Then

                If bool = True Then
                    query = query & " AND " & "language LIKE '%" & dbSearch.Language & "%'"
                Else
                    query = query & " language LIKE '%" & dbSearch.Language & "%'"
                End If

                bool = True
            End If

            If dbSearch.Country IsNot Nothing Then

                If bool = True Then
                    query = query & " AND " & "country LIKE '%" & dbSearch.Country & "%'"
                Else
                    query = query & " country LIKE '%" & dbSearch.Country & "%'"
                End If

                bool = True
            End If

            'LENGTH -------- https://www.techonthenet.com/mysql/between.php
            'If dbSearch.Length IsNot Nothing Then

            '    If bool = True Then
            '        query = query & " AND " & " length LIKE'%" & dbSearch.Length & "%'"
            '    Else
            '        query = query & " length LIKE '%" & dbSearch.Length & "%'"
            '    End If

            '    bool = True
            'End If

            If dbSearch.Director IsNot Nothing Then

                If bool = True Then
                    query = query & " AND " & "director LIKE '%" & dbSearch.Director & "%'"
                Else
                    query = query & " director LIKE '%" & dbSearch.Director & "%'"
                End If

                bool = True
            End If


            If dbSearch.Actors IsNot Nothing Then

                If bool = True Then
                    query = query & " AND " & " actors LIKE '%" & dbSearch.Actors & "%'"
                Else
                    query = query & " actors LIKE '%" & dbSearch.Actors & "%'"
                End If

                bool = True
            End If

            If dbSearch.ResumeVideo IsNot Nothing Then

                If bool = True Then
                    query = query & " AND " & "lower(resume) LIKE '%" & dbSearch.ResumeVideo & "%'"
                Else
                    query = query & " resume LIKE '%" & dbSearch.ResumeVideo & "%'"
                End If

                bool = True
            End If

            cmd.CommandText = query

            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(data)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Advanced Search Error!")
        End Try

        Return data
    End Function


    'Use  Case  16:  Rent a Video

    'Imports MySql.Data.MySqlClient

    'Public Class DBManager
    '    Private connectionString As String = "server=localhost;user id=root;password=;database=database;sslmode=none;" 'sslmode=none;
    '    Private con As MySqlConnection

    '    Public Sub New()
    '        Try
    '            Me.con = New MySqlConnection(connectionString)
    '            Me.con.Open()
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed1")
    '        End Try
    '    End Sub

    '    Public Sub TestConnection()
    '        If Me.con.State = ConnectionState.Open Then
    '            MsgBox("I'm wide open baby")
    '        Else
    '            MsgBox("Connection is closed")
    '        End If
    '    End Sub

    '    Public Function GetAllUsers()
    '        Dim query As String = "SELECT * FROM user"
    '        Dim dataset As New DataSet()

    '        Try
    '            Dim cmd As New MySqlCommand(query, Me.con)
    '            Dim adapter As New MySqlDataAdapter(cmd)

    '            adapter.Fill(dataset, "user")
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed2")
    '        End Try

    '        Return dataset.Tables("user").Rows
    '    End Function

    '    Public Function getAllUsersList() As List(Of User)
    '        Dim query As String = "SELECT * FROM users"
    '        Dim dataset As New DataSet()
    '        Dim userlist As New List(Of User)

    '        Try
    '            Dim cmd As New MySqlCommand(query, Me.con)
    '            Dim adapter As New MySqlDataAdapter(cmd)

    '            adapter.Fill(dataset, "users")

    '            For Each row As DataRow In dataset.Tables("users").Rows
    '                userlist.Add(New User(row("u_fname"), row("u_lname"), row("u_age"), row("u_gender"), row("u_id")))
    '            Next
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed3")
    '        End Try

    '        Return userlist
    '    End Function

    '    Public Sub AddNewUser(ByVal user As User)
    '        Dim cmd As New MySqlCommand

    '        Try
    '            cmd.Connection = Me.con
    '            cmd.CommandText = "INSERT INTO users VALUES(DEFAULT, @fname, @lname, @age, @gender)"

    '            cmd.Parameters.AddWithValue("@fname", user.Fname)
    '            cmd.Parameters.AddWithValue("@lname", user.Lname)
    '            cmd.Parameters.AddWithValue("@age", user.Age)
    '            cmd.Parameters.AddWithValue("@gender", user.Gender)

    '            Dim rowAffected = cmd.ExecuteNonQuery()
    '            MsgBox("Row affected: " & rowAffected)

    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Prepare Statement Failed4")
    '        End Try
    '    End Sub


    '    Public Sub DeleteUser(ByVal username As Integer)
    '        Dim cmd As New MySqlCommand

    '        Try
    '            cmd.Connection = Me.con
    '            cmd.CommandText = "DELETE FROM users WHERE username = @username"

    '            cmd.Parameters.AddWithValue("@username", username)

    '            Dim rowAffected = cmd.ExecuteNonQuery()
    '            MsgBox("Row affected: " & rowAffected)

    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Prepare Statement Failed5")
    '        End Try
    '    End Sub

    'End Class
End Class
