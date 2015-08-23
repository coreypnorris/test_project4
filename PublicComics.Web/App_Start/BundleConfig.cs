using System.Web;
using System.Web.Optimization;

namespace PublicComics.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            

            var globalCssBase = new StyleBundle("~/Content/globalBase");
            globalCssBase.Include(
                "~/Content/bootstrap.cyborg.css",
                "~/Custom_Css/global-base.css"
            );

            bundles.Add(globalCssBase);

            var globalJsBase = new ScriptBundle("~/Scripts/globalBase");
            globalJsBase.Include(
                "~/Scripts/jquery-2.1.4.js",
                "~/Scripts/bootstrap.js"
            );

            bundles.Add(globalJsBase);

            // Comment or uncomment this to toggle minification on or off.
            BundleTable.EnableOptimizations = true;
        }
    }
}
