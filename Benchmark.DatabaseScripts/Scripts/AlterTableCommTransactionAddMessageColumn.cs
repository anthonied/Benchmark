using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AlterTableCommTransactionAddMessageColumn : Script
    {
        public string GetScript()
        {
            return @"ALTER TABLE comm_transactions
                     ADD message varChar(MAX)";
        }
    }
}