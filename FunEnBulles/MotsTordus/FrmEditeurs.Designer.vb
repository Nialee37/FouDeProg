<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditeurs
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnSauvegarder = New System.Windows.Forms.Button()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.pnlAccueil = New System.Windows.Forms.Panel()
        Me.dtGrdEditeurs = New System.Windows.Forms.DataGridView()
        Me.GrpBxAuteur = New System.Windows.Forms.GroupBox()
        Me.GrpBxContact = New System.Windows.Forms.GroupBox()
        Me.lblContactN = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblContactP = New System.Windows.Forms.Label()
        Me.txtContactN = New System.Windows.Forms.TextBox()
        Me.txtContactP = New System.Windows.Forms.TextBox()
        Me.lblAdrss = New System.Windows.Forms.Label()
        Me.txtAdrss = New System.Windows.Forms.TextBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblTitre = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnlAccueil.SuspendLayout()
        CType(Me.dtGrdEditeurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBxAuteur.SuspendLayout()
        Me.GrpBxContact.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnValider)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAnnuler)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSauvegarder)
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
        Me.SplitContainer1.TabIndex = 15
        '
        'btnValider
        '
        Me.btnValider.BackColor = System.Drawing.Color.Transparent
        Me.btnValider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValider.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnValider.Image = Global.FunEnBulles.My.Resources.Resources.chercher_btn
        Me.btnValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnValider.Location = New System.Drawing.Point(15, 361)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(154, 58)
        Me.btnValider.TabIndex = 12
        Me.btnValider.Text = "          Chercher"
        Me.btnValider.UseVisualStyleBackColor = False
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
        'btnSauvegarder
        '
        Me.btnSauvegarder.BackColor = System.Drawing.Color.Transparent
        Me.btnSauvegarder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSauvegarder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSauvegarder.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSauvegarder.Image = Global.FunEnBulles.My.Resources.Resources.save_btn
        Me.btnSauvegarder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSauvegarder.Location = New System.Drawing.Point(15, 326)
        Me.btnSauvegarder.Name = "btnSauvegarder"
        Me.btnSauvegarder.Size = New System.Drawing.Size(154, 58)
        Me.btnSauvegarder.TabIndex = 10
        Me.btnSauvegarder.Text = "          Sauvegarder"
        Me.btnSauvegarder.UseVisualStyleBackColor = False
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
        Me.btnSupprimer.Location = New System.Drawing.Point(15, 262)
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
        Me.btnRechercher.Location = New System.Drawing.Point(15, 190)
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
        Me.btnModifier.Location = New System.Drawing.Point(15, 111)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(154, 58)
        Me.btnModifier.TabIndex = 6
        Me.btnModifier.Text = "      Modifier"
        Me.btnModifier.UseVisualStyleBackColor = False
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
        'pnlAccueil
        '
        Me.pnlAccueil.Controls.Add(Me.dtGrdEditeurs)
        Me.pnlAccueil.Controls.Add(Me.GrpBxAuteur)
        Me.pnlAccueil.Controls.Add(Me.lblTitre)
        Me.pnlAccueil.Location = New System.Drawing.Point(3, 3)
        Me.pnlAccueil.Name = "pnlAccueil"
        Me.pnlAccueil.Size = New System.Drawing.Size(623, 548)
        Me.pnlAccueil.TabIndex = 22
        '
        'dtGrdEditeurs
        '
        Me.dtGrdEditeurs.AllowUserToAddRows = False
        Me.dtGrdEditeurs.AllowUserToDeleteRows = False
        Me.dtGrdEditeurs.AllowUserToResizeColumns = False
        Me.dtGrdEditeurs.AllowUserToResizeRows = False
        Me.dtGrdEditeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrdEditeurs.Location = New System.Drawing.Point(3, 321)
        Me.dtGrdEditeurs.MultiSelect = False
        Me.dtGrdEditeurs.Name = "dtGrdEditeurs"
        Me.dtGrdEditeurs.ReadOnly = True
        Me.dtGrdEditeurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGrdEditeurs.Size = New System.Drawing.Size(611, 190)
        Me.dtGrdEditeurs.TabIndex = 18
        '
        'GrpBxAuteur
        '
        Me.GrpBxAuteur.Controls.Add(Me.GrpBxContact)
        Me.GrpBxAuteur.Controls.Add(Me.lblAdrss)
        Me.GrpBxAuteur.Controls.Add(Me.txtAdrss)
        Me.GrpBxAuteur.Controls.Add(Me.lblCode)
        Me.GrpBxAuteur.Controls.Add(Me.txtCode)
        Me.GrpBxAuteur.Controls.Add(Me.lblNom)
        Me.GrpBxAuteur.Controls.Add(Me.txtNom)
        Me.GrpBxAuteur.Font = New System.Drawing.Font("Georgia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBxAuteur.Location = New System.Drawing.Point(3, 33)
        Me.GrpBxAuteur.Name = "GrpBxAuteur"
        Me.GrpBxAuteur.Size = New System.Drawing.Size(611, 282)
        Me.GrpBxAuteur.TabIndex = 16
        Me.GrpBxAuteur.TabStop = False
        '
        'GrpBxContact
        '
        Me.GrpBxContact.Controls.Add(Me.lblContactN)
        Me.GrpBxContact.Controls.Add(Me.lblTel)
        Me.GrpBxContact.Controls.Add(Me.txtMail)
        Me.GrpBxContact.Controls.Add(Me.txtTel)
        Me.GrpBxContact.Controls.Add(Me.lblMail)
        Me.GrpBxContact.Controls.Add(Me.lblContactP)
        Me.GrpBxContact.Controls.Add(Me.txtContactN)
        Me.GrpBxContact.Controls.Add(Me.txtContactP)
        Me.GrpBxContact.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBxContact.Location = New System.Drawing.Point(20, 109)
        Me.GrpBxContact.Name = "GrpBxContact"
        Me.GrpBxContact.Size = New System.Drawing.Size(568, 156)
        Me.GrpBxContact.TabIndex = 39
        Me.GrpBxContact.TabStop = False
        Me.GrpBxContact.Text = "Contact"
        '
        'lblContactN
        '
        Me.lblContactN.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactN.Location = New System.Drawing.Point(6, 43)
        Me.lblContactN.Name = "lblContactN"
        Me.lblContactN.Size = New System.Drawing.Size(54, 24)
        Me.lblContactN.TabIndex = 34
        Me.lblContactN.Text = "Nom :  "
        Me.lblContactN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTel
        '
        Me.lblTel.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.Location = New System.Drawing.Point(2, 96)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(85, 24)
        Me.lblTel.TabIndex = 38
        Me.lblTel.Text = "Telephone :  "
        Me.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(301, 95)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(261, 23)
        Me.txtMail.TabIndex = 31
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(93, 95)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(152, 23)
        Me.txtTel.TabIndex = 37
        '
        'lblMail
        '
        Me.lblMail.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.Location = New System.Drawing.Point(256, 96)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(50, 24)
        Me.lblMail.TabIndex = 32
        Me.lblMail.Text = "Mail :  "
        Me.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblContactP
        '
        Me.lblContactP.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactP.Location = New System.Drawing.Point(279, 43)
        Me.lblContactP.Name = "lblContactP"
        Me.lblContactP.Size = New System.Drawing.Size(62, 24)
        Me.lblContactP.TabIndex = 36
        Me.lblContactP.Text = "Prenom :  "
        Me.lblContactP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContactN
        '
        Me.txtContactN.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactN.Location = New System.Drawing.Point(66, 45)
        Me.txtContactN.Name = "txtContactN"
        Me.txtContactN.Size = New System.Drawing.Size(207, 23)
        Me.txtContactN.TabIndex = 33
        '
        'txtContactP
        '
        Me.txtContactP.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactP.Location = New System.Drawing.Point(342, 43)
        Me.txtContactP.Name = "txtContactP"
        Me.txtContactP.Size = New System.Drawing.Size(220, 23)
        Me.txtContactP.TabIndex = 35
        '
        'lblAdrss
        '
        Me.lblAdrss.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdrss.Location = New System.Drawing.Point(5, 62)
        Me.lblAdrss.Name = "lblAdrss"
        Me.lblAdrss.Size = New System.Drawing.Size(90, 24)
        Me.lblAdrss.TabIndex = 30
        Me.lblAdrss.Text = "Adresse :  "
        Me.lblAdrss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAdrss
        '
        Me.txtAdrss.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdrss.Location = New System.Drawing.Point(101, 64)
        Me.txtAdrss.Name = "txtAdrss"
        Me.txtAdrss.Size = New System.Drawing.Size(487, 25)
        Me.txtAdrss.TabIndex = 29
        '
        'lblCode
        '
        Me.lblCode.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(5, 21)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(58, 24)
        Me.lblCode.TabIndex = 28
        Me.lblCode.Text = "Code : "
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(69, 20)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(207, 25)
        Me.txtCode.TabIndex = 24
        '
        'lblNom
        '
        Me.lblNom.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(292, 21)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(58, 24)
        Me.lblNom.TabIndex = 21
        Me.lblNom.Text = "Nom :  "
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(356, 23)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(232, 25)
        Me.txtNom.TabIndex = 16
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(19, 6)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(204, 24)
        Me.lblTitre.TabIndex = 17
        Me.lblTitre.Text = "Gestion des Editeurs"
        '
        'FrmEditeurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 562)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmEditeurs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEditeurs"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnlAccueil.ResumeLayout(False)
        Me.pnlAccueil.PerformLayout()
        CType(Me.dtGrdEditeurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBxAuteur.ResumeLayout(False)
        Me.GrpBxAuteur.PerformLayout()
        Me.GrpBxContact.ResumeLayout(False)
        Me.GrpBxContact.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents btnSauvegarder As System.Windows.Forms.Button
    Friend WithEvents btnRetour As System.Windows.Forms.Button
    Friend WithEvents btnSupprimer As System.Windows.Forms.Button
    Friend WithEvents btnRechercher As System.Windows.Forms.Button
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents pnlAccueil As System.Windows.Forms.Panel
    Friend WithEvents dtGrdEditeurs As System.Windows.Forms.DataGridView
    Friend WithEvents GrpBxAuteur As System.Windows.Forms.GroupBox
    Friend WithEvents GrpBxContact As System.Windows.Forms.GroupBox
    Friend WithEvents lblContactN As System.Windows.Forms.Label
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblContactP As System.Windows.Forms.Label
    Friend WithEvents txtContactN As System.Windows.Forms.TextBox
    Friend WithEvents txtContactP As System.Windows.Forms.TextBox
    Friend WithEvents lblAdrss As System.Windows.Forms.Label
    Friend WithEvents txtAdrss As System.Windows.Forms.TextBox
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents lblTitre As System.Windows.Forms.Label
End Class
