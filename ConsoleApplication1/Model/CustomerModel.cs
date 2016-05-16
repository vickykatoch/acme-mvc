using Acme.Domain;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication1.Model
{
    public class CustomerModel
    {
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
        public DateTime CreateDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public virtual ICollection<OpportunityModel> Opportunities { get; set; }
        public virtual ICollection<RiskModel> Risks { get; set; }
    }
}
