﻿using System;
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
    /// Logique d'interaction pour Connexion.xaml
    /// </summary>
    public partial class Connexion : Window
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            New_Mdp fenetre = new New_Mdp();
            fenetre.Show();
            this.Close();
        }

        private void Btn_connexion_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}