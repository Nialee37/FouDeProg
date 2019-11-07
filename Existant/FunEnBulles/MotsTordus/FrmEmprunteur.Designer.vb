<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmprunteurs
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
        Me.DateTimePickernaissance = New System.Windows.Forms.DateTimePicker()
        Me.txtDatenaissance = New System.Windows.Forms.TextBox()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.txtRue = New System.Windows.Forms.TextBox()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.lblmail = New System.Windows.Forms.Label()
        Me.MtbCodepostal = New System.Windows.Forms.MaskedTextBox()
        Me.lblCodepostal = New System.Windows.Forms.Label()
        Me.lblDateNaissance = New System.Windows.Forms.Label()
        Me.lblRue = New System.Windows.Forms.Label()
        Me.LblPrenom = New System.Windows.Forms.Label()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.dtGrdEmprunteurs = New System.Windows.Forms.DataGridView()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.btnChercher = New System.Windows.Forms.Button()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnSauvegarder = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.GrpBxEmprunteurs = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.dtGrdEmprunteurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBxEmprunteurs.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePickernaissance
        '
        Me.DateTimePickernaissance.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePickernaissance.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickernaissance.Location = New System.Drawing.Point(351, 106)
        Me.DateTimePickernaissance.MinDate = New Date(1940, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickernaissance.Name = "DateTimePickernaissance"
        Me.DateTimePickernaissance.Size = New System.Drawing.Size(140, 25)
        Me.DateTimePickernaissance.TabIndex = 49
        Me.DateTimePickernaissance.Value = New Date(1940, 1, 1, 0, 0, 0, 0)
        '
        'txtDatenaissance
        '
        Me.txtDatenaissance.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatenaissance.Location = New System.Drawing.Point(163, 109)
        Me.txtDatenaissance.Name = "txtDatenaissance"
        Me.txtDatenaissance.Size = New System.Drawing.Size(105, 25)
        Me.txtDatenaissance.TabIndex = 3
        '
        'txtVille
        '
        Me.txtVille.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVille.Location = New System.Drawing.Point(424, 196)
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(161, 25)
        Me.txtVille.TabIndex = 6
        '
        'txtRue
        '
        Me.txtRue.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRue.Location = New System.Drawing.Point(70, 154)
        Me.txtRue.Name = "txtRue"
        Me.txtRue.Size = New System.Drawing.Size(515, 25)
        Me.txtRue.TabIndex = 4
        '
        'lblVille
        '
        Me.lblVille.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVille.Location = New System.Drawing.Point(347, 197)
        Me.lblVille.Name = "lblVille"
        Me.lblVille.Size = New System.Drawing.Size(71, 24)
        Me.lblVille.TabIndex = 46
        Me.lblVille.Text = "Ville :"
        Me.lblVille.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(137, 252)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(216, 25)
        Me.txtMail.TabIndex = 7
        '
        'lblmail
        '
        Me.lblmail.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmail.Location = New System.Drawing.Point(6, 253)
        Me.lblmail.Name = "lblmail"
        Me.lblmail.Size = New System.Drawing.Size(125, 24)
        Me.lblmail.TabIndex = 41
        Me.lblmail.Text = "Adresse mail :"
        Me.lblmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MtbCodepostal
        '
        Me.MtbCodepostal.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MtbCodepostal.Location = New System.Drawing.Point(123, 197)
        Me.MtbCodepostal.Mask = "00000"
        Me.MtbCodepostal.Name = "MtbCodepostal"
        Me.MtbCodepostal.Size = New System.Drawing.Size(67, 25)
        Me.MtbCodepostal.TabIndex = 5
        '
        'lblCodepostal
        '
        Me.lblCodepostal.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodepostal.Location = New System.Drawing.Point(6, 200)
        Me.lblCodepostal.Name = "lblCodepostal"
        Me.lblCodepostal.Size = New System.Drawing.Size(111, 24)
        Me.lblCodepostal.TabIndex = 43
        Me.lblCodepostal.Text = "Code postal :"
        Me.lblCodepostal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateNaissance
        '
        Me.lblDateNaissance.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateNaissance.Location = New System.Drawing.Point(6, 109)
        Me.lblDateNaissance.Name = "lblDateNaissance"
        Me.lblDateNaissance.Size = New System.Drawing.Size(151, 24)
        Me.lblDateNaissance.TabIndex = 37
        Me.lblDateNaissance.Text = "Date de naissance :"
        Me.lblDateNaissance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRue
        '
        Me.lblRue.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRue.Location = New System.Drawing.Point(6, 155)
        Me.lblRue.Name = "lblRue"
        Me.lblRue.Size = New System.Drawing.Size(58, 24)
        Me.lblRue.TabIndex = 39
        Me.lblRue.Text = "Rue :"
        Me.lblRue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPrenom
        '
        Me.LblPrenom.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrenom.Location = New System.Drawing.Point(347, 62)
        Me.LblPrenom.Name = "LblPrenom"
        Me.LblPrenom.Size = New System.Drawing.Size(71, 24)
        Me.LblPrenom.TabIndex = 36
        Me.LblPrenom.Text = "Prénom :"
        Me.LblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPrenom
        '
        Me.txtPrenom.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrenom.Location = New System.Drawing.Point(424, 62)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(161, 25)
        Me.txtPrenom.TabIndex = 2
        '
        'lblNum
        '
        Me.lblNum.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.Location = New System.Drawing.Point(6, 15)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(78, 24)
        Me.lblNum.TabIndex = 34
        Me.lblNum.Text = "Numero :"
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(90, 14)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(53, 25)
        Me.txtNumero.TabIndex = 33
        '
        'lblNom
        '
        Me.lblNom.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(6, 61)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(66, 24)
        Me.lblNom.TabIndex = 32
        Me.lblNom.Text = "Nom :"
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(78, 60)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(161, 25)
        Me.txtNom.TabIndex = 1
        '
        'dtGrdEmprunteurs
        '
        Me.dtGrdEmprunteurs.AllowUserToAddRows = False
        Me.dtGrdEmprunteurs.AllowUserToDeleteRows = False
        Me.dtGrdEmprunteurs.AllowUserToResizeColumns = False
        Me.dtGrdEmprunteurs.AllowUserToResizeRows = False
        Me.dtGrdEmprunteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrdEmprunteurs.Location = New System.Drawing.Point(3, 338)
        Me.dtGrdEmprunteurs.MultiSelect = False
        Me.dtGrdEmprunteurs.Name = "dtGrdEmprunteurs"
        Me.dtGrdEmprunteurs.ReadOnly = True
        Me.dtGrdEmprunteurs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtGrdEmprunteurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGrdEmprunteurs.Size = New System.Drawing.Size(617, 211)
        Me.dtGrdEmprunteurs.TabIndex = 19
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(3, 9)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(247, 24)
        Me.lblTitre.TabIndex = 18
        Me.lblTitre.Text = "Gestion des Emprunteurs"
        '
        'btnChercher
        '
        Me.btnChercher.BackColor = System.Drawing.Color.Transparent
        Me.btnChercher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnChercher.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChercher.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnChercher.Image = Global.FunEnBulles.My.Resources.Resources.chercher_btn
        Me.btnChercher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChercher.Location = New System.Drawing.Point(26, 371)
        Me.btnChercher.Name = "btnChercher"
        Me.btnChercher.Size = New System.Drawing.Size(154, 58)
        Me.btnChercher.TabIndex = 16
        Me.btnChercher.Text = "          Chercher"
        Me.btnChercher.UseVisualStyleBackColor = False
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
        Me.btnRechercher.Location = New System.Drawing.Point(26, 195)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(154, 58)
        Me.btnRechercher.TabIndex = 14
        Me.btnRechercher.Text = "           Rechercher"
        Me.btnRechercher.UseVisualStyleBackColor = False
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
        Me.btnRetour.Location = New System.Drawing.Point(7, 507)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(187, 45)
        Me.btnRetour.TabIndex = 13
        Me.btnRetour.Text = "Accueil"
        Me.btnRetour.UseVisualStyleBackColor = False
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
        Me.btnAnnuler.Location = New System.Drawing.Point(26, 412)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(154, 58)
        Me.btnAnnuler.TabIndex = 12
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
        Me.btnSauvegarder.Location = New System.Drawing.Point(26, 348)
        Me.btnSauvegarder.Name = "btnSauvegarder"
        Me.btnSauvegarder.Size = New System.Drawing.Size(154, 58)
        Me.btnSauvegarder.TabIndex = 11
        Me.btnSauvegarder.Text = "          Sauvegarder"
        Me.btnSauvegarder.UseVisualStyleBackColor = False
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
        Me.btnSupprimer.Location = New System.Drawing.Point(26, 270)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(154, 58)
        Me.btnSupprimer.TabIndex = 9
        Me.btnSupprimer.Text = "       Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = False
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
        Me.btnModifier.Location = New System.Drawing.Point(26, 115)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(154, 58)
        Me.btnModifier.TabIndex = 7
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
        Me.btnAjouter.Location = New System.Drawing.Point(26, 28)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(154, 58)
        Me.btnAjouter.TabIndex = 6
        Me.btnAjouter.Text = "  Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'GrpBxEmprunteurs
        '
        Me.GrpBxEmprunteurs.Controls.Add(Me.DateTimePickernaissance)
        Me.GrpBxEmprunteurs.Controls.Add(Me.txtDatenaissance)
        Me.GrpBxEmprunteurs.Controls.Add(Me.txtVille)
        Me.GrpBxEmprunteurs.Controls.Add(Me.txtRue)
        Me.GrpBxEmprunteurs.Controls.Add(Me.lblVille)
        Me.GrpBxEmprunteurs.Controls.Add(Me.txtMail)
        Me.GrpBxEmprunteurs.Controls.Add(Me.lblmail)
        Me.GrpBxEmprunteurs.Controls.Add(Me.MtbCodepostal)
        Me.GrpBxEmprunteurs.Controls.Add(Me.lblCodepostal)
        Me.GrpBxEmprunteurs.Controls.Add(Me.lblDateNaissance)
        Me.GrpBxEmprunteurs.Controls.Add(Me.lblRue)
        Me.GrpBxEmprunteurs.Controls.Add(Me.LblPrenom)
        Me.GrpBxEmprunteurs.Controls.Add(Me.txtPrenom)
        Me.GrpBxEmprunteurs.Controls.Add(Me.lblNum)
        Me.GrpBxEmprunteurs.Controls.Add(Me.txtNumero)
        Me.GrpBxEmprunteurs.Controls.Add(Me.lblNom)
        Me.GrpBxEmprunteurs.Controls.Add(Me.txtNom)
        Me.GrpBxEmprunteurs.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBxEmprunteurs.Location = New System.Drawing.Point(3, 36)
        Me.GrpBxEmprunteurs.Name = "GrpBxEmprunteurs"
        Me.GrpBxEmprunteurs.Size = New System.Drawing.Size(617, 299)
        Me.GrpBxEmprunteurs.TabIndex = 0
        Me.GrpBxEmprunteurs.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnChercher)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRechercher)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRetour)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAnnuler)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSauvegarder)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSupprimer)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnModifier)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAjouter)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtGrdEmprunteurs)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblTitre)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GrpBxEmprunteurs)
        Me.SplitContainer1.Size = New System.Drawing.Size(830, 565)
        Me.SplitContainer1.SplitterDistance = 196
        Me.SplitContainer1.TabIndex = 1
        '
        'FrmEmprunteurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 565)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmEmprunteurs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEmprunteur"
        CType(Me.dtGrdEmprunteurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBxEmprunteurs.ResumeLayout(False)
        Me.GrpBxEmprunteurs.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DateTimePickernaissance As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDatenaissance As System.Windows.Forms.TextBox
    Friend WithEvents txtVille As System.Windows.Forms.TextBox
    Friend WithEvents txtRue As System.Windows.Forms.TextBox
    Friend WithEvents lblVille As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents lblmail As System.Windows.Forms.Label
    Friend WithEvents MtbCodepostal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblCodepostal As System.Windows.Forms.Label
    Friend WithEvents lblDateNaissance As System.Windows.Forms.Label
    Friend WithEvents lblRue As System.Windows.Forms.Label
    Friend WithEvents LblPrenom As System.Windows.Forms.Label
    Friend WithEvents txtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents dtGrdEmprunteurs As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents btnChercher As System.Windows.Forms.Button
    Friend WithEvents btnRechercher As System.Windows.Forms.Button
    Friend WithEvents btnRetour As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents btnSauvegarder As System.Windows.Forms.Button
    Friend WithEvents btnSupprimer As System.Windows.Forms.Button
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents GrpBxEmprunteurs As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
