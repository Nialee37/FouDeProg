using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FunEnBulles
{
    /// <summary>
    /// Logique d'interaction pour gestion_exemplaire.xaml
    /// </summary>
    public partial class gestion_exemplaire : UserControl
    {
        private MySqlConnection connection;
        public gestion_exemplaire()
        {
            InitializeComponent();
        }
        private bool ConnexionBase()
        {
            connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connexionBase"].ConnectionString);
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        private void fermerConnexion()
        {
            connection.Close();
        }

        private void cmd_ajouter_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommand sql_cmd_ajouter = new MySqlCommand();
            sql_cmd_ajouter.CommandText = "exemplaire_ajout_exemplaire";
            sql_cmd_ajouter.CommandType = CommandType.StoredProcedure;
            sql_cmd_ajouter.Connection = connection;

            sql_cmd_ajouter.Parameters.Add(new MySqlParameter("exemplaire_reference", MySqlDbType.String));
            sql_cmd_ajouter.Parameters.Add(new MySqlParameter("exemplaire_commentaire", MySqlDbType.String));
            sql_cmd_ajouter.Parameters.Add(new MySqlParameter("exemplaire_etat", MySqlDbType.String));
            sql_cmd_ajouter.Parameters.Add(new MySqlParameter("ouvrage_isbn", MySqlDbType.String));

            try
            {
                sql_cmd_ajouter.Parameters["exemplaire_reference"].Value = txt_exemplaire_reference.Text;
                sql_cmd_ajouter.Parameters["exemplaire_commentaire"].Value = txt_commentaire.Text;
                sql_cmd_ajouter.Parameters["exemplaire_etat"].Value = cb_etat.Text;
                sql_cmd_ajouter.Parameters["ouvrage_isbn"].Value = txt_isbn.Text;
            }
            catch
            {

            }
        }
        private void cmd_modifier_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommand sql_cmd_ajouter = new MySqlCommand();
            sql_cmd_ajouter.CommandText = "exemplaire_modifier_etat_exemplaire";
            sql_cmd_ajouter.CommandType = CommandType.StoredProcedure;
            sql_cmd_ajouter.Connection = connection;

            sql_cmd_ajouter.Parameters.Add(new MySqlParameter("exemplaire_etat", MySqlDbType.String));
            sql_cmd_ajouter.Parameters.Add(new MySqlParameter("ouvrage_isbn", MySqlDbType.String));

            try
            {
                sql_cmd_ajouter.Parameters["exemplaire_etat"].Value = cb_etat.Text;
                sql_cmd_ajouter.Parameters["ouvrage_isbn"].Value = txt_isbn.Text;
            }
            catch
            {

            }
        }
        private void cmd_supprimer_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommand sql_cmd_ajouter = new MySqlCommand();
            sql_cmd_ajouter.CommandText = "exemplaire_suppresion_exemplaire";
            sql_cmd_ajouter.CommandType = CommandType.StoredProcedure;
            sql_cmd_ajouter.Connection = connection;

            sql_cmd_ajouter.Parameters.Add(new MySqlParameter("exemplaire_reference", MySqlDbType.String));
            sql_cmd_ajouter.Parameters.Add(new MySqlParameter("ouvrage_isbn", MySqlDbType.String));

            try
            {
                sql_cmd_ajouter.Parameters["exemplaire_reference"].Value = txt_exemplaire_reference.Text;
                sql_cmd_ajouter.Parameters["ouvrage_isbn"].Value = txt_isbn.Text;
            }
            catch
            {

            }
        }
        private void cmd_rechercher_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommand sql_cmd_ajouter = new MySqlCommand();
            sql_cmd_ajouter.CommandText = "exemplaire_rechercher_exemplaire";
            sql_cmd_ajouter.CommandType = CommandType.StoredProcedure;
            sql_cmd_ajouter.Connection = connection;

            sql_cmd_ajouter.Parameters.Add(new MySqlParameter("ouvrage_isbn", MySqlDbType.String));

            try
            {
                sql_cmd_ajouter.Parameters["ouvrage_isbn"].Value = txt_isbn.Text;
            }
            catch
            {

            }
        }
    }
}

