using System.Web;
using System.Web.Optimization;

namespace Acme.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/all.js").Include(
                "~/Scripts/jquery-2.2.3.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/angular.js",
                
                "~/Scripts/angular-ui/ui-bootstrap-tpls.js"
                ).IncludeDirectory("~/public/app/","*.js",true));
            bundles.Add(new StyleBundle("~/Content/css/all.css").Include(
                "~/css/css/font-awesome.css",
                "~/Content/bootstrap.css",
                "~/Content/layout.css",
                "~/Content/Site.css"
                ));
            //"~/Content/bootstrap-theme.css",
        }
    }
}
