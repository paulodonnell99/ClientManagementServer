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
    public class ErrorReportingService : IErrorReportingService
    {
        private readonly IErrorRepository errorRepository;
        private readonly IUnitOfWork unitOfWork;

        public ErrorReportingService(IErrorRepository errorRepository, IUnitOfWork unitOfWork)
        {
            this.errorRepository = errorRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateErrorReport(ErrorReport errorReport)
        {
            errorRepository.Add(errorReport);
        }

        public ErrorReport GetErrorReportById(int id)
        {
            return errorRepository.GetErrorById(id);
        }

        public IEnumerable<ErrorReport> GetErrorReports()
        {
            return errorRepository.GetAll();
        }

        public void SaveErrorReport()
        {
            unitOfWork.Commit();
        }
    }
}
