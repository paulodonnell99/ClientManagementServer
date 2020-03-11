using ClientManagement.Data.Configurations;
using ClientManagement.Model.Models;
using System.Data.Entity;

namespace ClientManagement.Data
{
    public class ClientEntities : DbContext
    {
        public ClientEntities() : base("ClientEntities")
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientSoftwareProfile> SoftwareProfiles { get; set; }
        public DbSet<ClientGroup> ClientGroups { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ErrorReport> ErrorReports { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClientGroupConfiguration());
            modelBuilder.Configurations.Add(new ClientConfiguration());
            modelBuilder.Configurations.Add(new SoftwareProfileConfiguration());
            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Configurations.Add(new ErrorReportConfiguration());
        }
    }
}
 