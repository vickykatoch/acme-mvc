
using System;

namespace Acme.Web.Models
{
    public class OpportunityModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreateDate { get; set; }

        public int CustomerId { get; set; }

        public string CustomerName { get; set; }
    }
}
