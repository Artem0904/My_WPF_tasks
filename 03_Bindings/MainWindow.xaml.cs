using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace _03_Bindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel viewModel = new();
        ObservableCollection<Color> colors = new ObservableCollection<Color>();
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new ViewModel();
            this.DataContext = viewModel;
            ColorsListBox.ItemsSource= colors;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            colors.Add(viewModel.SelectedColor);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if(ColorsListBox.SelectedItem != null)
                colors.RemoveAt(ColorsListBox.SelectedIndex);
        }
    }
    
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class ViewModel
    {
        public byte AlphaValue { get; set; }
        public byte RedValue { get; set; }
        public byte GreenValue { get; set; }
        public byte BlueValue { get; set; }

        public Color SelectedColor => Color.FromArgb(AlphaValue, RedValue, GreenValue, BlueValue);

    }

}
