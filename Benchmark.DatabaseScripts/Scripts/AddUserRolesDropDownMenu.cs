using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    class AddUserRolesDropDownMenu : Script
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
                   (4
                   ,'User Roles'
                   ,null
                   ,null
                   ,'dropdown'
                   ,1
                   ,'UserRoles')
                    SET IDENTITY_INSERT [dbo].[user_type_menu_item] OFF 
            ";
        }
    }
}