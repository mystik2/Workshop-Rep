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

namespace Taschenrechner_Miki_WPF
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

        int Zahl1;
        int Zahl2;
        int[] Zahlenreihe;

        private void btCE_Click(object sender, RoutedEventArgs e)
        {
            txtRechnen.Text = null;
            txtErgebnis.Text = null;
        }

        private void btAddieren_Click(object sender, RoutedEventArgs e)
        {
            this.Zahl1 = Convert.ToInt32(txtRechnen.Text);
            Zahlenreihe [0] = Zahl1;
            txtRechnen.Text = (Zahl1.ToString() + " + ");
        }

        private void btSubtraktion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btMultiplikation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btDivision_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btErgebnis_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
