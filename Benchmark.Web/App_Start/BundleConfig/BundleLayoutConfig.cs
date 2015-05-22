namespace Benchmark.Web
{
    public class BundleLayoutConfig : BundleConfigBase, IBundleConfig
    {
        public const string CssJQueryUI = "~/CssBundles/CssJQueryUI";
        public static string CssBaseForBootstrap = "~/CssBundles/BaseForBootstrap";
        public static string CssExternal = "~/CssBundles/CssExternal";
        public static string CssCustom = "~/CssBundles/CssCustom";


        public static string JsJQuery = "~/JsBundles/JsJQuery";
        public static string JsExternal = "~/JsBundles/JsExternal";
        public static string JsCustomForApp = "~/JsBundles/JsCustomForApp";
        public const string JsSharedLayout = "~/JsBundles/JsSharedLayout";

        public void RegisterBundles()
        {
            AddStyleBundle(CssJQueryUI,
                "~/Content/Site.css",
                "~/Content/themes/base/jquery-ui.css",
                "~/Content/font-awesome.css");

            AddStyleBundle(CssBaseForBootstrap,
                "~/Content/bootstrap.css");

            AddStyleBundle(CssExternal,
                "~/Content/font-awesome.min.css",
                "~/Content/prettify.css");

            AddStyleBundle(CssCustom,
                "~/Content/Custom/Navbar.css",
                "~/Content/Custom/ProgressMeterButtons.css",
                "~/Content/Custom/Buttons.css",
                "~/Content/Custom/Fonts.css",
                "~/Content/Custom/Benchmark.css",
                "~/Content/Custom/animate.css");

            AddScriptBundle(JsJQuery,
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery-ui-{version}.js");

            AddScriptBundle(JsExternal,
                "~/Scripts/bootstrap.js",
                "~/Scripts/spin.js",
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/knockout.validation.js",
                "~/Scripts/modernizr-{version}.js");

            AddScriptBundle(JsCustomForApp,
                "~/Scripts/SolutionServer/SolutionServer.js",
                "~/Scripts/Custom/Custom.js",
                "~/Scripts/Custom/BootstrapRadioButtonGroupBinding.js",
                "~/Scripts/Custom/ProgressMeterButtons.js",
                "~/Scripts/Custom/Navbar.js");

            AddScriptBundle(JsSharedLayout,
                "~/Scripts/ViewScripts/Shared/_LayoutViewModel.js");
        }
    }
}