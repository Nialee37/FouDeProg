Imports MySql.Data.MySqlClient
Public Class FrmLivres
    Dim MonAuteur As String
    Dim Ajout As Boolean
    Dim MonAdapter As MySqlDataAdapter
    Dim MaRequete As String
    Dim requeteAjoutAuteur As String
    Dim requeteModifAuteur As String
    Dim UnDataset As New DataSet
    Dim MaDataTable As DataTable
    Dim MesAuteurs As DataTable
    Dim maTableCombo As DataTable
    Dim cmd As MySqlCommand
    Dim requete As String
    Dim requeteAut As String
    Dim requeteAut2 As String
    Dim requetedoublon As String
    Dim reponse As String
    Dim Annee As String
    Dim Droit As String
    Dim verif As Integer
    Dim Id As String
    Dim Lid As Integer


    Private Sub FrmLivres_Load(sender As Object, e As EventArgs) Handles Me.Load
        MajEcran()
        MonAdapter = New MySqlDataAdapter()
        rempDatagridConnec()
        RempCbxAnnee()
        btnSauvegarder.Tag = ""
    End Sub

#Region "DataGridView"

    'Remplissage du DataGrid
    Public Sub rempDatagridConnec()
        MaRequete = "SELECT DISTINCT (bd.BdId), BdTitre, BdTome, BdParution, NumSerie, NumEditeur FROM bd"
        MonAdapter.SelectCommand = New MySqlCommand(MaRequete, MaCxionMySql)
        MonAdapter.Fill(UnDataset, "livres")
        MaDataTable = UnDataset.Tables("livres")
        dtGrdLivres.DataSource = MaDataTable
        dtGrdLivres.Columns("BdId").HeaderText = "Code"
        dtGrdLivres.Columns("BdId").Width = 40
        dtGrdLivres.Columns("BdTitre").HeaderText = "Titre"
        dtGrdLivres.Columns("BdTitre").Width = 240
        dtGrdLivres.Columns("BdTome").HeaderText = "Tome"
        dtGrdLivres.Columns("BdTome").Width = 52
        dtGrdLivres.Columns("BdParution").HeaderText = "Parution"
        dtGrdLivres.Columns("BdParution").Width = 50
        dtGrdLivres.Columns("NumSerie").HeaderText = "Serie"
        dtGrdLivres.Columns("NumSerie").Width = 80
        dtGrdLivres.Columns("NumEditeur").HeaderText = "Editeur"
        dtGrdLivres.Columns("NumEditeur").Width = 90

        dtGrdLivres.Height = 200
    End Sub

    'Remplissage des champs *txt au click
    Private Sub dtGrdLivres_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrdLivres.CellClick
        If btnSauvegarder.Tag <> "A" Then
            txtCode.Text = dtGrdLivres.CurrentRow.Cells("BdId").Value
            txtTitre.Text = dtGrdLivres.CurrentRow.Cells("BdTitre").Value
            txtNumTome.Text = dtGrdLivres.CurrentRow.Cells("BdTome").Value
            txtSerie.Text = dtGrdLivres.CurrentRow.Cells("NumSerie").Value
            txtEditeur.Text = dtGrdLivres.CurrentRow.Cells("NumEditeur").Value
            cbxAnnee.SelectedItem = Trim(dtGrdLivres.CurrentRow.Cells("BdParution").Value)
            Annee = dtGrdLivres.CurrentRow.Cells("BdParution").Value

            requete = "SELECT numParticipant FROM participer WHERE numBd like " & txtCode.Text
            MonAdapter.SelectCommand = New MySqlCommand(requete, MaCxionMySql)
            MonAdapter.Fill(UnDataset, "participer")
            MesAuteurs = UnDataset.Tables("participer")

            Dim nbRows As Integer = MesAuteurs.Rows.Count
            If nbRows = 0 Then
                txtAuteur.Text = ""
                txtAuteur2.Text = ""
            End If
            If nbRows = 1 Then
                txtAuteur.Text = MesAuteurs.Rows(0).Item("numParticipant").ToString
                txtAuteur2.Text = ""
            End If
            If nbRows = 2 Then
                txtAuteur.Text = MesAuteurs.Rows(0).Item("numParticipant").ToString
                txtAuteur2.Text = MesAuteurs.Rows(1).Item("numParticipant").ToString
            End If
            MesAuteurs.Clear()

        End If
    End Sub

    'Rafraichissement des champs *txt au changement de ligne
    'Private Sub dtGrdLivres_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrdLivres.CellEnter
    '    If btnSauvegarder.Tag <> "A" Then
    '        txtCode.Text = dtGrdLivres.CurrentRow.Cells("BdId").Value
    '        txtTitre.Text = dtGrdLivres.CurrentRow.Cells("BdTitre").Value
    '        txtNumTome.Text = dtGrdLivres.CurrentRow.Cells("BdTome").Value
    '        cbxAnnee.SelectedItem = Trim(dtGrdLivres.CurrentRow.Cells("BdParution").Value)
    '        txtSerie.Text = dtGrdLivres.CurrentRow.Cells("NumSerie").Value
    '        txtEditeur.Text = dtGrdLivres.CurrentRow.Cells("EditeurNum").Value

    '        requete = "SELECT AuteurId FROM participer WHERE BdId like '" & txtTitre.Text & "' "
    '        cmd = New MySqlCommand
    '        cmd.Connection = MaCxionMySql
    '        cmd.CommandText = requete
    '        cmd.ExecuteNonQuery()

    '        Dim nbRows As Integer = MaDataTable.Rows.Count
    '        If nbRows = 1 Then
    '            txtAuteur.Text = MaDataTable.Rows(0).Item("AuteurId").ToString
    '        End If
    '        If nbRows = 2 Then
    '            txtAuteur2.Text = MaDataTable.Rows(1).Item("AuteurId").ToString
    '        End If
    '    End If
    'End Sub

