using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
    /// Interaction logic for Levels.xaml
    /// </summary>
    public partial class Levels : Page
    {
            
        private readonly List<Level> levels;
        public Levels()
        {
            InitializeComponent();
            levels = new List<Level>
            {
                new Level { Name = "Level 1", Description = "Pursuit of Glory", IsCompleted = false },
                new Level { Name = "Level 2", Description = "Pursuit of Pride", IsCompleted = false },
                new Level { Name = "Level 3", Description = "Pursuit of Joy", IsCompleted = false },
                new Level { Name = "Level 4", Description = "Pursuit of Legacy", IsCompleted = false },
                new Level { Name = "Level 5", Description = "Pursuit of Peace", IsCompleted = false }
            };

            LevelListBox.ItemsSource = levels;
        }

        private void PlayLevel_Click(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element && element.DataContext is Level selectedLevel)
            {
                MessageBox.Show($"Starting {selectedLevel.Name}");
                switch (selectedLevel.Name)
                {
                    case "Level 1":
                        
                        this.NavigationService.Navigate(new Cutscene_Level_1());
                        break;

                    case "Level 2":
                        
                        this.NavigationService.Navigate(new Cutscene_Level_2());
                        break;

                    case "Level 3":
                        
                        this.NavigationService.Navigate(new Cutscene_Level_3());
                        break;

                    case "Level 4":
                        
                        this.NavigationService.Navigate(new Cutscene_Level_4());
                        break;

                    case "Level 5":
                        
                        this.NavigationService.Navigate(new Cutscene_Level_5());
                        break;

                }
               
                
            }
        }

        private void LevelListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    public class Level
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
    }

}
