using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClientManagement.Model.Models
{
    public class ClientGroup
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string ClientGroupName { get; set; }

        public List<Client> Clients { get; set; }
    }
}
