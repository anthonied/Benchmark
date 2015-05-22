using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddExternalIdToCommTransactionsTable : Script
    {
        public string GetScript()
        {
            return @"ALTER TABLE comm_transactions 
                            ADD external_id varchar(200)";
        }
    }
}