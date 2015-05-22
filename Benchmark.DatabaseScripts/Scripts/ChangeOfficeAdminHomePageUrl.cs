using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class ChangeOfficeAdminHomePageUrl:Script
    {
        public string GetScript()
        {
            return @"UPDATE user_type SET start_page = 'Home/OfficeAdmin' WHERE id = 3";
        }
    }
}
