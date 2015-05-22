using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddAContentDropdownMenu : Script
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
                   (6
                   ,'Edit Content'
                   ,'Content/EditContent'
                   ,null
                   ,null
                   ,0
                   ,'EditContent')

                INSERT INTO [dbo].[menu_item]
                   ([id]
                   ,[text]
                   ,[href]
                   ,[role]
                   ,[data_toggle]
                   ,[is_header]
                   ,[translation_key])
                VALUES
                   (7
                   ,'Content'
                   ,null
                   ,null
                   ,'dropdown'
                   ,1
                   ,'Content')
                    SET IDENTITY_INSERT [dbo].[user_type_menu_item] OFF 

                INSERT INTO [dbo].[menu_item_dropdown]
                    ([parent_menu_item_id]
                    ,[child_menu_item_id])
                VALUES
                    (7
                    ,6)
            ";
        }
    }
}