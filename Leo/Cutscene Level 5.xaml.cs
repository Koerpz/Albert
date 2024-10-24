using static Leo.Page2;
using System.Windows.Controls;
using System.Windows;

namespace Leo
{
    public partial class Cutscene_Level_5 : Page
    {
        private List<string> textSequence = new List<string>();
        private int currentTextIndex;

        public Cutscene_Level_5()
        {
            InitializeComponent();
            InitializeTextSequence();
        }

        private void InitializeTextSequence()
        {
            textSequence = new List<string>
            {
                "Albert's journey brought him to the final chapter of his pursuit...",
                "With peace in his heart and a legacy in his wake, he knew this battle would define everything...",
                "The village depended on him to defeat the ultimate threat, the Peacekeeper Beast...",
                "This is the moment where history will be written, and peace will be restored once and for all..."
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
            this.NavigationService.Navigate(new Combat_Level_5(selectedEquipment));
        }
    }
}
