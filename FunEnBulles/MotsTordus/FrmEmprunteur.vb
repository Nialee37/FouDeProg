Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class FrmEmprunteurs

    Dim cmd As MySqlCommand
    Dim MonAdapter As New MySqlDataAdapter
    Dim MaRequete As String
    Dim UnDataset As New DataSet
    Dim MaDataTable As DataTable
    Dim requete As String
    Dim datecheck As Boolean
    Dim easyReq As String
    Dim verif As Boolean

    Private Sub FrmEmprunteurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'on fait appel a la methode  razenabledfalse qui empeche l'utilisateur de saisir dans les zones de saisie
        RazEnabledfalse()
        'On masque le datetimepicker
        DateTimePickernaissance.Visible = False
        DateTimePickernaissance.Format = DateTimePickerFormat.Custom
        DateTimePickernaissance.CustomFormat = "dd/MM/yyyy"
        'On masque le bouton sauvegarder,annuler et chercher
        btnSauvegarder.Visible = False
        btnAnnuler.Visible = False
        btnChercher.Visible = False
        'On fait appel à la méthode rempDatagridConnec
        rempDatagridConnec()



    End Sub

#Region "Fonctions"

    Public Sub Raz()
        'On  réinitialise les zones de saisie
        txtNom.Text = ""
        txtPrenom.Text = ""
        txtNumero.Text = ""
        txtRue.Text = ""
        txtMail.Text = ""
        txtDatenaissance.Text = ""
        txtVille.Text = ""
        MtbCodepostal.Text = ""



    End Sub

    Public Sub rempDatagridConnec()

        'On met à jour le DateGridView contenant la table Emprunteur
        requete = "SELECT emp_num,emp_nom, emp_prenom,emp_rue,emp_code_postal,emp_ville,emp_date_naiss,emp_mail FROM EMPRUNTEUR ORDER BY emp_num"

        MonAdapter.SelectCommand = New MySqlCommand(requete, MaCxionMySql)
        MonAdapter.Fill(UnDataset, "emprunteurs")
        MaDataTable = UnDataset.Tables("emprunteurs")
        dtGrdEmprunteurs.DataSource = MaDataTable
        dtGrdEmprunteurs.Columns("emp_num").HeaderText = "Numero"
        dtGrdEmprunteurs.Columns("emp_num").Width = 30
        dtGrdEmprunteurs.Columns("emp_nom").HeaderText = "Nom"
        dtGrdEmprunteurs.Columns("emp_nom").Width = 80
        dtGrdEmprunteurs.Columns("emp_prenom").HeaderText = "Prenom"
        dtGrdEmprunteurs.Columns("emp_prenom").Width = 60
        dtGrdEmprunteurs.Columns("emp_rue").HeaderText = "Rue"
        dtGrdEmprunteurs.Columns("emp_rue").Width = 100
        dtGrdEmprunteurs.Columns("emp_code_postal").HeaderText = "Code Postal"
        dtGrdEmprunteurs.Columns("emp_code_postal").Width = 50
        dtGrdEmprunteurs.Columns("emp_ville").HeaderText = "Ville"
        dtGrdEmprunteurs.Columns("emp_ville").Width = 70
        dtGrdEmprunteurs.Columns("emp_date_naiss").HeaderText = "Date de Naissance"
        dtGrdEmprunteurs.Columns("emp_date_naiss").Width = 70
        dtGrdEmprunteurs.Columns("emp_mail").HeaderText = "Mail"
        dtGrdEmprunteurs.Columns("emp_mail").Width = 95
        dtGrdEmprunteurs.Height = 215





    End Sub

    Public Sub RazBouton(valider As Boolean)
        'Mettre visible les boutons 
        btnModifier.Visible = valider
        btnSupprimer.Visible = valider
        btnAjouter.Visible = valider
        btnRechercher.Visible = valider
        btnChercher.Visible = Not (valider)
        btnSauvegarder.Visible = Not (valider)
        btnAnnuler.Visible = Not (valider)

    End Sub

    Public Sub RazEnabledfalse()
        'On désactive les zones de saisies
        txtNumero.Enabled = False
        txtNom.Enabled = False
        txtPrenom.Enabled = False
        txtRue.Enabled = False
        MtbCodepostal.Enabled = False
        txtVille.Enabled = False
        txtDatenaissance.Enabled = False
        txtMail.Enabled = False

    End Sub

    Public Sub RazEnabledtrue()
        'On désactive les zones de saisies
        txtNumero.Enabled = True
        txtNom.Enabled = True
        txtPrenom.Enabled = True
        txtRue.Enabled = True
        MtbCodepostal.Enabled = True
        txtVille.Enabled = True
        txtDatenaissance.Enabled = True
        txtMail.Enabled = True

    End Sub

    Public Sub rempData()

        txtNumero.Text = dtGrdEmprunteurs.CurrentRow.Cells("emp_num").Value
        txtNom.Text = dtGrdEmprunteurs.CurrentRow.Cells("emp_nom").Value
        txtPrenom.Text = dtGrdEmprunteurs.CurrentRow.Cells("emp_prenom").Value
        txtRue.Text = dtGrdEmprunteurs.CurrentRow.Cells("emp_rue").Value
        MtbCodepostal.Text = dtGrdEmprunteurs.CurrentRow.Cells("emp_code_postal").Value
        txtVille.Text = dtGrdEmprunteurs.CurrentRow.Cells("emp_ville").Value
        txtDatenaissance.Text = dtGrdEmprunteurs.CurrentRow.Cells("emp_date_naiss").Value
        txtMail.Text = dtGrdEmprunteurs.CurrentRow.Cells("emp_mail").Value

    End Sub

    Public Sub MasqueBouton(valider As Boolean)
        'Mettre visible les boutons liés au bouton btnSauvegarder 
        btnModifier.Visible = valider
        btnSupprimer.Visible = valider
        btnAjouter.Visible = valider
        btnRechercher.Visible = valider
        btnChercher.Visible = Not (valider)
        btnSauvegarder.Visible = Not (valider)
        btnAnnuler.Visible = Not (valider)
        btnSauvegarder.Location = New Point(15, 31)
        btnAnnuler.Location = New Point(15, 111)

    End Sub

    Private Function ChampsValide() As Boolean
        'Si les champs sont vides, on les met en jaune
        Dim valide As Boolean = True
        If (txtNom.Text = "") Then
            txtNom.BackColor = Color.Yellow
            valide = False
        End If
        If (txtPrenom.Text = "") Then
            txtPrenom.BackColor = Color.Yellow
            valide = False
        End If
        If (txtDatenaissance.Text = "") Then
            txtDatenaissance.BackColor = Color.Yellow
            valide = False
        End If
        If (txtRue.Text = "") Then
            txtRue.BackColor = Color.Yellow
            valide = False
        End If
        If (txtVille.Text = "") Then
            txtVille.BackColor = Color.Yellow
            valide = False
        End If
        If (MtbCodepostal.Text = "") Then
            MtbCodepostal.BackColor = Color.Yellow
            valide = False
        End If
        If valide = True Then
            txtNom.BackColor = Color.White
            txtPrenom.BackColor = Color.White
            txtRue.BackColor = Color.White
            txtVille.BackColor = Color.White
            txtDatenaissance.BackColor = Color.White
            MtbCodepostal.BackColor = Color.White
        End If
        Return valide
    End Function

    Public Sub MasqueBoutonRecherche(valider As Boolean)
        txtNumero.Enabled = Not (valider)
        txtPrenom.Enabled = Not (valider)
        txtRue.Enabled = Not (valider)
        txtMail.Enabled = Not (valider)
        txtDatenaissance.Enabled = Not (valider)

        lblNum.Enabled = Not (valider)
        LblPrenom.Enabled = Not (valider)
        lblRue.Enabled = Not (valider)
        lblmail.Enabled = Not (valider)
        lblDateNaissance.Enabled = Not (valider)




    End Sub

    Private Function EmailAddressChecker(ByVal Mail As String) As Boolean

        'Instancier un objet de type Regex (Expression Regulière)
        Dim regExPattern As New Regex("^[-+.\w]{1,64}@[-.\w]{1,64}\.[-.\w]{2,4}$")

        'On vérifie si le mail est dans un format correct
        Return regExPattern.IsMatch(Mail)

    End Function

