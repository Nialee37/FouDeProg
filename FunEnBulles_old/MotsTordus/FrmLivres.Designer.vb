<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLivres
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
        Me.txtAuteur2 = New System.Windows.Forms.TextBox()
        Me.lblAuteur2 = New System.Windows.Forms.Label()
        Me.cbxAuteur2 = New System.Windows.Forms.ComboBox()
        Me.txtAuteur = New System.Windows.Forms.TextBox()
        Me.dtGrdLivres = New System.Windows.Forms.DataGridView()
        Me.GrpBxAuteur = New System.Windows.Forms.GroupBox()
        Me.lblAuteur = New System.Windows.Forms.Label()
        Me.cbxAuteur = New System.Windows.Forms.ComboBox()
        Me.cbxAnnee = New System.Windows.Forms.ComboBox()
        Me.cbxEditeur = New System.Windows.Forms.ComboBox()
        Me.cbxSerie = New System.Windows.Forms.ComboBox()
        Me.txtEditeur = New System.Windows.Forms.TextBox()
        Me.lblEditeur = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAnneP = New System.Windows.Forms.Label()
        Me.txtNumTome = New System.Windows.Forms.TextBox()
        Me.lblNumTome = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblTitreLivre = New System.Windows.Forms.Label()
        Me.txtTitre = New System.Windows.Forms.TextBox()
        Me.pnlAccueil = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnSauvegarder = New System.Windows.Forms.Button()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        CType(Me.dtGrdLivres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBxAuteur.SuspendLayout()
        Me.pnlAccueil.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(11, 18)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(182, 24)
        Me.lblTitre.TabIndex = 17
        Me.lblTitre.Text = "Gestion des Livres"
        '
        'txtAuteur2
        '
        Me.txtAuteur2.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuteur2.Location = New System.Drawing.Point(91, 181)
        Me.txtAuteur2.Name = "txtAuteur2"
        Me.txtAuteur2.Size = New System.Drawing.Size(224, 25)
        Me.txtAuteur2.TabIndex = 41
        '
        'lblAuteur2
        '
        Me.lblAuteur2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuteur2.Location = New System.Drawing.Point(7, 179)
        Me.lblAuteur2.Name = "lblAuteur2"
        Me.lblAuteur2.Size = New System.Drawing.Size(79, 24)
        Me.lblAuteur2.TabIndex = 43
        Me.lblAuteur2.Text = "Auteur :"
        Me.lblAuteur2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxAuteur2
        '
        Me.cbxAuteur2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAuteur2.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAuteur2.FormattingEnabled = True
        Me.cbxAuteur2.Location = New System.Drawing.Point(322, 180)
        Me.cbxAuteur2.Name = "cbxAuteur2"
        Me.cbxAuteur2.Size = New System.Drawing.Size(213, 26)
        Me.cbxAuteur2.TabIndex = 42
        '
        'txtAuteur
        '
        Me.txtAuteur.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuteur.Location = New System.Drawing.Point(90, 150)
        Me.txtAuteur.Name = "txtAuteur"
        Me.txtAuteur.Size = New System.Drawing.Size(224, 25)
        Me.txtAuteur.TabIndex = 4
        '
        'dtGrdLivres
        '
        Me.dtGrdLivres.AllowUserToAddRows = False
        Me.dtGrdLivres.AllowUserToDeleteRows = False
        Me.dtGrdLivres.AllowUserToResizeColumns = False
        Me.dtGrdLivres.AllowUserToResizeRows = False
        Me.dtGrdLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrdLivres.Location = New System.Drawing.Point(3, 323)
        Me.dtGrdLivres.MultiSelect = False
        Me.dtGrdLivres.Name = "dtGrdLivres"
        Me.dtGrdLivres.ReadOnly = True
        Me.dtGrdLivres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGrdLivres.Size = New System.Drawing.Size(613, 222)
        Me.dtGrdLivres.TabIndex = 18
        '
        'GrpBxAuteur
        '
        Me.GrpBxAuteur.Controls.Add(Me.txtAuteur2)
        Me.GrpBxAuteur.Controls.Add(Me.lblAuteur2)
        Me.GrpBxAuteur.Controls.Add(Me.cbxAuteur2)
        Me.GrpBxAuteur.Controls.Add(Me.txtAuteur)
        Me.GrpBxAuteur.Controls.Add(Me.lblAuteur)
        Me.GrpBxAuteur.Controls.Add(Me.cbxAuteur)
        Me.GrpBxAuteur.Controls.Add(Me.cbxAnnee)
        Me.GrpBxAuteur.Controls.Add(Me.cbxEditeur)
        Me.GrpBxAuteur.Controls.Add(Me.cbxSerie)
        Me.GrpBxAuteur.Controls.Add(Me.txtEditeur)
        Me.GrpBxAuteur.Controls.Add(Me.lblEditeur)
        Me.GrpBxAuteur.Controls.Add(Me.txtSerie)
        Me.GrpBxAuteur.Controls.Add(Me.Label1)
        Me.GrpBxAuteur.Controls.Add(Me.lblAnneP)
        Me.GrpBxAuteur.Controls.Add(Me.txtNumTome)
        Me.GrpBxAuteur.Controls.Add(Me.lblNumTome)
        Me.GrpBxAuteur.Controls.Add(Me.lblCode)
        Me.GrpBxAuteur.Controls.Add(Me.txtCode)
        Me.GrpBxAuteur.Controls.Add(Me.lblTitreLivre)
        Me.GrpBxAuteur.Controls.Add(Me.txtTitre)
        Me.GrpBxAuteur.Font = New System.Drawing.Font("Georgia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBxAuteur.Location = New System.Drawing.Point(3, 45)
        Me.GrpBxAuteur.Name = "GrpBxAuteur"
        Me.GrpBxAuteur.Size = New System.Drawing.Size(613, 272)
        Me.GrpBxAuteur.TabIndex = 16
        Me.GrpBxAuteur.TabStop = False
        '
        'lblAuteur
        '
        Me.lblAuteur.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuteur.Location = New System.Drawing.Point(6, 148)
        Me.lblAuteur.Name = "lblAuteur"
        Me.lblAuteur.Size = New System.Drawing.Size(79, 24)
        Me.lblAuteur.TabIndex = 40
        Me.lblAuteur.Text = "Auteur :"
        Me.lblAuteur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxAuteur
        '
        Me.cbxAuteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAuteur.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAuteur.FormattingEnabled = True
        Me.cbxAuteur.Location = New System.Drawing.Point(321, 149)
        Me.cbxAuteur.Name = "cbxAuteur"
        Me.cbxAuteur.Size = New System.Drawing.Size(213, 26)
        Me.cbxAuteur.TabIndex = 5
        '
        'cbxAnnee
        '
        Me.cbxAnnee.DropDownHeight = 95
        Me.cbxAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAnnee.Enabled = False
        Me.cbxAnnee.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAnnee.FormattingEnabled = True
        Me.cbxAnnee.IntegralHeight = False
        Me.cbxAnnee.Location = New System.Drawing.Point(382, 104)
        Me.cbxAnnee.Name = "cbxAnnee"
        Me.cbxAnnee.Size = New System.Drawing.Size(88, 26)
        Me.cbxAnnee.TabIndex = 3
        '
        'cbxEditeur
        '
        Me.cbxEditeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEditeur.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxEditeur.FormattingEnabled = True
        Me.cbxEditeur.Location = New System.Drawing.Point(321, 241)
        Me.cbxEditeur.Name = "cbxEditeur"
        Me.cbxEditeur.Size = New System.Drawing.Size(213, 25)
        Me.cbxEditeur.TabIndex = 11
        '
        'cbxSerie
        '
        Me.cbxSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSerie.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSerie.FormattingEnabled = True
        Me.cbxSerie.Location = New System.Drawing.Point(321, 210)
        Me.cbxSerie.Name = "cbxSerie"
        Me.cbxSerie.Size = New System.Drawing.Size(213, 25)
        Me.cbxSerie.TabIndex = 9
        '
        'txtEditeur
        '
        Me.txtEditeur.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditeur.Location = New System.Drawing.Point(91, 241)
        Me.txtEditeur.Name = "txtEditeur"
        Me.txtEditeur.Size = New System.Drawing.Size(224, 25)
        Me.txtEditeur.TabIndex = 10
        '
        'lblEditeur
        '
        Me.lblEditeur.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditeur.Location = New System.Drawing.Point(6, 237)
        Me.lblEditeur.Name = "lblEditeur"
        Me.lblEditeur.Size = New System.Drawing.Size(79, 24)
        Me.lblEditeur.TabIndex = 35
        Me.lblEditeur.Text = "Editeur : "
        Me.lblEditeur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSerie
        '
        Me.txtSerie.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(91, 210)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(223, 25)
        Me.txtSerie.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 24)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Série : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnneP
        '
        Me.lblAnneP.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnneP.Location = New System.Drawing.Point(222, 103)
        Me.lblAnneP.Name = "lblAnneP"
        Me.lblAnneP.Size = New System.Drawing.Size(154, 24)
        Me.lblAnneP.TabIndex = 31
        Me.lblAnneP.Text = "Année de parution :  "
        Me.lblAnneP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNumTome
        '
        Me.txtNumTome.AcceptsTab = True
        Me.txtNumTome.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumTome.Location = New System.Drawing.Point(91, 101)
        Me.txtNumTome.Name = "txtNumTome"
        Me.txtNumTome.Size = New System.Drawing.Size(87, 25)
        Me.txtNumTome.TabIndex = 2
        '
        'lblNumTome
        '
        Me.lblNumTome.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumTome.Location = New System.Drawing.Point(6, 103)
        Me.lblNumTome.Name = "lblNumTome"
        Me.lblNumTome.Size = New System.Drawing.Size(85, 24)
        Me.lblNumTome.TabIndex = 29
        Me.lblNumTome.Text = "Tome n° : "
        Me.lblNumTome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCode
        '
        Me.lblCode.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(17, 21)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(58, 24)
        Me.lblCode.TabIndex = 28
        Me.lblCode.Text = "Code : "
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(91, 24)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(87, 25)
        Me.txtCode.TabIndex = 24
        '
        'lblTitreLivre
        '
        Me.lblTitreLivre.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreLivre.Location = New System.Drawing.Point(6, 63)
        Me.lblTitreLivre.Name = "lblTitreLivre"
        Me.lblTitreLivre.Size = New System.Drawing.Size(69, 24)
        Me.lblTitreLivre.TabIndex = 21
        Me.lblTitreLivre.Text = "Titre :  "
        Me.lblTitreLivre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTitre
        '
        Me.txtTitre.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitre.Location = New System.Drawing.Point(91, 67)
        Me.txtTitre.Name = "txtTitre"
        Me.txtTitre.Size = New System.Drawing.Size(443, 25)
        Me.txtTitre.TabIndex = 1
        '
        'pnlAccueil
        '
        Me.pnlAccueil.Controls.Add(Me.dtGrdLivres)
        Me.pnlAccueil.Controls.Add(Me.GrpBxAuteur)
        Me.pnlAccueil.Controls.Add(Me.lblTitre)
        Me.pnlAccueil.Location = New System.Drawing.Point(3, 3)
        Me.pnlAccueil.Name = "pnlAccueil"
        Me.pnlAccueil.Size = New System.Drawing.Size(623, 548)
        Me.pnlAccueil.TabIndex = 22
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
        Me.SplitContainer1.TabIndex = 16
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
        'FrmLivres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 565)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmLivres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLivres"
        CType(Me.dtGrdLivres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBxAuteur.ResumeLayout(False)
        Me.GrpBxAuteur.PerformLayout()
        Me.pnlAccueil.ResumeLayout(False)
        Me.pnlAccueil.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents txtAuteur2 As System.Windows.Forms.TextBox
    Friend WithEvents lblAuteur2 As System.Windows.Forms.Label
    Friend WithEvents cbxAuteur2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtAuteur As System.Windows.Forms.TextBox
    Friend WithEvents dtGrdLivres As System.Windows.Forms.DataGridView
    Friend WithEvents GrpBxAuteur As System.Windows.Forms.GroupBox
    Friend WithEvents lblAuteur As System.Windows.Forms.Label
    Friend WithEvents cbxAuteur As System.Windows.Forms.ComboBox
    Friend WithEvents cbxAnnee As System.Windows.Forms.ComboBox
    Friend WithEvents cbxEditeur As System.Windows.Forms.ComboBox
    Friend WithEvents cbxSerie As System.Windows.Forms.ComboBox
    Friend WithEvents txtEditeur As System.Windows.Forms.TextBox
    Friend WithEvents lblEditeur As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAnneP As System.Windows.Forms.Label
    Friend WithEvents txtNumTome As System.Windows.Forms.TextBox
    Friend WithEvents lblNumTome As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblTitreLivre As System.Windows.Forms.Label
    Friend WithEvents txtTitre As System.Windows.Forms.TextBox
    Friend WithEvents pnlAccueil As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents btnSauvegarder As System.Windows.Forms.Button
    Friend WithEvents btnRetour As System.Windows.Forms.Button
    Friend WithEvents btnSupprimer As System.Windows.Forms.Button
    Friend WithEvents btnRechercher As System.Windows.Forms.Button
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
End Class