#End Region

#Region "Boutons"


    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click


        Raz()

        unLock()

        txtTitre.Focus()

        Affichage()

        MasqueBouton(False)

        btnSauvegarder.Location = New Point(15, 31)

        btnAnnuler.Location = New Point(15, 111)

        btnSauvegarder.Tag = "A"

        RempCbxSerie()

        RempCbxEditeur()

        RempCbxAnnee()

        RempCbxAuteur()

        RempCbxAuteur2()



    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        RazBouton(True)
        Raz()
        RempCbxAnnee()
        ResetColor()
        btnSauvegarder.Tag = ""
        Lock()
        MasqueChamp()
    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Close()
        cbxAnnee.Items.Clear()
        RempCbxAnnee()
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click


        unLock()

        Affichage()

        MasqueBouton(False)

        btnSauvegarder.Tag = "M"

        RempCbxSerie()

        RempCbxAnnee()

        RempCbxEditeur()

        RempCbxAuteur()

        RempCbxAuteur2()


    End Sub

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click

        RempCbxAnnee()

        unLock()

        Affichage()
        lblAuteur.Visible = False
        txtAuteur.Visible = False
        cbxAuteur.Visible = False

        RempCbxEditeur()

        RempCbxSerie()

        RempCbxAuteur()

        RempCbxAuteur2()

        Raz()


        MasqueRecherche(False)


    End Sub

    Private Sub btnSauvegarder_Click(sender As Object, e As EventArgs) Handles btnSauvegarder.Click

        ResetColor()

        If (btnSauvegarder.Tag = "A") And ChampsValide() Then
            'gestion de l'échapement de l'apostrophe
            txtTitre.Text = txtTitre.Text.Replace("'", "\'")
            'gestion de la casse
            txtSerie.Text = txtSerie.Text.Substring(0, 1).ToUpper + txtSerie.Text.Substring(1).ToLower
            requeteAjoutAuteur = "INSERT INTO bd VALUES (0,'" & txtTitre.Text & "'," & txtNumTome.Text & "," & Annee & ",'','" & txtSerie.Text & "','" & txtEditeur.Text & "')"
            'requeteAjoutAuteur = "INSERT INTO Bd VALUES (NULL,'" & txtTitre.Text & "'," & txtNumTome.Text & "," & TxtAnnePar.Text & ",'','" & txtSerie.Text & "','" & txtEditeur.Text & "') "
            cmd = New MySqlCommand
            cmd.Connection = MaCxionMySql
            cmd.CommandText = requeteAjoutAuteur
            cmd.ExecuteNonQuery()

            'On fait la quete de recherche
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Livre " & txtTitre.Text & " ajouté !")
                'Si l'auteur existe, une erreur est déclarée
            Catch ex As Exception
                MsgBox("ERREUR : Le tome " & txtNumTome.Text & " du livre " & txtTitre.Text & "  existe déjà !")
            End Try

        End If

        Dim Id As String
        Dim Lid As Integer

        Id = "SELECT LAST_INSERT_ID()"

        cmd = New MySqlCommand
        cmd.Connection = MaCxionMySql
        cmd.CommandText = Id
        Lid = cmd.ExecuteScalar()

        If (btnSauvegarder.Tag = "A") And ChampsValide() And txtAuteur.Text <> "" Then

            requeteAut = "INSERT INTO participer VALUES ( '" & Lid & "', '" & txtAuteur.Text & "')"

            cmd = New MySqlCommand
            cmd.Connection = MaCxionMySql
            cmd.CommandText = requeteAut
            cmd.ExecuteNonQuery()
        End If

        If (btnSauvegarder.Tag = "A") And ChampsValide() And txtAuteur2.Text <> "" Then

            requeteAut2 = "INSERT INTO participer VALUES ( '" & Lid & "', '" & txtAuteur2.Text & "')"

            cmd = New MySqlCommand
            cmd.Connection = MaCxionMySql
            cmd.CommandText = requeteAut2
            cmd.ExecuteNonQuery()
        End If

        MasqueBouton(True)
        MaDataTable.Clear()
        rempDatagridConnec()
        dtGrdLivres.Refresh()
        Lock()
        If (btnSauvegarder.Tag = "M") And ChampsValide() Then
            'gestion de l'échapement de l'apostrophe
            txtTitre.Text = txtTitre.Text.Replace("'", "\'")
            'gestion de la casse
            txtSerie.Text = txtSerie.Text.Substring(0, 1).ToUpper + txtSerie.Text.Substring(1).ToLower
            requeteModifAuteur = " UPDATE Bd SET BdTitre = '" & txtTitre.Text & "', BdTome = " & txtNumTome.Text & ", BdParution = " & Annee & " , NumSerie = '" & txtSerie.Text & "', EditeurNum = '" & txtEditeur.Text & "' WHERE BdId = '" & txtCode.Text & "'"
            cmd = New MySqlCommand
            cmd.Connection = MaCxionMySql
            cmd.CommandText = requeteModifAuteur
            cmd.ExecuteNonQuery()


            Id = "SELECT LAST_INSERT_ID()"

            cmd = New MySqlCommand
            cmd.Connection = MaCxionMySql
            cmd.CommandText = Id
            Lid = cmd.ExecuteScalar()

            If (btnSauvegarder.Tag = "M") And ChampsValide() And txtAuteur.Text <> "" Then

                requeteAut = "INSERT INTO participer VALUES ( '" & Lid & "', '" & txtAuteur.Text & "')"

                cmd = New MySqlCommand
                cmd.Connection = MaCxionMySql
                cmd.CommandText = requeteAut
                cmd.ExecuteNonQuery()
            End If

            If (btnSauvegarder.Tag = "M") And ChampsValide() And txtAuteur2.Text <> "" Then

                requeteAut2 = "INSERT INTO participer VALUES ( '" & Lid & "', '" & txtAuteur2.Text & "')"

                cmd = New MySqlCommand
                cmd.Connection = MaCxionMySql
                cmd.CommandText = requeteAut2
                cmd.ExecuteNonQuery()
            End If


            MasqueBouton(True)
            MaDataTable.Clear()
            rempDatagridConnec()
            dtGrdLivres.Refresh()
            Lock()
        End If
        btnSauvegarder.Tag = ""

    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If txtTitre.Text = "" Then
            MsgBox("Aucun livre selectionné ", MessageBoxButtons.OK + MessageBoxIcon.Warning, "IMPORTANT")

        Else
            Dim rep As Integer = MsgBox("Etes-vous sur de supprimer le livre  -- " & txtTitre.Text.ToUpper & "  -- ? ", MessageBoxButtons.YesNo + MessageBoxIcon.Warning, "IMPORTANT")

            If rep = 6 Then
                requete = "DELETE FROM bd WHERE BdId Like '" & txtCode.Text & "'"
                cmd = New MySqlCommand
                cmd.Connection = MaCxionMySql
                cmd.CommandText = requete
                cmd.ExecuteNonQuery()
                MaDataTable.Clear()
                rempDatagridConnec()
                dtGrdLivres.Refresh()
                Raz()
                Dim reponse As Integer = MsgBox("Le livre a bien était supprimé", MessageBoxButtons.OK)
            End If

        End If


    End Sub

    Private Sub btnValider_Click(serder As Object, e As EventArgs) Handles btnValider.Click


        'requete selon le nom du livre
        requete = "SELECT BdId, BdTitre, BdTome, BdParution, NumSerie, EditeurNum FROM bd "

        'initialisation de la variable verifiant les champs remplis ou non
        verif = 0

        'si le textfield Auteur est rempli, alors la requete prends le where et la jointure

        If txtAuteur2.Text <> "" Then
            requete = requete + "WHERE AuteurId like " & txtAuteur.Text & " "
            verif += 1
        End If

        'ajout du where si l'utilisateur n'a pas rempli le textfield ci dessus
        If txtTitre.Text <> "" Then
            If verif = 0 Then
                requete = requete + "WHERE upper(BdTitre) like '%" & txtTitre.Text.ToUpper & "%' "
                verif += 1
            Else
                requete = requete + "AND BdTitre like " & txtTitre.Text & " "
            End If

        End If
        If txtEditeur.Text <> "" Then
            If (verif = 0) Then
                requete = requete + "WHERE EditeurNum like " & txtEditeur.Text & " "
                verif += 1
            Else
                requete = requete + "AND EditeurNum like " & txtEditeur.Text & " "
            End If
        End If
        If cbxAnnee.Text <> "" Then
            If (verif = 0) Then
                requete = requete + "WHERE BdParution = " & cbxAnnee.Text & " "
                verif += 1
            Else
                requete = requete + "AND BdParution = " & cbxAnnee.Text & " "
            End If
        End If
        If txtSerie.Text <> "" Then
            If (verif = 0) Then
                requete = requete + "WHERE NumSerie like " & txtSerie.Text & " "
                verif += 1
            Else
                requete = requete + "AND NumSerie like " & txtSerie.Text & " "
            End If
            'Si toutes les conditions sont remplies, l'ajout est fait
        End If


        MaDataTable.Clear()
        MonAdapter.SelectCommand = New MySqlCommand(requete, MaCxionMySql)
        MonAdapter.Fill(UnDataset, "bd")
        MaDataTable = UnDataset.Tables("bd")
        'création du datagridview en fonction de la recherche
        dtGrdLivres.DataSource = MaDataTable
        dtGrdLivres.Columns("BdId").HeaderText = "Code"
        dtGrdLivres.Columns("BdId").Width = 40
        dtGrdLivres.Columns("BdTitre").HeaderText = "Titre"
        dtGrdLivres.Columns("BdTitre").Width = 240
        dtGrdLivres.Columns("BdTome").HeaderText = "Tome"
        dtGrdLivres.Columns("BdTome").Width = 52
        dtGrdLivres.Columns("BdParution").HeaderText = "Parution"
        dtGrdLivres.Columns("BdParution").Width = 50
        dtGrdLivres.Columns("NumSerie").HeaderText = "Serie"
        dtGrdLivres.Columns("NumSerie").Width = 80
        dtGrdLivres.Columns("EditeurNum").HeaderText = "Editeur"
        dtGrdLivres.Columns("EditeurNum").Width = 90
        'dtGrdLivres.Columns("bd_Etat").HeaderText = "Etat"
        'dtGrdLivres.Columns("bd_Etat").Width = 90
        'affichage de tous les champs

        MasqueRecherche(True)
    End Sub


