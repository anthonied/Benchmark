using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddWhatsAppMenuItem : Script
    {
        public string GetScript()
        {
            return @"
                    SET IDENTITY_INSERT [dbo].[menu_item] ON 
                        INSERT [dbo].[menu_item] ([id], [text], [href], [role], [data_toggle], [is_header], [translation_key]) VALUES (4, 'WhatsApp', 'Whatsapp/SendMessage', NULL, NULL, 1, 'WhatsApp');
                    SET IDENTITY_INSERT [dbo].[menu_item] OFF

                    INSERT INTO [dbo].[user_type_menu_item]
                        ([user_type_id]
                        ,[menu_item_id])
                    VALUES
                        (3
                        ,4)
            ";
        }
    }
}