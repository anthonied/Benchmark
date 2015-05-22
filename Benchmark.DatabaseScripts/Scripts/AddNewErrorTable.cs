using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddNewErrorTable : Script
    {
        public string GetScript()
        {
            return @"CREATE TABLE dbo.error_logs
	(
	id int NOT NULL IDENTITY (1, 1),
	source varchar(50) NOT NULL,
	recipient varchar(50) NOT NULL,
	message varchar(300) NOT NULL,
	time_stamp datetime NOT NULL
	)  ON [PRIMARY]

ALTER TABLE dbo.error_logs ADD CONSTRAINT
	PK_error_logs PRIMARY KEY CLUSTERED 
	(
	id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]";
        }
    }
}