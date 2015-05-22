using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddAssignUserRolesMenuItem : Script
    {
        public string GetScript()
        {
            return @"
                        SET IDENTITY_INSERT [dbo].[menu_item] ON 
                INSERT INTO [dbo].[menu_item]
                   ([id]
                   ,[text]
                   ,[href]
                   ,[role]
                   ,[data_toggle]
                   ,[is_header]
                   ,[translation_key])
                VALUES
                   (5
                   ,'Assign User Roles'
                   ,'UserRoles/AssignUserRoles'
                   ,null
                   ,null
                   ,0
                   ,'AssignUserRoles')
                    SET IDENTITY_INSERT [dbo].[user_type_menu_item] OFF 

                INSERT INTO [dbo].[menu_item_dropdown]
                    ([parent_menu_item_id]
                    ,[child_menu_item_id])
                VALUES
                    (4
                    ,5)
            ";
        }
    }
}