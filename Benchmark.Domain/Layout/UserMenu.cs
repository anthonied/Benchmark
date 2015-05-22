using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionServerWebSession;
using UserAuthentication.Domain;

namespace Benchmark.Domain.Layout
{
        public class UserMenu : UserMenuBase
        {
            public UserMenu(List<Menu> mainMenus, string userRoleText)
            {
                UserRoleText = userRoleText;
                UserRoleType = "label label-warning col-md-3 login-status-display";

                NavbarLeft = mainMenus;
                NavbarRight = new List<Menu>();

                NavbarRight.AddRange(new List<Menu>
                {
                    new Menu
                    {
                        Id = 1,
                        Text = "Sign Off",
                        HRef = "Account/Logoff",
                        UseRootUrl = true,
                        Role = "",
                        DataToggle = "",
                        DropDown = new List<Menu>()
                    }
                });
            }

            
        }
    }
