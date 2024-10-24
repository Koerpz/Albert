using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Leo
{
    public partial class Page2 : Page
    {
        private Equipment? selectedEquipment; 

        public Page2()
        {
            InitializeComponent();
            var equipmentItems = new List<Equipment>
            {
                new Equipment { Name = "Sword", Type = "Weapon", Icon = "/Assets/sword.png", Attack = 20, Defense = 10 },
                new Equipment { Name = "Spear", Type = "Weapon", Icon = "/Assets/spear.png", Attack = 30, Defense = 5 }
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

        private void EquipmentListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EquipmentListBox.SelectedItem is Equipment equipment)
            {
                selectedEquipment = equipment;
                MessageBox.Show($"Selected: {selectedEquipment.Name}");
            }
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedEquipment != null)
            {
                Window1.SelectedEquipment = selectedEquipment; 
                MessageBox.Show("Equipment confirmed!");
            }
            else
            {
                MessageBox.Show("Please select equipment first.");
            }
        }
    }
}
