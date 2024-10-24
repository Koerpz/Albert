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
    /// Interaction logic for Cutscene_Level_2.xaml
    /// </summary>
    public partial class Cutscene_Level_2 : Page
    {
        private List<string> textSequence = new List<string>();
        private int currentTextIndex;
        public Cutscene_Level_2()
        {
            InitializeComponent();
            InitializeTextSequence();
        }

        private void InitializeTextSequence()
        {
            textSequence = new List<string>
            {
                "With the village curse lifted, Albert’s fame spread far and wide...",
                "Warriors from distant lands challenged Albert to prove his strength...",
                "Driven by pride, Albert took on these challenges, seeking to become the greatest warrior known...",
                "However, pride comes with a price, and Albert is about to face his fiercest rival yet...",
                "Prepare yourself, Albert. Your pride will be tested in combat..."
            };
            currentTextIndex = 0;
            DisplayCurrentText();
        }
        private void DisplayCurrentText()
        {
            if (currentTextIndex < textSequence.Count)
            {
                CutsceneTextBlock.Text = textSequence[currentTextIndex];
                currentTextIndex++;
            }
            else
            {
                ContinueButton.Visibility = Visibility.Visible;
            }
        }
        private void CutsceneGrid_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DisplayCurrentText();
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            Equipment selectedEquipment = Window1.SelectedEquipment ?? new Equipment { Name = "Sword", Attack = 10, Defense = 0 };
            this.NavigationService.Navigate(new Combat_Level_2(selectedEquipment));  
        }
    }
}
