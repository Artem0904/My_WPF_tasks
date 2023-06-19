﻿using _04_BookLibrary_HOME.ViewModels;
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

namespace _04_BookLibrary_HOME
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel viewModel = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = viewModel;
            viewModel.Init();
            LibraryListBox.ItemsSource = viewModel.Library;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Next();
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Prev();   
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
