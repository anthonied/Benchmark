using System.Configuration;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SolutionServer.DatabaseManager.Manager;

namespace Benchmark.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            new DbManager(ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString,
                new DatabaseScripts.DatabaseScripts().Scripts, "Benchmark").UpdateDatabase();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles();
        }
    }
}