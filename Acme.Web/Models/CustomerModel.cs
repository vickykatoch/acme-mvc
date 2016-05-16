using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Acme.Web.Models
{
    public class CustomerModel
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required, Display(Name = "Full Name", Prompt = "Full Name (ex: John Doe)...")]
        public string Name { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string WorkEmail { get; set; }
        [DataType(DataType.EmailAddress)]
        public string HomeEmail { get; set; }
        [Required, DataType(DataType.PhoneNumber)]
        public string WorkPhone { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string HomePhone { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
        [HiddenInput]
        public DateTime? TerminationDate { get; set; }
        [HiddenInput]
        public virtual ICollection<OpportunityModel> Opportunities { get; set; }
        [HiddenInput]
        public virtual ICollection<RiskModel> Risks { get; set; }
    }
}
