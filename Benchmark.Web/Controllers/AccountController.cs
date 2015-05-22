using System.Web.Mvc;
using SolutionServerWebSession;

namespace Benchmark.Web.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Logoff()
        {
            UserSession.LoggedInUser = null;
            UserSession.CurrentUser = null;
            return RedirectToAction("Index", "Home");
        }
	}
}