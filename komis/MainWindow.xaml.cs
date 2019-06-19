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
    /// Dzięki tej klasie możemy używać przycisków w nawigacji
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        /// Przez tą metode po klkiknięciu w przycisk "AUDI" przenosimy się do strony o nazwie "audi1"
        
        private void AUDI(object sender, RoutedEventArgs e)
        {
            Main.Content = new audi1();
          
        }

        /// Przez tą metode po klkiknięciu w przycisk "VLOKSWAGEN" przenosimy się do strony o nazwie "volks"

        private void VOLKSWAGEN(object sender, RoutedEventArgs e)
        {
            Main.Content = new volks();
          
        }

        /// Przez tą metode po klkiknięciu w przycisk "SEAT" przenosimy się do strony o nazwie "seat"

        private void SEAT(object sender, RoutedEventArgs e)
        {
            Main.Content = new seat();
         
        }

        /// Przez tą metode po klkiknięciu w przycisk "FIAT" przenosimy się do strony o nazwie "fiat"

        private void FIAT(object sender, RoutedEventArgs e)
        {
            Main.Content = new fiat();
            
        }

    }
}
