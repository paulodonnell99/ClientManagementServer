using ClientManagement.Data.Infrastructure;
using ClientManagement.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Data.Repositories
{
    public interface IClientRepository : IRepository<Client>
    {
        Client GetClientById(int clientId);
        DateTime GetRegistrationDate(int clientId);
    }
}
