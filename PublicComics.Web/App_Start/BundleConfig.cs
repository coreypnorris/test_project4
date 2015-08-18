using System.Web;
using System.Web.Optimization;

namespace PublicComics.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            var BaseJsBundle = new ScriptBundle("~/js-bundles/base");
            BaseJsBundle.Include(
                "~/Scripts/jquery-2.1.4.js",
                "~/Scripts/bootstrap.js"
            );

            var BaseCssBundle = new StyleBundle("~/css-bundles/base");
            BaseCssBundle.Include(
                "~/Content/bootstrap.cyborg.css"
            );

            bundles.Add(BaseJsBundle);
            bundles.Add(BaseCssBundle);

            // Comment or uncomment this to toggle minification on or off.
            BundleTable.EnableOptimizations = true;
        }
    }
}
