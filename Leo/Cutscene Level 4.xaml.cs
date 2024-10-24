using static Leo.Page2;
using System.Windows.Controls;
using System.Windows;

namespace Leo
{
    public partial class Cutscene_Level_4 : Page
    {
        private List<string> textSequence = new List<string>();
        private int currentTextIndex;

        public Cutscene_Level_4()
        {
            InitializeComponent();
            InitializeTextSequence();
        }

        private void InitializeTextSequence()
        {
            textSequence = new List<string>
            {
                "With joy restored to the village, Albert began to contemplate his legacy...",
                "He realized that true legacy is built not through glory, but through lasting peace...",
                "To protect his newfound peace, Albert must face the ancient Guardian Beast...",
                "This final trial will define his legacy for generations to come..."
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
            this.NavigationService.Navigate(new Combat_Level_4(selectedEquipment));
        }
    }
}
