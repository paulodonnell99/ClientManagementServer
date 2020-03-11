using ClientManagement.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Service
{
    public interface ISoftwareProfileService
    {
        ClientSoftwareProfile GetSoftwareProfileById(int id);
        ClientSoftwareProfile GetSoftwareProfileProductCode(string productCode);
        void CreateSoftwareProfile(ClientSoftwareProfile clientSoftwareProfile);
        void SaveSoftwareProfile();
        ClientSoftwareProfile GetSoftwareProfileByClientId(int clientId);
    }
}
