Public Class Frm_ajoutpatient

    Private Sub btn_ajout_Click(sender As Object, e As EventArgs) Handles btn_ajout.Click
        Dim p As patient
        p.code = txt_code.Text
        p.nom = txt_nom.Text
        p.prenom = txt_prenom.Text
        Ajouterpatient(p)
        If Ajouterpatient(p) Then
            MessageBox.Show("Ajout du patient avec succes")
        Else
            MessageBox.Show("Le tableau patient est saturé")
        End If
    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        txt_code.Clear()
        txt_nom.Clear()
        txt_prenom.Clear()
    End Sub
End Class