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

namespace Workshop_Manu
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

        public void test()
        {
            try
            {
                Kunde obj = new Kunde();
                ((Kunde)obj).setName(this.lblName.Content.ToString());
                this.lblName.Content = obj.getName();
                //String nameKunde = obj.getName();
            }
            catch (Exception e)
            {
               this.lblName.Content = e.ToString();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.test();
        }
        
    }
}
