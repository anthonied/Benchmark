using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class InsertHomeMenuIntoMenuItemTable:Script
    {
        public string GetScript()
        {
            return @"
                    SET IDENTITY_INSERT [dbo].[menu_item] ON 
                        INSERT [dbo].[menu_item] ([id], [text], [href], [role], [data_toggle], [is_header], [translation_key]) VALUES (1, N'Home', N'Home/Index', NULL, NULL, 1, N'Home')
                    SET IDENTITY_INSERT [dbo].[menu_item] OFF
                    ";
        }
    }
}