#End Region

#Region "Procédures publiques"

    Public Sub Raz()
        txtCode.Text = ""
        txtTitre.Text = ""
        txtNumTome.Text = ""
        txtSerie.Text = ""
        txtEditeur.Text = ""
        txtAuteur.Text = ""
        txtAuteur2.Text = ""
        cbxAnnee.Items.Clear()

    End Sub

    Public Sub MasqueBouton(valider As Boolean)
        btnModifier.Visible = valider
        btnRechercher.Visible = valider
        btnSupprimer.Visible = valider
        btnAjouter.Visible = valider
        btnSauvegarder.Visible = Not (valider)
        btnAnnuler.Visible = Not (valider)
        btnSauvegarder.Location = New Point(15, 31)
        btnAnnuler.Location = New Point(15, 111)

    End Sub

    Public Sub MasqueRecherche(valider As Boolean)
        btnModifier.Visible = valider
        btnRechercher.Visible = valider
        btnSupprimer.Visible = valider
        btnAjouter.Visible = valider
        btnSauvegarder.Visible = False
        btnValider.Visible = Not (valider)
        btnAnnuler.Visible = Not (valider)
        btnValider.Location = New Point(15, 31)
        btnAnnuler.Location = New Point(15, 111)

    End Sub

    Public Sub RazBouton(valider As Boolean)
        btnModifier.Visible = valider
        btnRechercher.Visible = valider
        btnSupprimer.Visible = valider
        btnAjouter.Visible = valider
        btnSauvegarder.Visible = Not (valider)
        btnValider.Visible = Not (valider)
        btnAnnuler.Visible = Not (valider)

    End Sub

    Public Sub RempCbxAnnee()
        'Remplissage de la combobox Année
        For i As Integer = 1940 To Date.Now.Year
            cbxAnnee.Items.Add(i.ToString)
        Next i
        cbxAnnee.Items.Add("")
        cbxAnnee.Refresh()
    End Sub

    Public Sub RempCbxSerie()
        'remplissage des combo
        requete = "SELECT DISTINCT(NumSerie) FROM BD ORDER BY 1"
        MonAdapter.SelectCommand = New MySqlCommand(requete, MaCxionMySql)
        MonAdapter.Fill(UnDataset, "NumSerie")
        'maTableCombo.Clear()
        maTableCombo = UnDataset.Tables("NumSerie")
        cbxSerie.DataSource = maTableCombo
        ''champ affiché
        cbxSerie.DisplayMember = "NumSerie"
        cbxSerie.ValueMember = "NumSerie"
    End Sub

    Public Sub RempCbxEditeur()
        requete = "SELECT EditeurNum, EditeurNom FROM EDITEUR"
        MonAdapter.SelectCommand = New MySqlCommand(requete, MaCxionMySql)
        MonAdapter.Fill(UnDataset, "editeur")
        maTableCombo = UnDataset.Tables("editeur")
        cbxEditeur.DataSource = maTableCombo
        'champ affiché
        cbxEditeur.DisplayMember = "NomEditeur"
        'valeur du champ caché, ici le code
        cbxEditeur.ValueMember = "EditeurNum"
    End Sub

    Public Sub RempCbxAuteur()
        requete = "SELECT AuteurId, AuteurNom FROM AUTEUR ORDER BY 1"
        MonAdapter.SelectCommand = New MySqlCommand(requete, MaCxionMySql)
        MonAdapter.Fill(UnDataset, "auteur")
        maTableCombo = UnDataset.Tables("auteur")
        cbxAuteur.DataSource = maTableCombo
        'champ affiché
        cbxAuteur.DisplayMember = "AuteurNom"
        'valeur du champ caché, ici le code
        cbxAuteur.ValueMember = "AuteurId"

    End Sub

    Public Sub RempCbxAuteur2()
        requete = "SELECT AuteurId, AuteurNom FROM AUTEUR ORDER BY 1"
        MonAdapter.SelectCommand = New MySqlCommand(requete, MaCxionMySql)
        MonAdapter.Fill(UnDataset, "auteur")
        maTableCombo = UnDataset.Tables("auteur")
        cbxAuteur2.DataSource = maTableCombo
        'champ affiché
        cbxAuteur2.DisplayMember = "AuteurNom"
        'valeur du champ caché, ici le code
        cbxAuteur2.ValueMember = "AuteurId"

    End Sub

