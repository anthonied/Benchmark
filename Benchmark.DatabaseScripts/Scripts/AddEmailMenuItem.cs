using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddEmailMenuItem : Script
    {
        public string GetScript()
        {
            return @" SET IDENTITY_INSERT menu_item ON 
                        INSERT menu_item (id, text, href, role, data_toggle, is_header, translation_key)
                        VALUES           (5, 'Email', 'Email/Index', NULL, NULL, 1, 'Email');
                    
                    SET IDENTITY_INSERT menu_item OFF

                    INSERT INTO user_type_menu_item
                                      (user_type_id
                                      ,menu_item_id)
                                             VALUES
                                                 (3
                                                 ,5)
";
        }
    }
}