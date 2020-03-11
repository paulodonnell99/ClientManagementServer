using ClientManagement.Data.Infrastructure;
using ClientManagement.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Data.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public Client GetClientById(int clientId)
        {
            return this.DbContext.Clients.Find(clientId);
        }

        public DateTime GetRegistrationDate(int clientId)
        {
            throw new NotImplementedException();
        }

        public override void Update(Client client)
        {
            client.DateRegistered = DateTime.Now;
            base.Update(client);
        }
    }
}
