<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAuteurs
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
        Me.GrpBxAuteur = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerDateNaiss = New System.Windows.Forms.DateTimePicker()
        Me.txtNaiss = New System.Windows.Forms.TextBox()
        Me.lblBio = New System.Windows.Forms.Label()
        Me.txtBio = New System.Windows.Forms.TextBox()
        Me.lblNaiss = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.dtGrdAuteurs = New System.Windows.Forms.DataGridView()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.pnlAccueil = New System.Windows.Forms.Panel()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnSauvegarder = New System.Windows.Forms.Button()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GrpBxAuteur.SuspendLayout()
        CType(Me.dtGrdAuteurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAccueil.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpBxAuteur
        '
        Me.GrpBxAuteur.Controls.Add(Me.DateTimePickerDateNaiss)
        Me.GrpBxAuteur.Controls.Add(Me.txtNaiss)
        Me.GrpBxAuteur.Controls.Add(Me.lblBio)
        Me.GrpBxAuteur.Controls.Add(Me.txtBio)
        Me.GrpBxAuteur.Controls.Add(Me.lblNaiss)
        Me.GrpBxAuteur.Controls.Add(Me.lblPrenom)
        Me.GrpBxAuteur.Controls.Add(Me.txtPrenom)
        Me.GrpBxAuteur.Controls.Add(Me.lblCode)
        Me.GrpBxAuteur.Controls.Add(Me.txtCode)
        Me.GrpBxAuteur.Controls.Add(Me.lblNom)
        Me.GrpBxAuteur.Controls.Add(Me.txtNom)
        Me.GrpBxAuteur.Font = New System.Drawing.Font("Georgia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBxAuteur.Location = New System.Drawing.Point(20, 42)
        Me.GrpBxAuteur.Name = "GrpBxAuteur"
        Me.GrpBxAuteur.Size = New System.Drawing.Size(581, 304)
        Me.GrpBxAuteur.TabIndex = 16
        Me.GrpBxAuteur.TabStop = False
        '
        'DateTimePickerDateNaiss
        '
        Me.DateTimePickerDateNaiss.CalendarFont = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerDateNaiss.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerDateNaiss.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerDateNaiss.Location = New System.Drawing.Point(354, 109)
        Me.DateTimePickerDateNaiss.Name = "DateTimePickerDateNaiss"
        Me.DateTimePickerDateNaiss.Size = New System.Drawing.Size(111, 28)
        Me.DateTimePickerDateNaiss.TabIndex = 0
        Me.DateTimePickerDateNaiss.Value = New Date(1940, 1, 1, 0, 0, 0, 0)
        '
        'txtNaiss
        '
        Me.txtNaiss.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNaiss.Location = New System.Drawing.Point(134, 108)
        Me.txtNaiss.Name = "txtNaiss"
        Me.txtNaiss.Size = New System.Drawing.Size(105, 25)
        Me.txtNaiss.TabIndex = 39
        '
        'lblBio
        '
        Me.lblBio.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBio.Location = New System.Drawing.Point(6, 145)
        Me.lblBio.Name = "lblBio"
        Me.lblBio.Size = New System.Drawing.Size(99, 24)
        Me.lblBio.TabIndex = 37
        Me.lblBio.Text = "Biographie :"
        Me.lblBio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBio
        '
        Me.txtBio.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBio.Location = New System.Drawing.Point(6, 172)
        Me.txtBio.Multiline = True
        Me.txtBio.Name = "txtBio"
        Me.txtBio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBio.Size = New System.Drawing.Size(569, 126)
        Me.txtBio.TabIndex = 36
        '
        'lblNaiss
        '
        Me.lblNaiss.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNaiss.Location = New System.Drawing.Point(6, 109)
        Me.lblNaiss.Name = "lblNaiss"
        Me.lblNaiss.Size = New System.Drawing.Size(132, 24)
        Me.lblNaiss.TabIndex = 35
        Me.lblNaiss.Text = "Date naissance :"
        Me.lblNaiss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrenom
        '
        Me.lblPrenom.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrenom.Location = New System.Drawing.Point(276, 67)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(76, 24)
        Me.lblPrenom.TabIndex = 30
        Me.lblPrenom.Text = "Prénom :  "
        Me.lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPrenom
        '
        Me.txtPrenom.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrenom.Location = New System.Drawing.Point(354, 69)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(200, 25)
        Me.txtPrenom.TabIndex = 29
        '
        'lblCode
        '
        Me.lblCode.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(6, 26)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(58, 24)
        Me.lblCode.TabIndex = 28
        Me.lblCode.Text = "Code : "
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(70, 24)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(200, 25)
        Me.txtCode.TabIndex = 24
        '
        'lblNom
        '
        Me.lblNom.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(6, 64)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(58, 24)
        Me.lblNom.TabIndex = 21
        Me.lblNom.Text = "Nom :  "
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(70, 67)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(200, 25)
        Me.txtNom.TabIndex = 16
        '
        'dtGrdAuteurs
        '
        Me.dtGrdAuteurs.AllowUserToAddRows = False
        Me.dtGrdAuteurs.AllowUserToDeleteRows = False
        Me.dtGrdAuteurs.AllowUserToResizeColumns = False
        Me.dtGrdAuteurs.AllowUserToResizeRows = False
        Me.dtGrdAuteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrdAuteurs.Location = New System.Drawing.Point(20, 352)
        Me.dtGrdAuteurs.MultiSelect = False
        Me.dtGrdAuteurs.Name = "dtGrdAuteurs"
        Me.dtGrdAuteurs.ReadOnly = True
        Me.dtGrdAuteurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGrdAuteurs.Size = New System.Drawing.Size(581, 177)
        Me.dtGrdAuteurs.TabIndex = 18
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(29, 15)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(199, 24)
        Me.lblTitre.TabIndex = 17
        Me.lblTitre.Text = "Gestion des Auteurs"
        '
        'pnlAccueil
        '
        Me.pnlAccueil.Controls.Add(Me.dtGrdAuteurs)
        Me.pnlAccueil.Controls.Add(Me.GrpBxAuteur)
        Me.pnlAccueil.Controls.Add(Me.lblTitre)
        Me.pnlAccueil.Location = New System.Drawing.Point(3, 3)
        Me.pnlAccueil.Name = "pnlAccueil"
        Me.pnlAccueil.Size = New System.Drawing.Size(623, 548)
        Me.pnlAccueil.TabIndex = 22
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
        Me.SplitContainer1.SplitterDistance = 192
        Me.SplitContainer1.TabIndex = 14
        '
        'FrmAuteurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 565)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmAuteurs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAuteurs"
        Me.GrpBxAuteur.ResumeLayout(False)
        Me.GrpBxAuteur.PerformLayout()
        CType(Me.dtGrdAuteurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAccueil.ResumeLayout(False)
        Me.pnlAccueil.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpBxAuteur As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePickerDateNaiss As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNaiss As System.Windows.Forms.TextBox
    Friend WithEvents lblBio As System.Windows.Forms.Label
    Friend WithEvents txtBio As System.Windows.Forms.TextBox
    Friend WithEvents lblNaiss As System.Windows.Forms.Label
    Friend WithEvents lblPrenom As System.Windows.Forms.Label
    Friend WithEvents txtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents dtGrdAuteurs As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents pnlAccueil As System.Windows.Forms.Panel
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents btnSauvegarder As System.Windows.Forms.Button
    Friend WithEvents btnRetour As System.Windows.Forms.Button
    Friend WithEvents btnSupprimer As System.Windows.Forms.Button
    Friend WithEvents btnRechercher As System.Windows.Forms.Button
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
