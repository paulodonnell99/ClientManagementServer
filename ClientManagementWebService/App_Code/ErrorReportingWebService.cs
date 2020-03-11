using ClientManagement.Model.Models;
using ClientManagement.Service;
using System;

namespace ClientManagementWebService
{
    public class ErrorReportingWebService : IErrorReportingWebService
    {
        private readonly IErrorReportingService errorReportingService;

        public ErrorReportingWebService(IErrorReportingService errorReportingService)
        {
            this.errorReportingService = errorReportingService;
        }

        /// <summary>
        /// Creates an error report from a client application
        /// </summary>
        /// <param name="lifetimeErrorReport">Error report info from the client</param>
        /// <returns>bool value to indicate if the error was logged successfully</returns>
        public bool ReportError(ClientErrorReport lifetimeErrorReport)
        {
            try
            {
                ErrorReport errorReport = new ErrorReport
                {
                    ClientId = lifetimeErrorReport.ClientId,
                    DateReceived = lifetimeErrorReport.DateReported,
                    ErrorMessage = lifetimeErrorReport.ErrorLog
                };
                errorReportingService.CreateErrorReport(errorReport);
                errorReportingService.SaveErrorReport();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
