﻿using BeautySalonWPF.View.Pages;
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

namespace BeautySalonWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new AuthorizationPage());
        }

        private void LogOutButtonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Page currentPage = MainFrame.Content as Page;
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }
        }

        private void AuthButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
