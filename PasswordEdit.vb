Public Class PasswordEdit

    Private Sub BTN_save_Click(sender As Object, e As EventArgs) Handles BTN_save.Click
        Dim db = New DBManager

        If TB_password.Text <> Login.login.Password Then
            MsgBox("Wrong login password...", MsgBoxStyle.Exclamation)
            TB_password.Text = ""
            Return
        End If

        If TB_newPassword.Text <> TB_confirmNewPassword.Text Then
            MsgBox("New passwords aren't the same...", MsgBoxStyle.Exclamation)
            TB_newPassword.Text = ""
            TB_confirmNewPassword.Text = ""
            Return
        End If

        If TB_password.Text.Length > 1 AndAlso TB_newPassword.Text.Length > 1 AndAlso TB_confirmNewPassword.Text.Length > 1 Then

            Login.login.Password = TB_confirmNewPassword.Text
            db.PasswordChange(Login.login)
            MsgBox("Password has been updated", MsgBoxStyle.Exclamation, "Changed password!")

            Login.Show()
            Me.Close()

        End If

    End Sub

    Private Sub submit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_confirmNewPassword.KeyPress, TB_newPassword.KeyPress, TB_password.KeyPress

        If Asc(e.KeyChar) = Keys.Enter Then
            Dim db = New DBManager

            If TB_password.Text <> Login.login.Password Then
                MsgBox("Wrong login password...", MsgBoxStyle.Exclamation)
                TB_password.Text = ""
                Return
            End If

            If TB_newPassword.Text <> TB_confirmNewPassword.Text Then
                MsgBox("New passwords aren't the same...", MsgBoxStyle.Exclamation)
                TB_newPassword.Text = ""
                TB_confirmNewPassword.Text = ""
                Return
            End If

            If TB_password.Text.Length > 1 AndAlso TB_newPassword.Text.Length > 1 AndAlso TB_confirmNewPassword.Text.Length > 1 Then

                Login.login.Password = TB_confirmNewPassword.Text
                db.PasswordChange(Login.login)
                MsgBox("Password has been updated", MsgBoxStyle.Exclamation, "Changed password!")

                Login.Show()
                Me.Close()

            End If

        End If
    End Sub

    Private Sub BTN_cancel_Click(sender As Object, e As EventArgs) Handles BTN_cancel.Click
        Dashboard.Show()
        Me.Close()
    End Sub

End Class