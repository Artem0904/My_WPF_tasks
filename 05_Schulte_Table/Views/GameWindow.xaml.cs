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

namespace _05_Schulte_Table
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        int count = 5;
        GameViewModel gameViewModel = new GameViewModel();
        public GameWindow(int count)
        {
            InitializeComponent();
            this.count = count;
            this.DataContext = gameViewModel;
        }
    }
}
