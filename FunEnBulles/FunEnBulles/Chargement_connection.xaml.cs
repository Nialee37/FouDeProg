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
    /// Logique d'interaction pour Chargement_connection.xaml
    /// </summary>
    public partial class Chargement_connection : Window
    {
        public Chargement_connection()
        {
            InitializeComponent();
        }
        private void gif_MediaEnded(object sender, RoutedEventArgs e)
        {
            gif.Position = new TimeSpan(0, 0, 1);
            gif.Play();
        }
    }
}
