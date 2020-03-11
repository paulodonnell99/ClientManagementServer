using ClientManagement.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Data.Configurations
{
    public class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            this.Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasRequired(c => c.ClientGroup)
                .WithMany(g => g.Clients);

            this.HasRequired(c => c.Address)
                .WithRequiredPrincipal(a => a.Client)
                .Map(m => m.MapKey("ClientId"));

            this.HasRequired(c => c.ClientSoftwareProfile)
                .WithRequiredPrincipal(s => s.Client)
                .Map(m => m.MapKey("ClientId"));

            this.HasMany<ErrorReport>(c => c.ErrorReports)
                .WithRequired(e => e.Client)
                .HasForeignKey<int>(e => e.ClientId);

        }
    }
}
