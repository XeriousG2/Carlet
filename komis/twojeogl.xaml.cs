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
    /// Logika interakcji dla klasy twojeogl.xaml
    /// </summary>
    public partial class twojeogl : Page
    {
        public twojeogl()
        {
            InitializeComponent();
        }
        private void CreateViewImageDynamically()
        {
            // Create Image and set its width and height  
            Image dynamicImage = new Image();
            dynamicImage.Width = 300;
            dynamicImage.Height = 200;

            // Create a BitmapSource  
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Books\Book WPF\How do I\ImageSample\ImageSample\Flower.JPG");
            bitmap.EndInit();

            // Set Image.Source  
            dynamicImage.Source = bitmap;

           
        }
    }
}
