using System;
using ClientManagement.Model.Models;
using ClientWebService.Tests.SubService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClientWebService.Tests
{
    [TestClass]
    public class TestSubscriptionWebService
    {
        [TestMethod]
        public void TestGetRegistrationInfo()
        {
            MockServices.MockSubscriptionDataManager mockSubscriptionDataManager = new MockServices.MockSubscriptionDataManager();
            MockServices.MockSubscriptionWebService mockSubscriptionWebService = new MockServices.MockSubscriptionWebService();
            
            RegistrationInfo expected = mockSubscriptionDataManager.GetRegistrationInfo(2);
            RegistrationInfo actual = mockSubscriptionWebService.GetRegistrationInfo(2);

            Assert.IsTrue(expected.ClientId == actual.ClientId, "Registration Info Client Ids are not equal, expected {0}, actual {1}", expected.ClientId, actual.ClientId);
            Assert.IsTrue(expected.FirstRegisteredDate == actual.FirstRegisteredDate, "Registration Info FirstRegisteredDates are not equal, expected {0}, actual {1}", expected.FirstRegisteredDate, actual.FirstRegisteredDate);
            Assert.IsTrue(expected.RegisteredTo == actual.RegisteredTo, "Registration Info RegisteredTo are not equal, expected {0}, actual {1}", expected.RegisteredTo, actual.RegisteredTo);
        }

        [TestMethod]
        public void TestGetRenewalDate()
        {
            MockServices.MockSubscriptionDataManager mockSubscriptionDataManager = new MockServices.MockSubscriptionDataManager();
            MockServices.MockSubscriptionWebService mockSubscriptionWebService = new MockServices.MockSubscriptionWebService();

            ClientInfo clientInfo = new ClientInfo();
            clientInfo.ClientId = 1;

            DateTime? expectedRenewalDate = mockSubscriptionWebService.GetRenewalDate(clientInfo);
            DateTime? actualRenewalDate = mockSubscriptionDataManager.ClientInfos[0].SubRenewalDate;

            Assert.AreEqual(expectedRenewalDate, actualRenewalDate);
        }

        [TestMethod]
        public void TestRegisterProduct()
        {
            MockServices.MockSubscriptionDataManager mockSubscriptionDataManager = new MockServices.MockSubscriptionDataManager();
            MockServices.MockSubscriptionWebService mockSubscriptionWebService = new MockServices.MockSubscriptionWebService();

            Client client = mockSubscriptionDataManager.Clients[2];
            ClientSoftwareProfile clientSoftwareProfile = mockSubscriptionDataManager.ClientInfos[2];

            int? expectedClientId = client.Id;
            int actuaClientId = mockSubscriptionWebService.RegisterProduct(clientSoftwareProfile.ProductCode).ClientId;

            Assert.AreEqual(expectedClientId, actuaClientId);
        }
    }
}
