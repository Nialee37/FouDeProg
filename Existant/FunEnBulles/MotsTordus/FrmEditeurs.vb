
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class FrmEditeurs
    Dim MonAuteur As String
    Dim Ajout As Boolean
    Dim MonAdapter As New MySqlDataAdapter()
    Dim MaRequete As String
    Dim UnDataset As New DataSet
    Dim MaDataTable As DataTable
    Dim cmd As MySqlCommand
    Dim requete As String

#Region "Evenements"

    ' ****************************************************
    'A l'ouverture de la fenetre Editeur:'
    'Desactiver champs'
    'Afficher les boutons interface editeur'
    'Afficher tableau des editeurs'
    'Afficher la fiche de l'éditeur'
    ' ****************************************************
    Private Sub FrmEditeurs_Load(sender As Object, e As EventArgs) Handles Me.Load

        DesaChampEdit()
        RazBouton(True)
        rempDatagridConnec()
        AfficheFiche()

    End Sub

    ' ****************************************************
    'Affiche la fiche de l'auteur au clic sur le tableau'
    ' ****************************************************
    Private Sub dtGrdAuteurs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrdEditeurs.CellClick

        txtNom.Text = dtGrdEditeurs.CurrentRow.Cells("EditeurNom").Value
        txtCode.Text = dtGrdEditeurs.CurrentRow.Cells("EditeurNum").Value
        txtAdrss.Text = dtGrdEditeurs.CurrentRow.Cells("EditeuAdresse").Value
        txtContactP.Text = dtGrdEditeurs.CurrentRow.Cells("edi_contact_prenom").Value
        txtContactN.Text = dtGrdEditeurs.CurrentRow.Cells("edi_contact_nom").Value
        txtMail.Text = dtGrdEditeurs.CurrentRow.Cells("edi_contact_mail").Value
        txtTel.Text = dtGrdEditeurs.CurrentRow.Cells("edi_contact_tel").Value

    End Sub

#Region "Controle saisie champ"

    'Saisie de chaine de caractère'
    Private Sub txtNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc((e.KeyChar)) <> System.Windows.Forms.Keys.Back And e.KeyChar <> Convert.ToChar(32) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtContactP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactP.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc((e.KeyChar)) <> System.Windows.Forms.Keys.Back And e.KeyChar <> Convert.ToChar(32) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtContactN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactN.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc((e.KeyChar)) <> System.Windows.Forms.Keys.Back And e.KeyChar <> Convert.ToChar(32) Then
            e.Handled = True
        End If
    End Sub

    'Saisie numérique'
    Private Sub txtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc((e.KeyChar)) <> System.Windows.Forms.Keys.Back And e.KeyChar <> Convert.ToChar(32) Then
            e.Handled = True
        End If
    End Sub

    'Limite à 6 caractères'
    'Met les caractères en majuscule'
    Private Sub txtNom_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNom.KeyUp
        'prendre les 6 premiers, oter les blancs 
        Dim txetSansChaine As String = txtNom.Text.ToUpper.Replace(" ", "")
        If (txetSansChaine.Length >= 6) Then
            txtCode.Text = txetSansChaine.Substring(0, 6)
        Else
            txtCode.Text = txtNom.Text.ToUpper.Replace(" ", "")
        End If
    End Sub
#End Region
#End Region

