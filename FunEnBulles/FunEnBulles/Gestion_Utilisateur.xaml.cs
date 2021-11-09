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
using lib_funEnBulles2;
using lib_funEnBulles;

namespace FunEnBulles
{
    /// <summary>
    /// Logique d'interaction pour Gestion_Utilisateur.xaml
    /// </summary>
    public partial class Gestion_Utilisateur : Window
    {
        public Gestion_Utilisateur()
        {
            InitializeComponent();
            datagrid_listing.IsReadOnly = true;

            Vue_Model_Utilisateur vm_utilisateur = new Vue_Model_Utilisateur();
            datagrid_listing.ItemsSource = vm_utilisateur.Afficher_Utilisateur();

            Actualiser_Combobox();
        }

        private void cmd_ajouter(object sender, RoutedEventArgs e)
        {
            
            string numeroCarte = txt_matricule.Text;
            string nom = txt_nom.Text;
            string prenom = txt_prenom.Text;
            string ville = txt_ville.Text;
            string codePostal = txt_code_postal.Text;
            string adresse = txt_adresse.Text;
            string telephone = txt_telephone.Text;
            string email = txt_email.Text;
            string pseudo = txt_pseudonyme.Text;
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

            if(!(String.IsNullOrWhiteSpace(numeroCarte) || String.IsNullOrWhiteSpace(nom) || String.IsNullOrWhiteSpace(prenom) || String.IsNullOrWhiteSpace(ville) || String.IsNullOrWhiteSpace(codePostal) || String.IsNullOrWhiteSpace(adresse) || String.IsNullOrWhiteSpace(telephone) || String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(pseudo) || dateValide))
            {
                // Champs valides
                Console.WriteLine("Champs valides");
                Utilisateur unUtilisateur = new Utilisateur(numeroCarte, nom, prenom, ville, codePostal, adresse, telephone, email, pseudo, dateNaissance);
                Vue_Model_Utilisateur vm_utilisateur = new Vue_Model_Utilisateur(unUtilisateur);
                vm_utilisateur.Ajout_Utilisateur();
            }
            else
            {
                // Champs invalides
                Console.WriteLine("Champs invalides");
                MessageBox.Show("Un ou plusieurs champs sont invalides");
            }
        }

        private void Btn_actualiser_Click(object sender, RoutedEventArgs e)
        {
            Vue_Model_Utilisateur vm_utilisateur = new Vue_Model_Utilisateur();
            datagrid_listing.ItemsSource = vm_utilisateur.Afficher_Utilisateur();
        }

        private void Btn_supprimer_Click(object sender, RoutedEventArgs e)
        {
            Vue_Model_Utilisateur vm_utilisateur = new Vue_Model_Utilisateur();

            DataGridCellInfo cellInfo = datagrid_listing.SelectedCells[0];
            String content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            vm_utilisateur.Supprimer_Utilisateur(int.Parse(content));
            Console.WriteLine(content);
        }

        private void Btn_modifier_Click(object sender, RoutedEventArgs e)
        {
            DataGridCellInfo cellInfo = datagrid_listing.SelectedCells[0];
            String content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            Modifier newForm = new Modifier(int.Parse(content));
            newForm.Show();
            //this.Hide();
        }

        private void Rdo_membre_famille_Unchecked(object sender, RoutedEventArgs e) // Chef de famille sélectionné
        {
            try { 
                cb_nom_chef_famille.Visibility = Visibility.Collapsed;
            }
            catch
            {

            }
        }

        private void Rdo_chef_famille_Unchecked(object sender, RoutedEventArgs e) // Membre de famille sélectionné
        {
            Actualiser_Combobox();
        }

        private void Actualiser_Combobox()
        {
            try
            {
                cb_nom_chef_famille.Visibility = Visibility.Visible;
                cb_nom_chef_famille.Items.Clear();
                Vue_Model_Utilisateur vm_utilisateur = new Vue_Model_Utilisateur();
                List<DataRow> list = vm_utilisateur.Afficher_Chef_Famille();

                
                cb_nom_chef_famille.Items.Add("-");
                cb_nom_chef_famille.SelectedIndex = 0;
                int count = 0;
                foreach (DataRow dr in list)
                {
                    Console.WriteLine($"{dr.Table.Rows[count][0]} - {dr.Table.Rows[count][1]}");
                    String content = $"({dr.Table.Rows[count][0]}) {dr.Table.Rows[count][1]}";
                    cb_nom_chef_famille.Items.Add(content);
                    count++;
                }
            }
            catch
            {

            }
        }
    }
}
