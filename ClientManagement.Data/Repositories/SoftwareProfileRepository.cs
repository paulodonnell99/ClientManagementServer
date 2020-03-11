using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ClientManagement.Data.Infrastructure;
using ClientManagement.Model.Models;

namespace ClientManagement.Data.Repositories
{
    public class SoftwareProfileRepository : Repository<ClientSoftwareProfile>, ISoftwareProfileRepository
    {
        public SoftwareProfileRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public ClientSoftwareProfile GetProfileByClientId(int clientId)
        {
            return this.DbContext.Clients.Find(clientId).ClientSoftwareProfile;
        }

        public ClientSoftwareProfile GetProfileByProductCode(string productCode)
        {
            return this.DbContext.SoftwareProfiles.Where(s => s.ProductCode == productCode).FirstOrDefault();
        }
    }
}
