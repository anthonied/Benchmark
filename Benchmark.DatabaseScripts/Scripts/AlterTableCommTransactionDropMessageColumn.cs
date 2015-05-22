using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AlterTableCommTransactionDropMessageColumn : Script
    {
        public string GetScript()
        {
            return @"ALTER TABLE comm_transactions
                     DROP COLUMN message";
        }
    }
}