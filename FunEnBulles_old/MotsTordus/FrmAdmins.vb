Imports MySql.Data.MySqlClient

Public Class FrmAdmins
    Dim MonAuteur As String
    Dim Ajout As Boolean
    Dim MonAdapter As MySqlDataAdapter
    Dim MaRequete As String
    Dim UnDataset As New DataSet
    Dim MaDataTable As DataTable
    Dim cmd As MySqlCommand
    Dim requete As String
    Dim recherche As Boolean

    Private Sub FrmClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonAdapter = New MySqlDataAdapter()
        txtCode.Enabled = False
        txtNom.Enabled = False
        TxtPrenom.Enabled = False
        TxtID.Enabled = False
        TxtMDP.Enabled = False
        RbtUser.Enabled = False
        rbtInvit.Enabled = False
        RbtAdmin.Enabled = False
        btnResetMDP.Enabled = False
        btnSauvegarder.Visible = False
        btnAnnuler.Visible = False

        recherche = False

        rempDatagridConnec()
    End Sub

    Private Sub dtGrdAuteurs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrdAuteurs.CellClick
        txtNom.Text = dtGrdAuteurs.CurrentRow.Cells("util_nom").Value
        TxtID.Text = dtGrdAuteurs.CurrentRow.Cells("util_id").Value
        TxtPrenom.Text = dtGrdAuteurs.CurrentRow.Cells("util_prenom").Value
        txtCode.Text = dtGrdAuteurs.CurrentRow.Cells("util_pseudo").Value
        TxtMDP.Text = dtGrdAuteurs.CurrentRow.Cells("util_password").Value

        If (dtGrdAuteurs.CurrentRow.Cells("util_niveau").Value = "user") Then
            RbtUser.Checked = True
        End If
        If (dtGrdAuteurs.CurrentRow.Cells("util_niveau").Value = "admin") Then
            RbtAdmin.Checked = True
        End If
        If (dtGrdAuteurs.CurrentRow.Cells("util_niveau").Value = "invit") Then
            RbtInvit.Checked = True
        End If

    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        txtNom.Enabled = True
        TxtPrenom.Enabled = True
        Raz()
        MasqueBouton(False)
        btnSauvegarder.Location = New Point(15, 31)
        btnAnnuler.Location = New Point(15, 111)
        LblPrenom.Visible = True
        TxtPrenom.Visible = True
        btnSauvegarder.Tag = "A"
        RbtUser.Enabled = True
        RbtAdmin.Enabled = True
        rbtInvit.Enabled = True
        dtGrdAuteurs.Enabled = False
        RbtUser.Checked = False
        RbtAdmin.Checked = False
        rbtInvit.Checked = True
    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Close()
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        txtCode.Enabled = False
        TxtID.Enabled = False
        TxtMDP.Enabled = False
        txtNom.Enabled = False
        TxtPrenom.Enabled = False
        RazBouton(True)
        Raz()
        LblPrenom.Visible = True
        TxtPrenom.Visible = True
        txtNom.BackColor = Color.White
        TxtPrenom.BackColor = Color.White
        TxtMDP.BackColor = Color.White
        dtGrdAuteurs.Enabled = True
        RbtUser.Checked = False
        RbtAdmin.Checked = False
        RbtUser.Enabled = False
        RbtAdmin.Enabled = False
        rbtInvit.Enabled = False
        btnResetMDP.Enabled = False

        RbtUser.Checked = False
        RbtAdmin.Checked = False
        rbtInvit.Checked = False

        recherche = False

        MaDataTable.Clear()
        rempDatagridConnec()
        dtGrdAuteurs.Refresh()

    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        If (txtNom.Text = "" Or TxtPrenom.Text = "") Then
            MsgBox("Sélectionner d'abord un utilisateur")
            Exit Sub
        End If
        txtNom.Enabled = True
        TxtPrenom.Enabled = True
        MasqueBouton(False)
        LblPrenom.Visible = True
        TxtPrenom.Visible = True
        btnSauvegarder.Tag = "M"
        RbtUser.Enabled = True
        RbtAdmin.Enabled = True
        rbtInvit.Enabled = True
        btnResetMDP.Enabled = True
    End Sub

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        txtNom.Enabled = True
        TxtPrenom.Enabled = True
        Raz()
        MasqueRecherche(False)
        RbtUser.Checked = False
        RbtAdmin.Checked = False
        rbtInvit.Enabled = False
        recherche = True
        MaDataTable.Clear()
        rempDatagridConnec()
        dtGrdAuteurs.Refresh()
    End Sub

    Private Sub btnSauvegarder_Click(sender As Object, e As EventArgs)

        Dim Ncheck As String = ""
        If (RbtUser.Checked = True) Then
            Ncheck = "user"
        End If
        If (RbtAdmin.Checked = True) Then
            Ncheck = "admin"
        End If
        If (rbtInvit.Checked = True) Then
            Ncheck = "invit"
        End If
        If ((RbtAdmin.Checked = False) And (RbtUser.Checked = False) And (rbtInvit.Checked = False)) Then
            Ncheck = "invit"
        End If

        If (btnSauvegarder.Tag = "A") And ChampsValide() Then
            txtNom.Text = txtNom.Text.Substring(0, 1).ToUpper + txtNom.Text.Substring(1).ToLower
            TxtPrenom.Text = TxtPrenom.Text.Substring(0, 1).ToUpper + TxtPrenom.Text.Substring(1).ToLower
            requete = "INSERT INTO utilisateurs VALUES ('','" & TxtPrenom.Text & "','" & txtNom.Text & "','" & txtCode.Text & "',md5('" & TxtMDP.Text & "'),'" & Ncheck & "')"
            cmd = New MySqlCommand
            cmd.Connection = MaCxionMySql
            cmd.CommandText = requete
            cmd.ExecuteNonQuery()
            MasqueBouton(True)
            MaDataTable.Clear()
            rempDatagridConnec()
            dtGrdAuteurs.Enabled = True
            dtGrdAuteurs.Refresh()
        End If
        If (btnSauvegarder.Tag = "M") And (txtNom.Text <> "") Then
            TxtPrenom.Text = TxtPrenom.Text.Substring(0, 1).ToUpper + TxtPrenom.Text.Substring(1).ToLower
            requete = "UPDATE utilisateurs SET util_prenom = '" & TxtPrenom.Text & "', util_nom = '" & txtNom.Text & "', util_pseudo = '" & txtCode.Text & "', util_niveau = '" & Ncheck & "' WHERE util_id Like '" & TxtID.Text & "'"
            cmd = New MySqlCommand
            cmd.Connection = MaCxionMySql
            cmd.CommandText = requete
            cmd.ExecuteNonQuery()
            MasqueBouton(True)
            MaDataTable.Clear()
            rempDatagridConnec()
            dtGrdAuteurs.Enabled = True
            dtGrdAuteurs.Refresh()
        End If

        txtCode.Enabled = False
        TxtID.Enabled = False
        TxtMDP.Enabled = False
        txtNom.Enabled = False
        TxtPrenom.Enabled = False
        RbtUser.Enabled = False
        RbtAdmin.Enabled = False
        rbtInvit.Enabled = False
        btnResetMDP.Enabled = False

        RbtUser.Checked = False
        RbtAdmin.Checked = False
        rbtInvit.Checked = False

        Raz()

    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click

        'Suppression d'un utilisateur
        If txtNom.Text = "" Then
            MsgBox("Aucun utilisateurs selectionné ", MessageBoxButtons.OK + MessageBoxIcon.Warning, "IMPORTANT")

        Else
            Dim rep As Integer = MsgBox("Etes-vous sur de supprimer l'utilisateur -- " & txtNom.Text.ToUpper & "  -- ?", MessageBoxButtons.YesNo + MessageBoxIcon.Warning, "IMPORTANT")

            If rep = 6 Then
                If (dtGrdAuteurs.CurrentRow.Cells("util_niveau").Value = "admin") Then
                    MsgBox("Impossible de supprimer un administrateur")

                Else
                    requete = "DELETE FROM utilisateurs WHERE util_id = '" & TxtID.Text & "'"
                    cmd = New MySqlCommand
                    cmd.Connection = MaCxionMySql
                    cmd.CommandText = requete
                    cmd.ExecuteNonQuery()
                End If

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

    Private Sub txtNom_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNom.KeyUp, TxtPrenom.KeyUp

        'prendre les 8 premiers, oter les blancs 
        Dim txtNomSansChaine As String = txtNom.Text.ToLower.Replace(" ", "")
        Dim txtPrenomSansChaine As String = TxtPrenom.Text.ToLower.Replace(" ", "")
        Dim txtP, txtN As String
        txtN = ""
        txtP = ""
        'Inscription du code automatique à chaque pression de touches
        For i As Integer = 1 To 4

            If (txtNomSansChaine.Length = i) Then
                txtN = txtNomSansChaine.Substring(0, i)
            End If
            If (txtPrenomSansChaine.Length = i) Then
                txtP = txtPrenomSansChaine.Substring(0, i)
            End If
            txtCode.Text = txtN + txtP
            TxtMDP.Text = txtN + txtP

        Next

        For i As Integer = 5 To 50

            If (txtNomSansChaine.Length = i) Then
                txtN = txtNomSansChaine.Substring(0, 4)
            End If
            If (txtPrenomSansChaine.Length = i) Then
                txtP = txtPrenomSansChaine.Substring(0, 4)
            End If
            txtCode.Text = txtN + txtP
            TxtMDP.Text = txtN + txtP

        Next

        'Requete exécuter si l'on se trouve ds le modeule "Recherche"
        If (recherche = True) Then

            MaRequete = "SELECT util_id, util_prenom, util_nom, util_pseudo, util_password, util_niveau FROM utilisateurs WHERE util_pseudo like '" & txtCode.Text + "%" & "'"

            MaDataTable.Clear()
            rempDatagridConnec()
            dtGrdAuteurs.Refresh()

        End If

    End Sub

    Public Sub Raz()
        txtNom.Text = ""
        txtCode.Text = ""
        TxtPrenom.Text = ""
        TxtID.Text = ""
        TxtMDP.Text = ""
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
        btnSauvegarder.Visible = valider
        btnAnnuler.Visible = Not (valider)
        btnAnnuler.Location = New Point(15, 111)

    End Sub

    Public Sub RazBouton(valider As Boolean)
        btnModifier.Visible = valider
        btnRechercher.Visible = valider
        btnSupprimer.Visible = valider
        btnAjouter.Visible = valider
        btnSauvegarder.Visible = Not (valider)
        btnAnnuler.Visible = Not (valider)

    End Sub

    Public Sub rempDatagridConnec()
        If (recherche = False) Then
            MaRequete = "SELECT util_id, util_prenom, util_nom, util_pseudo, util_password, util_niveau FROM utilisateurs"
        End If
        MonAdapter.SelectCommand = New MySqlCommand(MaRequete, MaCxionMySql)
        MonAdapter.Fill(UnDataset, "utilisateurs")
        MaDataTable = UnDataset.Tables("utilisateurs")
        dtGrdAuteurs.DataSource = MaDataTable
        dtGrdAuteurs.Columns("util_id").HeaderText = "ID"
        dtGrdAuteurs.Columns("util_id").Width = 31
        dtGrdAuteurs.Columns("util_prenom").HeaderText = "Prenom"
        dtGrdAuteurs.Columns("util_prenom").Width = 80
        dtGrdAuteurs.Columns("util_nom").HeaderText = "Nom"
        dtGrdAuteurs.Columns("util_nom").Width = 80
        dtGrdAuteurs.Columns("util_pseudo").HeaderText = "Pseudo/Code"
        dtGrdAuteurs.Columns("util_pseudo").Width = 90
        dtGrdAuteurs.Columns("util_password").HeaderText = "Mot de Passe (md5)"
        dtGrdAuteurs.Columns("util_password").Width = 207
        dtGrdAuteurs.Columns("util_niveau").HeaderText = "Niveau"
        dtGrdAuteurs.Columns("util_niveau").Width = 45
        dtGrdAuteurs.Width = 560
        dtGrdAuteurs.Height = 200
    End Sub

    Private Function ChampsValide() As Boolean
        Dim valide As Boolean = True
        If (txtNom.Text = "") Then
            txtNom.BackColor = Color.Yellow
            valide = False
        End If
        If (TxtPrenom.Text = "") Then
            TxtPrenom.BackColor = Color.Yellow
            valide = False
        End If
        Return valide
    End Function

    Private Sub btnResetMDP_Click(sender As Object, e As EventArgs) Handles btnResetMDP.Click
        Dim txtNomSansChaine As String = txtNom.Text.ToLower.Replace(" ", "")
        Dim txtPrenomSansChaine As String = TxtPrenom.Text.ToLower.Replace(" ", "")
        Dim txtP, txtN As String
        txtN = ""
        txtP = ""
        If (txtNomSansChaine.Length >= 4) Then
            txtN = txtNomSansChaine.Substring(0, 4)
        End If
        If (txtPrenomSansChaine.Length >= 4) Then
            txtP = txtPrenomSansChaine.Substring(0, 4)
        End If
        TxtMDP.Text = txtN + txtP

        requete = "UPDATE utilisateurs SET  util_password = md5('" & TxtMDP.Text & "') WHERE util_id Like '" & TxtID.Text & "'"
        cmd = New MySqlCommand
        cmd.Connection = MaCxionMySql
        cmd.CommandText = requete
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub DtGrdAuteurs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrdAuteurs.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class