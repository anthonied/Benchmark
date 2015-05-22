using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Benchmark.Domain.Layout;
using Benchmark.Repository;
using UserAuthentication.Domain;

namespace Benchmark.Web.Conductors
{
    public class AccountConductor
    {
        public static User GetUserPersonaObjectByUserType(User loggedInUser)
        {
            using (var menuRepo = new MenuRepository())
            {
                var userRoleMainMenus = loggedInUser.UserRoleId == 0 ? menuRepo.GetUserTypeMainMenusById(loggedInUser.UserTypeId) : menuRepo.GetUserRoleMainMenusById(loggedInUser.UserRoleId);
                userRoleMainMenus.ForEach(mainMenu => mainMenu.DropDown = getMyDropDowns(mainMenu));

                switch (loggedInUser.UserTypeId)
                {
                    case 3:
                    {
                        var officeAdmin = new OfficeAdmin(loggedInUser);

                        officeAdmin.Menu = new UserMenu(userRoleMainMenus, loggedInUser.UserType);

                        return officeAdmin;
                    }

                }

                throw new Exception("No usertypeid found");
            }
        }

        private static List<Menu> getMyDropDowns(Menu mainMenu)
        {
            using (var menuRepo = new MenuRepository())
            {
                return menuRepo.GetDropdownsForMainMenuById(mainMenu.Id);
            }
        }
    }
}