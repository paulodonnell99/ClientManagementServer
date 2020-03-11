using ClientManagement.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Service
{
    public interface IErrorReportingService
    {
        IEnumerable<ErrorReport> GetErrorReports();
        ErrorReport GetErrorReportById(int id);
        void CreateErrorReport(ErrorReport errorReport);
        void SaveErrorReport();

    }
}
