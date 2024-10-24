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
                "In the peaceful village of Albertus, a young warrior dreamed of glory...",
                "He was named after the village, Albert.",
                "The village, cursed by an ancient spell, needed a hero...",
                "Armed with merely a sword and shield, Albert set out to lift the curse and gain fame and glory...",
                "His journey was fraught with danger, and now he faces his first formidable foe...",
                "The Witch"

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
