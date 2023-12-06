<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ajoutpatient
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_prenom = New System.Windows.Forms.TextBox()
        Me.btn_ajout = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "prenom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "nom"
        '
        'txt_code
        '
        Me.txt_code.Location = New System.Drawing.Point(101, 12)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(100, 22)
        Me.txt_code.TabIndex = 4
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(101, 66)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(100, 22)
        Me.txt_nom.TabIndex = 5
        '
        'txt_prenom
        '
        Me.txt_prenom.Location = New System.Drawing.Point(101, 123)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.Size = New System.Drawing.Size(100, 22)
        Me.txt_prenom.TabIndex = 6
        '
        'btn_ajout
        '
        Me.btn_ajout.Location = New System.Drawing.Point(49, 209)
        Me.btn_ajout.Name = "btn_ajout"
        Me.btn_ajout.Size = New System.Drawing.Size(75, 23)
        Me.btn_ajout.TabIndex = 7
        Me.btn_ajout.Text = "ajouter"
        Me.btn_ajout.UseVisualStyleBackColor = True
        '
        'btn_annuler
        '
        Me.btn_annuler.Location = New System.Drawing.Point(190, 209)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(75, 23)
        Me.btn_annuler.TabIndex = 8
        Me.btn_annuler.Text = "annuler"
        Me.btn_annuler.UseVisualStyleBackColor = True
        '
        'Frm_ajoutpatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_ajout)
        Me.Controls.Add(Me.txt_prenom)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_ajoutpatient"
        Me.Text = "Patient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_code As TextBox
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_prenom As TextBox
    Friend WithEvents btn_ajout As Button
    Friend WithEvents btn_annuler As Button
End Class
