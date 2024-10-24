using System.Windows.Controls;
using System.Windows;

namespace Leo
{
    public partial class EndingSlide : Page
    {
        public EndingSlide()
        {
            InitializeComponent();
        }

        private void MainMenu_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new VictoryPage());
        }
    }
}
