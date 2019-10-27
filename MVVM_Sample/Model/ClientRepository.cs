using System;
using System.Collections.ObjectModel;

namespace MVVM_Sample.Model
{
    class ClientRepository
    {
        private static ObservableCollection<Client> _clients;
        public static ObservableCollection<Client> AllClients
        {
            get
            {
                if(_clients==null)
                {
                    _clients = GenerateClientRepository();
                }
                return _clients;
            }
        }

        private static ObservableCollection<Client> GenerateClientRepository()
        {
            ObservableCollection<Client> clients = new ObservableCollection<Client>();
            clients.Add(new Client("Jhon", "Doe"));
            clients.Add(new Client("Tom", "Ronald"));
            clients.Add(new Client("Jane", "Roe"));
            return clients;
        }
    }
}
