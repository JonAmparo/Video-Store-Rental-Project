Public Class ClientEdit

    Public Client_List As List(Of User)
    Dim EditClient As Client = Nothing

    Public birthDate As Date
    Public expirationDate As Date

    Private Sub ClientEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBManager

        Client_List = db.SelectClient
        CB_chooseClient.DataSource = Client_List
        CB_chooseClient.DisplayMember = "DisplayColumns"
        CB_chooseClient.ValueMember = "DisplayRows"

        CB_year.SelectedIndex = CB_year.FindString(EditClient.Dob.Year)
        CB_month.SelectedIndex = CB_month.FindString(EditClient.Dob.Month)
        CB_day.SelectedIndex = CB_day.FindString(EditClient.Dob.Day)
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
            EditClient = db.GetClientNum(CType(CB_chooseClient.SelectedItem, User).DisplayRows)

            If EditClient IsNot Nothing Then

                '1/3 - Primary Information
                TB_firstname.Text = EditClient.Fname
                TB_lastname.Text = EditClient.Lname
                TB_email.Text = EditClient.Email
                MTB_phone.Text = EditClient.Phone
                CB_year.SelectedIndex = CB_year.FindString(EditClient.Dob.Year)
                CB_month.SelectedIndex = CB_month.FindString(EditClient.Dob.Month)
                CB_day.SelectedIndex = CB_day.FindString(EditClient.Dob.Day)
                TB_address.Text = EditClient.Address
                TB_city.Text = EditClient.City
                CB_province.SelectedIndex = CB_province.FindString(EditClient.Province)
                MTB_postalCode.Text = EditClient.Postal_code

                '2/3 - Credit Information

                'CB_typeOfCard.SelectedItem = Edit_Client.
                'MTB_cardNumber.Text = Edit_Client.
                'CB_yearExp.SelectedIndex = CB_yearExp.FindString(EditClient.Dob.Year)
                'CB_monthExp.SelectedIndex = CB_monthExp.FindString(EditClient.Dob.Month)
                'CB_dayExp.SelectedIndex = CB_dayExp.FindString(EditClient.Dob.Day)


                '3/3 - Systems Information
                TB_clientNumber.Text = EditClient.Client_number
                TB_activeAccount.Text = EditClient.Status

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

    Private Sub BTN_save_Click(sender As Object, e As EventArgs) Handles BTN_save.Click
        Dim db As New DBManager

        '1/3 Primary Information
        If TB_firstname.Text.Length < 1 Then
            MsgBox("First name can't be blank!", MsgBoxStyle.Exclamation)
            Return
        End If

        If TB_lastname.Text.Length < 1 Then
            MsgBox("Last name can't be blank!", MsgBoxStyle.Exclamation)
            Return
        End If

        If TB_email.Text.Length < 1 Then
            MsgBox("Last name can't be blank!", MsgBoxStyle.Exclamation)
            Return
        End If

        If MTB_phone.Text.Length <> 12 Then
            MsgBox("Home phone format must be filled out!", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            birthDate = New Date(CInt(CB_year.SelectedItem), CInt(CB_month.SelectedItem), CInt(CB_day.SelectedItem))
        Catch ex As Exception
            MsgBox("Enter a correct birth date", MsgBoxStyle.Exclamation)
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

        If CB_province.SelectedIndex = 0 Then
            MsgBox("Please choose a province!", MsgBoxStyle.Exclamation)
            Return
        End If

        If MTB_postalCode.Text.Length <= 6 Then
            MsgBox("Postal code format must be filled out correctly!", MsgBoxStyle.Exclamation)
            Return
        End If


        '2/3 Credit Information
        'If CB_typeOfCard.SelectedIndex = 0 Then
        '    MsgBox("Please choose from the types of card.", MsgBoxStyle.Exclamation)
        '    Return
        'End If

        'If MTB_cardNumber.Text.Length <> 19 Then
        '    MsgBox("Card number must be filled out correctly!", MsgBoxStyle.Exclamation)
        '    Return
        'End If

        'If CB_year.SelectedItem Is Nothing Then ' =
        '    MsgBox("Expiration date must be filled correctly!", MsgBoxStyle.Exclamation)
        '    Return
        'End If

        'If CB_month.SelectedItem Is Nothing Then  ' =
        '    MsgBox("Expiration date must be filled correctly!", MsgBoxStyle.Exclamation)
        '    Return
        'End If

        'Try
        '    expirationDate = New Date(CInt(CB_yearExp.SelectedItem), CInt(CB_monthExp.SelectedItem), CInt(CB_dayExp.SelectedIndex))
        'Catch ex As Exception
        '    MsgBox("Enter a correct expiration date", MsgBoxStyle.Exclamation)
        '    Return
        'End Try

        'If expirationDate < Date.Now Then
        '    MsgBox("Card can't be expired...", MsgBoxStyle.Exclamation)
        '    Return
        'End If

        '3/3 Systems Information

        'If TB_clientNumber.Text = "" Then
        '    MsgBox("Client number can't be blank!", MsgBoxStyle.Exclamation)
        '    Return
        'End If

        'check if client number is already taken --------------------------

        If CBOX_activeAccount.Checked Then
            TB_activeAccount.Text = 1
        Else
            TB_activeAccount.Text = 2
        End If


        '1/3 - Primary Information
        EditClient.Fname = TB_firstname.Text
        EditClient.Lname = TB_lastname.Text
        EditClient.Email = TB_email.Text
        EditClient.Phone = MTB_phone.Text
        EditClient.Dob = birthDate
        EditClient.Address = TB_address.Text
        EditClient.City = TB_city.Text
        EditClient.Province = CB_province.Text
        EditClient.Postal_code = MTB_postalCode.Text

        '2/3 - Credit Information
        Dim typeOfCard As String = CB_typeOfCard.SelectedItem
        Dim cardNumber As String = MTB_cardNumber.Text
        'Dim expirationDate As String = .Text  -- See if it can be changed

        '3/3 - Systems Information
        Dim clientNumber As Integer = TB_clientNumber.Text
        Dim activeAccount As String = TB_activeAccount.Text


        Select Case MsgBox("Edit new client: Client Number #" & clientNumber & vbNewLine & vbNewLine &
               "First name: " & vbTab & EditClient.Fname & vbNewLine &
               "Last name:  " & vbTab & EditClient.Lname & vbNewLine &
               "Address:    " & vbTab & EditClient.Address & vbNewLine &
               "City:       " & vbTab & vbTab & EditClient.City & vbNewLine &
               "Province:   " & vbTab & EditClient.Province & vbNewLine &
               "Postal code:" & vbTab & EditClient.Postal_code & vbNewLine &
               "Phone:      " & vbTab & EditClient.Phone & vbNewLine &
               "Email:      " & vbTab & EditClient.Email & vbNewLine,
               MsgBoxStyle.YesNo, "Do you want to edit this client?"
               )
            Case MsgBoxResult.Yes
                db.EditClient(EditClient)
                MsgBox("Client #" & clientNumber & "| Name: " & EditClient.Fname & " " & EditClient.Lname & " has been sucessfuly added!")
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
        Return
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