<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmins
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
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.pnlAccueil = New System.Windows.Forms.Panel()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.dtGrdAuteurs = New System.Windows.Forms.DataGridView()
        Me.RbtUser = New System.Windows.Forms.RadioButton()
        Me.RbtAdmin = New System.Windows.Forms.RadioButton()
        Me.rbtInvit = New System.Windows.Forms.RadioButton()
        Me.GrbNiveau = New System.Windows.Forms.GroupBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.TxtPrenom = New System.Windows.Forms.TextBox()
        Me.LblPrenom = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.LblMDP = New System.Windows.Forms.Label()
        Me.TxtMDP = New System.Windows.Forms.TextBox()
        Me.btnResetMDP = New System.Windows.Forms.Button()
        Me.GrpBxAuteur = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pnlAccueil.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dtGrdAuteurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbNiveau.SuspendLayout()
        Me.GrpBxAuteur.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(29, 37)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(228, 24)
        Me.lblTitre.TabIndex = 17
        Me.lblTitre.Text = "Gestion des Utilisateurs"
        '
        'pnlAccueil
        '
        Me.pnlAccueil.Controls.Add(Me.Button2)
        Me.pnlAccueil.Controls.Add(Me.Button1)
        Me.pnlAccueil.Controls.Add(Me.GrbNiveau)
        Me.pnlAccueil.Controls.Add(Me.TextBox1)
        Me.pnlAccueil.Controls.Add(Me.dtGrdAuteurs)
        Me.pnlAccueil.Controls.Add(Me.GrpBxAuteur)
        Me.pnlAccueil.Controls.Add(Me.lblTitre)
        Me.pnlAccueil.Location = New System.Drawing.Point(3, 3)
        Me.pnlAccueil.Name = "pnlAccueil"
        Me.pnlAccueil.Size = New System.Drawing.Size(623, 548)
        Me.pnlAccueil.TabIndex = 22
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.Transparent
        Me.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnuler.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAnnuler.Image = Global.FunEnBulles.My.Resources.Resources.annuler_btn
        Me.btnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnnuler.Location = New System.Drawing.Point(15, 390)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(154, 58)
        Me.btnAnnuler.TabIndex = 11
        Me.btnAnnuler.Text = "          Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'btnRetour
        '
        Me.btnRetour.BackColor = System.Drawing.Color.Transparent
        Me.btnRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRetour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetour.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRetour.Image = Global.FunEnBulles.My.Resources.Resources.accueil
        Me.btnRetour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRetour.Location = New System.Drawing.Point(3, 480)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(187, 45)
        Me.btnRetour.TabIndex = 9
        Me.btnRetour.Text = "Accueil"
        Me.btnRetour.UseVisualStyleBackColor = False
        '
        'btnSupprimer
        '
        Me.btnSupprimer.BackColor = System.Drawing.Color.Transparent
        Me.btnSupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSupprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprimer.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSupprimer.Image = Global.FunEnBulles.My.Resources.Resources.supprimer_btn1
        Me.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSupprimer.Location = New System.Drawing.Point(12, 228)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(154, 58)
        Me.btnSupprimer.TabIndex = 8
        Me.btnSupprimer.Text = "       Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = False
        '
        'btnRechercher
        '
        Me.btnRechercher.BackColor = System.Drawing.Color.Transparent
        Me.btnRechercher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRechercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRechercher.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRechercher.Image = Global.FunEnBulles.My.Resources.Resources.recherche_btn1
        Me.btnRechercher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRechercher.Location = New System.Drawing.Point(15, 178)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(154, 58)
        Me.btnRechercher.TabIndex = 7
        Me.btnRechercher.Text = "           Rechercher"
        Me.btnRechercher.UseVisualStyleBackColor = False
        '
        'btnModifier
        '
        Me.btnModifier.BackColor = System.Drawing.Color.Transparent
        Me.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifier.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnModifier.Image = Global.FunEnBulles.My.Resources.Resources.modifier_btn1
        Me.btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifier.Location = New System.Drawing.Point(12, 114)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(154, 58)
        Me.btnModifier.TabIndex = 6
        Me.btnModifier.Text = "      Modifier"
        Me.btnModifier.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAnnuler)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRetour)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSupprimer)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRechercher)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnModifier)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAjouter)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlAccueil)
        Me.SplitContainer1.Size = New System.Drawing.Size(824, 557)
        Me.SplitContainer1.SplitterDistance = 193
        Me.SplitContainer1.TabIndex = 14
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.Transparent
        Me.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAjouter.Image = Global.FunEnBulles.My.Resources.Resources.ajouter_btn1
        Me.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjouter.Location = New System.Drawing.Point(15, 31)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(154, 58)
        Me.btnAjouter.TabIndex = 5
        Me.btnAjouter.Text = "  Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'dtGrdAuteurs
        '
        Me.dtGrdAuteurs.AllowUserToAddRows = False
        Me.dtGrdAuteurs.AllowUserToDeleteRows = False
        Me.dtGrdAuteurs.AllowUserToResizeColumns = False
        Me.dtGrdAuteurs.AllowUserToResizeRows = False
        Me.dtGrdAuteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrdAuteurs.Location = New System.Drawing.Point(33, 206)
        Me.dtGrdAuteurs.MultiSelect = False
        Me.dtGrdAuteurs.Name = "dtGrdAuteurs"
        Me.dtGrdAuteurs.ReadOnly = True
        Me.dtGrdAuteurs.RowHeadersWidth = 25
        Me.dtGrdAuteurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGrdAuteurs.Size = New System.Drawing.Size(560, 90)
        Me.dtGrdAuteurs.TabIndex = 18
        '
        'RbtUser
        '
        Me.RbtUser.AutoSize = True
        Me.RbtUser.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.RbtUser.Location = New System.Drawing.Point(218, 15)
        Me.RbtUser.Name = "RbtUser"
        Me.RbtUser.Size = New System.Drawing.Size(108, 27)
        Me.RbtUser.TabIndex = 0
        Me.RbtUser.TabStop = True
        Me.RbtUser.Text = "Utilisateur"
        Me.RbtUser.UseVisualStyleBackColor = True
        '
        'RbtAdmin
        '
        Me.RbtAdmin.AutoSize = True
        Me.RbtAdmin.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.RbtAdmin.Location = New System.Drawing.Point(381, 15)
        Me.RbtAdmin.Name = "RbtAdmin"
        Me.RbtAdmin.Size = New System.Drawing.Size(139, 27)
        Me.RbtAdmin.TabIndex = 1
        Me.RbtAdmin.TabStop = True
        Me.RbtAdmin.Text = "Administrateur"
        Me.RbtAdmin.UseVisualStyleBackColor = True
        '
        'rbtInvit
        '
        Me.rbtInvit.AutoSize = True
        Me.rbtInvit.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.rbtInvit.Location = New System.Drawing.Point(80, 15)
        Me.rbtInvit.Name = "rbtInvit"
        Me.rbtInvit.Size = New System.Drawing.Size(73, 27)
        Me.rbtInvit.TabIndex = 2
        Me.rbtInvit.TabStop = True
        Me.rbtInvit.Text = "Invité"
        Me.rbtInvit.UseVisualStyleBackColor = True
        '
        'GrbNiveau
        '
        Me.GrbNiveau.Controls.Add(Me.rbtInvit)
        Me.GrbNiveau.Controls.Add(Me.RbtAdmin)
        Me.GrbNiveau.Controls.Add(Me.RbtUser)
        Me.GrbNiveau.Location = New System.Drawing.Point(33, 311)
        Me.GrbNiveau.Name = "GrbNiveau"
        Me.GrbNiveau.Size = New System.Drawing.Size(560, 48)
        Me.GrbNiveau.TabIndex = 38
        Me.GrbNiveau.TabStop = False
        Me.GrbNiveau.Text = "Rang"
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(80, 78)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(165, 24)
        Me.txtNom.TabIndex = 35
        '
        'lblNom
        '
        Me.lblNom.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(16, 76)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(58, 24)
        Me.lblNom.TabIndex = 21
        Me.lblNom.Text = "Nom :  "
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(133, 34)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(122, 24)
        Me.txtCode.TabIndex = 24
        '
        'lblCode
        '
        Me.lblCode.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(16, 32)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(114, 24)
        Me.lblCode.TabIndex = 28
        Me.lblCode.Text = "Code/Pseudo : "
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtPrenom
        '
        Me.TxtPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrenom.Location = New System.Drawing.Point(364, 76)
        Me.TxtPrenom.Name = "TxtPrenom"
        Me.TxtPrenom.Size = New System.Drawing.Size(172, 24)
        Me.TxtPrenom.TabIndex = 36
        '
        'LblPrenom
        '
        Me.LblPrenom.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrenom.Location = New System.Drawing.Point(280, 75)
        Me.LblPrenom.Name = "LblPrenom"
        Me.LblPrenom.Size = New System.Drawing.Size(76, 24)
        Me.LblPrenom.TabIndex = 30
        Me.LblPrenom.Text = "Prénom :  "
        Me.LblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblID
        '
        Me.LblID.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.Location = New System.Drawing.Point(280, 32)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(76, 24)
        Me.LblID.TabIndex = 31
        Me.LblID.Text = "ID :  "
        Me.LblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtID
        '
        Me.TxtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtID.Location = New System.Drawing.Point(334, 34)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(61, 24)
        Me.TxtID.TabIndex = 32
        '
        'LblMDP
        '
        Me.LblMDP.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMDP.Location = New System.Drawing.Point(16, 118)
        Me.LblMDP.Name = "LblMDP"
        Me.LblMDP.Size = New System.Drawing.Size(80, 24)
        Me.LblMDP.TabIndex = 35
        Me.LblMDP.Text = "MDP :  "
        Me.LblMDP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtMDP
        '
        Me.TxtMDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMDP.Location = New System.Drawing.Point(80, 120)
        Me.TxtMDP.Name = "TxtMDP"
        Me.TxtMDP.Size = New System.Drawing.Size(315, 24)
        Me.TxtMDP.TabIndex = 37
        '
        'btnResetMDP
        '
        Me.btnResetMDP.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetMDP.Location = New System.Drawing.Point(410, 107)
        Me.btnResetMDP.Name = "btnResetMDP"
        Me.btnResetMDP.Size = New System.Drawing.Size(126, 44)
        Me.btnResetMDP.TabIndex = 38
        Me.btnResetMDP.Text = "Reinitialiser le MDP"
        Me.btnResetMDP.UseVisualStyleBackColor = True
        '
        'GrpBxAuteur
        '
        Me.GrpBxAuteur.Controls.Add(Me.btnResetMDP)
        Me.GrpBxAuteur.Controls.Add(Me.TxtMDP)
        Me.GrpBxAuteur.Controls.Add(Me.LblMDP)
        Me.GrpBxAuteur.Controls.Add(Me.TxtID)
        Me.GrpBxAuteur.Controls.Add(Me.LblID)
        Me.GrpBxAuteur.Controls.Add(Me.LblPrenom)
        Me.GrpBxAuteur.Controls.Add(Me.TxtPrenom)
        Me.GrpBxAuteur.Controls.Add(Me.lblCode)
        Me.GrpBxAuteur.Controls.Add(Me.txtCode)
        Me.GrpBxAuteur.Controls.Add(Me.lblNom)
        Me.GrpBxAuteur.Controls.Add(Me.txtNom)
        Me.GrpBxAuteur.Font = New System.Drawing.Font("Georgia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBxAuteur.Location = New System.Drawing.Point(33, 365)
        Me.GrpBxAuteur.Name = "GrpBxAuteur"
        Me.GrpBxAuteur.Size = New System.Drawing.Size(560, 157)
        Me.GrpBxAuteur.TabIndex = 16
        Me.GrpBxAuteur.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(397, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 44)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Reinitialiser le MDP"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(113, 111)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(122, 24)
        Me.TextBox1.TabIndex = 39
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(397, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 44)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Reinitialiser le MDP"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmAdmins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 565)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmAdmins"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAdmins"
        Me.pnlAccueil.ResumeLayout(False)
        Me.pnlAccueil.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dtGrdAuteurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbNiveau.ResumeLayout(False)
        Me.GrbNiveau.PerformLayout()
        Me.GrpBxAuteur.ResumeLayout(False)
        Me.GrpBxAuteur.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents pnlAccueil As System.Windows.Forms.Panel
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents btnRetour As System.Windows.Forms.Button
    Friend WithEvents btnSupprimer As System.Windows.Forms.Button
    Friend WithEvents btnRechercher As System.Windows.Forms.Button
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GrbNiveau As GroupBox
    Friend WithEvents rbtInvit As RadioButton
    Friend WithEvents RbtAdmin As RadioButton
    Friend WithEvents RbtUser As RadioButton
    Friend WithEvents dtGrdAuteurs As DataGridView
    Friend WithEvents GrpBxAuteur As GroupBox
    Friend WithEvents btnResetMDP As Button
    Friend WithEvents TxtMDP As TextBox
    Friend WithEvents LblMDP As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents LblID As Label
    Friend WithEvents LblPrenom As Label
    Friend WithEvents TxtPrenom As TextBox
    Friend WithEvents lblCode As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents lblNom As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
End Class
