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

namespace _05_Schulte_Table
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameWindow gameWindow;
        public MainWindow()
        {
            InitializeComponent();
            gameWindow = new GameWindow();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            if(DificultySlider.Value == 0)
            {
                count = 9;
            }
            else if(DificultySlider.Value == 0)
            {
                count = 7;
            }
            else
            {
                count = 7;
            }
            gameWindow.ShowDialog();
            gameWindow.Close();
        }
    }
}
