using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AlterTableCommTransactionAddClientIdFkReference : Script
    {
        public string GetScript()
        {
            return @"ALTER TABLE comm_transactions 
                    ADD CONSTRAINT FK_comm_transactions_client_id 
                    FOREIGN KEY(client_id)
                    REFERENCES clients (id)";
        }
    }
}