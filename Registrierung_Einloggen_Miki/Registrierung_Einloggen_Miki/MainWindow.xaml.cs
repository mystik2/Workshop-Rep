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
using System.Windows.Forms;
using System.Data;



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

            Benutzer1.maxZeichenlaengeUsername(txtRegistrierUsername.Text);
            Benutzer1.minZeichenlaengePassword(txtRegistrierPassword.Text);
            
           //System.Windows.Forms.MessageBox.Show(Benutzer1.getUsername());
           //System.Windows.Forms.MessageBox.Show(Benutzer1.getPassword());

           //Tabellen DT = new Tabellen();
           //Tabellen.GetTable(Benutzer1.getUsername(), Benutzer1.getPassword());,

            DataTable table = new DataTable();
            table.Columns.Add("Username", typeof(String));
            table.Columns.Add("Password", typeof(String));

            table.Rows.Add(Benutzer1.getUsername(), Benutzer1.getPassword());
        }

      

        private void btbLogin_Click(object sender, RoutedEventArgs e)
        {
           
        }

       
       
    }
}
