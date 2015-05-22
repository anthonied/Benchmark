using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddMenuItemForAssignMenuItem : Script
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
                   (3
                   ,'Assign Menu Items'
                   ,'UserRoles/Assign'
                   ,null
                   ,null
                   ,1
                   ,'AssignMenuItems')
                    SET IDENTITY_INSERT [dbo].[user_type_menu_item] OFF 
            ";
        }
    }
}
