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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();

            var equipmentItems = new List<Equipment>
            {
                 new Equipment { Name = "Sword" , Type = "Weapon", Icon = "/Assets/sword.png", Attack = 10, Defense = 0 },
                 new Equipment { Name = "Shield", Type = "Armor", Icon = "/Assets/shield.png", Attack = 0, Defense = 10 },
                 new Equipment { Name = "Helmet", Type = "Armor", Icon = "/Assets/helmet.png", Attack = 0, Defense = 10}
            };
            EquipmentListBox.ItemsSource = equipmentItems;
        }
        public class Equipment
        {
            public string Name { get; set; } = string.Empty;
            public string Type { get; set; } = string.Empty;
            public string Icon { get; set; } = string.Empty;
            public int Attack { get; set; }
            public int Defense { get; set; }
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void EquipmentListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
