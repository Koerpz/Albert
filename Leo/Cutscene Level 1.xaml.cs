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
    /// Interaction logic for Cutscene_Level_1.xaml
    /// </summary>
    public partial class Cutscene_Level_1 : Page
    {
        private List<string> textSequence = new List<string>();
        private int currentTextIndex;

        public Cutscene_Level_1()
        {
            InitializeComponent();
            InitializeTextSequence();
        }
        private void InitializeTextSequence()
        {
            textSequence = new List<string>
            {
                "Once upon a time in the peaceful kingdom of Arisia...",
                "Darkness began to spread as the evil sorcerer Zoltar sought to plunge the world into chaos.",
                "A hero arises to challenge the darkness and restore peace."
                
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
                // All texts shown, navigate to the next page or end the cutscene
                Continue_Click(this, new RoutedEventArgs());
            }
        }
        private void CutsceneGrid_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DisplayCurrentText();
        }
        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Combat_Level_1());
        }
    }
}
