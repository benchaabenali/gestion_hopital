Public Class frm_ajoutrdv
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim r As rendezvous
        r.code = txt_code.Text
        r.Dateheure = dtp_rdv.Text
        Ajout_rdv(r)

    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        txt_code.Clear()
    End Sub

    Private Sub btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        Me.Hide()
        frm_main.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles code_p.Click

    End Sub
End Class