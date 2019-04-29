Public Class EmployeeCreate1

    Dim db As New DBManager
    Public birthDate As Date

    Private Sub EmployeeCreate1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CB_province.SelectedIndex = 0
        CB_education.SelectedIndex = 0
        CB_accessLevel.SelectedIndex = 0

        If TB_dateStarted.Text = "" Then
            TB_dateStarted.Text = DateTime.Now
        End If
    End Sub

    Private Sub BTN_create_Click(sender As Object, e As EventArgs) Handles BTN_create.Click

        'create a check employee number and username so two people wont have the same
        '=============================================================================

        '1/3 Primary Information
        If TB_firstname.Text.Length < 1 Then
            MsgBox("First name can't be blank!", MsgBoxStyle.Exclamation)
            Label1.Visible = True
            Return
        End If

        If TB_lastname.Text.Length < 1 Then
            MsgBox("Last name can't be blank!", MsgBoxStyle.Exclamation)
            Label2.Visible = True
            Return
        End If

        Try
            birthDate = New Date(CB_year.SelectedItem, CInt(CB_month.SelectedItem), CInt(CB_day.SelectedItem))
        Catch ex As Exception
            MsgBox("Enter a correct day", MsgBoxStyle.Exclamation)
            Label3.Visible = True
            Return
        End Try

        If birthDate > Date.Now Then
            MsgBox("Date can't be greater than today...", MsgBoxStyle.Exclamation)
            Label3.Visible = True
            Return
        End If

        If TB_address.Text.Length < 1 Then
            MsgBox("Address can't be blank!", MsgBoxStyle.Exclamation)
            Label4.Visible = True
            Return
        End If

        If TB_city.Text.Length < 1 Then
            MsgBox("City can't be blank!", MsgBoxStyle.Exclamation)
            Label5.Visible = True
            Return
        End If

        If CB_province.SelectedIndex = 0 Then
            MsgBox("Please choose a province!", MsgBoxStyle.Exclamation)
            Label6.Visible = True
            Return
        End If

        If MTB_postalCode.Text.Length <= 6 Then
            MsgBox("Postal code format must be filled out!", MsgBoxStyle.Exclamation)
            Label7.Visible = True
            Return
        End If

        If MTB_homePhone.Text.Length <= 11 Then
            MsgBox("Home phone format must be filled out!", MsgBoxStyle.Exclamation)
            Label8.Visible = True
            Return
        End If

        If MTB_cellPhone.Text.Length <= 11 Then
            MsgBox("Cell phone format must be filled out!", MsgBoxStyle.Exclamation)
            Label9.Visible = True
            Return
        End If

        '2/3 Human Resources
        If TB_employeeNumber.Text.Length < 1 Then
            MsgBox("Employee number can't be blank!", MsgBoxStyle.Exclamation)
            Label10.Visible = True
            Return
        End If

        Dim bool1 = db.GetEmployeeNum(TB_employeeNumber.Text)
        If bool1 = True Then
            MsgBox("That employee number is already in use! Please choose a different employee number.", MsgBoxStyle.Exclamation)
            Label10.Visible = True
            Return
        End If

        If MTB_sin.Text.Length <= 10 Then
            MsgBox("Social insurance number format must be filled out!", MsgBoxStyle.Exclamation)
            Label11.Visible = True
            Return
        End If

        Try
            If CDbl(TB_hourlyPay.Text) <= 11.99 Then
                MsgBox("Hourly pay can't be below minimum wage ($12.00+ )", MsgBoxStyle.Exclamation)
                Label12.Visible = True
                Return
            End If
        Catch ex As Exception
            MsgBox("Hourley pay must be entered correctly", MsgBoxStyle.Exclamation)
            Return
        End Try

        '3/3 Systems Information
        If CB_accessLevel.SelectedItem = "" Then
            MsgBox("Access level must be chosen!", MsgBoxStyle.Exclamation)
            Label15.Visible = True
            Return
        End If

        If TB_username.Text.Length <= 1 Then
            MsgBox("Username can't be blank!", MsgBoxStyle.Exclamation)
            Label16.Visible = True
            Return
        End If

        If CBOX_activeAccount.Checked Then
            TB_activeAccount.Text = 1
        Else
            TB_activeAccount.Text = 2
        End If

        Dim employee_number As Integer = TB_employeeNumber.Text
        Dim username As String = TB_username.Text
        Dim password As String = TB_password.Text
        Dim fname As String = TB_firstname.Text
        Dim lname As String = TB_lastname.Text
        Dim address As String = TB_address.Text
        Dim city As String = TB_city.Text
        Dim province As String = CB_province.Text
        Dim postal_code As String = MTB_postalCode.Text
        Dim home_phone As String = MTB_homePhone.Text
        Dim cell_phone As String = MTB_cellPhone.Text
        Dim start_date As DateTime = TB_dateStarted.Text
        Dim sin As String = MTB_sin.Text
        Dim hourly_Pay As Double = TB_hourlyPay.Text
        Dim education As String = CB_education.Text
        Dim level As Integer = CB_accessLevel.SelectedIndex
        Dim status As Integer = TB_activeAccount.Text

        Dim createEmployee As New Employee(employee_number, username, password, fname, lname, birthDate, address, city, province, postal_code, home_phone, cell_phone, start_date, sin, hourly_Pay, education, level, status)

        Select Case MsgBox("Employee #" & employee_number & vbNewLine &
               "Username:   " & vbTab & username & vbNewLine &
               "First name: " & vbTab & fname & vbNewLine &
               "Last name:  " & vbTab & lname & vbNewLine &
               "Address:    " & vbTab & address & vbNewLine &
               "City:       " & vbTab & vbTab & city & vbNewLine &
               "Province:   " & vbTab & province & vbNewLine &
               "Postal code:" & vbTab & postal_code & vbNewLine &
               "Home phone: " & vbTab & home_phone & vbNewLine &
               "Cell phone: " & vbTab & cell_phone & vbNewLine &
               "Start date: " & vbTab & start_date & vbNewLine &
               "Sin:        " & vbTab & vbTab & sin & vbNewLine &
               "Hourly pay: " & vbTab & hourly_Pay & vbNewLine &
               "Education:  " & vbTab & education & vbNewLine &
               "Level:      " & vbTab & vbTab & level & vbNewLine &
               "status:     " & vbTab & status & vbNewLine,
               MsgBoxStyle.YesNo, "Do you want to add this employee?"
               )
            Case MsgBoxResult.Yes
                db.AddNewEmployee(createEmployee)
                MsgBox(username & " has been sucessfuly added!")
                Dashboard.Show()
                Me.Close()
            Case MsgBoxResult.No
                Return
        End Select

    End Sub

    Private Sub AgeChange(sender As Object, e As EventArgs) Handles CB_year.SelectedValueChanged, CB_month.SelectedValueChanged, CB_day.SelectedValueChanged
        Dim currentAge As Date

        Try
            currentAge = New Date(CInt(CB_year.SelectedItem), CInt(CB_month.SelectedItem), CInt(CB_day.SelectedItem))
        Catch ex As Exception
        End Try

        TB_age.Text = DateDiff(DateInterval.Year, currentAge, Date.Now)
    End Sub

    Private Sub BTN_cancel_Click(sender As Object, e As EventArgs) Handles BTN_cancel.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    '=======================================  MENU STRIP ============================================
    'MenuStrip - File (Change Password, Logout, Exit)
    Private Sub TS_changePassword_Click(sender As Object, e As EventArgs) Handles TS_changePassword.Click
        PasswordEdit.Show()
        Me.Close()
    End Sub

    Private Sub TS_logout_Click(sender As Object, e As EventArgs) Handles TS_logout.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub TS_exit_Click(sender As Object, e As EventArgs) Handles TS_exit.Click
        End
    End Sub

    'MenuStrip - Employees (List, Create, Edit, Delete)
    Private Sub TS_listEmployees_Click(sender As Object, e As EventArgs) Handles TS_listEmployees.Click
        EmployeeList.Show()
        Me.Close()
    End Sub

    Private Sub TS_createEmployees_Click(sender As Object, e As EventArgs) Handles TS_createEmployees.Click
        Return
    End Sub

    Private Sub TS_editEmployees_Click(sender As Object, e As EventArgs) Handles TS_editEmployees.Click
        EmployeeEdit.Show()
        Me.Close()
    End Sub

    Private Sub TS_deleteEmployees_Click(sender As Object, e As EventArgs) Handles TS_deleteEmployees.Click
        EmployeeDelete.Show()
        Me.Close()
    End Sub

    'MenuStrip - Clients (List, Create, Edit, Delete)
    Private Sub TS_listClient_Click(sender As Object, e As EventArgs) Handles TS_listClient.Click
        ClientList.Show()
        Me.Close()
    End Sub

    Private Sub TS_createClient_Click(sender As Object, e As EventArgs) Handles TS_createClient.Click
        ClientCreate.Show()
        Me.Close()
    End Sub

    Private Sub TS_editClient_Click(sender As Object, e As EventArgs) Handles TS_editClient.Click
        ClientEdit.Show()
        Me.Close()
    End Sub

    Private Sub TS_deleteClient_Click(sender As Object, e As EventArgs) Handles TS_deleteClient.Click
        ClientDelete.Show()
        Me.Close()
    End Sub

    'MenuStrip - Videos (List, Create, Edit, Delete)
    Private Sub TS_listVideos_Click(sender As Object, e As EventArgs) Handles TS_listVideos.Click
        VideoList.Show()
        Me.Close()
    End Sub

    Private Sub TS_createVideos_Click(sender As Object, e As EventArgs) Handles TS_createVideos.Click
        VideoCreate.Show()
        Me.Close()
    End Sub

    Private Sub TS_editVideos_Click(sender As Object, e As EventArgs) Handles TS_editVideos.Click
        VideoEdit.Show()
        Me.Close()
    End Sub

    Private Sub TS_deleteVideos_Click(sender As Object, e As EventArgs) Handles TS_deleteVideos.Click
        VideoDelete.Show()
        Me.Close()
    End Sub

    'MenuStrip - Search (Quick Search, Advanced Search)
    Private Sub TS_quickSearch_Click(sender As Object, e As EventArgs) Handles TS_quickSearch.Click
        SearchQuick.Show()
        Me.Close()
    End Sub

    Private Sub TS_advancedSearch_Click(sender As Object, e As EventArgs) Handles TS_advancedSearch.Click
        SearchAdvanced.Show()
        Me.Close()
    End Sub

    'MenuStrip - Rent  (Rent video, Return video)
    Private Sub TS_rentVideo_Click(sender As Object, e As EventArgs) Handles TS_rentVideo.Click
        VideoRent.Show()
        Me.Close()
    End Sub

    Private Sub TS_returnVideo_Click(sender As Object, e As EventArgs) Handles TS_returnVideo.Click
        VideoReturn.Show()
        Me.Close()
    End Sub

    '=======================================  MENU STRIP ============================================

End Class