Public Class frm_afficherpatient
    Private Sub frm_afficherpatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficher(DGV_patient)
    End Sub

    Private Sub btn_supp_Click(sender As Object, e As EventArgs) Handles btn_supp.Click
        Dim i As Integer = DGV_patient.SelectedCells(0).RowIndex
        If i < 0 Then
            MsgBox("aucune selection")
        Else
            DGV_patient.Rows.RemoveAt(i)
            patients(i) = Nothing
        End If
    End Sub
    Private Sub btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        Me.Close()
        frm_main.Show()
    End Sub
End Class