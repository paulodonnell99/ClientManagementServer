using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ClientManagementWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface ISubscriptionWebService
    {

        [OperationContract]
        DateTime? GetRenewalDate(ClientInfo clientInfo);

        [OperationContract]
        RegistrationInfo RegisterProduct(string productCode);

        [OperationContract]
        RegistrationInfo GetRegistrationInfo(int clientId);

    }

    [DataContract]
    public class RegistrationInfo
    {
        [DataMember]
        public int ClientId { get; set; }

        [DataMember]
        public DateTime FirstRegisteredDate { get; set; }

        [DataMember]
        public string RegisteredTo { get; set; }

        [DataMember]
        public int NoOfLicenses { get; set; }
    }

    [DataContract]
    public class ClientInfo
    {
        [DataMember]
        public int ClientId { get; set; }

        [DataMember]
        public string LifetimeVersion { get; set; }

        [DataMember]
        public string LifetimeAccountsVersion { get; set; }
    }

}