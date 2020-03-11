using System;
using System.Collections.Generic;
using System.Linq;
using ClientManagement.Model.Models;
using ClientWebService.Tests.SubService;

namespace ClientWebService.Tests.MockServices
{
    public class MockSubscriptionDataManager : ISubscriptionDataManager
    {

        public List<ClientSoftwareProfile> ClientInfos { get; set; }
        public List<Client> Clients { get; set; }

        public MockSubscriptionDataManager()
        {
            ClientInfos = new List<ClientSoftwareProfile>();
            Clients = new List<Client>();

            var testClient1 = new Client();
            testClient1.Id = 1;
            testClient1.DateRegistered = new DateTime(2019, 01, 01);
            testClient1.ClientName = "test Client 1";
            Clients.Add(testClient1);

            var testClient2 = new Client();
            testClient2.Id = 2;
            testClient2.DateRegistered = new DateTime(2019, 02, 02);
            testClient2.ClientName = "test Client 2";
            Clients.Add(testClient2);

            var testClient3 = new Client();
            testClient3.Id = 3;
            testClient3.DateRegistered = new DateTime(2019, 03, 03);
            testClient3.ClientName = "test Client 3";
            Clients.Add(testClient3);

            var client1 = new ClientSoftwareProfile();
            client1.Client = Clients[0];
            client1.ProductCode = "ED9D7855-C8B1-4795-88A5-4E34BBFA1127";
            client1.SubRenewalDate = new DateTime(2019, 01, 01);
            ClientInfos.Add(client1);

            var client2 = new ClientSoftwareProfile();
            client2.Client = Clients[1];
            client2.ProductCode = "F6CA022E-F4E9-44E5-A232-B8250ED943D3";
            client2.SubRenewalDate = new DateTime(2019, 02, 02);
            ClientInfos.Add(client2);

            var client3 = new ClientSoftwareProfile();
            client3.Client = Clients[2];
            client3.ProductCode = "1058B968-3914-4A85-84CB-8D7D8214C124";
            client3.SubRenewalDate = new DateTime(2019, 03, 03);
            ClientInfos.Add(client3);
        }

        public RegistrationInfo GetRegistrationInfo(int clientId)
        {
            Client client = Clients.Where(c => c.Id == clientId).ToList()[0];
            ClientSoftwareProfile clientSoftwareProfile = ClientInfos.Where(i => i.Client.Id == client.Id).FirstOrDefault();
            RegistrationInfo regInfo = new RegistrationInfo();
            regInfo.ClientId = client.Id;
            regInfo.FirstRegisteredDate = (DateTime)client.DateRegistered;
            regInfo.RegisteredTo = client.ClientName;

            return regInfo;
        }

        public DateTime? GetRenewalDate(ClientInfo clientInfo)
        {
            ClientSoftwareProfile clientSoftwareProfile = ClientInfos.Where(i => i.Client.Id == clientInfo.ClientId).ToList()[0];
            return clientSoftwareProfile.SubRenewalDate;
        }

        public RegistrationInfo RegisterProduct(string productCode)
        {
            ClientSoftwareProfile clientSoftwareProfile = ClientInfos.Where(c => c.ProductCode == productCode).ToList()[0];
            Client client = Clients.Where(c => c.Id == clientSoftwareProfile.Client.Id).FirstOrDefault();

            RegistrationInfo regInfo = new RegistrationInfo();
            regInfo.ClientId = client.Id;
            regInfo.FirstRegisteredDate = (DateTime)client.DateRegistered;
            regInfo.RegisteredTo = client.ClientName;

            return regInfo;
        }
    }
}
