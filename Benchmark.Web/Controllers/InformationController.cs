using System.Web.Mvc;
using Benchmark.Web.Models;

namespace Benchmark.Web.Controllers
{
    public class InformationController : Controller
    {
        public ActionResult Tables()
        {
            var model = new TablesModel();
            return View(model);
        }

        public ActionResult Profiles()
        {
            var model = new ProfileModel();

            return View(model);
        }
    }
}