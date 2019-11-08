<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Me.pctBxCouvertures = New System.Windows.Forms.PictureBox()
        Me.pctBxEditeurs = New System.Windows.Forms.PictureBox()
        Me.pctBxLivres = New System.Windows.Forms.PictureBox()
        Me.pctBxEmprunteur = New System.Windows.Forms.PictureBox()
        Me.lblNotConnect = New System.Windows.Forms.Label()
        Me.pnlAccueil = New System.Windows.Forms.Panel()
        Me.pctBxAuteurs = New System.Windows.Forms.PictureBox()
        Me.Lbltitre = New System.Windows.Forms.Label()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.lblRang2 = New System.Windows.Forms.Label()
        Me.Btn_connexion = New System.Windows.Forms.Button()
        Me.LblRang = New System.Windows.Forms.Label()
        Me.txt_mdp = New System.Windows.Forms.TextBox()
        Me.lbl_pseudo = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Btn_deco = New System.Windows.Forms.Button()
        Me.lbl_mdp = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.lbl_error_login = New System.Windows.Forms.Label()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.Lbl_connect_error_2 = New System.Windows.Forms.Label()
        Me.Lbl_connect_error_1 = New System.Windows.Forms.Label()
        Me.lbl_connection_1 = New System.Windows.Forms.Label()
        Me.Login_Box = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.pctBxCouvertures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBxEditeurs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBxLivres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBxEmprunteur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAccueil.SuspendLayout()
        CType(Me.pctBxAuteurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Login_Box.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pctBxCouvertures
        '
        Me.pctBxCouvertures.Image = Global.FunEnBulles.My.Resources.Resources.images
        Me.pctBxCouvertures.Location = New System.Drawing.Point(428, 107)
        Me.pctBxCouvertures.Name = "pctBxCouvertures"
        Me.pctBxCouvertures.Size = New System.Drawing.Size(132, 132)
        Me.pctBxCouvertures.TabIndex = 21
        Me.pctBxCouvertures.TabStop = False
        '
        'pctBxEditeurs
        '
        Me.pctBxEditeurs.Image = Global.FunEnBulles.My.Resources.Resources.editeurs_00
        Me.pctBxEditeurs.Location = New System.Drawing.Point(188, 400)
        Me.pctBxEditeurs.Name = "pctBxEditeurs"
        Me.pctBxEditeurs.Size = New System.Drawing.Size(132, 132)
        Me.pctBxEditeurs.TabIndex = 20
        Me.pctBxEditeurs.TabStop = False
        '
        'pctBxLivres
        '
        Me.pctBxLivres.Image = Global.FunEnBulles.My.Resources.Resources.livre_01
        Me.pctBxLivres.Location = New System.Drawing.Point(202, 40)
        Me.pctBxLivres.Name = "pctBxLivres"
        Me.pctBxLivres.Size = New System.Drawing.Size(132, 132)
        Me.pctBxLivres.TabIndex = 19
        Me.pctBxLivres.TabStop = False
        '
        'pctBxEmprunteur
        '
        Me.pctBxEmprunteur.Image = Global.FunEnBulles.My.Resources.Resources.emprunteur
        Me.pctBxEmprunteur.Location = New System.Drawing.Point(405, 307)
        Me.pctBxEmprunteur.Name = "pctBxEmprunteur"
        Me.pctBxEmprunteur.Size = New System.Drawing.Size(132, 132)
        Me.pctBxEmprunteur.TabIndex = 17
        Me.pctBxEmprunteur.TabStop = False
        '
        'lblNotConnect
        '
        Me.lblNotConnect.AutoSize = True
        Me.lblNotConnect.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotConnect.ForeColor = System.Drawing.Color.Maroon
        Me.lblNotConnect.Location = New System.Drawing.Point(120, 250)
        Me.lblNotConnect.Name = "lblNotConnect"
        Me.lblNotConnect.Size = New System.Drawing.Size(399, 42)
        Me.lblNotConnect.TabIndex = 12
        Me.lblNotConnect.Text = "< En attente de connexion"
        '
        'pnlAccueil
        '
        Me.pnlAccueil.Controls.Add(Me.pctBxCouvertures)
        Me.pnlAccueil.Controls.Add(Me.pctBxEditeurs)
        Me.pnlAccueil.Controls.Add(Me.pctBxLivres)
        Me.pnlAccueil.Controls.Add(Me.pctBxAuteurs)
        Me.pnlAccueil.Controls.Add(Me.pctBxEmprunteur)
        Me.pnlAccueil.Location = New System.Drawing.Point(3, 3)
        Me.pnlAccueil.Name = "pnlAccueil"
        Me.pnlAccueil.Size = New System.Drawing.Size(621, 551)
        Me.pnlAccueil.TabIndex = 22
        '
        'pctBxAuteurs
        '
        Me.pctBxAuteurs.Image = Global.FunEnBulles.My.Resources.Resources.auteur_02
        Me.pctBxAuteurs.Location = New System.Drawing.Point(23, 214)
        Me.pctBxAuteurs.Name = "pctBxAuteurs"
        Me.pctBxAuteurs.Size = New System.Drawing.Size(132, 132)
        Me.pctBxAuteurs.TabIndex = 18
        Me.pctBxAuteurs.TabStop = False
        '
        'Lbltitre
        '
        Me.Lbltitre.AutoSize = True
        Me.Lbltitre.Font = New System.Drawing.Font("Calibri", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbltitre.Location = New System.Drawing.Point(3, 25)
        Me.Lbltitre.Name = "Lbltitre"
        Me.Lbltitre.Size = New System.Drawing.Size(149, 33)
        Me.Lbltitre.TabIndex = 1
        Me.Lbltitre.Text = "FunEnBulles"
        '
        'btnQuitter
        '
        Me.btnQuitter.AutoSize = True
        Me.btnQuitter.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnQuitter.FlatAppearance.BorderSize = 0
        Me.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuitter.ForeColor = System.Drawing.Color.Transparent
        Me.btnQuitter.Image = Global.FunEnBulles.My.Resources.Resources.quitter_btn
        Me.btnQuitter.Location = New System.Drawing.Point(64, 500)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(54, 54)
        Me.btnQuitter.TabIndex = 0
        Me.btnQuitter.UseVisualStyleBackColor = False
        '
        'lblRang2
        '
        Me.lblRang2.AutoSize = True
        Me.lblRang2.Location = New System.Drawing.Point(71, 96)
        Me.lblRang2.Name = "lblRang2"
        Me.lblRang2.Size = New System.Drawing.Size(20, 16)
        Me.lblRang2.TabIndex = 3
        Me.lblRang2.Text = "..."
        '
        'Btn_connexion
        '
        Me.Btn_connexion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_connexion.Location = New System.Drawing.Point(43, 126)
        Me.Btn_connexion.Name = "Btn_connexion"
        Me.Btn_connexion.Size = New System.Drawing.Size(100, 23)
        Me.Btn_connexion.TabIndex = 6
        Me.Btn_connexion.Text = "Connexion"
        Me.Btn_connexion.UseVisualStyleBackColor = True
        Me.Btn_connexion.Visible = False
        '
        'LblRang
        '
        Me.LblRang.AutoSize = True
        Me.LblRang.Location = New System.Drawing.Point(8, 96)
        Me.LblRang.Name = "LblRang"
        Me.LblRang.Size = New System.Drawing.Size(57, 16)
        Me.LblRang.TabIndex = 2
        Me.LblRang.Text = "Rang : "
        '
        'txt_mdp
        '
        Me.txt_mdp.Location = New System.Drawing.Point(100, 61)
        Me.txt_mdp.Name = "txt_mdp"
        Me.txt_mdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_mdp.Size = New System.Drawing.Size(81, 22)
        Me.txt_mdp.TabIndex = 3
        '
        'lbl_pseudo
        '
        Me.lbl_pseudo.AutoSize = True
        Me.lbl_pseudo.Location = New System.Drawing.Point(8, 30)
        Me.lbl_pseudo.Name = "lbl_pseudo"
        Me.lbl_pseudo.Size = New System.Drawing.Size(89, 16)
        Me.lbl_pseudo.TabIndex = 1
        Me.lbl_pseudo.Text = "Bienvenue, "
        Me.lbl_pseudo.Visible = False
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(100, 27)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(81, 22)
        Me.txt_id.TabIndex = 2
        '
        'Btn_deco
        '
        Me.Btn_deco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_deco.Location = New System.Drawing.Point(33, 126)
        Me.Btn_deco.Name = "Btn_deco"
        Me.Btn_deco.Size = New System.Drawing.Size(119, 23)
        Me.Btn_deco.TabIndex = 0
        Me.Btn_deco.Text = "Deconnexion"
        Me.Btn_deco.UseVisualStyleBackColor = True
        Me.Btn_deco.Visible = False
        '
        'lbl_mdp
        '
        Me.lbl_mdp.AutoSize = True
        Me.lbl_mdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mdp.Location = New System.Drawing.Point(7, 64)
        Me.lbl_mdp.Name = "lbl_mdp"
        Me.lbl_mdp.Size = New System.Drawing.Size(96, 13)
        Me.lbl_mdp.TabIndex = 1
        Me.lbl_mdp.Text = "Mot de Passe : "
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(7, 30)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(87, 16)
        Me.lbl_id.TabIndex = 0
        Me.lbl_id.Text = "Identifiant : "
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdmin.Location = New System.Drawing.Point(19, 275)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(154, 58)
        Me.btnAdmin.TabIndex = 11
        Me.btnAdmin.Text = "          Administrer"
        Me.btnAdmin.UseVisualStyleBackColor = False
        Me.btnAdmin.Visible = False
        '
        'lbl_error_login
        '
        Me.lbl_error_login.AutoSize = True
        Me.lbl_error_login.Location = New System.Drawing.Point(10, 181)
        Me.lbl_error_login.Name = "lbl_error_login"
        Me.lbl_error_login.Size = New System.Drawing.Size(16, 13)
        Me.lbl_error_login.TabIndex = 7
        Me.lbl_error_login.Text = "..."
        Me.lbl_error_login.Visible = False
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_login.Location = New System.Drawing.Point(0, 148)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(199, 19)
        Me.lbl_login.TabIndex = 6
        Me.lbl_login.Text = "En attente d'identification..."
        Me.lbl_login.Visible = False
        '
        'Lbl_connect_error_2
        '
        Me.Lbl_connect_error_2.ForeColor = System.Drawing.Color.Red
        Me.Lbl_connect_error_2.Location = New System.Drawing.Point(10, 226)
        Me.Lbl_connect_error_2.Name = "Lbl_connect_error_2"
        Me.Lbl_connect_error_2.Size = New System.Drawing.Size(174, 110)
        Me.Lbl_connect_error_2.TabIndex = 5
        Me.Lbl_connect_error_2.Text = "..."
        Me.Lbl_connect_error_2.Visible = False
        '
        'Lbl_connect_error_1
        '
        Me.Lbl_connect_error_1.AutoSize = True
        Me.Lbl_connect_error_1.Location = New System.Drawing.Point(10, 110)
        Me.Lbl_connect_error_1.Name = "Lbl_connect_error_1"
        Me.Lbl_connect_error_1.Size = New System.Drawing.Size(16, 13)
        Me.Lbl_connect_error_1.TabIndex = 4
        Me.Lbl_connect_error_1.Text = "..."
        Me.Lbl_connect_error_1.Visible = False
        '
        'lbl_connection_1
        '
        Me.lbl_connection_1.AutoSize = True
        Me.lbl_connection_1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_connection_1.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_connection_1.Location = New System.Drawing.Point(19, 81)
        Me.lbl_connection_1.Name = "lbl_connection_1"
        Me.lbl_connection_1.Size = New System.Drawing.Size(154, 19)
        Me.lbl_connection_1.TabIndex = 3
        Me.lbl_connection_1.Text = "Connexion à la BDD..."
        '
        'Login_Box
        '
        Me.Login_Box.BackColor = System.Drawing.Color.RoyalBlue
        Me.Login_Box.Controls.Add(Me.lblRang2)
        Me.Login_Box.Controls.Add(Me.Btn_connexion)
        Me.Login_Box.Controls.Add(Me.LblRang)
        Me.Login_Box.Controls.Add(Me.txt_mdp)
        Me.Login_Box.Controls.Add(Me.lbl_pseudo)
        Me.Login_Box.Controls.Add(Me.txt_id)
        Me.Login_Box.Controls.Add(Me.Btn_deco)
        Me.Login_Box.Controls.Add(Me.lbl_mdp)
        Me.Login_Box.Controls.Add(Me.lbl_id)
        Me.Login_Box.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_Box.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Login_Box.Location = New System.Drawing.Point(3, 339)
        Me.Login_Box.Name = "Login_Box"
        Me.Login_Box.Size = New System.Drawing.Size(187, 155)
        Me.Login_Box.TabIndex = 2
        Me.Login_Box.TabStop = False
        Me.Login_Box.Text = "Connexion"
        Me.Login_Box.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAdmin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbl_error_login)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbl_login)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Lbl_connect_error_2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Lbl_connect_error_1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbl_connection_1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Login_Box)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Lbltitre)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnQuitter)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblNotConnect)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlAccueil)
        Me.SplitContainer1.Size = New System.Drawing.Size(824, 557)
        Me.SplitContainer1.SplitterDistance = 193
        Me.SplitContainer1.TabIndex = 13
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 552)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Accueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accueil"
        CType(Me.pctBxCouvertures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBxEditeurs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBxLivres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBxEmprunteur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAccueil.ResumeLayout(False)
        CType(Me.pctBxAuteurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Login_Box.ResumeLayout(False)
        Me.Login_Box.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pctBxCouvertures As System.Windows.Forms.PictureBox
    Friend WithEvents pctBxEditeurs As System.Windows.Forms.PictureBox
    Friend WithEvents pctBxLivres As System.Windows.Forms.PictureBox
    Friend WithEvents pctBxEmprunteur As System.Windows.Forms.PictureBox
    Friend WithEvents lblNotConnect As System.Windows.Forms.Label
    Friend WithEvents pnlAccueil As System.Windows.Forms.Panel
    Friend WithEvents pctBxAuteurs As System.Windows.Forms.PictureBox
    Friend WithEvents Lbltitre As System.Windows.Forms.Label
    Friend WithEvents btnQuitter As System.Windows.Forms.Button
    Friend WithEvents lblRang2 As System.Windows.Forms.Label
    Friend WithEvents Btn_connexion As System.Windows.Forms.Button
    Friend WithEvents LblRang As System.Windows.Forms.Label
    Friend WithEvents txt_mdp As System.Windows.Forms.TextBox
    Friend WithEvents lbl_pseudo As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Btn_deco As System.Windows.Forms.Button
    Friend WithEvents lbl_mdp As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents btnAdmin As System.Windows.Forms.Button
    Friend WithEvents lbl_error_login As System.Windows.Forms.Label
    Friend WithEvents lbl_login As System.Windows.Forms.Label
    Friend WithEvents Lbl_connect_error_2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_connect_error_1 As System.Windows.Forms.Label
    Friend WithEvents lbl_connection_1 As System.Windows.Forms.Label
    Friend WithEvents Login_Box As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
