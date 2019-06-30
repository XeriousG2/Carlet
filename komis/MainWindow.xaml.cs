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

        /// <summary>
        /// Przez tą metode po klkiknięciu w przycisk "AUDI" przenosimy się do strony o nazwie "audi1"
        /// Ten obiekt <paramref name="sender"> służy do identyfikacji, kto wywołał procedurę</paramref>
        /// <paramref name="e">Dowolny dodatkowy argument do wystąpienia zdarzenia</paramref>
        /// </summary>
        private void AUDI(object sender, RoutedEventArgs e)
        {
          
            Main.Content = new audi1();
          
        }

        /// <summary>
        /// Przez tą metode po klkiknięciu w przycisk "VLOKSWAGEN" przenosimy się do strony o nazwie "volks"
        /// Ten obiekt <paramref name="sender"> służy do identyfikacji, kto wywołał procedurę</paramref>
        /// <paramref name="e">Dowolny dodatkowy argument do wystąpienia zdarzenia</paramref>
        /// </summary>
        private void VOLKSWAGEN(object sender, RoutedEventArgs e)
        {

            Main.Content = new volks();
          
        }

        /// <summary>
        /// Przez tą metode po klkiknięciu w przycisk "SEAT" przenosimy się do strony o nazwie "seat"
        /// Ten obiekt <paramref name="sender"> służy do identyfikacji, kto wywołał procedurę</paramref>
        /// <paramref name="e">Dowolny dodatkowy argument do wystąpienia zdarzenia</paramref>
        /// </summary>
        private void SEAT(object sender, RoutedEventArgs e)
        {

            Main.Content = new seat();
         
        }

        /// <summary>
        /// Przez tą metode po klkiknięciu w przycisk "FIAT" przenosimy się do strony o nazwie "seat"
        /// Ten obiekt <paramref name="sender"> służy do identyfikacji, kto wywołał procedurę</paramref>
        /// <paramref name="e">Dowolny dodatkowy argument do wystąpienia zdarzenia</paramref>
        /// </summary>
        private void FIAT(object sender, RoutedEventArgs e)
        {

            Main.Content = new fiat();

        }

    }
}
