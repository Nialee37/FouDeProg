Imports MySql.Data.MySqlClient

Public Class FrmAuteurs
    Dim MonAuteur As String
    Dim Ajout As Boolean
    Dim MonAdapter As MySqlDataAdapter
    Dim MaRequete As String
    Dim UnDataset As New DataSet
    Dim MaDataTable As DataTable
    Dim cmd As MySqlCommand
    Dim requete As String
    Dim dateCheck As Boolean


    Private Sub FrmClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonAdapter = New MySqlDataAdapter()
        DesaChamp()
        RazBouton(True)
        Couleur()
        rempDatagridConnec()

    End Sub

    Private Sub dtGrdAuteurs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrdAuteurs.CellClick

        txtNom.Text = dtGrdAuteurs.CurrentRow.Cells("AuteurNom").Value
        txtCode.Text = dtGrdAuteurs.CurrentRow.Cells("AuteurId").Value
        txtPrenom.Text = dtGrdAuteurs.CurrentRow.Cells("AuteurPrenom").Value
        txtBio.Text = dtGrdAuteurs.CurrentRow.Cells("AuteurBiographie").Value
        txtNaiss.Text = dtGrdAuteurs.CurrentRow.Cells("AuteurDateNaiss").Value
        DateTimePickerDateNaiss.Text = dtGrdAuteurs.CurrentRow.Cells("AuteurDateNaiss").Value

    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click

        Raz()

        txtNom.Enabled = True
        txtPrenom.Enabled = True
        txtNaiss.Enabled = True
        txtBio.Enabled = True
        DateTimePickerDateNaiss.Enabled = True


        MasqueBouton(False)

        btnSauvegarder.Location = New Point(15, 31)
        btnAnnuler.Location = New Point(15, 111)
        btnSauvegarder.Tag = "A"

    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click

        Me.Close()

    End Sub

    Private Sub btnValider_clickk(sender As Object, e As EventArgs) Handles btnValider.Click

        If (ChampsValideRech()) Then

            txtNom.BackColor = Color.White

            requete = "SELECT AuteurId, AuteurNom, AuteurPrenom, AuteurBiographie, AuteurDateNaiss FROM AUTEUR WHERE UPPER(AuteurNom) like '%" & txtNom.Text.ToUpper & "%' "
            cmd = New MySqlCommand
            cmd.Connection = MaCxionMySql
            cmd.CommandText = requete
            cmd.ExecuteNonQuery()
            MaDataTable.Clear()
            MonAdapter.SelectCommand = New MySqlCommand(requete, MaCxionMySql)
            MonAdapter.Fill(UnDataset, "auteurs")
            MaDataTable = UnDataset.Tables("auteurs")
            dtGrdAuteurs.DataSource = MaDataTable
            RazBouton(True)
            MasqueRecherche(True)
            btnSauvegarder.Visible = False
            VisiChamp()
            Raz()
            DesaChamp()
            Couleur()

        End If

    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click

        RazBouton(True)
        VisiChamp()
        Raz()
        DesaChamp()
        Couleur()

    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click

        txtPrenom.Enabled = True
        txtBio.Enabled = True
        txtNaiss.Enabled = True
        DateTimePickerDateNaiss.Enabled = True
        MasqueBouton(False)
        btnSauvegarder.Tag = "M"

    End Sub

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click

        txtNom.Enabled = True
        txtBio.Visible = False
        lblBio.Visible = False
        txtNaiss.Visible = False
        DateTimePickerDateNaiss.Visible = False
        lblNaiss.Visible = False
        Raz()
        MasqueRecherche(False)
        lblPrenom.Visible = False
        txtPrenom.Visible = False

    End Sub

    Private Sub btnSauvegarder_Click(sender As Object, e As EventArgs) Handles btnSauvegarder.Click

        If ((btnSauvegarder.Tag = "A") And ChampsValide()) Then
            txtNom.Text = txtNom.Text.Substring(0, 1).ToUpper + txtNom.Text.Substring(1).ToLower
            txtPrenom.Text = txtPrenom.Text.Substring(0, 1).ToUpper + txtPrenom.Text.Substring(1).ToLower
            txtBio.Text = txtBio.Text.Replace("'", "\'")
            requete = "INSERT INTO Auteur VALUES ('" & txtCode.Text & "','" & txtNom.Text & "','" & txtPrenom.Text & "', '" & txtNaiss.Text & "', '" & txtBio.Text & "')"
            cmd = New MySqlCommand
            cmd.Connection = MaCxionMySql
            cmd.CommandText = requete
            'On fait la quete de recherche'
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Auteur ajouté", MessageBoxButtons.OK + MessageBoxIcon.Information, "Confirmation")
                'Si l'auteur existe, une erreur est déclarée'
            Catch ex As Exception
                MsgBox("ERREUR : L'auteur " & txtNom.Text & " existe déjà !")
            End Try
            MasqueBouton(True)
            btnValider.Visible = False
            MaDataTable.Clear()
            rempDatagridConnec()
            dtGrdAuteurs.Refresh()
            VisiChamp()
            Raz()
            DesaChamp()
            Couleur()



        End If

        If ((btnSauvegarder.Tag = "M") And ChampsValideModif()) Then
            txtPrenom.Text = txtPrenom.Text.Substring(0, 1).ToUpper + txtPrenom.Text.Substring(1).ToLower
            txtBio.Text = txtBio.Text.Replace("'", "\'")
            requete = "UPDATE Auteur SET AuteurPrenom ='" & txtPrenom.Text & "', AuteurBiographie ='" & txtBio.Text & "', AuteurDateNaiss ='" & txtNaiss.Text & "' WHERE AuteurId Like '" & txtCode.Text & "'"
            cmd = New MySqlCommand
            cmd.Connection = MaCxionMySql
            cmd.CommandText = requete
            cmd.ExecuteNonQuery()
            MasqueBouton(True)
            MaDataTable.Clear()
            rempDatagridConnec()
            dtGrdAuteurs.Refresh()
            btnValider.Visible = False
            VisiChamp()
            Raz()
            DesaChamp()
            Couleur()

        End If

    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If txtNom.Text = "" Then
            MsgBox("Aucun auteur selectionné ", MessageBoxButtons.OK + MessageBoxIcon.Warning, "IMPORTANT")

        Else
            Dim rep As Integer = MsgBox("Etes-vous sur de supprimer l'auteur -- " & txtNom.Text.ToUpper & "  -- ?", MessageBoxButtons.YesNo + MessageBoxIcon.Warning, "IMPORTANT")

            If rep = 6 Then
                requete = "DELETE FROM Auteur WHERE AuteurId Like '" & txtCode.Text & "'"
                cmd = New MySqlCommand
                cmd.Connection = MaCxionMySql
                cmd.CommandText = requete
                cmd.ExecuteNonQuery()
                MaDataTable.Clear()
                rempDatagridConnec()
                dtGrdAuteurs.Refresh()
                Raz()
            End If
        End If


    End Sub

    Private Sub txtNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc((e.KeyChar)) <> System.Windows.Forms.Keys.Back And e.KeyChar <> Convert.ToChar(32) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrenom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrenom.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc((e.KeyChar)) <> System.Windows.Forms.Keys.Back And e.KeyChar <> Convert.ToChar(32) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNaiss_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNaiss.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc((e.KeyChar)) <> System.Windows.Forms.Keys.Back And e.KeyChar <> Convert.ToChar(47) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNom_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNom.KeyUp
        'prendre les 6 premiers, oter les blancs 
        Dim txetSansChaine As String = txtNom.Text.ToUpper.Replace(" ", "")
        If (txetSansChaine.Length >= 6) Then
            txtCode.Text = txetSansChaine.Substring(0, 6)
        Else
            txtCode.Text = txtNom.Text.ToUpper.Replace(" ", "")
        End If
    End Sub

    Public Sub Couleur()

        txtNom.BackColor = Color.White
        txtPrenom.BackColor = Color.White
        txtNaiss.BackColor = Color.White
        DateTimePickerDateNaiss.CalendarTitleBackColor = Color.White

    End Sub

    Public Sub VisiChamp()

        txtCode.Visible = True
        txtNom.Visible = True
        txtPrenom.Visible = True
        txtBio.Visible = True
        txtNaiss.Visible = True
        DateTimePickerDateNaiss.Visible = True
        lblCode.Visible = True
        lblNom.Visible = True
        lblPrenom.Visible = True
        lblBio.Visible = True
        lblNaiss.Visible = True

    End Sub

    Public Sub Raz()

        txtNom.Text = ""
        txtCode.Text = ""
        txtPrenom.Text = ""
        txtBio.Text = ""
        txtNaiss.Text = ""

    End Sub

    Public Sub DesaChamp()

        txtCode.Enabled = False
        txtNom.Enabled = False
        txtPrenom.Enabled = False
        txtBio.Enabled = False
        txtNaiss.Enabled = False
        DateTimePickerDateNaiss.Enabled = False

    End Sub

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

    Public Sub MasqueRecherche(valider As Boolean)

        btnModifier.Visible = valider
        btnRechercher.Visible = valider
        btnSupprimer.Visible = valider
        btnAjouter.Visible = valider
        btnSauvegarder.Visible = valider
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

    Public Sub rempDatagridConnec()

        MaRequete = "SELECT AuteurId, AuteurNom, AuteurPrenom, AuteurDateNaiss, AuteurBiographie FROM AUTEUR"
        MonAdapter.SelectCommand = New MySqlCommand(MaRequete, MaCxionMySql)
        MonAdapter.Fill(UnDataset, "auteurs")
        MaDataTable = UnDataset.Tables("auteurs")
        dtGrdAuteurs.DataSource = MaDataTable
        dtGrdAuteurs.Columns("AuteurId").HeaderText = "Code"
        dtGrdAuteurs.Columns("AuteurNom").HeaderText = "Nom"
        dtGrdAuteurs.Columns("AuteurPrenom").HeaderText = "Prenom"
        dtGrdAuteurs.Columns("AuteurBiographie").HeaderText = "Biographie"
        dtGrdAuteurs.Columns("AuteurDateNaiss").HeaderText = "Date Naiss."
        dtGrdAuteurs.Columns("AuteurId").Width = 80
        dtGrdAuteurs.Columns("AuteurNom").Width = 80
        dtGrdAuteurs.Columns("AuteurPrenom").Width = 80
        dtGrdAuteurs.Columns("AuteurBiographie").Width = 200
        dtGrdAuteurs.Columns("AuteurDateNaiss").Width = 85


    End Sub

    Private Function ChampsValide() As Boolean

        Dim valide As Boolean = True

        dateCheck = IsDate(txtNaiss.Text)

        If (dateCheck = True) AndAlso ((DateTime.Now.ToString("yyyy") - Format(CType(txtNaiss.Text, Date), "yyyy")) < 15) Then
            dateCheck = False
        End If

        If ((btnSauvegarder.Tag = "A") And ((txtNom.Text <> "") And (txtPrenom.Text <> "") And (dateCheck = True))) Then
            txtNaiss.Text = Format(CType(txtNaiss.Text, Date), "yyyy-MM-dd")
            txtNom.BackColor = Color.White
            txtPrenom.BackColor = Color.White
            txtNaiss.BackColor = Color.White

        End If

        If ((btnSauvegarder.Tag = "A") And ((txtNom.Text = "") Or (txtPrenom.Text = "") Or (dateCheck = False))) Then
            valide = False
            txtNom.BackColor = Color.Yellow
            txtPrenom.BackColor = Color.Yellow
            txtNaiss.BackColor = Color.Yellow
            MsgBox("Informations manquantes ou date incorrecte", MessageBoxButtons.OK + MessageBoxIcon.Information, "Attention")

        End If

        Return valide

    End Function

    Private Function ChampsValideModif() As Boolean

        Dim modifvalid As Boolean = True

        dateCheck = IsDate(txtNaiss.Text)

        If ((dateCheck = True) AndAlso ((DateTime.Now.ToString("yyyy") - Format(CType(txtNaiss.Text, Date), "yyyy")) < 15)) Then
            dateCheck = False
        End If

        If ((btnSauvegarder.Tag = "M") And (txtPrenom.Text <> "") And (dateCheck = True)) Then
            txtNaiss.Text = Format(CType(txtNaiss.Text, Date), "yyyy-MM-dd")
            txtPrenom.BackColor = Color.White
            txtNaiss.BackColor = Color.White

        End If

        If ((btnSauvegarder.Tag = "M") And ((txtPrenom.Text = "") Or (dateCheck = False))) Then
            txtPrenom.BackColor = Color.Yellow
            txtNaiss.BackColor = Color.Yellow
            modifvalid = False
            MsgBox("Saisir les informations à modifier !", MessageBoxButtons.OK + MessageBoxIcon.Information, "Attention")
        End If

        Return modifvalid

    End Function

    Private Function ChampsValideRech() As Boolean

        Dim rechvalid As Boolean = True

        If (txtNom.Text = "") Then
            txtNom.BackColor = Color.Yellow
            rechvalid = False
            MsgBox("Saisir un auteur à rechercher", MessageBoxButtons.OK + MessageBoxIcon.Information, "Attention")

        End If

        Return rechvalid

    End Function

    Private Sub dtGrdAuteurs_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrdAuteurs.CellEnter

        txtNom.Text = dtGrdAuteurs.CurrentRow.Cells("AuteurNom").Value
        txtCode.Text = dtGrdAuteurs.CurrentRow.Cells("AuteurId").Value
        txtPrenom.Text = dtGrdAuteurs.CurrentRow.Cells("AuteurPrenom").Value
        txtBio.Text = dtGrdAuteurs.CurrentRow.Cells("AuteurBiographie").Value
        txtNaiss.Text = dtGrdAuteurs.CurrentRow.Cells("AuteurDateNaiss").Value
        DateTimePickerDateNaiss.Text = dtGrdAuteurs.CurrentRow.Cells("AuteurDateNaiss").Value
    End Sub

    'Différencier evenement click de la cellule et click tout court avec un Mouseclick'
    'Variable hit contient les coordonnées du click (cellule)'
    'Si les coordonnées sont celles du topleftheader 0,0'
    'Actualiser + Afficher tableau'

    Private Sub dtGrdAuteurs_MouseClick(sender As Object, e As MouseEventArgs) Handles dtGrdAuteurs.MouseClick
        Dim hit As DataGridView.HitTestInfo = dtGrdAuteurs.HitTest(e.X, e.Y)
        If (hit.Type = DataGridViewHitTestType.TopLeftHeader) Then
            MaDataTable.Clear()
            rempDatagridConnec()
        End If
    End Sub

    Private Sub DateTimePickerDateNaiss_CloseUp(sender As Object, e As EventArgs) Handles DateTimePickerDateNaiss.ValueChanged
        txtNaiss.Text = DateTimePickerDateNaiss.Text
    End Sub

End Class