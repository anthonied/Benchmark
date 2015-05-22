using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class ExtendUsersTableWithUserRole : Script
    {
        public string GetScript()
        {
            return @"
                ALTER TABLE dbo.users ADD
	                user_role_id int NULL
            ";
        }
    }
}