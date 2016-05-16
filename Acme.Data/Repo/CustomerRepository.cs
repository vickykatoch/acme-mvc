using System;
using System.Collections.Generic;
using Acme.Domain;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Acme.Data.Repo
{
    public class CustomerRepository : Repository<Customer>
    {
        public CustomerRepository() 
        {
            
        }
        public Customer FecthById(int id, bool include)
        {
            return _context.Customers
                .Include(c => c.Risks)
                .Include(c=>c.Opportunities)
                .Where(r => r.Id == id).FirstOrDefault();
        }


    }
}
