Public Class Login

    Dim db As New DBManager()
    Public login As EmployeeLogin = Nothing

    Private Sub submit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_username.KeyPress, TB_password.KeyPress

        If Asc(e.KeyChar) = Keys.Enter Then
            If TB_password.Text.Length >= 1 AndAlso TB_username.Text.Length >= 1 Then
                login = db.Logon(TB_username.Text, TB_password.Text)

                If login Is Nothing Then

                    MsgBox("Username and password is incorrect")
                    TB_username.Text = ""
                    TB_password.Text = ""

                    Return
                End If

                Dashboard.Show()
                Me.Hide()

                TB_username.Text = ""
                TB_password.Text = ""
            End If

        End If
    End Sub

    Private Sub BTN_login_Click(sender As Object, e As EventArgs) Handles BTN_login.Click

        If TB_password.Text.Length >= 1 AndAlso TB_username.Text.Length >= 1 Then
            login = db.Logon(TB_username.Text, TB_password.Text)

            If login Is Nothing Then

                MsgBox("Username and password is incorrect")
                TB_username.Text = ""
                TB_password.Text = ""

                Return
            End If

            Dashboard.Show()
            Me.Hide()

            TB_username.Text = ""
            TB_password.Text = ""

        End If
    End Sub



    Private Sub TS_exit_Click(sender As Object, e As EventArgs) Handles TS_exit.Click
        End
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'db.TestConnection()
    End Sub


End Class
