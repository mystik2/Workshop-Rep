using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Registrierung_Einloggen_Miki;

namespace Registrierung_Einloggen_Miki
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btbRegistrieren_Click(object sender, RoutedEventArgs e)
        {
            User Benutzer1 = new User();

            Benutzer1.maxZeichenlaengeUsername(txtRegistrierUsername.ToString());
            Benutzer1.minZeichenlaengePassword(txtRegistrierPassword.ToString());

            MessageBox.Show("hier Username");
            MessageBox.Show("heir PW");
        }

       
    }
}
