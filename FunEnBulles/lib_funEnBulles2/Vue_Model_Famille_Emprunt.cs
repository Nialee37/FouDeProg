using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_funEnBulles2
{
    public class Vue_Model_Famille_Emprunt
    {
        public Vue_Model_Famille_Emprunt()
        {

        }

        public void Ajouter_Famille_Emprunt(int matricule_chef, int matricule_membre)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connectBdd"].ConnectionString);
                connection.Open();

                // Création de l'objet Command et association à la procédure stockée
                MySqlCommand cmd_ajout_famille = new MySqlCommand();
                cmd_ajout_famille.CommandText = "famille_emprunteur_ajouter";
                cmd_ajout_famille.CommandType = CommandType.StoredProcedure;
                cmd_ajout_famille.Connection = connection;

                // Paramètre d'entrée
                cmd_ajout_famille.Parameters.Add(new MySqlParameter("wMatriculeChef", MySqlDbType.Int16));
                cmd_ajout_famille.Parameters.Add(new MySqlParameter("wMatriculeMembre", MySqlDbType.Int16));

                // Affectation des valeurs
                cmd_ajout_famille.Parameters["wMatriculeChef"].Value = matricule_chef;
                cmd_ajout_famille.Parameters["wMatriculeMembre"].Value = matricule_membre;

                cmd_ajout_famille.ExecuteNonQuery();
            }
            catch
            {

            }
        }
    }
}
