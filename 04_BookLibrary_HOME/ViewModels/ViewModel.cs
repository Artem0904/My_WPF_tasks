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
        public Book book1 = new Book("Wow", "dsgsdsdkjghsdghsdsifhsdxlsnhgksggggggggggggdlghdkjghsfgkljsdghkjghskghskghkfghjfghskgjsdf", "Authooor", new DateOnly(2001, 6, 5));
        public Book book2 = new Book("Wow", "dsgsdstretdkjghsdghsdsifhsdxlsnhgksdlghdkjghsfgkljsdghkjghskghskghkfghjfghskgjsdf", "Authooor", new DateOnly(2001, 6, 5));
        public Book book3 = new Book("Wow", "dsgsdsfdsfdgfgdkjghsdghsdsifhsdxlsnhgksdlghdkjghsfgkljsdghkjghskghskghkfghjfghskgjsdf", "Authooor", new DateOnly(2001, 6, 5));
        private ObservableCollection<Book> library = new ObservableCollection<Book> { };
        public IEnumerable<Book> Library => library;

        private int CurrentBook = 0;
        public Book SelectedBook { get; set; }
        public void add()
        {
            library.Add(book1);
            library.Add(book2);
            library.Add(book3);
        }

        public void Next()
        {
            if(CurrentBook != library.Count)
            {
                SelectedBook = library[CurrentBook];
                CurrentBook++;
            }
        }

        public void Prev()
        {
            if(CurrentBook != 0)
            {
                SelectedBook = library[CurrentBook];
                CurrentBook--;
            }
        }
    }
}
