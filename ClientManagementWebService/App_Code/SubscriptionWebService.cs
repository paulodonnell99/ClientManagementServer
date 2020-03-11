using ClientManagement.Service;
using System;

namespace ClientManagementWebService
{ 
    public class SubscriptionWebService : ISubscriptionWebService
    {
        //Declaration
        private readonly IClientService clientService;
        private readonly ISoftwareProfileService softwareProfileService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="clientService"></param>
        /// <param name="softwareProfileService"></param>
        public SubscriptionWebService(IClientService clientService, ISoftwareProfileService softwareProfileService)
        {
            this.clientService = clientService;
            this.softwareProfileService = softwareProfileService;
        }

        /// <summary>
        /// Returns software registration information to the client
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public RegistrationInfo GetRegistrationInfo(int clientId)
        {
            var client = clientService.GetClientById(clientId);
            if (client != null)
            {
                var clientSoftwareProfile = client.ClientSoftwareProfile;

                //Map information from the db entities to the RegistrationInfo entity
                RegistrationInfo regInfo = new RegistrationInfo();
                regInfo.ClientId = client.Id;
                regInfo.FirstRegisteredDate = (DateTime)client.DateRegistered;
                regInfo.RegisteredTo = client.ClientName;
                regInfo.NoOfLicenses = (int)clientSoftwareProfile.LicensesPurchased;
                return regInfo;
            }
            return null;
        }

        /// <summary>
        /// Receives information from the client about their current version, updates the database with
        /// this data, and returns the subscription renewal date to the client.
        /// </summary>
        /// <param name="clientInfo">ClientId and current version info</param>
        /// <returns>SubRenewalDate - the date which the client is due to renew their subscription</returns>
        public DateTime? GetRenewalDate(ClientInfo clientInfo)
        {
            var client = clientService.GetClientById(clientInfo.ClientId);

            if (client != null)
            {
                var softwareProfile = client.ClientSoftwareProfile;

                //Update the client's profile on their current verison info & last subscription renewal check
                softwareProfile.ProductVersion = clientInfo.LifetimeVersion;
                softwareProfile.AccountsVersion = clientInfo.LifetimeAccountsVersion;
                softwareProfile.LastRenewalCheckedDate = DateTime.Now;
                softwareProfileService.SaveSoftwareProfile();

                return softwareProfile.SubRenewalDate;
            }
            else return DateTime.MinValue;
        }

        /// <summary>
        /// Registers a copy of software for a new installation on the client's machine
        /// </summary>
        /// <param name="productCode">Unique product code as provided to the client</param>
        /// <returns>Registration info to the client</returns>
        public RegistrationInfo RegisterProduct(string productCode)
        {
            var clientSoftwareProfile = softwareProfileService.GetSoftwareProfileProductCode(productCode);
            if (clientSoftwareProfile != null)
            {
                var client = clientSoftwareProfile.Client;
                RegistrationInfo regInfo = new RegistrationInfo();
                regInfo.FirstRegisteredDate = (DateTime)client.DateRegistered;
                regInfo.RegisteredTo = client.ClientName;
                regInfo.ClientId = (int)client.Id;
                return regInfo;
            }
            else return null;
        }
    }
}