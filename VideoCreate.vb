Public Class VideoCreate

    Dim db As New DBManager

    Private Sub VideoCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN_create_Click(sender As Object, e As EventArgs) Handles BTN_create.Click
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

        ' #3 - System Information

        'If TB_videoID.Text.Length < 1 Then
        '    MsgBox("Video ID can't be blank!", MsgBoxStyle.Exclamation)
        '    Return
        'End If



        ' #1 - Video Information
        Dim title As String = TB_videoTitle.Text
        Dim genre As String = TB_genre.Text
        Dim year As String = CB_year.SelectedItem
        Dim language As String = TB_language.Text
        Dim country As String = TB_country.Text
        Dim length As String = NUD_length.Text
        Dim director As String = TB_director.Text
        Dim actors As String = TB_actors.Text
        Dim resumeVideo As String = TB_description.Text
        Dim status As Integer = 1

        ' #2 - Upload photo
        Dim photo As String = TB_postPhotoURL.Text

        'try and make image load as soon as URL is entered

        ' #3 - System Information
        'Dim videoID As Integer = TB_videoID.Text

        Dim createVideo As New Video(photo, title, year, country, language, length, resumeVideo, genre, actors, director, status)

        Select Case MsgBox("Title:        " & vbTab & createVideo.Title & vbNewLine &
                           "Year:         " & vbTab & createVideo.Year & vbNewLine &
                           "Language:     " & vbTab & createVideo.Language & vbNewLine &
                           "Country:      " & vbTab & createVideo.Country & vbNewLine &
                           "Length:       " & vbTab & createVideo.Length & vbNewLine &
                           "Postal code:  " & vbTab & createVideo.Director & vbNewLine &
                           "Actors:       " & vbTab & createVideo.Actors & vbNewLine &
                           "Description:  " & vbTab & createVideo.ResumeVideo & vbNewLine,
                            MsgBoxStyle.YesNo, "Do you want to create this video?"
                           )
            Case MsgBoxResult.Yes
                'Dim db As New DBManager
                db.AddNewVideo(createVideo)
                MsgBox("Video id: " & createVideo.Video_id & "  | Title: " & createVideo.Title & " has been sucessfuly created!")
                Dashboard.Show()
                Me.Close()
            Case MsgBoxResult.No
                Return
        End Select

        'db.AddNewVideo(createVideo)
        'Dashboard.Show()
        'Me.Close()

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
        Return
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