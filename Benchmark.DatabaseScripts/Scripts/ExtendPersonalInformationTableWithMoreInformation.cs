using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class ExtendPersonalInformationTableWithMoreInformation : Script
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
                    ALTER TABLE dbo.personal_information ADD
	                    gender varchar(10) NULL,
	                    cellphone_number varchar(13) NULL,
	                    postal_address varchar(50) NULL,
	                    physical_address varchar(50) NULL
                    ALTER TABLE dbo.personal_information SET (LOCK_ESCALATION = TABLE)
                    COMMIT";
        }
    }
}