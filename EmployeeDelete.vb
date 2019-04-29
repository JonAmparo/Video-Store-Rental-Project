Public Class EmployeeDelete

    Public Employee_List As List(Of User)
    Dim DeleteEmployee As Employee = Nothing

    Public birthDate As Date

    Private Sub EmployeeDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBManager

        Employee_List = db.SelectEmployee
        CB_chooseEmployee.DataSource = Employee_List
        CB_chooseEmployee.DisplayMember = "DisplayColumns"
        CB_chooseEmployee.ValueMember = "DisplayRows"


        Try
            birthDate = New Date(CInt(CB_year.SelectedItem), CInt(CB_month.SelectedItem), CInt(CB_day.SelectedItem))
        Catch ex As Exception
            MsgBox("Enter a correct day", MsgBoxStyle.Exclamation)
            Return
        End Try

        CB_year.SelectedIndex = CB_year.FindString(DeleteEmployee.Dob.Year)
        CB_month.SelectedIndex = CB_month.FindString(DeleteEmployee.Dob.Month)
        CB_day.SelectedIndex = CB_day.FindString(DeleteEmployee.Dob.Day)


    End Sub

    Private Sub CB_year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_year.SelectedIndexChanged, CB_day.SelectedValueChanged, CB_month.SelectedValueChanged
        Dim currentAge As Date

        Try
            currentAge = New Date(CInt(CB_year.SelectedItem), CInt(CB_month.SelectedItem), CInt(CB_day.SelectedItem))
        Catch ex As Exception
        End Try

        TB_age.Text = DateDiff(DateInterval.Year, currentAge, Date.Now)
    End Sub

    Private Sub CB_chooseEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_chooseEmployee.SelectedIndexChanged
        Dim db As New DBManager

        If CB_chooseEmployee.SelectedValue IsNot Nothing Then
            DeleteEmployee = db.GetEmployeeNum(CType(CB_chooseEmployee.SelectedItem, User).DisplayRows)

            If DeleteEmployee IsNot Nothing Then
                '1/3 - Primary Information
                TB_firstname.Text = DeleteEmployee.Fname
                TB_lastname.Text = DeleteEmployee.Lname
                CB_year.SelectedIndex = CB_year.FindString(DeleteEmployee.Dob.Year)
                CB_month.SelectedIndex = CB_month.FindString(DeleteEmployee.Dob.Month)
                CB_day.SelectedIndex = CB_day.FindString(DeleteEmployee.Dob.Day)

                TB_address.Text = DeleteEmployee.Address
                TB_city.Text = DeleteEmployee.City
                CB_province.SelectedIndex = CB_province.FindString(DeleteEmployee.Province)
                MTB_postalCode.Text = DeleteEmployee.Postal_code
                MTB_homePhone.Text = DeleteEmployee.Home_phone
                MTB_cellPhone.Text = DeleteEmployee.Cell_phone

                '2/3 - Human Resources
                TB_employeeNumber.Text = DeleteEmployee.Employee_number
                MTB_sin.Text = DeleteEmployee.Sin
                TB_hourlyPay.Text = DeleteEmployee.Hourly_pay
                TB_dateStarted.Text = DeleteEmployee.Start_date
                CB_education.SelectedIndex = CB_education.FindString(DeleteEmployee.Education)

                '3/3 - Systems Information
                'CB_accessLevel.Text = CB_accessLevel.FindString(EditEmployee.Level)
                TB_username.Text = DeleteEmployee.Username
                TB_password.Text = "**"

                'CBOX_activeAccount.CheckAlign = status
                'Make sure that check box is checked 

                If DeleteEmployee.Level = 0 Then
                    CB_accessLevel.SelectedIndex = 0
                ElseIf DeleteEmployee.Level = 1 Then
                    CB_accessLevel.SelectedIndex = 1
                ElseIf DeleteEmployee.Level = 2 Then
                    CB_accessLevel.SelectedIndex = 2
                End If

            End If
        End If
    End Sub

    Private Sub BTN_cancel_Click(sender As Object, e As EventArgs) Handles BTN_cancel.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub BTN_delete_Click(sender As Object, e As EventArgs) Handles BTN_delete.Click

        Select Case MsgBox("Delete employee: " & vbNewLine & vbNewLine &
                           "Employee # " & DeleteEmployee.Employee_number & vbNewLine &
                           "Username:   " & vbTab & DeleteEmployee.Username & vbNewLine &
                           "First name: " & vbTab & DeleteEmployee.Fname & vbNewLine &
                           "Last name:  " & vbTab & DeleteEmployee.Lname & vbNewLine, MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Dim db As New DBManager
                db.DeleteEmployee(DeleteEmployee.Employee_number)
                MsgBox(TB_username.Text & " has been sucessfuly deleted!")
                Dashboard.Show()
                Me.Close()
            Case MsgBoxResult.No
                Return
        End Select
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
        EmployeeCreate1.Show()
        Me.Close()
    End Sub

    Private Sub TS_editEmployees_Click(sender As Object, e As EventArgs) Handles TS_editEmployees.Click
        EmployeeEdit.Show()
        Me.Close()
    End Sub

    Private Sub TS_deleteEmployees_Click(sender As Object, e As EventArgs) Handles TS_deleteEmployees.Click
        Return
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