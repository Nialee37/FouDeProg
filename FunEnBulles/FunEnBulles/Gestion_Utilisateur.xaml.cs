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
            string pseudo = "a";
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
    }
}
