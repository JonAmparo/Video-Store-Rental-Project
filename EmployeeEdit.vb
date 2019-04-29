Public Class EmployeeEdit

    Public Employee_List As List(Of User)
    Dim EditEmployee As Employee = Nothing

    Public birthDate As Date

    Private Sub EmployeeEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBManager

        Employee_List = db.SelectEmployee
        CB_chooseEmployee.DataSource = Employee_List
        CB_chooseEmployee.DisplayMember = "DisplayColumns"
        CB_chooseEmployee.ValueMember = "DisplayRows"

        CB_year.SelectedIndex = CB_year.FindString(EditEmployee.Dob.Year)
        CB_month.SelectedIndex = CB_month.FindString(EditEmployee.Dob.Month)
        CB_day.SelectedIndex = CB_day.FindString(EditEmployee.Dob.Day)

    End Sub

    Private Sub CB_chooseEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_chooseEmployee.SelectedIndexChanged
        Dim db As New DBManager

        If CB_chooseEmployee.SelectedValue IsNot Nothing Then
            EditEmployee = db.GetEmployeeNum(CType(CB_chooseEmployee.SelectedItem, User).DisplayRows)

            If EditEmployee IsNot Nothing Then
                '1/3 - Primary Information
                TB_firstname.Text = EditEmployee.Fname
                TB_lastname.Text = EditEmployee.Lname
                CB_year.SelectedIndex = CB_year.FindString(EditEmployee.Dob.Year)
                CB_month.SelectedIndex = CB_month.FindString(EditEmployee.Dob.Month)
                CB_day.SelectedIndex = CB_day.FindString(EditEmployee.Dob.Day)

                TB_address.Text = EditEmployee.Address
                TB_city.Text = EditEmployee.City
                CB_province.SelectedIndex = CB_province.FindString(EditEmployee.Province)
                MTB_postalCode.Text = EditEmployee.Postal_code
                MTB_homePhone.Text = EditEmployee.Home_phone
                MTB_cellPhone.Text = EditEmployee.Cell_phone

                '2/3 - Human Resources
                TB_employeeNumber.Text = EditEmployee.Employee_number
                MTB_sin.Text = EditEmployee.Sin
                TB_hourlyPay.Text = EditEmployee.Hourly_pay
                TB_dateStarted.Text = EditEmployee.Start_date
                CB_education.SelectedIndex = CB_education.FindString(EditEmployee.Education)

                '3/3 - Systems Information
                CB_accessLevel.Text = CB_accessLevel.FindString(EditEmployee.Level)
                TB_username.Text = EditEmployee.Username
                'TB_password.Text = ""

                'Active or not ---- NEW!!!
                'If TB_activeAccount.Text = 1 Then
                '    CBOX_activeAccount.Checked = True
                'ElseIf TB_activeAccount.Text = 2 Then
                '    CBOX_activeAccount.Checked = False
                'End If

                'Status level
                If EditEmployee.Level = 1 Then
                    CB_accessLevel.SelectedIndex = 1
                ElseIf EditEmployee.Level = 2 Then
                    CB_accessLevel.SelectedIndex = 2
                ElseIf EditEmployee.Level = 3 Then
                    CB_accessLevel.SelectedIndex = 3
                End If

            End If
        End If
    End Sub

    Private Sub ChangeAge(sender As Object, e As EventArgs) Handles CB_year.SelectedIndexChanged, CB_day.SelectedValueChanged, CB_month.SelectedValueChanged
        Dim currentAge As Date

        Try
            currentAge = New Date(CInt(CB_year.SelectedItem), CInt(CB_month.SelectedItem), CInt(CB_day.SelectedItem))
        Catch ex As Exception
        End Try

        TB_age.Text = DateDiff(DateInterval.Year, currentAge, Date.Now)
    End Sub

    Private Sub BTN_save_Click(sender As Object, e As EventArgs) Handles BTN_save.Click
        Dim db As New DBManager

        '1/3 - Primary Information
        If TB_firstname.Text.Length < 1 Then
            MsgBox("First name can't be blank!", MsgBoxStyle.Exclamation)
            Return
        End If

        If TB_lastname.Text.Length < 1 Then
            MsgBox("Last name can't be blank!", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            birthDate = New Date(CInt(CB_year.SelectedItem), CInt(CB_month.SelectedItem), CInt(CB_day.SelectedItem))
        Catch ex As Exception
            MsgBox("Enter a correct day", MsgBoxStyle.Exclamation)
            Return
        End Try

        If birthDate > Date.Now Then
            MsgBox("Date can't be greater than today...", MsgBoxStyle.Exclamation)
            Return
        End If

        If TB_address.Text.Length < 1 Then
            MsgBox("Address can't be blank!", MsgBoxStyle.Exclamation)
            Return
        End If

        If TB_city.Text.Length < 1 Then
            MsgBox("City can't be blank!", MsgBoxStyle.Exclamation)
            Return
        End If

        If MTB_postalCode.Text.Length <= 6 Then
            MsgBox("Postal code format must be filled out!", MsgBoxStyle.Exclamation)
            Return
        End If

        If MTB_homePhone.Text.Length <= 11 Then
            MsgBox("Home phone format must be filled out!", MsgBoxStyle.Exclamation)
            Return
        End If

        If MTB_cellPhone.Text.Length <= 11 Then
            MsgBox("Cell phone format must be filled out!", MsgBoxStyle.Exclamation)
            Return
        End If

        If CB_province.SelectedIndex = 0 Then
            MsgBox("Please choose a province!", MsgBoxStyle.Exclamation)
            Return
        End If

        '2/3 - Human Resources
        If TB_employeeNumber.Text.Length < 1 Then
            MsgBox("Employee number can't be blank!", MsgBoxStyle.Exclamation)
            Return
        End If

        If MTB_sin.Text.Length <= 10 Then
            MsgBox("Social insurance number format must be filled out!", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            If CDbl(TB_hourlyPay.Text) <= 11.99 Then
                MsgBox("Hourly pay can't be below minimum wage ($12.00+ )", MsgBoxStyle.Exclamation)
                Return
            End If
        Catch ex As Exception
            MsgBox("Hourley pay must be entered correctly", MsgBoxStyle.Exclamation)
            Return
        End Try

        If TB_employeeNumber.Text <= 2 Then
            MsgBox("Employee number is already in use!  Choose a different number!", MsgBoxStyle.Exclamation)
            Return
        End If

        '3/3 - Systems Information
        If CB_accessLevel.SelectedItem = "" Then
            MsgBox("Access level must be chosen!", MsgBoxStyle.Exclamation)
            Return
        End If

        'If CB_accessLevel.SelectedItem = "1 (Low)" Then
        '    CB_accessLevel.Text = 1
        'ElseIf CB_accessLevel.SelectedItem = "2 (Mid)" Then
        '    CB_accessLevel.Text = 2
        'ElseIf CB_accessLevel.SelectedItem = "3 (High)" Then
        '    CB_accessLevel.Text = 3

        'End If

        If TB_username.Text.Length <= 1 Then
            MsgBox("Username can't be blank!", MsgBoxStyle.Exclamation)
            Return
        End If

        'Check is username is taken
        'If EditEmployee.Username <> TB_username.Text Then
        '
        '    If db.(TB_username.Text) = True Then
        '        MsgBox("")
        '        Return
        '    End If

        'End If

        If CBOX_activeAccount.Checked Then
            TB_activeAccount.Text = 1
        Else
            TB_activeAccount.Text = 2
        End If

        '1/3 - Primary Information
        EditEmployee.Fname = TB_firstname.Text
        EditEmployee.Lname = TB_lastname.Text
        EditEmployee.Dob = birthDate
        EditEmployee.Address = TB_address.Text
        EditEmployee.City = TB_city.Text
        EditEmployee.Province = CB_province.SelectedItem
        EditEmployee.Postal_code = MTB_postalCode.Text
        EditEmployee.Home_phone = MTB_homePhone.Text
        EditEmployee.Cell_phone = MTB_cellPhone.Text

        '2/3 - Human Resources
        EditEmployee.Sin = MTB_sin.Text
        EditEmployee.Hourly_pay = TB_hourlyPay.Text
        EditEmployee.Start_date = TB_dateStarted.Text
        EditEmployee.Education = CB_education.SelectedItem

        '3/3 - Systems Information
        EditEmployee.Level = CB_accessLevel.SelectedIndex
        EditEmployee.Username = TB_username.Text
        EditEmployee.Status = TB_activeAccount.Text


        Select Case MsgBox("Employee #: " & vbTab & EditEmployee.Employee_number & vbNewLine &
               "Username:   " & vbTab & EditEmployee.Username & vbNewLine &
               "First name: " & vbTab & EditEmployee.Fname & vbNewLine &
               "Last name:  " & vbTab & EditEmployee.Lname & vbNewLine &
               "Address:    " & vbTab & EditEmployee.Address & vbNewLine &
               "City:       " & vbTab & vbTab & EditEmployee.City & vbNewLine &
               "Province:   " & vbTab & EditEmployee.Province & vbNewLine &
               "Postal code:" & vbTab & EditEmployee.Postal_code & vbNewLine &
               "Home phone: " & vbTab & EditEmployee.Home_phone & vbNewLine &
               "Cell phone: " & vbTab & EditEmployee.Cell_phone & vbNewLine &
               "Start date: " & vbTab & EditEmployee.Start_date & vbNewLine &
               "Sin:        " & vbTab & vbTab & EditEmployee.Sin & vbNewLine &
               "Hourly pay: " & vbTab & EditEmployee.Hourly_pay & vbNewLine &
               "Education:  " & vbTab & EditEmployee.Education & vbNewLine &
               "Level:      " & vbTab & vbTab & EditEmployee.Level & vbNewLine &
               "status:     " & vbTab & EditEmployee.Status & vbNewLine,
               MsgBoxStyle.YesNo, "Are you sure you want this edit?"
               )
            Case MsgBoxResult.Yes
                db.EditEmployee(EditEmployee)
                EditEmployee = Nothing
                MsgBox(TB_username.Text & " has been sucessfuly added!")
                Dashboard.Show()
                Me.Close()
            Case MsgBoxResult.No
                Return
        End Select

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
        EmployeeList.visible = True
        Me.Close()
    End Sub

    Private Sub TS_createEmployees_Click(sender As Object, e As EventArgs) Handles TS_createEmployees.Click
        EmployeeCreate1.Show()
        Me.Close()
    End Sub

    Private Sub TS_editEmployees_Click(sender As Object, e As EventArgs) Handles TS_editEmployees.Click
        Return
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