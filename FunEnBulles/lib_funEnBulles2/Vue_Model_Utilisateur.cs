
using lib_funEnBulles;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace lib_funEnBulles2
{
    public class Vue_Model_Utilisateur
    {
        private Utilisateur _Utilisateur;

        public Vue_Model_Utilisateur(Utilisateur utilisateur)
        {
            _Utilisateur = utilisateur;
        }

        public void Ajout_Utilisateur()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connectBdd"].ConnectionString);
                connection.Open();

                // Création de l'objet Command et association à la procédure stockée
                MySqlCommand cmd_ajout_utilisateur = new MySqlCommand();
                cmd_ajout_utilisateur.CommandText = "utilisateur_ajouter";
                cmd_ajout_utilisateur.CommandType = CommandType.StoredProcedure;
                cmd_ajout_utilisateur.Connection = connection;

                // Paramètre d'entrée
                cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("numero_carte", MySqlDbType.Int16));
                cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("nom", MySqlDbType.String));
                cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("prenom", MySqlDbType.String));
                cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("ville", MySqlDbType.String));
                cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("code_postal", MySqlDbType.String));
                cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("adresse", MySqlDbType.String));
                cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("telephone", MySqlDbType.String));
                cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("date_naissance", MySqlDbType.DateTime));
                cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("email", MySqlDbType.String));
                cmd_ajout_utilisateur.Parameters.Add(new MySqlParameter("pseudonyme", MySqlDbType.String));

                // Affectation des valeurs
                cmd_ajout_utilisateur.Parameters["numero_carte"].Value = _Utilisateur.NumeroCarte;
                cmd_ajout_utilisateur.Parameters["nom"].Value = _Utilisateur.Nom;
                cmd_ajout_utilisateur.Parameters["prenom"].Value = _Utilisateur.Prenom;
                cmd_ajout_utilisateur.Parameters["ville"].Value = _Utilisateur.Ville;
                cmd_ajout_utilisateur.Parameters["code_postal"].Value = _Utilisateur.CodePostal;
                cmd_ajout_utilisateur.Parameters["adresse"].Value = _Utilisateur.Adresse;
                cmd_ajout_utilisateur.Parameters["telephone"].Value = _Utilisateur.Telephone;
                cmd_ajout_utilisateur.Parameters["date_naissance"].Value = _Utilisateur.DateNaissance;
                cmd_ajout_utilisateur.Parameters["email"].Value = _Utilisateur.Email;
                cmd_ajout_utilisateur.Parameters["pseudonyme"].Value = _Utilisateur.Pseudonyme;

                cmd_ajout_utilisateur.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}