using lib_funEnBulles2;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace FunEnBulles
{
    /// <summary>
    /// Logique d'interaction pour Modifier.xaml
    /// </summary>
    public partial class Modifier : Window
    {
        public Modifier(int matricule)
        {
            InitializeComponent();
            Console.WriteLine($"Form modifier ouverte - Matricule : {matricule}");

            Vue_Model_Utilisateur vm_utilisateur = new Vue_Model_Utilisateur();
            List<DataRow> list = vm_utilisateur.Afficher_Utilisateur_Matricule(matricule);

            Console.WriteLine(list[0].ItemArray[0].ToString());
            foreach(var str in list[0].ItemArray)
            {
                Console.WriteLine(str);
            }

            txt_matricule.Text = list[0].ItemArray[0].ToString();
            txt_nom.Text = list[0].ItemArray[1].ToString();
            txt_prenom.Text = list[0].ItemArray[2].ToString();
            txt_ville.Text = list[0].ItemArray[3].ToString();
            txt_code_postal.Text = list[0].ItemArray[4].ToString();
            txt_adresse.Text = list[0].ItemArray[5].ToString();
            txt_telephone.Text = list[0].ItemArray[6].ToString();
            txt_date_naissance.Text = list[0].ItemArray[7].ToString();
            txt_email.Text = list[0].ItemArray[8].ToString();
            txt_pseudonyme.Text = list[0].ItemArray[9].ToString();
        }
    }
}
