using static Leo.Page2;
using System.Windows.Controls;
using System.Windows;

namespace Leo
{
    public partial class Combat_Level_2 : Page
    {
        private int playerHealth = 100;
        private int enemyHealth = 150;
        private bool playerTurn = true;
        private int playerAttackPower = 10;
        private int playerDefensePower = 0;
        private bool fierySwordUsed = false;
        private bool spearThrowUsed = false;
        private string? equippedWeapon;

        public Combat_Level_2(Equipment equipment)
        {
            InitializeComponent();
            EquipWeapon(equipment);
            UpdateStatus("Your turn! Choose an action.");
        }

        private void EquipWeapon(Equipment? weapon)
        {
            if (weapon != null)
            {
                playerAttackPower = weapon.Attack;
                playerDefensePower = weapon.Defense;
                equippedWeapon = weapon.Name;
            }
            else
            {
                playerAttackPower = 10; 
                playerDefensePower = 0; 
                equippedWeapon = "None";
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
                UpdateStatus("You attacked the Dragon!");
                if (enemyHealth <= 0)
                {
                    MessageBox.Show("You defeated the Dragon!");
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

        private void FierySwordButton_Click(object sender, RoutedEventArgs e)
        {
            if (playerTurn && !fierySwordUsed && equippedWeapon == "Sword")
            {
                enemyHealth -= playerAttackPower * 2;
                EnemyHealthText.Text = enemyHealth.ToString();
                fierySwordUsed = true;
                UpdateStatus("You used Fiery Sword on the Dragon!");
                if (enemyHealth <= 0)
                {
                    MessageBox.Show("You defeated the Dragon!");
                    this.NavigationService.Navigate(new VictoryPage());
                    return;
                }
                playerTurn = false;
                EnemyTurn();
            }
            else if (playerTurn && equippedWeapon != "Sword")
            {
                UpdateStatus("Fiery Sword can only be used with a sword!");
            }
            else if (playerTurn && fierySwordUsed)
            {
                UpdateStatus("Fiery Sword can only be used once!");
            }
        }

        private void SpearThrowButton_Click(object sender, RoutedEventArgs e)
        {
            if (playerTurn && !spearThrowUsed && equippedWeapon == "Spear")
            {
                enemyHealth -= playerAttackPower * 2;
                EnemyHealthText.Text = enemyHealth.ToString();
                spearThrowUsed = true;
                UpdateStatus("You used Spear Throw on the Dragon!");
                if (enemyHealth <= 0)
                {
                    MessageBox.Show("You defeated the Dragon!");
                    this.NavigationService.Navigate(new VictoryPage());
                    return;
                }
                playerTurn = true;
                UpdateStatus("Your turn! Choose an action.");
            }
            else if (playerTurn && equippedWeapon != "Spear")
            {
                UpdateStatus("Spear Throw can only be used with a spear!");
            }
            else if (playerTurn && spearThrowUsed)
            {
                UpdateStatus("Spear Throw can only be used once!");
            }
        }

        private void EnemyTurn()
        {
            UpdateStatus("Dragon's turn...");
            System.Threading.Tasks.Task.Delay(1000).ContinueWith(_ =>
            {
                Dispatcher.Invoke(() =>
                {
                    playerHealth -= Math.Max(0, 15 - playerDefensePower);
                    PlayerHealthText.Text = playerHealth.ToString();
                    if (playerHealth <= 0)
                    {
                        MessageBox.Show("You were defeated by the Dragon.");
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
