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

namespace lib_funEnBulles
{
    public class Vue_Model_Utilisateur
    {
        private Utilisateur _Utilisateur;

        public Vue_Model_Utilisateur()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connectBdd"].ConnectionString);

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
        }
    }
}