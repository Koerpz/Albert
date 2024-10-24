using static Leo.Page2;
using System.Windows.Controls;
using System.Windows;

namespace Leo
{
    public partial class Cutscene_Level_3 : Page
    {
        private List<string> textSequence = new List<string>();
        private int currentTextIndex;

        public Cutscene_Level_3()
        {
            InitializeComponent();
            InitializeTextSequence();
        }

        private void InitializeTextSequence()
        {
            textSequence = new List<string>
            {
                "With pride overcome, Albert sought a deeper sense of fulfillment...",
                "He discovered joy not in battle, but in bringing light to those in need...",
                "Albert's journey led him to a village plagued by shadows...",
                "Determined to restore joy, he must face the cunning Shadow Beast..."
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
            this.NavigationService.Navigate(new Combat_Level_3(selectedEquipment));
        }
    }
}
