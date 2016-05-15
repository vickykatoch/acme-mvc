using Acme.Web.Xtns;
using System.Web;
using System.Web.Mvc;

namespace Acme.Web.Helpers
{
    public static class JsonHtmlHelpers
    {
        public static IHtmlString JsonFor<T>(this HtmlHelper helper, T obj)
        {
            return helper.Raw(obj.ToJson());
        }
    }
}
