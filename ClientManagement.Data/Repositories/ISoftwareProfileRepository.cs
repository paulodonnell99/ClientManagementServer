using ClientManagement.Data.Infrastructure;
using ClientManagement.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Data.Repositories
{
    public interface ISoftwareProfileRepository : IRepository<ClientSoftwareProfile>
    {
        ClientSoftwareProfile GetProfileByProductCode(string productCode);
        ClientSoftwareProfile GetProfileByClientId(int clientId);
    }
}
