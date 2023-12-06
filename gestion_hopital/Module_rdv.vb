Module Module_rdv
    Public Structure rendezvous
        Dim code As String
        Dim Dateheure As Date
    End Structure
    Public rdvs(100) As rendezvous
    Public nb As Integer = 0

    Function Ajout_rdv(r As rendezvous) As Boolean
        Dim pe As Boolean = False
        For Each c As patient In patients
            If (r.code = c.code) Then
                pe = True
                Exit For
            End If
        Next
        If pe Then
            If (nb < 100) Then
                rdvs(nb) = r
                nb += 1
                MsgBox("rdv ajout avec succés")
                Return True
            Else
                MsgBox("tableu Saturee")
                Return False
            End If
        Else
            MsgBox("Ce client n'existe pas")
            Return False
        End If
    End Function
    Public Function afficherRDVsDuJour(dgv As DataGridView)
        dgv.DataSource = Nothing
        dgv.Rows.Clear()
        Dim jour As DateTime = DateTime.Now.Date
        Dim dateFin As DateTime = jour.AddDays(1).AddSeconds(-1)
        For Each r In rdvs
            If r.code IsNot Nothing Then
                dgv.Rows.Add(r.code, r.Dateheure)
            End If
        Next
    End Function

End Module
