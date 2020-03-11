using ClientManagement.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Service
{
    public interface IClientService
    {
        IEnumerable<Client> GetClients();
        Client GetClientById(int id);
        void CreateClient(Client client);
        void SaveClient();
    }
}
