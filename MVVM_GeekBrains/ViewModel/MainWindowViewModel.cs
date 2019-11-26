using MVVM_GeekBrains.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_GeekBrains.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        Book[] books;
        Book selectedBook;
        public ObservableCollection<Book> Books { get; private set; }
        public Book SelectedBook
        {
            get { return selectedBook; }
            set { selectedBook = value; OnPropertyChanged("SelectedBook"); }
        }
        public ICommand AddCommand { get; private set; }
        public ICommand RemoveCommand { get; private set; }
        public MainWindowViewModel()
        {
            Books = new ObservableCollection<Book>(Book.GetBooks());
            AddCommand = new DelegateCommand(AddBook);
            RemoveCommand = new DelegateCommand(RemoveBook, CanRemoveBook);
        }

        private bool CanRemoveBook(object arg)
        {
            return (arg as Book) != null;
        }

        private void RemoveBook(object obj)
        {
            Books.Remove((Book)obj);
        }

        private void AddBook(object obj)
        {
            Books.Add(new Book { Author = "Автор", Title = "Новая книга" });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
