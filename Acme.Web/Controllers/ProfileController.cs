using Acme.Data;
using Acme.Domain;
using Acme.Web.Models;
using System.Web.Mvc;

namespace Acme.Web.Controllers
{
    public class ProfileController : AcmeControllerBase
    {
        private readonly AcmeContext context = new AcmeContext();

        public ProfileController()
        {
        }

        public ActionResult Index()
        {
            var model = new ProfileModel()
            {
                 FullName = "Balwinder Katoch", EmailAddress ="vickykatoch@yahoo.com"
            };
            return View(model);
        }
    }
}