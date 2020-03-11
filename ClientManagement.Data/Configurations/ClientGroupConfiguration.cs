using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ClientManagement.Model.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientManagement.Data.Configurations
{
    public class ClientGroupConfiguration : EntityTypeConfiguration<ClientGroup>
    {
        public ClientGroupConfiguration()
        {
            this.Property(i => i.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }
    }
}
