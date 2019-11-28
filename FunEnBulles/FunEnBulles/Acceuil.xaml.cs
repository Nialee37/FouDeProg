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
using System.Windows.Shapes;

namespace FunEnBulles
{
    /// <summary>
    /// Logique d'interaction pour Acceuil.xaml
    /// </summary>
    public partial class Acceuil : Window
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Connexion fenetre = new Connexion();
            fenetre.Show();
            this.Close();
        }
    }
}
