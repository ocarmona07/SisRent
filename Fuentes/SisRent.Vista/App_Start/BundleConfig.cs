namespace SisRent.Vista
{
    using System.Web.Optimization;

    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/ct-navbar").Include(
                      "~/Scripts/ct-navbar.js"));

            bundles.Add(new StyleBundle("~/Styles/css").Include(
                      "~/Styles/bootstrap.css",
                      "~/Styles/font-awesome.css",
                      "~/Styles/ct-navbar.css",
                      "~/Styles/site.css"));

            bundles.Add(new StyleBundle("~/Styles/AdminLTE").Include(
                      "~/Styles/bootstrap.css",
                      "~/Styles/font-awesome.css",
                      "~/Styles/AdminLTE.min.css",
                      "~/Styles/skins/_all-skins.min.css"));

            bundles.Add(new ScriptBundle("~/Scripts/AdminLTE").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/jquery-{version}.js",
                      "~/Scripts/jquery.validate*",
                      "~/Scripts/adminlte.min.js"));

            bundles.Add(new StyleBundle("~/Styles/select2").Include(
                      "~/Styles/select2.min.css"));

            bundles.Add(new ScriptBundle("~/Scripts/select2").Include(
                      "~/Scripts/select2.full.min.js"));

            bundles.Add(new StyleBundle("~/Styles/datepicker").Include(
                      "~/Styles/bootstrap-datepicker3.css"));

            bundles.Add(new ScriptBundle("~/Scripts/datepicker").Include(
                      "~/Scripts/bootstrap-datepicker.min.js"));

            bundles.Add(new StyleBundle("~/Styles/timepicker").Include(
                      "~/Styles/bootstrap-timepicker.css"));

            bundles.Add(new ScriptBundle("~/Scripts/timepicker").Include(
                      "~/Scripts/bootstrap-timepicker.js"));

            bundles.Add(new StyleBundle("~/Styles/datatables").Include(
                      "~/Styles/datatables.min.css"));

            bundles.Add(new ScriptBundle("~/Scripts/datatables").Include(
                      "~/Scripts/datatables.min.js"));
        }
    }
}
