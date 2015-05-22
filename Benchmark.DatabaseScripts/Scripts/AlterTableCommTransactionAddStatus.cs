using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AlterTableCommTransactionAddStatus : Script
    {
        public string GetScript()
        {
            return @"ALTER TABLE comm_transactions ADD status varchar(20)";
        }
    }
}