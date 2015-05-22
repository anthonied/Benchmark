using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class CreatPersonalInformationTable : Script
    {
        public string GetScript()
        {
            return @"BEGIN TRANSACTION
                    SET QUOTED_IDENTIFIER ON
                    SET ARITHABORT ON
                    SET NUMERIC_ROUNDABORT OFF
                    SET CONCAT_NULL_YIELDS_NULL ON
                    SET ANSI_NULLS ON
                    SET ANSI_PADDING ON
                    SET ANSI_WARNINGS ON
                    COMMIT
                    BEGIN TRANSACTION
                    ALTER TABLE dbo.users SET (LOCK_ESCALATION = TABLE)
                    COMMIT
                    select Has_Perms_By_Name(N'dbo.users', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.users', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.users', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
                    CREATE TABLE dbo.personal_information
	                    (
	                    id int NOT NULL IDENTITY (1, 1),
	                    user_id int NOT NULL,
	                    id_number int NULL
	                    )  ON [PRIMARY]
                    ALTER TABLE dbo.personal_information ADD CONSTRAINT
	                    PK_personal_information PRIMARY KEY CLUSTERED 
	                    (
	                    id
	                    ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

                    ALTER TABLE dbo.personal_information ADD CONSTRAINT
	                    FK_personal_information_users FOREIGN KEY
	                    (
	                    user_id
	                    ) REFERENCES dbo.users
	                    (
	                    base_id
	                    ) ON UPDATE  NO ACTION 
	                     ON DELETE  NO ACTION 
	
                    ALTER TABLE dbo.personal_information SET (LOCK_ESCALATION = TABLE)
                    COMMIT";
        }
    }
}