using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class ChangeAssignToAsignMenus : Script
    {
        public string GetScript()
        {
            return @"UPDATE [dbo].[menu_item]
                       SET [href] = 'UserRoles/AssignMenus'
                     WHERE id = 3

                     UPDATE [dbo].[menu_item]
                       SET [href] = 'UserRoles/CreateUserRoles'
                     WHERE id = 2";
        }
    }
}