#End Region

#Region "Procédures privées"

    Private Sub Lock()
        txtTitre.Enabled = False
        txtNumTome.Enabled = False
        txtSerie.Enabled = False
        cbxAnnee.Enabled = False
        txtEditeur.Enabled = False
        cbxEditeur.Enabled = False
        cbxSerie.Enabled = False

    End Sub

    Private Sub unLock()
        txtTitre.Enabled = True
        txtNumTome.Enabled = True
        txtSerie.Enabled = True
        cbxAnnee.Enabled = True
        txtEditeur.Enabled = False
        cbxEditeur.Enabled = True
        cbxSerie.Enabled = True
    End Sub

    Private Sub Affichage()
        txtTitre.Visible = True
        txtNumTome.Visible = True
        txtSerie.Visible = True
        cbxAnnee.Visible = True
        txtEditeur.Visible = True
        cbxEditeur.Visible = True
        cbxSerie.Visible = True
        cbxAuteur.Visible = True
        cbxAuteur2.Visible = True
    End Sub

    Private Sub MasqueChamp()
        cbxEditeur.Visible = False
        cbxSerie.Visible = False
        cbxAuteur.Visible = False
        cbxAuteur2.Visible = False
    End Sub

    Private Sub MajEcran()
        txtCode.Enabled = False
        txtTitre.Enabled = False
        txtNumTome.Enabled = False
        txtAuteur.Enabled = False
        txtAuteur2.Enabled = False
        cbxAnnee.Enabled = False
        txtSerie.Enabled = False
        txtEditeur.Enabled = False
        btnValider.Visible = False
        btnSauvegarder.Visible = False
        btnAnnuler.Visible = False
        cbxEditeur.Visible = False
        cbxSerie.Visible = False
        cbxAuteur.Visible = False
        cbxAuteur2.Visible = False
    End Sub

    Private Sub ResetColor()
        txtTitre.BackColor = Color.White
        txtSerie.BackColor = Color.White
        txtEditeur.BackColor = Color.White
    End Sub

    Private Sub cbxSerie_DropDownClosed(sender As Object, e As EventArgs) Handles cbxSerie.DropDownClosed
        txtSerie.Text = DirectCast(cbxSerie.SelectedItem, DataRowView).Item("NumSerie")
    End Sub

    Private Sub cbxAuteur_DropDownClosed(sender As Object, e As EventArgs) Handles cbxAuteur.DropDownClosed
        txtAuteur.Text = DirectCast(cbxAuteur.SelectedItem, DataRowView).Item("AuteurNom")
    End Sub

    Private Sub cbxAuteur2_DropDownClosed(sender As Object, e As EventArgs) Handles cbxAuteur2.DropDownClosed
        txtAuteur2.Text = DirectCast(cbxAuteur2.SelectedItem, DataRowView).Item("AuteurNom")
    End Sub

    Private Sub cbxEditeur_DropDownClosed(sender As Object, e As EventArgs) Handles cbxEditeur.DropDownClosed
        txtEditeur.Text = CType(cbxEditeur.SelectedValue, String)
    End Sub

    Private Sub txtNumTome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumTome.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc((e.KeyChar)) <> System.Windows.Forms.Keys.Back Then
            e.Handled = True
        End If
    End Sub

#End Region

#Region "Fonction Privées"

    Private Function ChampsValide() As Boolean
        Dim valide As Boolean = True
        If (txtTitre.Text = "") Then
            txtTitre.BackColor = Color.Yellow
            valide = False
        End If
        If (txtSerie.Text = "") Then
            txtSerie.BackColor = Color.Yellow
            valide = False
        End If
        If (txtEditeur.Text = "") Then
            txtEditeur.BackColor = Color.Yellow
            valide = False
        End If
        Return valide
    End Function

    Private Sub ComboBox1_DropDownClosed(sender As Object, e As EventArgs) Handles cbxAnnee.DropDownClosed
        Annee = Me.cbxAnnee.SelectedItem
    End Sub


#End Region

End Class