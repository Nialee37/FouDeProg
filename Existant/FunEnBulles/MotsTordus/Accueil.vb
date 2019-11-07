
Imports MySql.Data.MySqlClient

Public Class Accueil

    Dim niveau As String
    Dim ToolTip = New System.Windows.Forms.ToolTip

    'On teste la connection a la base et on signale si il y a des erreurs

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connexion()

        If (Erreur = 1) Then

            lbl_connection_1.ForeColor = Color.FromArgb(150, 0, 0)
            Lbl_connect_error_1.ForeColor = Color.FromArgb(150, 0, 0)
            Lbl_connect_error_2.ForeColor = Color.FromArgb(150, 0, 0)
            Lbl_connect_error_1.Visible = True
            Lbl_connect_error_1.Text = "Echec"
            Lbl_connect_error_2.Visible = True
            Lbl_connect_error_2.Text = MsgErreur

        End If

        If (Erreur = 0) Then

            lbl_connection_1.ForeColor = Color.FromArgb(0, 255, 0)
            Lbl_connect_error_1.ForeColor = Color.FromArgb(0, 255, 0)
            Lbl_connect_error_1.Visible = True
            Lbl_connect_error_1.Text = "OK"
            Login_Box.Visible = True
            Btn_connexion.Visible = True
            lbl_login.Visible = True

        End If

        ToolTip.SetToolTip(pctBxAuteurs, "Auteurs")
        ToolTip.SetToolTip(pctBxEmprunteur, "Emprunteurs")
        ToolTip.SetToolTip(pctBxEditeurs, "Editeurs")
        ToolTip.SetToolTip(pctBxLivres, "Livres")
        ToolTip.SetToolTip(pctBxCouvertures, "Images Couvertures")

        pnlAccueil.Visible = False


    End Sub


    Private Sub pctBxAuteurs_Click(sender As Object, e As EventArgs) Handles pctBxAuteurs.Click
        Dim FenAuteurs As New FrmAuteurs
        FenAuteurs.Show()
        If niveau = "invit" Then
            FenAuteurs.btnAjouter.Enabled = False
            FenAuteurs.btnModifier.Enabled = False
            FenAuteurs.btnSupprimer.Enabled = False
        End If
    End Sub

    Private Sub pctBxEditeurs_Click(sender As Object, e As EventArgs) Handles pctBxEditeurs.Click
        Dim FenEditeurs As New FrmEditeurs
        FenEditeurs.Show()
        If niveau = "invit" Then
            FenEditeurs.btnAjouter.Enabled = False
            FenEditeurs.btnModifier.Enabled = False
            FenEditeurs.btnSupprimer.Enabled = False
        End If
    End Sub

    Private Sub pctBxLivres_Click(sender As Object, e As EventArgs) Handles pctBxLivres.Click
        Dim FenLivres As New FrmLivres
        FenLivres.Show()
        If niveau = "invit" Then
            FenLivres.btnAjouter.Enabled = False
            FenLivres.btnModifier.Enabled = False
            FenLivres.btnSupprimer.Enabled = False
        End If
    End Sub

    Private Sub pctBxCouvertures_Click(sender As Object, e As EventArgs) Handles pctBxCouvertures.Click
        Dim FenImages As New FrmCouvertures
        FenImages.Show()
        If niveau = "invit" Then
            'FenImages.btnAjouter.Enabled = False
            FenImages.btnModifier.Enabled = False
            FenImages.btnSupprimer.Enabled = False
        End If
    End Sub

    Private Sub pctBxEmprunteur_Click(sender As Object, e As EventArgs) Handles pctBxEmprunteur.Click
        Dim FenEmprunteurs As New FrmEmprunteurs
        FenEmprunteurs.Show()
        If niveau = "invit" Then
            FenEmprunteurs.btnAjouter.Enabled = False
            FenEmprunteurs.btnModifier.Enabled = False
            FenEmprunteurs.btnSupprimer.Enabled = False
        End If
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Deconnexion()
        Me.Close()

    End Sub

    Private Function Exception() As Boolean
        Throw New NotImplementedException
    End Function

    Private Sub Btn_connection_Click(sender As Object, e As EventArgs) Handles Btn_connexion.Click

        'Au clic du bouton de connexion
        'Recherche du compte

        Dim myAdapter As New MySqlDataAdapter
        Dim sqlquery = "SELECT * FROM utilisateurs WHERE util_pseudo = '" + txt_id.Text + "' AND util_password = md5('" + txt_mdp.Text + "')"
        Dim myCommand As New MySqlCommand()
        myCommand.Connection = MaCxionMySql
        myCommand.CommandText = sqlquery
        myAdapter.SelectCommand = myCommand
        Dim myData As MySqlDataReader
        myData = myCommand.ExecuteReader

        'Recuperation du niveau
        If myData.HasRows Then
            Do While myData.Read()
                niveau = (myData.GetString(5))
                'MsgBox(niveau)
            Loop
        Else
            Console.WriteLine("No rows found.")
        End If

        'Si le compte n'est pas trouvé

        If myData.HasRows = 0 Then
            lbl_error_login.Visible = True
            lbl_error_login.ForeColor = Color.FromArgb(150, 0, 0)
            lbl_error_login.Text = "Identifiants invalides ou manquants"
            txt_mdp.Text = ""
            pnlAccueil.Visible = False

            'Si le compte est trouvé

        Else
            lbl_login.ForeColor = Color.FromArgb(0, 255, 0)
            lbl_error_login.ForeColor = Color.FromArgb(0, 255, 0)
            lbl_error_login.Visible = True
            lbl_error_login.Text = "OK"
            lbl_pseudo.Text = "Bienvenue, " + txt_id.Text

            pnlAccueil.Visible = True
            lbl_id.Visible = False
            txt_id.Visible = False
            lbl_mdp.Visible = False
            txt_mdp.Visible = False
            Btn_connexion.Visible = False
            Btn_deco.Visible = True

            lbl_pseudo.Visible = True
            lblNotConnect.Visible = False

            'Redefinition du mdp si defaut

            If (txt_id.Text = txt_mdp.Text) Then
                dlgRedefineMDP.Show()
            End If

            ' Recupere le niveau du compte

            If niveau = "admin" Then
                lblRang2.Text = "Administrateur"
                pctBxCouvertures.Enabled = True
                pctBxEmprunteur.Enabled = True
                pctBxCouvertures.Image = My.Resources.Resources.images
                pctBxEmprunteur.Image = My.Resources.Resources.emprunteur
                btnAdmin.Visible = True
            End If
            If niveau = "user" Then
                lblRang2.Text = "Utilisateur"
                pctBxCouvertures.Enabled = True
                pctBxEmprunteur.Enabled = True
                pctBxCouvertures.Image = My.Resources.Resources.images
                pctBxEmprunteur.Image = My.Resources.Resources.emprunteur
                btnAdmin.Visible = False
            End If
            If niveau = "invit" Then
                lblRang2.Text = "Invité"
                pctBxCouvertures.Enabled = True
                pctBxEmprunteur.Enabled = True
                pctBxCouvertures.Image = My.Resources.Resources.images
                pctBxEmprunteur.Image = My.Resources.Resources.emprunteur
                btnAdmin.Visible = False
            End If
            pnlAccueil.Show()
        End If

        myData.Close()
    End Sub

    Private Sub Btn_deco_Click(sender As Object, e As EventArgs) Handles Btn_deco.Click
        lbl_login.ForeColor = Color.FromArgb(150, 0, 0)
        lbl_error_login.ForeColor = Color.FromArgb(150, 0, 0)
        lbl_error_login.Text = "..."
        txt_mdp.Text = ""

        lbl_id.Visible = True
        txt_id.Visible = True
        lbl_mdp.Visible = True
        txt_mdp.Visible = True
        Btn_connexion.Visible = True
        Btn_deco.Visible = False

        lbl_pseudo.Visible = False
        btnAdmin.Visible = False

        lblRang2.Text = ""

        pnlAccueil.Visible = False
        lblNotConnect.Visible = True
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim FenAdmin As New FrmAdmins
        FenAdmin.Show()
    End Sub

    Private Sub Lbltitre_Click(sender As Object, e As EventArgs) Handles Lbltitre.Click

    End Sub
End Class