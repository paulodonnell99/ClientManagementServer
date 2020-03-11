using ClientManagement.Data.Infrastructure;
using ClientManagement.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Data.Repositories
{
    public class ErrorRepository : Repository<ErrorReport>, IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public ErrorReport GetErrorById(int id)
        {
            return DbContext.ErrorReports.Find(id);
        }

        public IEnumerable<ErrorReport> GetErrorsByClientId(int clientId)
        {
            return DbContext.ErrorReports.Where(e => e.ClientId == clientId);
        }
    }
}
