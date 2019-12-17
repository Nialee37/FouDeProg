using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using lib_funEnBulles;

namespace FunEnBulles
{
    /// <summary>
    /// Logique d'interaction pour Gestion_Utilisateur.xaml
    /// </summary>
    public partial class Gestion_Utilisateur : Window
    {
        private MySqlConnection connection;
        public Gestion_Utilisateur()
        {
            InitializeComponent();
            
        }

        private void cmd_ajouter(object sender, RoutedEventArgs e)
        {
            /*
            // Création de l'objet Command et association à la procédure stockée
            MySqlCommand cmd_ajout_utilisateur = new MySqlCommand();
            cmd_ajout_utilisateur.CommandText = "utilisateur_ajouter";
            cmd_ajout_utilisateur.CommandType = CommandType.StoredProcedure;
            cmd_ajout_utilisateur.Connection = connection;

            // Paramètre d'entrée
            cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("matricule", MySqlDbType.String));
            cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("nom", MySqlDbType.String));
            cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("prenom", MySqlDbType.String));
            cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("ville", MySqlDbType.String));
            cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("code_postal", MySqlDbType.String));
            cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("adresse", MySqlDbType.String));
            cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("telephone", MySqlDbType.String));
            // cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("droit_administration", MySqlDbType.String));
            cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("date_naissance", MySqlDbType.DateTime));
            cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("email", MySqlDbType.DateTime));
            cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("pseudonyme", MySqlDbType.DateTime));
            cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("mot_de_passe", MySqlDbType.DateTime));

            // Affectation des valeurs
            try
            {
                cmd_ajout_utilisateur.Parameters["matricule"].Value = txt_matricule.Text;
                cmd_ajout_utilisateur.Parameters["nom"].Value = txt_nom.Text;
                cmd_ajout_utilisateur.Parameters["prenom"].Value = txt_prenom.Text;
                cmd_ajout_utilisateur.Parameters["ville"].Value = txt_ville.Text;
                cmd_ajout_utilisateur.Parameters["code_postal"].Value = txt_code_postal.Text;
                cmd_ajout_utilisateur.Parameters["adresse"].Value = txt_adresse.Text;
                cmd_ajout_utilisateur.Parameters["telephone"].Value = txt_telephone.Text;
                // cmd_ajout_utilisateur.Parameters["droit_administration"].Value = txt;
                cmd_ajout_utilisateur.Parameters["date_naissance"].Value = ;
                cmd_ajout_utilisateur.Parameters["email"].Value = ;
                cmd_ajout_utilisateur.Parameters["pseudonyme"].Value = ;
                cmd_ajout_utilisateur.Parameters["mot_de_passe"].Value = ;
            }
            catch
            {

            }
            */

            /*
             * Finir contrôle des dates
             * 
             */
            string matricule = txt_matricule.Text;
            string nom = txt_nom.Text;
            string prenom = txt_prenom.Text;
            string ville = txt_ville.Text;
            string codePostal = txt_code_postal.Text;
            string adresse = txt_adresse.Text;
            string telephone = txt_telephone.Text;
            string email = txt_email.Text;
            string pseudo = "a";
            string droit = "a";
            DateTime localDate = DateTime.Now; // Date actuelle pour la comparaison avec la date de naissance
            DateTime dateNaissance = localDate;
            try
            {
                dateNaissance = dp_date_naissance.SelectedDate.Value.Date; // Si aucune date n'est sélectionnée
            }
            catch
            {
                Console.WriteLine("Sélectionnez une date");
                MessageBox.Show("Sélectionnez une date");
            }
            bool dateValide = dateNaissance.Date >= localDate.Date; // True : Invalide / False : Valide

            if(!(String.IsNullOrWhiteSpace(matricule) || String.IsNullOrWhiteSpace(nom) || String.IsNullOrWhiteSpace(prenom) || String.IsNullOrWhiteSpace(ville) || String.IsNullOrWhiteSpace(codePostal) || String.IsNullOrWhiteSpace(adresse) || String.IsNullOrWhiteSpace(telephone) || String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(pseudo) || String.IsNullOrWhiteSpace(droit) || dateValide))
            {
                // Champs valides
                Console.WriteLine("Champs valides");
                //Utilisateur unUtilisateur = new Utilisateur(matricule, nom, prenom, ville, codePostal, adresse, telephone, email, pseudo, droit, dateNaissance);
            }
            else
            {
                // Champs invalides
                Console.WriteLine("Champs invalides");
                MessageBox.Show("Un ou plusieurs champs sont invalides");
            }
        }

        private bool ConnexionBdd()
        {
            connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connectBdd"].ConnectionString);
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        private void fermerConnexion()
        {
            connection.Close();
        }
    }
}
