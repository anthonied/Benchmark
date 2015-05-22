using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddClientCreditRatesTable : Script
    {
        public string GetScript()
        {
            return @"CREATE TABLE client_credit_rates
                    (
                    id             int NOT NULL IDENTITY(1,1) PRIMARY KEY,
                    client_id      int NOT NULL,
                    email_rate     int,
                    sms_rate       int,
                    whatsapp_rate  int
                    )";
        }
    }
}