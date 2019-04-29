Public Class VideoEdit

    Public Video_List As List(Of User)
    Dim EditVideo As Video = Nothing

    Private Sub VideoEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DBManager

        Video_List = db.SelectVideo
        CB_chooseVideo.DataSource = Video_List
        CB_chooseVideo.DisplayMember = "DisplayColumns"
        CB_chooseVideo.ValueMember = "DisplayRows"


        CB_year.SelectedIndex = CB_year.FindString(EditVideo.Year)
    End Sub

    Private Sub CB_chooseVideo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_chooseVideo.SelectedIndexChanged
        Dim db As New DBManager

        If CB_chooseVideo.SelectedValue IsNot Nothing Then
            EditVideo = db.GetVideoID(CType(CB_chooseVideo.SelectedItem, User).DisplayRows)

            If EditVideo IsNot Nothing Then

                ' #1 - Video Information
                TB_videoTitle.Text = EditVideo.Title
                TB_genre.Text = EditVideo.Genre
                'CB_year.Text = EditVideo.Year

                CB_year.SelectedIndex = CB_year.FindString(EditVideo.Year)
                TB_language.Text = EditVideo.Language
                TB_country.Text = EditVideo.Country
                NUD_length.Text = EditVideo.Length
                TB_director.Text = EditVideo.Director
                TB_actors.Text = EditVideo.Actors
                TB_description.Text = EditVideo.ResumeVideo

                ' #2 - Upload photo
                TB_postPhotoURL.Text = EditVideo.Photo

                ' #3 - System Information
                TB_videoID.Text = EditVideo.Video_id

            End If
        End If
    End Sub

    Private Sub BTN_save_Click(sender As Object, e As EventArgs) Handles BTN_save.Click
        Dim db As New DBManager

        ' #1 - Video Information
        If TB_videoTitle.Text.Length < 1 Then
            MsgBox("Video title can't be blank!", MsgBoxStyle.Exclamation)
            Return
        End If

        If TB_genre.Text.Length < 1 Then
            MsgBox("Genre can't be blank!", MsgBoxStyle.Exclamation)
            Return
        End If

        'Fix with years all the way back to 1900s
        If CB_year.Text.Length < 1 Then
            MsgBox("Year can't be blank!", MsgBoxStyle.Exclamation)
            Return
        End If

        If TB_language.Text.Length < 1 Then
            MsgBox("Language can't be blank!", MsgBoxStyle.Exclamation)
            Return
        End If

        If TB_country.Text.Length < 1 Then
            MsgBox("Country can't be blank!", MsgBoxStyle.Exclamation)
            Return
        End If

        If NUD_length.Text.Length = 0 Then
            MsgBox("Must set a length longer than 0 minutes", MsgBoxStyle.Exclamation)
            Return
        End If

        If TB_director.Text.Length < 1 Then
            MsgBox("Director can't be blank!", MsgBoxStyle.Exclamation)
            Return
        End If

        If TB_actors.Text.Length < 1 Then
            MsgBox("Actors can't be blank!", MsgBoxStyle.Exclamation)
            Return
        End If

        If TB_description.Text.Length < 1 Then
            MsgBox("Description can't be blank!", MsgBoxStyle.Exclamation)
            Return
        End If

        ' #2 - Upload photo
        If TB_postPhotoURL.Text.Length < 1 Then
            MsgBox("Photo URL can't be blank!", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim status As Integer = 1

        ' #1 Video Information
        EditVideo.Title = TB_videoTitle.Text
        EditVideo.Genre = TB_genre.Text
        EditVideo.Year = CB_year.SelectedItem
        EditVideo.Language = TB_language.Text
        EditVideo.Country = TB_country.Text
        EditVideo.Length = NUD_length.Text
        EditVideo.Director = TB_director.Text
        EditVideo.Actors = TB_actors.Text
        EditVideo.ResumeVideo = TB_description.Text

        ' #2 - Upload photo
        EditVideo.Photo = TB_postPhotoURL.Text

        ' #3 - System Information
        EditVideo.Status = status
        EditVideo.Video_id = TB_videoID.Text

        'try and make image load as soon as URL is entered

        'COPY FROM VIDEO CREATE -- VALIDATION!!!

        Select Case MsgBox("Video id:     " & vbTab & EditVideo.Video_id & vbNewLine &
                           "Title:        " & vbTab & EditVideo.Title & vbNewLine &
                           "Year:         " & vbTab & EditVideo.Year & vbNewLine &
                           "Language:     " & vbTab & EditVideo.Language & vbNewLine &
                           "Country:      " & vbTab & EditVideo.Country & vbNewLine &
                           "Length:       " & vbTab & EditVideo.Length & vbNewLine &
                           "Postal code:  " & vbTab & EditVideo.Director & vbNewLine &
                           "Actors:       " & vbTab & EditVideo.Actors & vbNewLine &
                           "Description:  " & vbTab & EditVideo.ResumeVideo & vbNewLine,
                            MsgBoxStyle.YesNo, "Do you want to edit this video?"
                           )
            Case MsgBoxResult.Yes
                'Dim db As New DBManager
                db.EditVideo(EditVideo)
                MsgBox("Video id: " & EditVideo.Video_id & "  | Title: " & EditVideo.Title & " has been sucessfuly edited!")
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
        Return
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