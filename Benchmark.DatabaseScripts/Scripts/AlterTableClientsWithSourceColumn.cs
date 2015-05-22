using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts
{
    public class AlterTableClientsWithSourceColumn : Script
    {
        public string GetScript()
        {
            return @"ALTER TABLE clients ADD source varchar(50)";
        }
    }
}