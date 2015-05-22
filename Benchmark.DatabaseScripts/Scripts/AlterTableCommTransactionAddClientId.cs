using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AlterTableCommTransactionAddClientId : Script
    {
        public string GetScript()
        {
            return @"ALTER TABLE comm_transactions ADD client_id int ";
        }
    }
}