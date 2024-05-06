﻿using System.Windows;
using System.Windows.Controls;

namespace Task5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog dialog = new();

            if (dialog.ShowDialog() == true)
                dialog.PrintVisual(printCanvas, "описание");
            MessageBox.Show("Картинка сохранена!", "Печать", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}