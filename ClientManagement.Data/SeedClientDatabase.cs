using ClientManagement.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Data
{
    public class SeedClientDatabase : DropCreateDatabaseIfModelChanges<ClientEntities>
    {
        private static List<ClientGroup> clientGroups;
        private static List<Address> addresses;
        private static List<ClientSoftwareProfile> softwareProfiles;

        protected override void Seed(ClientEntities context)
        {
            clientGroups = GetClientGroups();
            clientGroups.ForEach(g => context.ClientGroups.Add(g));

            addresses = GetAddresses();
            addresses.ForEach(a => context.Addresses.Add(a));

            softwareProfiles = GetSoftwareProfiles();
            softwareProfiles.ForEach(s => context.SoftwareProfiles.Add(s));           

            GetClients().ForEach(c => context.Clients.Add(c));

            context.Commit();

        }

        private static List<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientName = "Antrim Client",
                    ClientGroup = clientGroups[0],
                    Address = addresses[0],
                    ClientSoftwareProfile = softwareProfiles[0],
                    ClientActive = true,
                    DateRegistered = DateTime.Now,
                    Landline = "028 25412323",
                    Contact1 = "John Bloggs"
                },
                new Client
                {
                    ClientName = "Downpatrick Client",
                    ClientGroup = clientGroups[0],
                    Address = addresses[1],
                    ClientSoftwareProfile = softwareProfiles[1],
                    ClientActive = true,
                    DateRegistered = DateTime.Now,
                    Landline = "028 52621313",
                    Contact1 = "Jim Bloggs"
                },
                new Client
                {
                    ClientName = "Derry Client",
                    ClientGroup = clientGroups[1],
                    Address = addresses[2],
                    ClientSoftwareProfile = softwareProfiles[2],
                    ClientActive = true,
                    DateRegistered = DateTime.Now,
                    Landline = "028 40943241",
                    Contact1 = "Sarah Bloggs"
                },
                new Client
                {
                    ClientName = "Enniskillen Client",
                    ClientGroup = clientGroups[3],
                    Address = addresses[3],
                    ClientSoftwareProfile = softwareProfiles[3],
                    ClientActive = true,
                    DateRegistered = DateTime.Now,
                    Landline = "028 96313216",
                    Contact1 = "Mary Bloggs"
                },
                new Client
                {
                    ClientName = "Dundalk Client",
                    ClientGroup = clientGroups[2],
                    Address = addresses[4],
                    ClientSoftwareProfile = softwareProfiles[4],
                    ClientActive = true,
                    DateRegistered = DateTime.Now,
                    Landline = "028 71033132",
                    Contact1 = "Peter Bloggs",
                    ROI = true
                },
            };
        }

        private List<ClientSoftwareProfile> GetSoftwareProfiles()
        {
            var sProfiles = new List<ClientSoftwareProfile>();
            for (int i = 0; i < 5; i++)
                sProfiles.Add(new ClientSoftwareProfile());
            return sProfiles;
        }

        private List<Address> GetAddresses()
        {
            return new List<Address>
            {
                new Address
                {
                    Address1 = "51 Main Street",
                    Town = "Antrim",
                    Postcode = "BT43 4RG",
                    County = "Co, Antrim"
                },
                new Address
                {
                    Address1 = "34 Downpatrick St",
                    Town = "Downpatrick",
                    Postcode = "BT56 6TH",
                    County = "Co Down"
                },
                 new Address
                {
                    Address1 = "292B Francis St",
                    Town = "Derry",
                    Postcode = "BT36 6JH",
                    County = "Co Derry"
                },
                 new Address
                {
                    Address1 = "106 Erne St",
                    Town = "Enniskillen",
                    Postcode = "BT92 6TH",
                    County = "Co Fermanagh"
                },
                 new Address
                {
                    Address1 = "Dundalk Park",
                    Town = "Dundalk",
                    Postcode = "BT56 6TH",
                    County = "Co Louth"
                }
            };
        }

        private static List<ClientGroup> GetClientGroups()
        {
            return new List<ClientGroup>
            {
                new ClientGroup { ClientGroupName = "Antrim & Down"},
                new ClientGroup { ClientGroupName = "Derry & Donegal"},
                new ClientGroup { ClientGroupName = "Louth & Monaghan"},
                new ClientGroup { ClientGroupName = "Fermanagh & Cavan"}
            };
        }
    }
}