#End Region


#Region "Boutons et evenement clic"


    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click

        ' Pour le bouton btnAjouter, on va juste s'occuper de modifier l'interface. Le bouton btnSauvegarder s'occupera des événements

        DateTimePickernaissance.Visible = True

        txtNumero.Visible = False

        btnChercher.Visible = False
        btnRechercher.Visible = False

        Raz()
        RazEnabledtrue()

        lblNum.Visible = False

        dtGrdEmprunteurs.Visible = False

        MasqueBouton(False)

        btnSauvegarder.Location = New Point(15, 31)
        btnAnnuler.Location = New Point(15, 111)

        btnSauvegarder.Tag = "A"

    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        'On indique à l'utilisateur si il n'a pas sélectionné d'emprunteur
        If txtNom.Text = "" Then
            MsgBox("Aucun auteur selectionné ", MessageBoxButtons.OK + MessageBoxIcon.Warning, "IMPORTANT")

        Else
            ' On demande à l'utilisateur s'il est certain de vouloir supprimer l'emprunteur sélectionné
            Dim rep As Integer = MsgBox("Etes-vous sur de supprimer l'emprunteur -- " & txtNom.Text.ToUpper & "  -- ?", MessageBoxButtons.YesNo + MessageBoxIcon.Warning, "IMPORTANT")
            ' S'il affirme vouloir supprimer l'emmprunteur sélectionné :
            If rep = 6 Then
                'Requete SQL permettant de supprimer l'emprunteur sélectionné de la BDD
                requete = "DELETE FROM Emprunteur WHERE emp_num Like '" & txtNumero.Text & "'"
                cmd = New MySqlCommand
                cmd.Connection = MaCxionMySql
                cmd.CommandText = requete
                cmd.ExecuteNonQuery()
                MaDataTable.Clear()
                rempDatagridConnec()
                dtGrdEmprunteurs.Refresh()
                Raz()
                RazEnabledfalse()
            End If
        End If
    End Sub

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click

        btnAjouter.Visible = False
        btnModifier.Visible = False
        btnSauvegarder.Visible = False
        btnSupprimer.Visible = False
        btnRechercher.Visible = False
        btnChercher.Visible = True
        btnAnnuler.Visible = True
        DateTimePickernaissance.Visible = False

        Raz()
        MasqueBoutonRecherche(True)

        txtNom.Enabled = True
        MtbCodepostal.Enabled = True
        txtVille.Enabled = True

        btnChercher.Location = New Point(15, 31)
        btnAnnuler.Location = New Point(15, 111)




        txtNom.Focus()
        rempDatagridConnec()

    End Sub

    Private Sub btnChercher_Click(sender As Object, e As EventArgs) Handles btnChercher.Click

        'requete en fonction de la recherche de l'utilisateur
        easyReq = "SELECT emp_num,emp_nom, emp_prenom,emp_rue,emp_code_postal,emp_ville,emp_date_naiss,emp_mail FROM EMPRUNTEUR  "

        ' Variable booléenne pour indiquer si un champ est rempli ou non.
        verif = False

        If txtNom.Text = "" And MtbCodepostal.Text = "" And txtVille.Text = "" Then
            MsgBox("Vous n'avez effectué aucune recherche. ", MessageBoxButtons.OK + MessageBoxIcon.Warning, "IMPORTANT")
            txtNom.Text = ""
            txtVille.Text = ""
            MtbCodepostal.Text = ""
        Else

            If MtbCodepostal.Text <> "" Then
                If verif = False Then
                    easyReq = easyReq + " WHERE emp_code_postal like '%" & MtbCodepostal.Text & "%' "
                    verif = True
                Else
                    easyReq = easyReq + " AND emp_code_postal like '%" & MtbCodepostal.Text & "%' "
                End If
            End If

            If txtVille.Text <> "" Then

                If verif = False Then
                    easyReq = easyReq + " WHERE Lower(emp_ville) like '%" & txtVille.Text.ToLower() & "%' "
                    verif = True
                Else
                    easyReq = easyReq + " AND emp_ville like '%" & txtVille.Text.ToLower & "%' "
                End If
            End If

            If txtNom.Text <> "" Then
                If verif = False Then
                    easyReq = easyReq + " WHERE LOWER(emp_nom) like '%" & txtNom.Text.ToLower() & "%' "
                    verif = True
                Else
                    easyReq = easyReq + " AND LOWER(emp_nom) like '%" & txtNom.Text.ToLower() & "%' "
                End If
            End If

            MaDataTable.Clear()
            MonAdapter.SelectCommand = New MySqlCommand(easyReq, MaCxionMySql)
            MonAdapter.Fill(UnDataset, "emprunteurs")
            MaDataTable = UnDataset.Tables("emprunteurs")
            dtGrdEmprunteurs.DataSource = MaDataTable
            dtGrdEmprunteurs.Columns("emp_num").HeaderText = "Numero"
            dtGrdEmprunteurs.Columns("emp_num").Width = 30
            dtGrdEmprunteurs.Columns("emp_nom").HeaderText = "Nom"
            dtGrdEmprunteurs.Columns("emp_nom").Width = 80
            dtGrdEmprunteurs.Columns("emp_prenom").HeaderText = "Prenom"
            dtGrdEmprunteurs.Columns("emp_prenom").Width = 60
            dtGrdEmprunteurs.Columns("emp_rue").HeaderText = "Rue"
            dtGrdEmprunteurs.Columns("emp_rue").Width = 100
            dtGrdEmprunteurs.Columns("emp_code_postal").HeaderText = "Code Postal"
            dtGrdEmprunteurs.Columns("emp_code_postal").Width = 50
            dtGrdEmprunteurs.Columns("emp_ville").HeaderText = "Ville"
            dtGrdEmprunteurs.Columns("emp_ville").Width = 70
            dtGrdEmprunteurs.Columns("emp_date_naiss").HeaderText = "Date de Naissance"
            dtGrdEmprunteurs.Columns("emp_date_naiss").Width = 70
            dtGrdEmprunteurs.Columns("emp_mail").HeaderText = "Mail"
            dtGrdEmprunteurs.Columns("emp_mail").Width = 95
            dtGrdEmprunteurs.Height = 215
            Raz()
            MasqueBouton(True)

        End If

    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        ' Pour le bouton btnModifier, on va juste s'occuper de modifier l'interface. Le bouton btnSauvegarder s'occupera des événements

        RazEnabledtrue()

        txtNumero.Enabled = False

        btnSauvegarder.Tag = "M"

        DateTimePickernaissance.Visible = True

        btnChercher.Visible = False
        btnRechercher.Visible = False


        MasqueBouton(False)



    End Sub

    Private Sub dtGrdEmprunteurs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrdEmprunteurs.CellClick

        'On affecte le contenu des saisies de l'utilisateur sur l'interface à notre BDD

        rempData()


    End Sub

    Private Sub dtGrdEmprunteurs_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrdEmprunteurs.CellEnter
        rempData()

    End Sub

    Private Sub DateTimePickernaissance_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickernaissance.ValueChanged
        txtDatenaissance.Text = DateTimePickernaissance.Value

    End Sub

