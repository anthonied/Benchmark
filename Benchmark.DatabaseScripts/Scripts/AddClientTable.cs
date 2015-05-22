using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddClientTable : Script
    {
        public string GetScript()
        {
            return @"
                    CREATE TABLE clients
                    (
                    id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
                    name varchar(255) NOT NULL,
                    api_key uniqueidentifier,
                    credit_balance int
                    );
                    ";
        }
    }
}