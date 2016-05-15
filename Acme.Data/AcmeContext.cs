using Acme.Domain;
using System.Data.Entity;

namespace Acme.Data
{
    public class AcmeContext : DbContext
    {
        #region ctor
        public AcmeContext() : base("AcmeContext")
        {

        }
        #endregion

        #region DBSets
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Opportunity> Opportunities { get; set; }
        public IDbSet<Risk> Risks { get; set; }
        #endregion
    }
}