#Region "Keypress"

    Private Sub txtNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom.KeyPress

        If Char.IsLetter(e.KeyChar) = False And Asc((e.KeyChar)) <> System.Windows.Forms.Keys.Back And Asc((e.KeyChar)) <> System.Windows.Forms.Keys.Space Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtPrenom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrenom.KeyPress

        If Char.IsLetter(e.KeyChar) = False And Asc((e.KeyChar)) <> System.Windows.Forms.Keys.Back And Asc((e.KeyChar)) <> System.Windows.Forms.Keys.Space Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtVille_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVille.KeyPress

        If Char.IsLetter(e.KeyChar) = False And Asc((e.KeyChar)) <> System.Windows.Forms.Keys.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtDatenaissance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDatenaissance.KeyPress

        If Char.IsNumber(e.KeyChar) = False And Char.IsSeparator(e.KeyChar) = False And Char.IsPunctuation(e.KeyChar) = False And Asc((e.KeyChar)) <> System.Windows.Forms.Keys.Back Then

            e.Handled = True

        End If
    End Sub

#End Region


    Private Sub btnSauvegarder_Click(sender As Object, e As EventArgs) Handles btnSauvegarder.Click

        '*****************************
        'Sauvegarder: bouton ajouter
        '*****************************
        'Si l'utilisateur a cliqué sur le bouton btnAjouter et qu'il n'y a pas de problème concernant les champs :'
        If (btnSauvegarder.Tag = "A") And ChampsValide() Then

            Try
                'On vérifie que la date saisie est valide
                datecheck = IsDate(CType(txtDatenaissance.Text, Date))

            Catch ex As Exception
                MsgBox("Date de naissance non valide ", MessageBoxButtons.OK + MessageBoxIcon.Warning, "IMPORTANT")
                txtDatenaissance.BackColor = Color.Yellow
                datecheck = False
            End Try

            If txtMail.Text <> "" Then

                EmailAddressChecker(txtMail.Text)

                If EmailAddressChecker(txtMail.Text) = False Then
                    MsgBox("Adresse électronique non valide ", MessageBoxButtons.OK + MessageBoxIcon.Warning, "IMPORTANT")
                    txtMail.BackColor = Color.Yellow

                End If
                If EmailAddressChecker(txtMail.Text) = True Then
                    If datecheck = True Then


                        txtDatenaissance.Text = Format(CType(txtDatenaissance.Text, Date), "yyyy-MM-dd")

                        txtNom.Text = txtNom.Text.ToUpper

                        txtPrenom.Text = txtPrenom.Text.Substring(0, 1).ToUpper + txtPrenom.Text.Substring(1).ToLower

                        txtVille.Text = txtVille.Text.Substring(0, 1).ToUpper + txtVille.Text.Substring(1).ToLower
                        txtRue.Text = txtRue.Text.Replace("'", "\")
                        txtRue.Text = txtRue.Text.Replace("char(34)", "\")

                        txtDatenaissance.BackColor = Color.White

                        ' Requete SQL permettant d'insérer un nouveau champ dans la base de données
                        requete = "INSERT INTO Emprunteur (emp_nom, emp_prenom,emp_rue,emp_ville,emp_code_postal, emp_date_naiss,emp_mail) VALUES ('" & txtNom.Text & "','" & txtPrenom.Text & "','" & txtRue.Text & "','" & txtVille.Text & "','" & MtbCodepostal.Text & "','" & txtDatenaissance.Text & "','" & txtMail.Text & "')"
                        ' Indiquer que la variable "cmd" est une commande SQL
                        cmd = New MySqlCommand
                        ' Commandes SQL pour se connecter a la base et appliquer la requête
                        cmd.Connection = MaCxionMySql
                        cmd.CommandText = requete
                        cmd.ExecuteNonQuery()
                        MasqueBouton(True)
                        ChampsValide()
                        MaDataTable.Clear()
                        rempDatagridConnec()
                        'On rend visible le DataGridView contenant la table Emprunteur et on raffraichit son contenu
                        dtGrdEmprunteurs.Visible = True
                        dtGrdEmprunteurs.Refresh()
                        dtGrdEmprunteurs.CurrentCell = dtGrdEmprunteurs(0, dtGrdEmprunteurs.RowCount - 1)


                        ' On fait appel à la méthode RazEnablefalse
                        RazEnabledfalse()


                    End If


                End If

            End If
            If txtMail.Text = "" Then
                If datecheck = True Then


                    txtDatenaissance.Text = Format(CType(txtDatenaissance.Text, Date), "yyyy-MM-dd")

                    txtNom.Text = txtNom.Text.ToUpper

                    txtPrenom.Text = txtPrenom.Text.Substring(0, 1).ToUpper + txtPrenom.Text.Substring(1).ToLower

                    txtVille.Text = txtVille.Text.Substring(0, 1).ToUpper + txtVille.Text.Substring(1).ToLower
                    txtRue.Text = txtRue.Text.Replace("'", "\")
                    txtRue.Text = txtRue.Text.Replace("char(34)", "\")

                    txtDatenaissance.BackColor = Color.White

                    ' Requete SQL permettant d'insérer un nouveau champ dans la base de données
                    requete = "INSERT INTO Emprunteur (emp_nom, emp_prenom,emp_rue,emp_ville,emp_code_postal, emp_date_naiss,emp_mail) VALUES ('" & txtNom.Text & "','" & txtPrenom.Text & "','" & txtRue.Text & "','" & txtVille.Text & "','" & MtbCodepostal.Text & "','" & txtDatenaissance.Text & "','" & txtMail.Text & "')"
                    ' Indiquer que la variable "cmd" est une commande SQL
                    cmd = New MySqlCommand
                    ' Commandes SQL pour se connecter a la base et appliquer la requête
                    cmd.Connection = MaCxionMySql
                    cmd.CommandText = requete
                    cmd.ExecuteNonQuery()
                    MasqueBouton(True)
                    ChampsValide()
                    MaDataTable.Clear()
                    rempDatagridConnec()
                    'On rend visible le DataGridView contenant la table Emprunteur et on raffraichit son contenu
                    dtGrdEmprunteurs.Visible = True
                    dtGrdEmprunteurs.Refresh()
                    dtGrdEmprunteurs.CurrentCell = dtGrdEmprunteurs(0, dtGrdEmprunteurs.RowCount - 1)


                    ' On fait appel à la méthode RazEnablefalse
                    RazEnabledfalse()


                End If
            End If




        End If

        '*****************************
        'Sauvegarder: bouton modifier
        '*****************************
        'Si l'utilisateur a cliqué sur le bouton btnSauvegarder et les champs ne sont pas vides : 
        If (btnSauvegarder.Tag = "M") And (txtNom.Text <> "") And (txtPrenom.Text <> "") And (txtDatenaissance.Text <> "") And (txtRue.Text <> "") Then

            Try
                'On valide que la date est valide 
                datecheck = IsDate(CType(txtDatenaissance.Text, Date))
            Catch ex As Exception
                MsgBox("Date de naissance non valide ", MessageBoxButtons.OK + MessageBoxIcon.Warning, "IMPORTANT")
                txtDatenaissance.BackColor = Color.Yellow

            End Try

            If txtMail.Text <> "" Then

                EmailAddressChecker(txtMail.Text)

                If EmailAddressChecker(txtMail.Text) = False Then
                    MsgBox("Adresse électronique non valide ", MessageBoxButtons.OK + MessageBoxIcon.Warning, "IMPORTANT")
                    txtMail.BackColor = Color.Yellow
                End If

                If EmailAddressChecker(txtMail.Text) = True Then
                    If datecheck = True Then
                        'On vérifie que la date saisie est valide
                        txtDatenaissance.Text = Format(CType(txtDatenaissance.Text, Date), "yyyy-MM-dd")

                        txtNom.Text = txtNom.Text.ToUpper
                        txtPrenom.Text = txtPrenom.Text.Substring(0, 1).ToUpper + txtPrenom.Text.Substring(1).ToLower
                        txtVille.Text = txtVille.Text.Substring(0, 1).ToUpper + txtVille.Text.Substring(1).ToLower
                        txtRue.Text = txtRue.Text.Replace("'", "\")
                        txtRue.Text = txtRue.Text.Replace("char(34)", "\")
                        txtDatenaissance.BackColor = Color.White

                        'Requete SQL permettant de modifier les champs de la table Emprunteur
                        requete = "UPDATE Emprunteur SET emp_prenom = '" & txtPrenom.Text & "', emp_nom='" & txtNom.Text & "', emp_rue= '" & txtRue.Text & "' , emp_code_postal= " & MtbCodepostal.Text & ", emp_ville='" & txtVille.Text & "',emp_date_naiss='" & txtDatenaissance.Text & "', emp_mail= '" & txtMail.Text & "' WHERE emp_num = " & txtNumero.Text & " "
                        'Commandes SQL pour se connecter à la base de et appliquer la requete
                        cmd = New MySqlCommand
                        cmd.Connection = MaCxionMySql
                        cmd.CommandText = requete
                        cmd.ExecuteNonQuery()

                        MasqueBouton(True)

                        ChampsValide()

                        MaDataTable.Clear()

                        rempDatagridConnec()


                        dtGrdEmprunteurs.Refresh()



                        RazEnabledfalse()
                    End If
                End If
            End If

            If txtMail.Text = "" Then
                If datecheck = True Then


                    'On vérifie que la date saisie est valide
                    txtDatenaissance.Text = Format(CType(txtDatenaissance.Text, Date), "yyyy-MM-dd")

                    txtNom.Text = txtNom.Text.ToUpper
                    txtPrenom.Text = txtPrenom.Text.Substring(0, 1).ToUpper + txtPrenom.Text.Substring(1).ToLower
                    txtVille.Text = txtVille.Text.Substring(0, 1).ToUpper + txtVille.Text.Substring(1).ToLower
                    txtRue.Text = txtRue.Text.Replace("'", "\")
                    txtRue.Text = txtRue.Text.Replace("char(34)", "\")
                    txtDatenaissance.BackColor = Color.White

                    'Requete SQL permettant de modifier les champs de la table Emprunteur
                    requete = "UPDATE Emprunteur SET emp_prenom = '" & txtPrenom.Text & "', emp_nom='" & txtNom.Text & "', emp_rue= '" & txtRue.Text & "' , emp_code_postal= " & MtbCodepostal.Text & ", emp_ville='" & txtVille.Text & "',emp_date_naiss='" & txtDatenaissance.Text & "', emp_mail= '" & txtMail.Text & "' WHERE emp_num = " & txtNumero.Text & " "
                    'Commandes SQL pour se connecter à la base de et appliquer la requete
                    cmd = New MySqlCommand
                    cmd.Connection = MaCxionMySql
                    cmd.CommandText = requete
                    cmd.ExecuteNonQuery()

                    MasqueBouton(True)

                    ChampsValide()

                    MaDataTable.Clear()

                    rempDatagridConnec()


                    dtGrdEmprunteurs.Refresh()



                    RazEnabledfalse()

                End If
            End If

        End If
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        'On redéfinit l'interface à son état initial
        RazBouton(True)
        Raz()
        RazEnabledfalse()
        txtNumero.Visible = True
        lblNum.Visible = True

        MasqueBoutonRecherche(False)


        DateTimePickernaissance.Visible = False

        dtGrdEmprunteurs.Visible = True




    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Close()
    End Sub

#End Region

End Class