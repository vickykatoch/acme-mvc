using Acme.Domain;
using System.Data.Entity;

namespace Acme.Data
{
    public class AcmeContext : DbContext
    {
        #region ctor
        public AcmeContext() : base("AcmeContext")
        {
            Configuration.LazyLoadingEnabled = true;
        }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }


        #region DBSets
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Opportunity> Opportunities { get; set; }
        public IDbSet<Risk> Risks { get; set; }
        #endregion
    }
}
