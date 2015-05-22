using Benchmark.Domain.Layout;
using SolutionServerWebSession;
using System.Collections.Generic;
using UserAuthentication.Domain;

namespace Benchmark.Web.Models
{
    public class MenuModel
    {
        public MenuModel()
        {
            var menu = UserSession.LoggedInUser == null ? new LoggedOutUserMenu(new List<Menu>()) : ((IUserRole)UserSession.LoggedInUser).Menu;

            NavbarLeft = menu.NavbarLeft;
            NavbarRight = menu.NavbarRight;
            Sidebar = menu.Sidebar;
            NavPills = menu.NavPills;
            UserRoleText = menu.UserRoleText;
            UserRoleType = menu.UserRoleType;
        }

        public List<Menu> NavbarLeft { get; set; }
        public List<Menu> NavbarRight { get; set; }
        public List<Menu> Sidebar { get; set; }
        public List<Menu> NavPills { get; set; }
        public string UserRoleType { get; set; }
        public string UserRoleText { get; set; }

        public bool UserLoggedIn {
            get { return UserSession.LoggedInUser != null; }
        }
    }
}