using Acme.Domain;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Acme.Data.Repo
{
    public class OpportunityRepository : Repository<Opportunity>
    {
        public Opportunity FecthById(int id, bool include)
        {
            return _context
                .Opportunities
                .Include(c => c.Customer)
                .Where(r => r.Id == id).FirstOrDefault();
        }
        public IEnumerable<Opportunity> FetchAllWithRefs()
        {
            return _context
                .Opportunities
                .Include(c => c.Customer)
                .ToList();
        }
    }
}
