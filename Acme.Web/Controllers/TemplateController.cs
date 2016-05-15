using System.Web.Mvc;

namespace Acme.Web.Controllers
{
    public class TemplateController : AcmeControllerBase
    {
        public PartialViewResult Render(string feature, string name)
        {
            return PartialView(string.Format("~/public/app/{0}/templates/{1}", feature, name));
        }
    }
}
