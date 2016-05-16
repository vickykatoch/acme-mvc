using Acme.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Acme.Data.Repo
{
    public class RiskRepository : Repository<Risk>
    {
        public Risk FecthById(int id, bool include)
        {
            return _context.Risks.Include(c => c.Customer).Where(r => r.Id == id).FirstOrDefault();
        }
        public IEnumerable<Risk> FetchAllWithRefs()
        {
            return _context.Risks.Include(c => c.Customer).ToList();
        }
    }
}
