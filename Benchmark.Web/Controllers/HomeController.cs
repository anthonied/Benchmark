using System;
using System.Web.Mvc;
using Benchmark.Web.Conductors;
using Benchmark.Web.Models;
using SolutionServerWebSession;
using UserAuthentication.Repository;

namespace Benchmark.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            if (UserSession.LoggedInUser == null)
            {
                var model = new IndexModel();
                return View(model);
            }

            var actionName = UserSession.LoggedInUser.StartPage.Split('/')[1];
            return RedirectToAction(actionName);
        }
        
        public ActionResult Index()
        {
            if (UserSession.LoggedInUser == null)
            {
                var model = new HomeModel();
                return View(model);
            }

            var actionName = UserSession.LoggedInUser.StartPage.Split('/')[1];
            return RedirectToAction(actionName);

        }

      public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult LoginAccount(LoginModel loginCredentials)
        {
            using (var repo = new AuthenticationRepository())
            {
                var user = repo.CheckLogin("", loginCredentials.Username, loginCredentials.Password);
                if (!user.IsOk)
                {
                    string loginErrorMessage = String.Format("You are not registered in the system");
                    return new JsonResult
                    {
                        Data = new { isOk = false, Message = loginErrorMessage }
                    };
                }
                if (!user.Data.Confirmed)
                {
                    string confirmErrorMessage = String.Format("The user with email: '{0}' is not verified yet.", loginCredentials.Username);
                    return new JsonResult
                    {
                        Data = new { isOk = false, Message = confirmErrorMessage }
                    };
                }
                UserSession.LoggedInUser = AccountConductor.GetUserPersonaObjectByUserType(user.Data);

            }
            return new JsonResult { Data = new { isOk = true, login = loginCredentials.Username, startPage = UserSession.LoggedInUser.StartPage } };
        }

        public ActionResult OfficeAdmin()
        {
            var model = new OfficeAdminModel();
            return View(model);
        }

    }
}