Public Class authentification
    Private Sub txt_login_TextChanged(sender As Object, e As EventArgs) Handles txt_login.TextChanged

    End Sub

    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        Dim login As String
        Dim pw As String
        login = txt_login.Text
        pw = txt_pwd.Text
        If (login = "admin") And (pw = "1234") Then
            Me.Hide()
            frm_main.Show()
        End If
    End Sub

    Private Sub txt_pwd_TextChanged(sender As Object, e As EventArgs) Handles txt_pwd.TextChanged

    End Sub
End Class