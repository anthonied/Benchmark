using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts
{
    public class AlterTableCreditsAuditWithTransactionIdColumn : Script
    {
        public string GetScript()
        {
            return @"ALTER TABLE credits_audit ADD transaction_id varchar(200)";
        }
    }
}