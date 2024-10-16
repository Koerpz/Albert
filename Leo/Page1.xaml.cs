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

namespace Leo
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            var abilities = new List<Ability>
            {
                new Ability { Name = "Fiery Sword", Description = "Sword catches fire leading to extra damage.", Cooldown = 5, EnergyCost = 20, Icon = "/Assets/fierysword.jpg" },
                new Ability { Name = "Shield Block", Description = "Blocks incoming attacks.", Cooldown = 10, EnergyCost = 15 , Icon = "/Assets/blockingshield.jpg" },
            };
            AbilitiesListBox.ItemsSource = abilities;
        }
        public class Ability
        {
            public string Name { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public int Cooldown { get; set; }
            public int EnergyCost { get; set; }
            public string Icon { get; set; } = string.Empty;
        }


        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AbilitiesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
