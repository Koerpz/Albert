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
        private List<Equipment> selectedEquipments = new List<Equipment>(); 
        public Page2()
        {
            InitializeComponent();

            var equipmentItems = new List<Equipment>
            {
                 new Equipment { Name = "Sword and Shield" , Icon = "/Assets/sword.png", Attack = 20, Defense = 10 },
                 new Equipment { Name = "Spear and Shield", Icon = "/Assets/shield.png", Attack = 30, Defense = 5 },

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
            selectedEquipments.Clear();
            foreach (var item in EquipmentListBox.SelectedItems)
            {
                if (item is Equipment equipment)
                {
                    selectedEquipments.Add(equipment);
                }
            }
            MessageBox.Show($"Selected {selectedEquipments.Count} items.");
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            Window1.SelectedEquipments = selectedEquipments; 
            MessageBox.Show("Equipments confirmed!");
        }


    }
}
