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

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GridMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemEditeur":
                    gestion_utilisateur unUtilisateur = new gestion_utilisateur();
                    GridMain.Children.Add(unUtilisateur);
                    break;
                case "ItemOuvrage":
                    gestion_ouvrage unOuvrage = new gestion_ouvrage();
                    GridMain.Children.Add(unOuvrage);
                    break;
                case "ItemExemplaire":
                    gestion_exemplaire unExemplaire = new gestion_exemplaire();
                    GridMain.Children.Add(unExemplaire);
                    break;
                default:
                    break;
            }
        }
    }
    }

