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
using static Leo.Page2;

namespace Leo
{
    /// <summary>
    /// Interaction logic for GameOverPage.xaml
    /// </summary>
    public partial class GameOverPage : Page
    {
        public GameOverPage()
        {
            InitializeComponent();
        }
        private void Retry_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Combat_Level_1());
        }

        private void MainMenu_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Levels());
        }
    }
}
