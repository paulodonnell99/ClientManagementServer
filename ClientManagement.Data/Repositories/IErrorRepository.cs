using ClientManagement.Data.Infrastructure;
using ClientManagement.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Data.Repositories
{
    public interface IErrorRepository : IRepository<ErrorReport>
    {
        IEnumerable<ErrorReport> GetErrorsByClientId(int clientId);
        ErrorReport GetErrorById(int id);
    }
}
