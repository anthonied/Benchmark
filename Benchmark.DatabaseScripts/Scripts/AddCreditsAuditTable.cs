using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddCreditsAuditTable : Script
    {
        public string GetScript()
        {
            return @"
                     CREATE TABLE credits_audit
                    (
                    id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
                    client_id int NOT NULL,
                    old_balance int,
                    qty int,
                    new_balance int);
                    ";
        }
    }
}

