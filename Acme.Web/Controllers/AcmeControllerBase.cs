using Acme.Web.ActionResults;
using System.Web.Mvc;

namespace Acme.Web.Controllers
{
    public class AcmeControllerBase : Controller
    {
        public BetterJsonResult<T> BetterJson<T>(T model)
        {
            return new BetterJsonResult<T>() { Data = model };
        }
    }
}
