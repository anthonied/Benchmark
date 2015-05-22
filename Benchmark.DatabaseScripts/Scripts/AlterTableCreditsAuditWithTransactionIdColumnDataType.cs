using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts
{
    public class AlterTableCreditsAuditWithTransactionIdColumnDataType : Script
    {
        public string GetScript()
        {
            return @"ALTER TABLE credits_audit
                     ALTER COLUMN transaction_id int";
        }
    }
}