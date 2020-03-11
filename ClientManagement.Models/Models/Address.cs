using ClientManagement.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Model.Models
{
    public class Address
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Address1 { get; set; }

        [StringLength(100)]
        public string Address2 { get; set; }

        [StringLength(100)]
        public string Address3 { get; set; }

        [StringLength(50)]
        public string Town { get; set; }

        [StringLength(20)]
        public string County { get; set; }

        [StringLength(10)]
        public string Postcode { get; set; }

        [StringLength(20)]
        public string Country { get; set; }

        public virtual Client Client { get; set; }
    }
}
