using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    class AssignExistingUserRoleMenuItemsToUserRoleDropDown: Script
    {
        public string GetScript()
        {
            return @"INSERT INTO [dbo].[menu_item_dropdown]
                               ([parent_menu_item_id]
                               ,[child_menu_item_id])
                         VALUES
                               (4
                               ,2)

INSERT INTO [dbo].[menu_item_dropdown]
                               ([parent_menu_item_id]
                               ,[child_menu_item_id])
                         VALUES
                               (4
                               ,3)

                        DELETE FROM [dbo].[user_type_menu_item]
                              WHERE user_type_id = 3
	                     AND menu_item_id = 2";
        }
    }
}
