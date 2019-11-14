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
    /// Logique d'interaction pour New_Mdp.xaml
    /// </summary>
    public partial class New_Mdp : Window
    {
        public New_Mdp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (pb_Newmdp.Password != pb_NewmdpVerif.Password)
            {
                MessageBox.Show("Veuillez saisir le même mot de passe !");
            }
            else
            {
                Connexion fene = new Connexion();
                fene.Show();
                this.Close();
            }
        }
    }
}
