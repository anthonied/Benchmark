using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class CreateContentTable : Script
    {
        public string GetScript()
        {
            return @"
                CREATE TABLE [dbo].[content](
	                [name] varchar (50) NULL,
	                [information] varchar (max) NULL)";
        }
    }
}
