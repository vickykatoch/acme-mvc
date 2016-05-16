using System;

namespace Acme.Domain
{
    public class Opportunity : Entity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreateDate { get; set; }
        public Customer Customer { get; set; }
        public override bool IsNew { get { return Id == 0; } }
        public Opportunity()
        {
            CreateDate = DateTime.Now;
        }
    }
}
