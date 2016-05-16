using Acme.Data;
using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;

namespace Acme.Web.Controllers
{
    public class CustomerController : AcmeControllerBase
    {
        private readonly AcmeContext _context = new AcmeContext();

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult All()
        {
            var customers = _context.Customers.Include(X=>X.Opportunities)
                .Include(x=>x.Risks).ToArray();
            return BetterJson(customers);
        }
    }
}