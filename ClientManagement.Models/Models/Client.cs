using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientManagement.Model.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        public int ClientGroupId { get; set; }

        [Required]
        [StringLength(200)]
        public string ClientName { get; set; }

        [StringLength(50)]
        public string Landline { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string AdditionalPhone { get; set; }

        [StringLength(50)]
        public string EmailAddress { get; set; }

        [StringLength(100)]
        public string Webpage { get; set; }

        [StringLength(50)]
        public string Contact1 { get; set; }

        [StringLength(50)]
        public string Contact1JobTitle { get; set; }

        [StringLength(50)]
        public string Contact2 { get; set; }

        [StringLength(50)]
        public string Contact2JobTitle { get; set; }

        [StringLength(50)]
        public string Contact3 { get; set; }

        [StringLength(50)]
        public string Contact3JobTitle { get; set; }

        public bool? ClientActive { get; set; }

        public bool ROI { get; set; }

        public DateTime? DateRegistered { get; set; }

        public DateTime? DateUnregistered { get; set; }

        public string AccountRef { get; set; }

        public string Notes { get; set; }
        
        public virtual ClientGroup ClientGroup { get; set; }

        public virtual ClientSoftwareProfile ClientSoftwareProfile { get; set; }

        public virtual Address Address { get; set; }

        public virtual List<ErrorReport> ErrorReports { get; set; }
    }
}
