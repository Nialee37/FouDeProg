using lib_funEnBulles;
using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour gestion_utilisateur.xaml
    /// </summary>
    public partial class gestion_utilisateur : UserControl
    {
        public gestion_utilisateur()
        {
            InitializeComponent();
        }

        private void Btn_Ajouter_Click(object sender, RoutedEventArgs e)
        {
            Ouvrage unOubrage = new Ouvrage(txt_isbn.Text, txt_Titre.Text, int.Parse(txt_numTome.Text), txt_resume.Text, cb_format.Text, txt_image.Text, int.Parse(txt_nbrPage.Text), DateTime.Parse(dp_dateParution.Text), DateTime.Parse(dp_dateCreation.Text), txt_categorie.Text, txt_Genre.Text, double.Parse(txt_prixUnite.Text));
        }
    }
}
