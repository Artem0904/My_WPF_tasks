using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace _03_Bindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel viewModel = new();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = viewModel;

        }
    }

    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class ViewModel
    {

        public byte AlphaValue { get; set; }
        public byte RedVlue { get; set; }
        public byte GreenValue { get; set; }
        public byte BlueValue { get; set; }

        public Color color => Color.FromArgb(AlphaValue, RedVlue, GreenValue, BlueValue);
        
       

    }

}
