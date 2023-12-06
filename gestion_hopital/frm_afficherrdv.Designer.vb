<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_afficherrdv
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateheure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.btn_retour = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(622, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code, Me.dateheure})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 26)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(611, 417)
        Me.DataGridView1.TabIndex = 2
        '
        'code
        '
        Me.code.HeaderText = "code"
        Me.code.MinimumWidth = 6
        Me.code.Name = "code"
        Me.code.Width = 125
        '
        'dateheure
        '
        Me.dateheure.HeaderText = "date et heure"
        Me.dateheure.MinimumWidth = 6
        Me.dateheure.Name = "dateheure"
        Me.dateheure.Width = 125
        '
        'btn_supprimer
        '
        Me.btn_supprimer.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supprimer.Location = New System.Drawing.Point(311, 292)
        Me.btn_supprimer.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(126, 44)
        Me.btn_supprimer.TabIndex = 7
        Me.btn_supprimer.Text = "supprimer"
        Me.btn_supprimer.UseVisualStyleBackColor = True
        '
        'btn_retour
        '
        Me.btn_retour.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retour.Location = New System.Drawing.Point(116, 292)
        Me.btn_retour.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Size = New System.Drawing.Size(123, 44)
        Me.btn_retour.TabIndex = 8
        Me.btn_retour.Text = "retour"
        Me.btn_retour.UseVisualStyleBackColor = True
        '
        'frm_afficherrdv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(622, 433)
        Me.Controls.Add(Me.btn_retour)
        Me.Controls.Add(Me.btn_supprimer)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_afficherrdv"
        Me.Text = "frm_afficherrdv"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents code As DataGridViewTextBoxColumn
    Friend WithEvents dateheure As DataGridViewTextBoxColumn
    Friend WithEvents btn_supprimer As Button
    Friend WithEvents btn_retour As Button
End Class
