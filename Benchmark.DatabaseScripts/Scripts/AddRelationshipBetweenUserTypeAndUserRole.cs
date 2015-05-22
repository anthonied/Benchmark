using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddRelationshipBetweenUserTypeAndUserRole : Script
    {
        public string GetScript()
        {
            return @"
                ALTER TABLE dbo.users ADD CONSTRAINT
	                FK_users_user_role FOREIGN KEY
	                (
	                user_role_id
	                ) REFERENCES dbo.user_role
	                (
	                id
	                ) ON UPDATE  NO ACTION 
	                 ON DELETE  NO ACTION 
            ";
        }
    }
}