using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class ChangeIdNumberInPersonalInformationToVarchar : Script
    {
        public string GetScript()
        {
            return @"ALTER TABLE personal_information
                    ALTER COLUMN id_number varchar(13)";
        }
    }
}