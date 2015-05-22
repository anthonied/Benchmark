using System.Collections.Generic;
using UserAuthentication.Domain;

namespace Benchmark.Domain.Layout
{
    public class LoggedOutUserMenu : UserMenuBase
    {
        public LoggedOutUserMenu(List<Menu> mainMenus)
        {
            UserRoleText = "Logged Out";
            UserRoleType = "label label-primary col-md-3 login-status-display";

            this.NavbarLeft = mainMenus;

            NavbarRight = new List<Menu>
            {
                new Menu
                {
                    Id = 4,
                    Text = "Register",
                    HRef = "Account/Register",
                    UseRootUrl = true,
                    Role = "",
                    DataToggle = "",
                    DropDown = new List<Menu>()
                },
                new Menu
                {
                    Id = 5,
                    Text = "Login",
                    HRef = "Account/Login",
                    UseRootUrl = true,
                    Role = "",
                    DataToggle = "",
                    DropDown = new List<Menu>()
                }
            };
        }
    }
}
