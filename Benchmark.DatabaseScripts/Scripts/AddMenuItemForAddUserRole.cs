using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddMenuItemForAddUserRole : Script
    {
        public string GetScript()
        {
            return @"
                INSERT INTO [dbo].[menu_item]
                   ([text]
                   ,[href]
                   ,[role]
                   ,[data_toggle]
                   ,[is_header]
                   ,[translation_key])
                VALUES
                   ('Add User Roles'
                   ,'UserRoles/AddUserRole'
                   ,null
                   ,null
                   ,1
                   ,'Add user roles')
            ";
        }
    }
}