using ClientWebService.Tests.SubService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientWebService.Tests.MockServices
{
    public class MockSubscriptionWebService : ISubscriptionWebService
    {
        ISubscriptionDataManager _dataManager;

        public MockSubscriptionWebService()
        {
            _dataManager = new MockSubscriptionDataManager();
        }

        public RegistrationInfo GetRegistrationInfo(int clientId)
        {
            return _dataManager.GetRegistrationInfo(clientId);
        }

        public Task<RegistrationInfo> GetRegistrationInfoAsync(int clientId)
        {
            throw new NotImplementedException();
        }

        public DateTime? GetRenewalDate(ClientInfo clientInfo)
        {
            return _dataManager.GetRenewalDate(clientInfo);
        }

        public Task<DateTime?> GetRenewalDateAsync(ClientInfo clientInfo)
        {
            throw new NotImplementedException();
        }

        public RegistrationInfo RegisterProduct(string productCode)
        {
            return _dataManager.RegisterProduct(productCode);

        }

        public Task<RegistrationInfo> RegisterProductAsync(string productCode)
        {
            throw new NotImplementedException();
        }
    }
}
