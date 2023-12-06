<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class authentification
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
        Me.txt_pwd = New System.Windows.Forms.TextBox()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(148, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "login"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(143, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_pwd
        '
        Me.txt_pwd.ForeColor = System.Drawing.Color.Black
        Me.txt_pwd.Location = New System.Drawing.Point(324, 231)
        Me.txt_pwd.Name = "txt_pwd"
        Me.txt_pwd.Size = New System.Drawing.Size(205, 26)
        Me.txt_pwd.TabIndex = 3
        Me.txt_pwd.Tag = "*"
        Me.txt_pwd.UseSystemPasswordChar = True
        '
        'txt_login
        '
        Me.txt_login.ForeColor = System.Drawing.Color.Black
        Me.txt_login.Location = New System.Drawing.Point(324, 170)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(205, 26)
        Me.txt_login.TabIndex = 4
        '
        'btn_annuler
        '
        Me.btn_annuler.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.ForeColor = System.Drawing.Color.Black
        Me.btn_annuler.Location = New System.Drawing.Point(324, 392)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(205, 53)
        Me.btn_annuler.TabIndex = 5
        Me.btn_annuler.Text = "annuler"
        Me.btn_annuler.UseVisualStyleBackColor = True
        '
        'btn_valider
        '
        Me.btn_valider.ForeColor = System.Drawing.Color.Black
        Me.btn_valider.Location = New System.Drawing.Point(324, 333)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(205, 53)
        Me.btn_valider.TabIndex = 6
        Me.btn_valider.Text = "valider"
        Me.btn_valider.UseVisualStyleBackColor = True
        '
        'authentification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.gestion_hopital.My.Resources.Resources.images__1_
        Me.ClientSize = New System.Drawing.Size(834, 535)
        Me.Controls.Add(Me.btn_valider)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.txt_pwd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "authentification"
        Me.Text = "authentification"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_pwd As TextBox
    Friend WithEvents txt_login As TextBox
    Friend WithEvents btn_annuler As Button
    Friend WithEvents btn_valider As Button
End Class
