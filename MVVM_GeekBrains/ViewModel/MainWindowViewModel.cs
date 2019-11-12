using MVVM_GeekBrains.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_GeekBrains.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        Book[] books;
        public Book[] Books { get; private set; }
        public MainWindowViewModel()
        {
            Books = 
        }
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
