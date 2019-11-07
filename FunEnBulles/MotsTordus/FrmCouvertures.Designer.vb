<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCouvertures
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCouvertures))
        Me.dtGrdBd = New System.Windows.Forms.DataGridView()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.txtEditeur = New System.Windows.Forms.TextBox()
        Me.GrpBxAuteur = New System.Windows.Forms.GroupBox()
        Me.lblEditeur = New System.Windows.Forms.Label()
        Me.btnParcourir = New System.Windows.Forms.Button()
        Me.pictBoxImage = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.txtNumTome = New System.Windows.Forms.TextBox()
        Me.lblNumTome = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblTitreLivre = New System.Windows.Forms.Label()
        Me.txtTitre = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSansCouv = New System.Windows.Forms.Button()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnSauvegarder = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        CType(Me.dtGrdBd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBxAuteur.SuspendLayout()
        CType(Me.pictBoxImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtGrdBd
        '
        Me.dtGrdBd.AllowUserToAddRows = False
        Me.dtGrdBd.AllowUserToDeleteRows = False
        Me.dtGrdBd.AllowUserToResizeColumns = False
        Me.dtGrdBd.AllowUserToResizeRows = False
        Me.dtGrdBd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrdBd.Location = New System.Drawing.Point(7, 375)
        Me.dtGrdBd.MultiSelect = False
        Me.dtGrdBd.Name = "dtGrdBd"
        Me.dtGrdBd.ReadOnly = True
        Me.dtGrdBd.RowHeadersWidth = 24
        Me.dtGrdBd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dtGrdBd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGrdBd.Size = New System.Drawing.Size(601, 173)
        Me.dtGrdBd.TabIndex = 19
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(29, 20)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(325, 24)
        Me.lblTitre.TabIndex = 18
        Me.lblTitre.Text = "Gestion des Couvertures / Images"
        '
        'txtEditeur
        '
        Me.txtEditeur.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditeur.Location = New System.Drawing.Point(360, 103)
        Me.txtEditeur.Name = "txtEditeur"
        Me.txtEditeur.Size = New System.Drawing.Size(224, 25)
        Me.txtEditeur.TabIndex = 5
        '
        'GrpBxAuteur
        '
        Me.GrpBxAuteur.Controls.Add(Me.txtEditeur)
        Me.GrpBxAuteur.Controls.Add(Me.lblEditeur)
        Me.GrpBxAuteur.Controls.Add(Me.btnParcourir)
        Me.GrpBxAuteur.Controls.Add(Me.pictBoxImage)
        Me.GrpBxAuteur.Controls.Add(Me.Label1)
        Me.GrpBxAuteur.Controls.Add(Me.txtSerie)
        Me.GrpBxAuteur.Controls.Add(Me.txtNumTome)
        Me.GrpBxAuteur.Controls.Add(Me.lblNumTome)
        Me.GrpBxAuteur.Controls.Add(Me.lblCode)
        Me.GrpBxAuteur.Controls.Add(Me.txtCode)
        Me.GrpBxAuteur.Controls.Add(Me.lblTitreLivre)
        Me.GrpBxAuteur.Controls.Add(Me.txtTitre)
        Me.GrpBxAuteur.Font = New System.Drawing.Font("Georgia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBxAuteur.Location = New System.Drawing.Point(7, 62)
        Me.GrpBxAuteur.Name = "GrpBxAuteur"
        Me.GrpBxAuteur.Size = New System.Drawing.Size(601, 305)
        Me.GrpBxAuteur.TabIndex = 20
        Me.GrpBxAuteur.TabStop = False
        '
        'lblEditeur
        '
        Me.lblEditeur.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditeur.Location = New System.Drawing.Point(278, 104)
        Me.lblEditeur.Name = "lblEditeur"
        Me.lblEditeur.Size = New System.Drawing.Size(79, 24)
        Me.lblEditeur.TabIndex = 37
        Me.lblEditeur.Text = "Editeur : "
        Me.lblEditeur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnParcourir
        '
        Me.btnParcourir.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParcourir.Location = New System.Drawing.Point(360, 246)
        Me.btnParcourir.Name = "btnParcourir"
        Me.btnParcourir.Size = New System.Drawing.Size(95, 28)
        Me.btnParcourir.TabIndex = 37
        Me.btnParcourir.Text = "Parcourir"
        Me.btnParcourir.UseVisualStyleBackColor = True
        Me.btnParcourir.Visible = False
        '
        'pictBoxImage
        '
        Me.pictBoxImage.ErrorImage = CType(resources.GetObject("pictBoxImage.ErrorImage"), System.Drawing.Image)
        Me.pictBoxImage.Location = New System.Drawing.Point(53, 104)
        Me.pictBoxImage.Name = "pictBoxImage"
        Me.pictBoxImage.Size = New System.Drawing.Size(131, 182)
        Me.pictBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictBoxImage.TabIndex = 21
        Me.pictBoxImage.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 24)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Série : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSerie
        '
        Me.txtSerie.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(70, 64)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(234, 25)
        Me.txtSerie.TabIndex = 3
        '
        'txtNumTome
        '
        Me.txtNumTome.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumTome.Location = New System.Drawing.Point(411, 63)
        Me.txtNumTome.Name = "txtNumTome"
        Me.txtNumTome.Size = New System.Drawing.Size(87, 25)
        Me.txtNumTome.TabIndex = 4
        '
        'lblNumTome
        '
        Me.lblNumTome.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumTome.Location = New System.Drawing.Point(320, 65)
        Me.lblNumTome.Name = "lblNumTome"
        Me.lblNumTome.Size = New System.Drawing.Size(85, 24)
        Me.lblNumTome.TabIndex = 29
        Me.lblNumTome.Text = "Tome n° : "
        Me.lblNumTome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCode
        '
        Me.lblCode.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(8, 25)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(58, 24)
        Me.lblCode.TabIndex = 28
        Me.lblCode.Text = "Code : "
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(70, 27)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(87, 25)
        Me.txtCode.TabIndex = 1
        '
        'lblTitreLivre
        '
        Me.lblTitreLivre.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreLivre.Location = New System.Drawing.Point(258, 25)
        Me.lblTitreLivre.Name = "lblTitreLivre"
        Me.lblTitreLivre.Size = New System.Drawing.Size(60, 24)
        Me.lblTitreLivre.TabIndex = 21
        Me.lblTitreLivre.Text = "Titre :  "
        Me.lblTitreLivre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTitre
        '
        Me.txtTitre.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitre.Location = New System.Drawing.Point(324, 24)
        Me.txtTitre.Name = "txtTitre"
        Me.txtTitre.Size = New System.Drawing.Size(260, 25)
        Me.txtTitre.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.GrpBxAuteur)
        Me.Panel2.Controls.Add(Me.dtGrdBd)
        Me.Panel2.Controls.Add(Me.lblTitre)
        Me.Panel2.Location = New System.Drawing.Point(206, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(625, 561)
        Me.Panel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.btnSansCouv)
        Me.Panel1.Controls.Add(Me.btnRetour)
        Me.Panel1.Controls.Add(Me.btnValider)
        Me.Panel1.Controls.Add(Me.btnAnnuler)
        Me.Panel1.Controls.Add(Me.btnSauvegarder)
        Me.Panel1.Controls.Add(Me.btnSupprimer)
        Me.Panel1.Controls.Add(Me.btnRechercher)
        Me.Panel1.Controls.Add(Me.btnModifier)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 561)
        Me.Panel1.TabIndex = 2
        '
        'btnSansCouv
        '
        Me.btnSansCouv.BackColor = System.Drawing.Color.Transparent
        Me.btnSansCouv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSansCouv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSansCouv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSansCouv.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSansCouv.Image = Global.FunEnBulles.My.Resources.Resources._1382122681_unknown
        Me.btnSansCouv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSansCouv.Location = New System.Drawing.Point(12, 214)
        Me.btnSansCouv.Name = "btnSansCouv"
        Me.btnSansCouv.Size = New System.Drawing.Size(154, 58)
        Me.btnSansCouv.TabIndex = 15
        Me.btnSansCouv.Text = "        Sans" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        couverture"
        Me.btnSansCouv.UseVisualStyleBackColor = False
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
        Me.btnRetour.Location = New System.Drawing.Point(12, 481)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(187, 45)
        Me.btnRetour.TabIndex = 14
        Me.btnRetour.Text = "Accueil"
        Me.btnRetour.UseVisualStyleBackColor = False
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
        Me.btnValider.Location = New System.Drawing.Point(12, 355)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(154, 58)
        Me.btnValider.TabIndex = 13
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
        Me.btnAnnuler.Location = New System.Drawing.Point(12, 396)
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
        Me.btnSauvegarder.Location = New System.Drawing.Point(12, 332)
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
        Me.btnSupprimer.Location = New System.Drawing.Point(12, 268)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(154, 58)
        Me.btnSupprimer.TabIndex = 9
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
        Me.btnRechercher.Location = New System.Drawing.Point(12, 150)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(154, 58)
        Me.btnRechercher.TabIndex = 8
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
        Me.btnModifier.Location = New System.Drawing.Point(12, 33)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(154, 58)
        Me.btnModifier.TabIndex = 7
        Me.btnModifier.Text = "      Modifier"
        Me.btnModifier.UseVisualStyleBackColor = False
        '
        'FrmCouvertures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 565)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCouvertures"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCouvertures"
        CType(Me.dtGrdBd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBxAuteur.ResumeLayout(False)
        Me.GrpBxAuteur.PerformLayout()
        CType(Me.pictBoxImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtGrdBd As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents txtEditeur As System.Windows.Forms.TextBox
    Friend WithEvents GrpBxAuteur As System.Windows.Forms.GroupBox
    Friend WithEvents lblEditeur As System.Windows.Forms.Label
    Friend WithEvents btnParcourir As System.Windows.Forms.Button
    Friend WithEvents pictBoxImage As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents txtNumTome As System.Windows.Forms.TextBox
    Friend WithEvents lblNumTome As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblTitreLivre As System.Windows.Forms.Label
    Friend WithEvents txtTitre As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnRechercher As System.Windows.Forms.Button
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSansCouv As System.Windows.Forms.Button
    Friend WithEvents btnRetour As System.Windows.Forms.Button
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents btnSauvegarder As System.Windows.Forms.Button
    Friend WithEvents btnSupprimer As System.Windows.Forms.Button
End Class
