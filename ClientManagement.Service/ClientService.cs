using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientManagement.Data.Infrastructure;
using ClientManagement.Data.Repositories;
using ClientManagement.Model.Models;

namespace ClientManagement.Service
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository clientRepository;
        private readonly IUnitOfWork unitOfWork;

        public ClientService(IClientRepository clientRepository, IUnitOfWork unitOfWork)
        {
            this.clientRepository = clientRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateClient(Client client)
        {
            clientRepository.Add(client);
        }

        public Client GetClientById(int id)
        {
            return clientRepository.GetById(id);
        }

        public IEnumerable<Client> GetClients()
        {
            return clientRepository.GetAll();
        }

        public void SaveClient()
        {
            unitOfWork.Commit();
        }
    }
}
