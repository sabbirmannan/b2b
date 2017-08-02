using System.Web;
using System.Web.Optimization;

namespace PackageBD
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            #region custom bundle

            #endregion

            #region admin bundles
            bundles.Add(new ScriptBundle("~/BackEnd/js/adminJsBundle").Include(
                        //Bootstrap 3.3.6-- >
                        "~/BackEnd/js/bootstrap.min.js",
                        //FastClick
                        //"~/Dashboard/js/fastclick/fastclick.min.js",
                        //AdminLTE App 
                        "~/BackEnd/js/app.min.js",
                        //Sparkline
                        "~/BackEnd/js/sparkline/jquery.sparkline.min.js",
                        //jvectormap
                        "~/BackEnd/js/jvectormap/jquery-jvectormap-1.2.2.min.js",
                        "~/BackEnd/js/jvectormap/jquery-jvectormap-world-mill-en.js",
                        //Slimscroll
                        "~/BackEnd/js/slimScroll/jquery.slimscroll.min.js",
                        //ChartJS 1.0.1
                        "~/BackEnd/js/chartjs/Chart.min.js",
                        //Morris.js charts
                        "~/BackEnd/js/morris/morris.min.js",
                        // AdminLTE dashboard demo(This is only for demo purposes)
                        //"~/Dashboard/js/pages/dashboard2.js",
                        "~/BackEnd/js/demo.js",
                        "~/BackEnd/js/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js"
                    ));


            bundles.Add(new StyleBundle("~/BackEnd/css/backendCss").Include(
                        //Bootstrap 3.3.6-- >
                        "~/BackEnd/css/bootstrap.min.css",
                        //Theme style-- >
                        "~/BackEnd/css/AdminLTE.min.css",
                        //AdminLTE Skins. Choose a skin from the css/skins
                        //folder instead of downloading all of them to reduce the load.
                        "~/BackEnd/css/skins/_all-skins.min.css",
                        //iCheek
                        "~/BackEnd/css/iCheck/flat/blue.css",
                        //Morris chart
                        "~/BackEnd/plugins/morris/morris.css",
                        //jvectormap
                        "~/BackEnd/css/jvectormap/jquery-jvectormap-1.2.2.css",
                        //Date Picker
                        "~/BackEnd/css/datepicker/datepicker3.css",
                        //Daterange picker
                        "~/BackEnd/css/daterangepicker/daterangepicker.css",
                        //bootstrap wysihtml5 - text editor
                        "~/BackEnd/css/bootstrap-wysihtml5/bootstrap3-wysihtml5.css"
                    ));
            #endregion

        }
    }
}
