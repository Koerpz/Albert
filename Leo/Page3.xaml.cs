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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();

            var iventoryItems = new List<InventoryItem>
            {
                new InventoryItem { Icon = "path/to/icon1.png", Name = "Gold Bar", Quantity = 1 },
                new InventoryItem { Icon = "path/to/icon2.png", Name = "Coins", Quantity = 5 }
            };
            InventoryListBox.ItemsSource = iventoryItems;


        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    public class InventoryItem
    {
        public string Icon { get; set; } = "default/path.png";
        public string Name { get; set; } = "Default Item";
        public int Quantity { get; set; }
    }
}
