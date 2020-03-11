using ClientManagement.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientManagement.Data.Configurations
{
    public class ErrorReportConfiguration : EntityTypeConfiguration<ErrorReport>
    {
        public ErrorReportConfiguration()
        {
            this.Property(e => e.Id)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }
    }
}
