using System.Web;
using System.Web.Optimization;

namespace BooksSorterWApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularJs").Include(
                      "~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/toastrJs").Include(
                      "~/Scripts/toastr.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/dataTables.bootstrap.min.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/toastr").Include(
                      "~/Content/toastr.css"));

            bundles.Add(new ScriptBundle("~/bundles/customJs").Include(
                      "~/Scripts/app/Module.js",
                      "~/Scripts/app/Service.js",
                      "~/Scripts/app/Controller.js",
                      "~/Scripts/jquery.dataTables.min.js",
                      "~/Scripts/angular-dataTables.min.js"
                      ));
        }
    }
}
