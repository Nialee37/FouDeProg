Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class dlgRedefineMDP

    'Changement du mot de passe au click du bouton "OK"
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim requete = "UPDATE utilisateurs SET  util_password = md5('" & txtNewMDP.Text & "') WHERE util_pseudo Like '" & Accueil.txt_id.Text & "'"
        Dim cmd = New MySqlCommand
        cmd.Connection = MaCxionMySql
        cmd.CommandText = requete
        cmd.ExecuteNonQuery()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    'Desactive le bouton "OK" tant que le mot de passe n'est pas vérifié
    Private Sub txtMDP_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNewMDP.KeyUp, txtNewMDPVerif.KeyUp
        If (txtNewMDP.Text = txtNewMDPVerif.Text And txtNewMDP.Text <> "") Then
            txtNewMDPVerif.BackColor = Color.White
            OK_Button.Enabled = True
        End If
        If (txtNewMDP.Text <> txtNewMDPVerif.Text) Then
            txtNewMDPVerif.BackColor = Color.Yellow
            OK_Button.Enabled = False
        End If
    End Sub


End Class