#Region "Boutons"

    ' ****************************************************
    'Bouton ajouter'
    ' ****************************************************
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click

        'Rend accessible les champs necessaires à l'ajout'
        'Remise à zero des champs pour l'ajout'
        'Masquer les boutons non necessaires pour l'ajout'
        'Affecter une valeur au bouton sauvegarder pour distinguer'

        txtNom.Enabled = True
        txtAdrss.Enabled = True
        txtMail.Enabled = True
        txtContactN.Enabled = True
        txtContactP.Enabled = True
        txtTel.Enabled = True
        Raz()
        MasqueBouton(False)
        btnSauvegarder.Location = New Point(15, 31)
        btnAnnuler.Location = New Point(15, 111)
        btnSauvegarder.Tag = "A"

    End Sub

    ' ****************************************************
    'Bouton retour'
    ' ****************************************************
    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click

        'Ferme la fenetre'
        Me.Close()

    End Sub

    ' ****************************************************
    'Bouton annuler'
    ' ****************************************************
    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click

        'Affiche les bouton necessaires au retour à l'accueil de l'editeur'
        'Remet en blanc les champs qui sont ou peuvent etre jaune'
        'Rend visible les champs/labels qui ont pus etre cachés'
        RazBouton(True)
        Raz()
        DesaChampEdit()
        CouleurEdit()
        AfficheFiche()
        GrpBxContact.Visible = True
        txtAdrss.Visible = True
        lblAdrss.Visible = True

    End Sub

    ' ****************************************************
    'Bouton modifier'
    ' ****************************************************
    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click

        'Rend accessible les champs necessaires à la modification'
        'Masquer les boutons non necessaires pour la modification'
        'Affecter une valeur au bouton sauvegarder pour distinguer'
        txtAdrss.Enabled = True
        txtMail.Enabled = True
        txtContactN.Enabled = True
        txtContactP.Enabled = True
        txtTel.Enabled = True
        MasqueBouton(False)
        btnSauvegarder.Tag = "M"

    End Sub

    ' ****************************************************
    'Bouton rechercher'
    ' ****************************************************
    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        txtNom.Enabled = True
        Raz()
        MasqueRecherche(False)
        btnValider.Visible = True

        'Cacher les champs non necessaires'
        GrpBxContact.Visible = False
        txtAdrss.Visible = False
        lblAdrss.Visible = False

    End Sub

    ' ****************************************************
    'Bouton sauvegarder'
    ' ****************************************************
    Private Sub btnSauvegarder_Click(sender As Object, e As EventArgs) Handles btnSauvegarder.Click

        'Met la 1ere lettre de nom et prenom de contact, en majuscule si champ rempli'
        If (txtContactN.Text <> "") Then
            txtContactN.Text = txtContactN.Text.Substring(0, 1).ToUpper + txtContactN.Text.Substring(1).ToLower
        End If
        If (txtContactP.Text <> "") Then
            txtContactP.Text = txtContactP.Text.Substring(0, 1).ToUpper + txtContactP.Text.Substring(1).ToLower
        End If
        If (txtAdrss.Text <> "") Then
            'Echappe les apostrophe'
            txtAdrss.Text = txtAdrss.Text.Replace("'", "\'")
        End If

        If ((btnSauvegarder.Tag = "A") AndAlso ChampsValideAjout()) Then
            'Met le 1ere lettre de nom en majuscule'
            txtNom.Text = txtNom.Text.Substring(0, 1).ToUpper + txtNom.Text.Substring(1).ToLower

            'Requete d'ajout'
            requete = "INSERT INTO Editeur VALUES ('" & txtCode.Text & "','" & txtNom.Text & "', '" & txtAdrss.Text & "', '" & txtContactN.Text & "', '" & txtContactP.Text & "', '" & txtMail.Text & "', '" & txtTel.Text & "')"
            cmd = New MySqlCommand
            cmd.Connection = MaCxionMySql
            cmd.CommandText = requete

            'Exception de Paul S.'
            Try
                cmd.ExecuteNonQuery()
                'Si l'auteur existe, une erreur est déclarée
            Catch ex As Exception
                MsgBox("ERREUR : L'éditeur " & txtNom.Text & " existe déjà !")
            End Try

            MasqueBouton(True)
            MaDataTable.Clear()
            rempDatagridConnec()
            dtGrdEditeurs.Refresh()
            btnValider.Visible = False
            Raz()
            DesaChampEdit()
            CouleurEdit()
            AfficheFiche()

        End If

        If ((btnSauvegarder.Tag = "M") AndAlso ChampsModifEdit()) Then
            'Requete de modification'
            requete = "UPDATE Editeur SET EditeuAdresse = '" & txtAdrss.Text & "', edi_contact_tel = '" & txtTel.Text & "', edi_contact_mail = '" & txtMail.Text & "', edi_contact_prenom = '" & txtContactP.Text & "', edi_contact_nom = '" & txtContactN.Text & "' WHERE EditeurNum Like '" & txtCode.Text & "'"
            cmd = New MySqlCommand
            cmd.Connection = MaCxionMySql
            cmd.CommandText = requete
            cmd.ExecuteNonQuery()
            MasqueBouton(True)
            MaDataTable.Clear()
            rempDatagridConnec()
            dtGrdEditeurs.Refresh()
            btnValider.Visible = False
            Raz()
            DesaChampEdit()
            CouleurEdit()
            AfficheFiche()

        End If
    End Sub

    ' ****************************************************
    'Bouton suppression'
    ' ****************************************************
    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click

        'Controle de saisie'
        'Requete de suppression'
        If txtNom.Text = "" Then
            MsgBox("Aucun editeur selectionné ", MessageBoxButtons.OK + MessageBoxIcon.Warning, "IMPORTANT")

        Else
            Dim rep As Integer = MsgBox("Etes-vous sur de supprimer l'editeur -- " & txtNom.Text.ToUpper & "  -- ? Tout ce qui lui est associé sera également supprimé ", MessageBoxButtons.YesNo + MessageBoxIcon.Warning, "IMPORTANT")

            If rep = 6 Then
                requete = "DELETE FROM editeur WHERE EditeurNum Like '" & txtCode.Text & "'"
                cmd = New MySqlCommand
                cmd.Connection = MaCxionMySql
                cmd.CommandText = requete
                cmd.ExecuteNonQuery()
                MaDataTable.Clear()
                rempDatagridConnec()
                dtGrdEditeurs.Refresh()
                Raz()
                AfficheFiche()
            End If
        End If
    End Sub

    ' ****************************************************
    'Bouton valider la recherche'
    ' ****************************************************
    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click

        If (ValideRechEdit()) Then

            txtNom.BackColor = Color.White

            requete = "SELECT EditeurNum, EditeurNom, EditeuAdresse, edi_contact_nom, edi_contact_prenom, edi_contact_mail, edi_contact_tel FROM editeur WHERE UPPER(EditeurNom) like '%" & txtNom.Text.ToUpper & "%' "
            cmd = New MySqlCommand
            cmd.Connection = MaCxionMySql
            cmd.CommandText = requete
            cmd.ExecuteNonQuery()
            MaDataTable.Clear()
            MonAdapter.SelectCommand = New MySqlCommand(requete, MaCxionMySql)
            MonAdapter.Fill(UnDataset, "auteurs")
            MaDataTable = UnDataset.Tables("auteurs")
            dtGrdEditeurs.DataSource = MaDataTable

            GrpBxContact.Visible = True
            txtAdrss.Visible = True
            lblAdrss.Visible = True
            Raz()
            RazBouton(True)
            txtNom.Enabled = False

        End If
    End Sub
