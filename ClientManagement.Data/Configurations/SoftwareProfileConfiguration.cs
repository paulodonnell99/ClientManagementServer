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
    public class SoftwareProfileConfiguration : EntityTypeConfiguration<ClientSoftwareProfile>
    {
        public SoftwareProfileConfiguration()
        {
            this.Property(s => s.Id)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
