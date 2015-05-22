using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class InsertHomeMenusIntoUserTypeMenuItemTable:Script
    {
        public string GetScript()
        {
            return @"
                        SET IDENTITY_INSERT [dbo].[user_type_menu_item] ON 
                            INSERT [dbo].[user_type_menu_item] ([id], [user_type_id], [menu_item_id]) VALUES (1, 1, 1)
                            INSERT [dbo].[user_type_menu_item] ([id], [user_type_id], [menu_item_id]) VALUES (2, 2, 1)
                            INSERT [dbo].[user_type_menu_item] ([id], [user_type_id], [menu_item_id]) VALUES (3, 3, 1)
                        SET IDENTITY_INSERT [dbo].[user_type_menu_item] OFF
                    ";
        }
    }
}
