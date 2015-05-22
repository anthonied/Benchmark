using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddSmsMenuItem : Script
    {
        public string GetScript()
        {
            return @"
                    SET IDENTITY_INSERT [dbo].[menu_item] ON 
                        INSERT [dbo].[menu_item] ([id], [text], [href], [role], [data_toggle], [is_header], [translation_key]) VALUES (3, 'SMS', 'Sms/Index', NULL, NULL, 1, 'SMS');
                    SET IDENTITY_INSERT [dbo].[menu_item] OFF

                    INSERT INTO [dbo].[user_type_menu_item]
                        ([user_type_id]
                        ,[menu_item_id])
                    VALUES
                        (3
                        ,3)
            ";
        }
    }
}