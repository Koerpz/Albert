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
    /// Interaction logic for Combat_Level_1.xaml
    /// </summary>
    public partial class Combat_Level_1 : Page
    {
        private int playerHealth = 100;
        private int enemyHealth = 100;
        private bool playerTurn = true;
        private int playerAttackPower = 10;
        private int playerDefensePower = 0;
       

        public Combat_Level_1()
        {
            InitializeComponent();
            EquipWeapons(Window1.SelectedEquipments); 
            UpdateStatus("Your turn! Choose an action.");
        }
        private void EquipWeapons(List<Equipment> equipments)
        {
            foreach (var equipment in equipments)
            {
                playerAttackPower += equipment.Attack;
                playerDefensePower += equipment.Defense;
            }
        }

        private void UpdateStatus(string message)
        {
            StatusText.Text = message;
        }

        private void AttackButton_Click(object sender, RoutedEventArgs e)
        {
            if (playerTurn)
            {
                enemyHealth -= playerAttackPower; 
                EnemyHealthText.Text = enemyHealth.ToString();
                UpdateStatus("You attacked the enemy!");
                if (enemyHealth <= 0)
                {
                    MessageBox.Show("You defeated the Witch!");
                    this.NavigationService.Navigate(new VictoryPage());
                    return;
                }
                playerTurn = false;
                EnemyTurn();
            }
        }

        private void DefendButton_Click(object sender, RoutedEventArgs e)
        {
            if (playerTurn)
            {
                UpdateStatus("You defended!");
                playerTurn = false;
                EnemyTurn();
            }
        }

        private void HealButton_Click(object sender, RoutedEventArgs e)
        {
            if (playerTurn)
            {
                playerHealth = Math.Min(playerHealth + 20, 100);
                PlayerHealthText.Text = playerHealth.ToString();
                UpdateStatus("You healed!");
                playerTurn = false;
                EnemyTurn();
            }
        }

        private void EnemyTurn()
        {
            UpdateStatus("Enemy's turn...");

            System.Threading.Tasks.Task.Delay(1000).ContinueWith(_ =>
            {
                Dispatcher.Invoke(() =>
                {
                    playerHealth -= Math.Max(0, 10 - playerDefensePower); 
                    PlayerHealthText.Text = playerHealth.ToString();
                    if (playerHealth <= 0)
                    {
                        MessageBox.Show("You were defeated by the Witch.");
                        this.NavigationService.Navigate(new GameOverPage());
                        return;
                    }
                    playerTurn = true;
                    UpdateStatus("Your turn! Choose an action.");





                });
            });
        }
    }
}