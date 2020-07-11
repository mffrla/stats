using System.Web;
using System.Web.Optimization;

namespace MFFStats.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.1.1.min.js"));

            // jQuery Validate
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            // Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            // CSS
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            // Main App
            bundles.Add(new ScriptBundle("~/bundles/mainApp").Include(
                      "~/Scripts/mainApp.js"));

            // Angular
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/Scripts/angular.min.js"));

            // Service
            bundles.Add(new ScriptBundle("~/bundles/service").Include(
                      "~/Scripts/service.js"));

            // Home Controller
            bundles.Add(new ScriptBundle("~/bundles/home").Include(
                      "~/Scripts/Home/HomeController.js"));

            // Character Controller
            bundles.Add(new ScriptBundle("~/bundles/character").Include(
                      "~/Scripts/Character/CharacterController.js"));

            // Character Manage Controller
            bundles.Add(new ScriptBundle("~/bundles/manage").Include(
                      "~/Scripts/Character/ManageController.js"));

            // Character Add Controller
            bundles.Add(new ScriptBundle("~/bundles/add").Include(
                      "~/Scripts/Character/AddController.js"));
        }
    }
}
