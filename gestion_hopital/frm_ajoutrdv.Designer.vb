<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ajoutrdv
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
        Me.code_p = New System.Windows.Forms.Label()
        Me.date_heure = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.dtp_rdv = New System.Windows.Forms.DateTimePicker()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'code_p
        '
        Me.code_p.AutoSize = True
        Me.code_p.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.code_p.Location = New System.Drawing.Point(11, 71)
        Me.code_p.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.code_p.Name = "code_p"
        Me.code_p.Size = New System.Drawing.Size(158, 24)
        Me.code_p.TabIndex = 0
        Me.code_p.Text = "code du patient :"
        Me.code_p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'date_heure
        '
        Me.date_heure.AutoSize = True
        Me.date_heure.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_heure.Location = New System.Drawing.Point(31, 191)
        Me.date_heure.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.date_heure.Name = "date_heure"
        Me.date_heure.Size = New System.Drawing.Size(61, 24)
        Me.date_heure.TabIndex = 1
        Me.date_heure.Text = "date :"
        '
        'txt_code
        '
        Me.txt_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_code.Location = New System.Drawing.Point(229, 68)
        Me.txt_code.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(218, 29)
        Me.txt_code.TabIndex = 3
        '
        'dtp_rdv
        '
        Me.dtp_rdv.CalendarFont = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_rdv.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_rdv.Location = New System.Drawing.Point(229, 188)
        Me.dtp_rdv.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_rdv.Name = "dtp_rdv"
        Me.dtp_rdv.Size = New System.Drawing.Size(218, 29)
        Me.dtp_rdv.TabIndex = 4
        '
        'btn_ajouter
        '
        Me.btn_ajouter.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter.Location = New System.Drawing.Point(553, 132)
        Me.btn_ajouter.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(105, 52)
        Me.btn_ajouter.TabIndex = 5
        Me.btn_ajouter.Text = "ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = True
        '
        'btn_annuler
        '
        Me.btn_annuler.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.Location = New System.Drawing.Point(553, 57)
        Me.btn_annuler.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(105, 52)
        Me.btn_annuler.TabIndex = 6
        Me.btn_annuler.Text = "annuler"
        Me.btn_annuler.UseVisualStyleBackColor = True
        '
        'btn_retour
        '
        Me.btn_retour.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retour.Location = New System.Drawing.Point(553, 210)
        Me.btn_retour.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Size = New System.Drawing.Size(105, 52)
        Me.btn_retour.TabIndex = 7
        Me.btn_retour.Text = "retour"
        Me.btn_retour.UseVisualStyleBackColor = True
        '
        'frm_ajoutrdv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.gestion_hopital.My.Resources.Resources.images__3_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(740, 424)
        Me.Controls.Add(Me.btn_retour)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.dtp_rdv)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.date_heure)
        Me.Controls.Add(Me.code_p)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_ajoutrdv"
        Me.Text = "frm_ajoutrdv"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents code_p As Label
    Friend WithEvents date_heure As Label
    Friend WithEvents txt_code As TextBox
    Friend WithEvents dtp_rdv As DateTimePicker
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_annuler As Button
    Friend WithEvents btn_retour As Button
End Class
