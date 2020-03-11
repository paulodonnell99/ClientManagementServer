using ClientManagement.Data.Infrastructure;
using ClientManagement.Data.Repositories;
using ClientManagement.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Service
{
    public class SoftwareProfileService : ISoftwareProfileService
    {
        private readonly ISoftwareProfileRepository softwareProfileRepository;
        private readonly IUnitOfWork unitOfWork;

        public SoftwareProfileService(ISoftwareProfileRepository softwareProfileRepository, IUnitOfWork unitOfWork)
        {
            this.softwareProfileRepository = softwareProfileRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateSoftwareProfile(ClientSoftwareProfile clientSoftwareProfile)
        {
            softwareProfileRepository.Add(clientSoftwareProfile);
        }

        public ClientSoftwareProfile GetSoftwareProfileByClientId(int clientId)
        {
            return softwareProfileRepository.GetProfileByClientId(clientId);
        }

        public ClientSoftwareProfile GetSoftwareProfileById(int id)
        {
            return softwareProfileRepository.GetById(id);
        }

        public ClientSoftwareProfile GetSoftwareProfileProductCode(string productCode)
        {
            return softwareProfileRepository.GetProfileByProductCode(productCode);
        }

        public void SaveSoftwareProfile()
        {
            unitOfWork.Commit();
        }
    }
}
