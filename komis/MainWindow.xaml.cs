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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace komis
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        
        private void AUDI(object sender, RoutedEventArgs e)
        {
            Main.Content = new audi1();
          
        }

        private void VOLKSWAGEN(object sender, RoutedEventArgs e)
        {
            Main.Content = new volks();
          
        }

        private void SEAT(object sender, RoutedEventArgs e)
        {
            Main.Content = new seat();
         
        }

        private void FIAT(object sender, RoutedEventArgs e)
        {
            Main.Content = new fiat();
            
        }

        private void ogloszenie(object sender, RoutedEventArgs e)
        {
            Main.Content = new ogloszenie();
        }
    }
}
