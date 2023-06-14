using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_BookLibrary_HOME.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    internal class ViewModel
    {
        private ObservableCollection<Book> library = new ObservableCollection<Book>();

        public IEnumerable<Book> Library => library;

        public Book SelectedBook { get; set; }

    }
}
