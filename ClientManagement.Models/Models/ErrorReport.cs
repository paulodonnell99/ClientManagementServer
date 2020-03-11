using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientManagement.Model.Models
{
    public class ErrorReport
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public DateTime DateReceived { get; set; }

        [Column("ErrorReport")]
        [DisplayName("Error Message")]
        public string ErrorMessage { get; set; }

        public virtual Client Client { get; set; }
    }
}