#End Region

#Region "Procédures"

    'Vide les champs de saisie'
    Public Sub Raz()
        txtNom.Text = ""
        txtCode.Text = ""
        txtAdrss.Text = ""
        txtMail.Text = ""
        txtContactN.Text = ""
        txtContactP.Text = ""
        txtTel.Text = ""
    End Sub

    'Desactive les champs de saisie'
    Public Sub DesaChampEdit()
        txtCode.Enabled = False
        txtNom.Enabled = False
        txtAdrss.Enabled = False
        txtMail.Enabled = False
        txtContactN.Enabled = False
        txtContactP.Enabled = False
        txtTel.Enabled = False
    End Sub

    'Affiche la fiche de l'éditeur'
    Public Sub AfficheFiche()
        txtNom.Text = dtGrdEditeurs.CurrentRow.Cells("EditeurNom").Value
        txtCode.Text = dtGrdEditeurs.CurrentRow.Cells("EditeurNum").Value
        txtAdrss.Text = dtGrdEditeurs.CurrentRow.Cells("EditeuAdresse").Value
        txtContactP.Text = dtGrdEditeurs.CurrentRow.Cells("edi_contact_prenom").Value
        txtContactN.Text = dtGrdEditeurs.CurrentRow.Cells("edi_contact_nom").Value
        txtMail.Text = dtGrdEditeurs.CurrentRow.Cells("edi_contact_mail").Value
        txtTel.Text = dtGrdEditeurs.CurrentRow.Cells("edi_contact_tel").Value
    End Sub

    'Met en blanc les champs de saisie'
    Public Sub CouleurEdit()
        txtNom.BackColor = Color.White
        txtAdrss.BackColor = Color.White
        txtContactN.BackColor = Color.White
        txtContactP.BackColor = Color.White
        txtTel.BackColor = Color.White
        txtMail.BackColor = Color.White
    End Sub

    'Affiche ou cache les boutons' 
    Public Sub MasqueBouton(valider As Boolean)
        btnModifier.Visible = valider
        btnRechercher.Visible = valider
        btnSupprimer.Visible = valider
        btnAjouter.Visible = valider
        btnSauvegarder.Visible = Not (valider)
        btnAnnuler.Visible = Not (valider)
        btnValider.Visible = valider
        btnSauvegarder.Location = New Point(15, 31)
        btnAnnuler.Location = New Point(15, 111)
    End Sub

    'Affiche ou cache les boutons'
    Public Sub MasqueRecherche(valider As Boolean)
        btnModifier.Visible = valider
        btnRechercher.Visible = valider
        btnSupprimer.Visible = valider
        btnAjouter.Visible = valider
        btnSauvegarder.Visible = valider
        btnValider.Visible = valider
        btnAnnuler.Visible = Not (valider)
        btnValider.Location = New Point(15, 31)
        btnAnnuler.Location = New Point(15, 111)
    End Sub

    'Affiche ou cache les boutons'
    Public Sub RazBouton(valider As Boolean)
        btnModifier.Visible = valider
        btnRechercher.Visible = valider
        btnSupprimer.Visible = valider
        btnAjouter.Visible = valider
        btnSauvegarder.Visible = Not (valider)
        btnValider.Visible = Not (valider)
        btnAnnuler.Visible = Not (valider)
    End Sub

    'Selectionner les editeurs par une requete'
    Public Sub rempDatagridConnec()
        MaRequete = "SELECT EditeurNum, EditeurNom, EditeuAdresse, edi_contact_nom, edi_contact_prenom, edi_contact_mail, edi_contact_tel FROM EDITEUR"
        MonAdapter.SelectCommand = New MySqlCommand(MaRequete, MaCxionMySql)
        MonAdapter.Fill(UnDataset, "editeurs")
        MaDataTable = UnDataset.Tables("editeurs")
        dtGrdEditeurs.DataSource = MaDataTable
        dtGrdEditeurs.Columns("EditeurNum").HeaderText = "Code"
        dtGrdEditeurs.Columns("EditeurNum").Width = 100
        dtGrdEditeurs.Columns("EditeurNom").HeaderText = "Nom"
        dtGrdEditeurs.Columns("EditeurNom").Width = 100
        dtGrdEditeurs.Columns("EditeuAdresse").HeaderText = "Adresse"
        dtGrdEditeurs.Columns("EditeuAdresse").Width = 120
        dtGrdEditeurs.Columns("edi_contact_nom").HeaderText = "Nom contact"
        dtGrdEditeurs.Columns("edi_contact_nom").Width = 100
        dtGrdEditeurs.Columns("edi_contact_prenom").HeaderText = "Prenom contact"
        dtGrdEditeurs.Columns("edi_contact_prenom").Width = 100
        dtGrdEditeurs.Columns("edi_contact_mail").HeaderText = "Mail contact"
        dtGrdEditeurs.Columns("edi_contact_mail").Width = 100
        dtGrdEditeurs.Columns("edi_contact_tel").HeaderText = "Tel contact"
        dtGrdEditeurs.Columns("edi_contact_tel").Width = 80
    End Sub
