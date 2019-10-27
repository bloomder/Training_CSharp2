using MVVM_Sample.Infrasrtucture;
using MVVM_Sample.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MVVM_Sample.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        Client _currentClient;
        public Client CurrentClient
        {
            get
            {
                if (_currentClient == null)
                    _currentClient = new Client();
                return _currentClient;
            }
            set
            {
                _currentClient = value;
                OnPropertyChanged("CurrentClient");
            }
        }

        ObservableCollection<Client> _clients;
        public ObservableCollection<Client> Clients
        {
            get
            {
                if (_clients == null)
                    _clients = ClientRepository.AllClients;
                return _clients;
            }
        }

        RelayCommand _addClientCommand;
        public ICommand AddClient
        {
            get
            {
                if (_addClientCommand == null)
                    _addClientCommand = new RelayCommand(ExecuteAddClientCommand, CanExecuteAddClientCommand);
                return _addClientCommand;
            }
        }

        public void ExecuteAddClientCommand(object parameter)
        {
            Clients.Add(CurrentClient);
            CurrentClient = null;
        }
        public bool CanExecuteAddClientCommand(object parameter)
        {
            if (string.IsNullOrEmpty(CurrentClient.FirstName) ||
                string.IsNullOrEmpty(CurrentClient.LastName))
                return false;
            return true;
        }

        protected override void OnDispose()
        {
            this.Clients.Clear();
        }

        private void OnPropertyChanged(string v)
        {
            throw new NotImplementedException();
        }
    }
}
