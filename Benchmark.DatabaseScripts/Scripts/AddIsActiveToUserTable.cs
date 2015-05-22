using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    class AddIsActiveToUserTable : Script
    {
        public string GetScript()
        {
            return @" ALTER TABLE dbo.users ADD
	                  is_active bit NOT NULL CONSTRAINT DF_users_is_active DEFAULT 1";
        }
    }
}
