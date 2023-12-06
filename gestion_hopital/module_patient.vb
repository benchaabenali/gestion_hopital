Module module_patient
    Public Structure patient
        Dim code As String
        Dim nom As String
        Dim prenom As String
    End Structure
    Public patients(100) As patient
    Public nb As Integer = 0

    Function Ajouterpatient(p As patient) As Boolean
        Dim pp As Boolean = True
        For Each c As patient In patients
            If (p.code = c.code) Then
                pp = False
                MsgBox("ce code existe")
                Exit For
            End If
        Next
        If pp Then
            If (nb < 100) Then
                patients(nb) = p
                nb += 1
                MsgBox("patient ajout avec succés")
                Return True
            Else
                MsgBox("tableu Saturee")
                Return False
            End If
        End If
    End Function

    Public Function afficher(dgv As DataGridView)
        Dim p As patient
        For Each p In patients
            If p.nom IsNot Nothing Then
                dgv.Rows.Add(p.prenom, p.nom, p.code)
            End If
        Next
    End Function
    Private Function existe(p As patient) As Boolean
        Dim i As Integer = 0
        While ((i < nb) And (patients(i).code <> p.code))
            i += 1
        End While
        Return i < nb
    End Function
    Public Function ajout_patient(p As patient) As Boolean
        If nb < 100 And existe(p) = False Then
            patients(nb) = p
            nb += 1
            Return True
        Else Return False
        End If
    End Function
End Module
