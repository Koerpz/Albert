﻿using System;
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
using System.Windows.Shapes;

namespace Leo
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();

            // Achtergrond instellen naar een afbeelding vanuit de resources
            ImageBrush brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Assets/achtergrond.jpg"));

            // Stel de achtergrond van het huidige Window in
            this.Background = brush;  // 'this' verwijst naar het huidige venster
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Window1 = new Window1();
            Window1.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page1();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page2();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page3();
        }

        private void Main_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

    }

}
