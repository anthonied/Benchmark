using Benchmark.DatabaseScripts.Scripts;
using SolutionServer.DatabaseManager.Domain;
using System.Collections.Generic;

namespace Benchmark.DatabaseScripts
{
    public class DatabaseScripts
    {
        public Dictionary<int, Script> Scripts
        {
            get
            {
                return new Dictionary<int, Script>
                {
                    {0, new Initialization()},
                    {1, new AddNewMenuItemTable()},
                    {2, new AddNewUserTypeMenuItemTable()},
                    {3, new AddNewMenuItemDropdown()},
                    {4, new InsertHomeMenuIntoMenuItemTable()},
                    {5, new InsertHomeMenusIntoUserTypeMenuItemTable()},
                    {6, new AddUserRoleTable()},
                    {7, new ExtendUsersTableWithUserRole()},
                    {8, new AddIsActiveToUserTable()},
                    {9, new ChangeOfficeAdminHomePageUrl()},
                    {10, new AddIsApprovedColumnToUserTable()},
                };
            }
        }
    }
}