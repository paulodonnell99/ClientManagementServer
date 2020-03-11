using ClientWebService.Tests.SubService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientWebService.Tests.MockServices
{
    public interface ISubscriptionDataManager
    {
        RegistrationInfo GetRegistrationInfo(int clientId);
        DateTime? GetRenewalDate(ClientInfo clientInfo);
        RegistrationInfo RegisterProduct(string productCode);
    }
}
