using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddIsApprovedColumnToUserTable : Script
    {
        public string GetScript()
        {
            return @"ALTER TABLE dbo.users ADD
	                 is_approved bit NOT NULL CONSTRAINT DF_users_is_approved DEFAULT 0";
        }
    }
}