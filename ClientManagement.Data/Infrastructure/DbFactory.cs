using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        public ClientEntities clientEntitiesDB;

        public ClientEntities Init()
        {
            return clientEntitiesDB ?? (clientEntitiesDB = new ClientEntities());
        }

        protected override void DisposeObject()
        {
            if (clientEntitiesDB != null)
                clientEntitiesDB.Dispose();
        }
    }
}
