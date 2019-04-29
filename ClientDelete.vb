Public Class ClientDelete

    Public Client_List As List(Of User)
    Dim DeleteClient As Client = Nothing

    Public birthDate As Date
    Public expirationDate As Date

    Private Sub ClientDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBManager

        Client_List = db.SelectClient
        CB_chooseClient.DataSource = Client_List
        CB_chooseClient.DisplayMember = "DisplayColumns"
        CB_chooseClient.ValueMember = "DisplayRows"

        Try
            birthDate = New Date(CInt(CB_year.SelectedItem), CInt(CB_month.SelectedItem), CInt(CB_day.SelectedItem))
        Catch ex As Exception
            MsgBox("Enter a correct day", MsgBoxStyle.Exclamation)
            Return
        End Try

        CB_year.SelectedIndex = CB_year.FindString(DeleteClient.Dob.Year)
        CB_month.SelectedIndex = CB_month.FindString(DeleteClient.Dob.Month)
        CB_day.SelectedIndex = CB_day.FindString(DeleteClient.Dob.Day)

    End Sub

    Private Sub ChangeAge(sender As Object, e As EventArgs) Handles CB_year.SelectedValueChanged, CB_month.SelectedValueChanged, CB_day.SelectedValueChanged
        Dim currentAge As Date

        Try
            currentAge = New Date(CInt(CB_year.SelectedItem), CInt(CB_month.SelectedItem), CInt(CB_day.SelectedItem))
        Catch ex As Exception
        End Try

        TB_age.Text = DateDiff(DateInterval.Year, currentAge, Date.Now)
    End Sub

    Private Sub CB_chooseClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_chooseClient.SelectedIndexChanged
        Dim db As New DBManager

        If CB_chooseClient.SelectedValue IsNot Nothing Then
            DeleteClient = db.GetClientNum(CType(CB_chooseClient.SelectedItem, User).DisplayRows)

            If DeleteClient IsNot Nothing Then
                '1/3 - Primary Information
                TB_firstname.Text = DeleteClient.Fname
                TB_lastname.Text = DeleteClient.Lname
                TB_email.Text = DeleteClient.Email
                MTB_phone.Text = DeleteClient.Phone
                CB_year.SelectedIndex = CB_year.FindString(DeleteClient.Dob.Year)
                CB_month.SelectedIndex = CB_month.FindString(DeleteClient.Dob.Month)
                CB_day.SelectedIndex = CB_day.FindString(DeleteClient.Dob.Day)
                TB_address.Text = DeleteClient.Address
                TB_city.Text = DeleteClient.City
                CB_province.SelectedIndex = CB_province.FindString(DeleteClient.Province)
                MTB_postalCode.Text = DeleteClient.Postal_code

                '2/3 - Credit Information

                'CB_typeOfCard.SelectedItem = Edit_Client.
                'MTB_cardNumber.Text = Edit_Client.
                'CB_yearExp.SelectedIndex = CB_yearExp.FindString(EditClient.Dob.Year)
                'CB_monthExp.SelectedIndex = CB_monthExp.FindString(EditClient.Dob.Month)
                'CB_dayExp.SelectedIndex = CB_dayExp.FindString(EditClient.Dob.Day)


                '3/3 - Systems Information
                TB_clientNumber.Text = DeleteClient.Client_number
                TB_activeAccount.Text = DeleteClient.Status

                If TB_activeAccount.Text = 1 Then
                    CBOX_activeAccount.Checked = True
                ElseIf TB_activeAccount.Text = 2 Then
                    CBOX_activeAccount.Checked = False
                End If

                'CB_accessLevel.Text = CB_accessLevel.FindString(EditEmployee.Level)

                'CBOX_activeAccount.CheckAlign = status
                'Make sure that check box is checked 

            End If
        End If
    End Sub

    Private Sub BTN_cancel_Click(sender As Object, e As EventArgs) Handles BTN_cancel.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub BTN_delete_Click(sender As Object, e As EventArgs) Handles BTN_delete.Click

        Select Case MsgBox("Client id:" & vbTab & vbTab & DeleteClient.Client_id & vbNewLine &
                           "First name: " & vbTab & DeleteClient.Fname & vbNewLine &
                           "Last name:  " & vbTab & DeleteClient.Lname & vbNewLine &
                           "Address:    " & vbTab & DeleteClient.Address & vbNewLine &
                           "City:       " & vbTab & vbTab & DeleteClient.City & vbNewLine &
                           "Province:   " & vbTab & DeleteClient.Province & vbNewLine &
                           "Postal code:" & vbTab & DeleteClient.Postal_code & vbNewLine &
                           "Phone:      " & vbTab & DeleteClient.Phone & vbNewLine &
                           "Email:      " & vbTab & DeleteClient.Email & vbNewLine,
                            MsgBoxStyle.YesNo, "Do you want to delete this client?"
                           )
            Case MsgBoxResult.Yes
                Dim db As New DBManager
                db.DeleteClient(DeleteClient.Client_number)
                MsgBox("Client id: " & DeleteClient.Client_id & " | Name: " & DeleteClient.Fname & " " & DeleteClient.Lname & " has been sucessfuly deleted!")
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
        Return
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