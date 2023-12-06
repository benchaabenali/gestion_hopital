<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RDVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Blue
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PToolStripMenuItem, Me.RDVToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(674, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PToolStripMenuItem
        '
        Me.PToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem, Me.AfficherToolStripMenuItem})
        Me.PToolStripMenuItem.Name = "PToolStripMenuItem"
        Me.PToolStripMenuItem.Size = New System.Drawing.Size(66, 21)
        Me.PToolStripMenuItem.Text = "Patient"
        '
        'AjouterToolStripMenuItem
        '
        Me.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem"
        Me.AjouterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AjouterToolStripMenuItem.Text = "ajouter"
        '
        'AfficherToolStripMenuItem
        '
        Me.AfficherToolStripMenuItem.Name = "AfficherToolStripMenuItem"
        Me.AfficherToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AfficherToolStripMenuItem.Text = "afficher"
        '
        'RDVToolStripMenuItem
        '
        Me.RDVToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem1, Me.AfficherToolStripMenuItem1})
        Me.RDVToolStripMenuItem.Name = "RDVToolStripMenuItem"
        Me.RDVToolStripMenuItem.Size = New System.Drawing.Size(52, 21)
        Me.RDVToolStripMenuItem.Text = "RDV"
        '
        'AjouterToolStripMenuItem1
        '
        Me.AjouterToolStripMenuItem1.Name = "AjouterToolStripMenuItem1"
        Me.AjouterToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.AjouterToolStripMenuItem1.Text = "ajouter"
        '
        'AfficherToolStripMenuItem1
        '
        Me.AfficherToolStripMenuItem1.Name = "AfficherToolStripMenuItem1"
        Me.AfficherToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.AfficherToolStripMenuItem1.Text = "afficher"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(674, 366)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_main"
        Me.Text = "formulaire ajout afficher  patient "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfficherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RDVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AfficherToolStripMenuItem1 As ToolStripMenuItem
End Class
