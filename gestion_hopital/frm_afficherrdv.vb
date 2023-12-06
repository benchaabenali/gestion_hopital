Public Class frm_afficherrdv
    Private Sub frm_afficherrdv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficherRDVsDuJour(DataGridView1)
    End Sub

    Private Sub btn_sup_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        Dim i As Integer = DataGridView1.SelectedCells(0).RowIndex
        If i < 0 Then
            MsgBox("aucune selection")
        Else
            DataGridView1.Rows.RemoveAt(i)
            patients(i) = Nothing
        End If
    End Sub
    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        DataGridView1.ClearSelection()
        Me.Close()
        frm_main.Show()
    End Sub
End Class