﻿Public Class SearchAdvanced

    Private Sub SearchAdvanced_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN_search_Click(sender As Object, e As EventArgs) Handles BTN_search.Click
        Dim SearchItem As New SearchClass
        Dim db As New DBManager

        'If TB_title.Text = "" Then
        '    MsgBox("Can't be blank!")
        '    Return
        'End If

        SearchItem.Title = TB_title.Text
        SearchItem.Genre = TB_genre.Text
        SearchItem.Year = CB_year.Text '???
        'SearchItem.Year = CB_year.Text '???
        SearchItem.Language = TB_language.Text
        SearchItem.Country = TB_country.Text
        'Length // Make it so that when the user picks a start time to end time
        'to find movies that are between x and y (picking a movie less then 1 hour
        'but more than 45 minutes)
        SearchItem.Length = NUD_length1.Text '???
        'SearchItem.Length = NUD_length2.Text '???
        SearchItem.Director = TB_director.Text
        SearchItem.Actors = TB_actors.Text
        SearchItem.ResumeVideo = TB_description.Text

        Dim data1 = db.AdvancedSearch(SearchItem)
        Dashboard.Show()

        Dashboard.DGV_dashboard.Visible = True

        If Dashboard.DGV_dashboard.DataSource IsNot Nothing Then
            Dashboard.DGV_dashboard.DataSource = Nothing
        End If

        Try

            With Dashboard.DGV_dashboard
                .DataSource = data1

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.AbortRetryIgnore, "Search Advanced Class Error!")
        End Try

        Me.Close()

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
        Return
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