using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MVVM_cyberforum.Infrastructure
{
    class OnPropertyChangedClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            string[] names = prop.Split("\\/\r \n()\"\'-".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            if (names.Length != 0)
                foreach (string _prp in names)
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_prp));
        }
        public void OnPropertyChanged(IEnumerable<string> propList)
        {
            foreach (string _prp in propList.Where(name => !string.IsNullOrWhiteSpace(name)))
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_prp));
        }
        public void OnPropertyChanged(IEnumerable<PropertyInfo> propList)
        {
            foreach (PropertyInfo _prp in propList)
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_prp.Name));
        }
        public void OnAllPropertyChanged() => OnPropertyChanged(GetType().GetProperties());
    }
}
