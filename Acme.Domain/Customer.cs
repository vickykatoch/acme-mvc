using System;
using System.Collections.Generic;

namespace Acme.Domain
{
    public class Customer : Entity
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

        public virtual ICollection<Opportunity> Opportunities { get; set; }

        public virtual ICollection<Risk> Risks { get; set; }

        public override bool IsNew { get { return Id == 0; } }

        public Customer()
        {
            CreateDate = DateTime.Today;
        }
    }
}
