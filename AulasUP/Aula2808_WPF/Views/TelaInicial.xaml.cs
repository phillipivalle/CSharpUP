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

namespace Aula2808_WPF.Views
{
    /// <summary>
    /// Lógica interna para TelaInicial.xaml
    /// </summary>
    public partial class TelaInicial : Window
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btntela1(object sender, RoutedEventArgs e)
        {
            MainWindow minhatela1 = new MainWindow();

            minhatela1.Show();
        }

        private void btnTela2_Click(object sender, RoutedEventArgs e)
        {
            NewWindow minhatela2 = new NewWindow();
            minhatela2.ShowDialog();
        }
    }
}
