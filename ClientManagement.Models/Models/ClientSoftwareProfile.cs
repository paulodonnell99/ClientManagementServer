using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientManagement.Model.Models
{
    public class ClientSoftwareProfile
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string ProductCode { get; set; }

        [StringLength(10)]
        public string ProductVersion { get; set; }

        [StringLength(10)]
        public string AccountsVersion { get; set; }

        public bool Accounts { get; set; }

        public bool GiftAid { get; set; }

        public bool Safeguarding { get; set; }

        public bool Website { get; set; }

        public int? LicensesPurchased { get; set; }

        public int? LicensesUsed { get; set; }

        public DateTime? SubRenewalDate { get; set; }

        public DateTime? LastRenewalCheckedDate { get; set; }

        public virtual Client Client { get; set; }

        public ClientSoftwareProfile()
        {
            ProductCode = Guid.NewGuid().ToString().ToUpper();
            LicensesPurchased = 1;
            LicensesUsed = 1;
            SubRenewalDate = DateTime.Now.Date;
        }
    }
}
