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
using myStik.Default;
using System.Data;

namespace Miki_SQLSchnittstelle_und_Klassen
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
       
        //Alles folgende ist zu testzwecken programmiert.
        private void btbAbschickenUser_Click(object sender, RoutedEventArgs e)
        {
            //User.writeToDB(txtNachname.Text, txtVorname.Text, "d", "d", "d", "d");

        }

        private void btbAbrufenUser_Click(object sender, RoutedEventArgs e)
        {
            User Benutzer1 = new User(Convert.ToInt32(txtUserID.Text));
            MessageBox.Show("Der Benutzer heißt " + Benutzer1.getNachname() + " " + Benutzer1.getVorname());
        }

        private void btbAbschickenProdukt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btbChangeAbschicken_Click(object sender, RoutedEventArgs e)
        {
            User Benutzer1 = new User(Convert.ToInt32(txtUserID.Text));

            Benutzer1.changeNameInDB(txtChangeNachname.Text, txtChangeVorname.Text, Convert.ToInt32(txtUserID.Text));
        }

        
    }
}
