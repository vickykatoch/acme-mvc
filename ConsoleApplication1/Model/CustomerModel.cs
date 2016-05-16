using Acme.Domain;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Model
{
    class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WorkEmail { get; set; }
        public string HomeEmail { get; set; }
        public string WorkPhone { get; set; }
        public string HomePhone { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public virtual ICollection<OpportunityModel> Opportunities { get; set; }
        public virtual ICollection<RiskModel> Risks { get; set; }
    }
}