#End Region

#Region "Fontions"

    Private Function ChampsValideAjout() As Boolean

        'test prend la valeur booléenne du resultat de vérification du mail'

        'Si le nom est saisi et que le mail est invalide faire:
        'champs invalides en jaune
        'valide prend false pour ne pas executer la requete d'ajout
        'boite de dialogue indication'

        'Si le nom n'est pas rempli faire:
        'valide prend false pour ne pas executer la requete d'ajout
        'boite de dialogue indication'

        Dim valide As Boolean = True

        CouleurEdit()

        Dim test As Boolean

        test = EmailAddressChecker(txtMail.Text)

        If ((txtNom.Text <> "") AndAlso ((txtMail.Text <> "") AndAlso (test = False))) Then
            txtMail.BackColor = Color.Yellow
            valide = False
            MsgBox("Mail incorrect", MessageBoxButtons.OK + MessageBoxIcon.Warning, "IMPORTANT")
        End If

        If (txtNom.Text = "") Then
            txtNom.BackColor = Color.Yellow
            valide = False
            MsgBox("Saisir au moins le nom de l'éditeur", MessageBoxButtons.OK + MessageBoxIcon.Warning, "IMPORTANT")

        End If

        Return valide
    End Function

    Private Function ChampsModifEdit() As Boolean

        'Si le mail est saisi et qu'il est incorrect faire:
        'champ invalide en jaune
        'modif prend false pour ne pas executer la requete de modification
        'boite de dialogue indication'

        Dim modif As Boolean = True

        CouleurEdit()

        If ((txtMail.Text <> "") AndAlso (EmailAddressChecker(txtMail.Text) = False)) Then
            txtMail.BackColor = Color.Yellow
            modif = False
            MsgBox("Mail incorrect", MessageBoxButtons.OK + MessageBoxIcon.Warning, "IMPORTANT")
        End If

        Return modif
    End Function

    'Fonction  de vérification de l'adresse mail; faite par Paul.S'
    Private Function EmailAddressChecker(ByVal Mail As String) As Boolean

        'Instancier un objet de type Regex (Expression Regulière)

        Dim regExPattern As New Regex("^[-+.\w]{1,64}@[-.\w]{1,64}\.[-.\w]{2,4}$")

        'On vérifie si le mail est dans un format correct

        Return regExPattern.IsMatch(Mail)
    End Function

    Private Sub dtGrdAuteurs_MouseClick(sender As Object, e As MouseEventArgs) Handles dtGrdEditeurs.MouseClick

        'Différencier evenement click de la cellule et click tout court avec un Mouseclick'
        'Variable hit contient les coordonnées du click (cellule)'
        'Si les coordonnées sont celles du topleftheader 0,0'
        'Actualiser + Afficher tableau'

        Dim hit As DataGridView.HitTestInfo = dtGrdEditeurs.HitTest(e.X, e.Y)
        If (hit.Type = DataGridViewHitTestType.TopLeftHeader) Then
            MaDataTable.Clear()
            rempDatagridConnec()

        End If
    End Sub

    Private Function ValideRechEdit() As Boolean

        'Si le champ du nom est vide faire:
        'champ nom devient jaune
        'rechvalidedit prend false pour ne pas executer la requete de recherche
        'boite de dialogue d'information'

        Dim rechvalidedit As Boolean = True

        If (txtNom.Text = "") Then
            txtNom.BackColor = Color.Yellow
            rechvalidedit = False
            MsgBox("Saisir un auteur à rechercher", MessageBoxButtons.OK + MessageBoxIcon.Information, "Attention")

        End If

        Return rechvalidedit

    End Function
#End Region
End Class