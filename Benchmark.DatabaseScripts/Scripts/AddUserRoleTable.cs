using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddUserRoleTable : Script
    {
        public string GetScript()
        {
            return @"
                CREATE TABLE dbo.user_role
	                (
	                id int NOT NULL IDENTITY (1, 1),
	                user_role varchar(50) NULL
	                )  ON [PRIMARY]
                ALTER TABLE dbo.user_role ADD CONSTRAINT
	                PK_user_role PRIMARY KEY CLUSTERED 
	                (
	                id
	                ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
            ";
        }
    }
}