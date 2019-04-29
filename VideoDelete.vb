Public Class VideoDelete

    Public Video_List As List(Of User)
    Dim DeleteVideo As Video = Nothing

    Private Sub VideoDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBManager

        Video_List = db.SelectVideo
        CB_chooseVideo.DataSource = Video_List
        CB_chooseVideo.DisplayMember = "DisplayColumns"
        CB_chooseVideo.ValueMember = "DisplayRows"

        CB_year.SelectedIndex = CB_year.FindString(DeleteVideo.Year)
    End Sub

    Private Sub CB_chooseVideo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_chooseVideo.SelectedIndexChanged
        Dim db As New DBManager

        If CB_chooseVideo.SelectedValue IsNot Nothing Then
            DeleteVideo = db.GetVideoID(CType(CB_chooseVideo.SelectedItem, User).DisplayRows)

            If DeleteVideo IsNot Nothing Then

                ' #1 - Video Information
                TB_videoTitle.Text = DeleteVideo.Title
                TB_genre.Text = DeleteVideo.Genre
                'CB_year.Text = DeleteVideo.Year

                CB_year.SelectedIndex = CB_year.FindString(DeleteVideo.Year)
                TB_language.Text = DeleteVideo.Language
                TB_country.Text = DeleteVideo.Country
                NUD_length.Text = DeleteVideo.Length
                TB_director.Text = DeleteVideo.Director
                TB_actors.Text = DeleteVideo.Actors
                TB_description.Text = DeleteVideo.ResumeVideo

                ' #2 - Upload photo
                TB_postPhotoURL.Text = DeleteVideo.Photo

                ' #3 - System Information
                TB_videoID.Text = DeleteVideo.Video_id


            End If
        End If
    End Sub

    Private Sub BTN_delete_Click(sender As Object, e As EventArgs) Handles BTN_delete.Click
        Select Case MsgBox("Video id:     " & vbTab & DeleteVideo.Video_id & vbNewLine &
                           "Title:        " & vbTab & DeleteVideo.Title & vbNewLine &
                           "Year:         " & vbTab & DeleteVideo.Year & vbNewLine &
                           "Language:     " & vbTab & DeleteVideo.Language & vbNewLine &
                           "Country:      " & vbTab & DeleteVideo.Country & vbNewLine &
                           "Length:       " & vbTab & DeleteVideo.Length & vbNewLine &
                           "Postal code:  " & vbTab & DeleteVideo.Director & vbNewLine &
                           "Actors:       " & vbTab & DeleteVideo.Actors & vbNewLine &
                           "Description:  " & vbTab & DeleteVideo.ResumeVideo & vbNewLine,
                            MsgBoxStyle.YesNo, "Do you want to delete this video?"
                           )
            Case MsgBoxResult.Yes
                Dim db As New DBManager
                db.DeleteVideo(DeleteVideo.Video_id)
                MsgBox("Video id: " & DeleteVideo.Video_id & "  | Title: " & DeleteVideo.Title & " has been sucessfuly deleted!")
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
        Return
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