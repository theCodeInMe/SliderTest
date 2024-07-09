using System.Windows;
using System.Windows.Media;

namespace SliderTest
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

        private void changeBackColor(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color hgb = Color.FromArgb((byte)alphaSlide.Value, (byte)redSlide.Value, (byte)blueSlide.Value, (byte)greenSlide.Value);
            Background = new SolidColorBrush(hgb);
        }
    }
}
