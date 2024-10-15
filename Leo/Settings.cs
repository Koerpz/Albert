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

namespace Leo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///     public partial class MainWindow : Window
    public partial class Settings : Window
    {
        public Settings() => InitializeComponent();


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }
    }
}