Public Class frm_main
    Private Sub AjouterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterToolStripMenuItem.Click
        Me.Hide()
        Frm_ajoutpatient.show()
    End Sub
    Private Sub AfficherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherToolStripMenuItem.Click
        Me.Hide()
        frm_afficherpatient.Show()
    End Sub
    Private Sub AjouterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AjouterToolStripMenuItem1.Click
        frm_ajoutrdv.Show()
    End Sub
    Private Sub AfficherToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AfficherToolStripMenuItem1.Click
        frm_afficherrdv.Show()
    End Sub



End Class
