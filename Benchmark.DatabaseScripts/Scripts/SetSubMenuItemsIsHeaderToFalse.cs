
using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    class SetSubMenuItemsIsHeaderToFalse: Script
    {
        public string GetScript()
        {
            return @"UPDATE [dbo].[menu_item]
   SET [is_header] = 0
 WHERE id = 2

UPDATE [dbo].[menu_item]
   SET [is_header] = 0
 WHERE id = 3";
        }
    }
}
