using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AlterTableCommTransactionColumnOrder : Script
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
BEGIN TRANSACTION
CREATE TABLE dbo.Tmp_comm_transactions
	(
	id int NOT NULL IDENTITY (1, 1),
	client_id int NULL,
	type varchar(50) NULL,
	source varchar(50) NULL,
	recipient varchar(50) NULL,
	subject varchar(50) NULL,
	time_stamp datetime NULL,
	external_id varchar(200) NULL,
	status varchar(20) NULL
	)  ON [PRIMARY]
ALTER TABLE dbo.Tmp_comm_transactions SET (LOCK_ESCALATION = TABLE)
SET IDENTITY_INSERT dbo.Tmp_comm_transactions ON
IF EXISTS(SELECT * FROM dbo.comm_transactions)
	 EXEC('INSERT INTO dbo.Tmp_comm_transactions (id, client_id, type, source, recipient, subject, time_stamp, external_id, status)
		SELECT id, client_id, type, source, recipient, subject, time_stamp, external_id, status FROM dbo.comm_transactions WITH (HOLDLOCK TABLOCKX)')
SET IDENTITY_INSERT dbo.Tmp_comm_transactions OFF
DROP TABLE dbo.comm_transactions
EXECUTE sp_rename N'dbo.Tmp_comm_transactions', N'comm_transactions', 'OBJECT' 
ALTER TABLE dbo.comm_transactions ADD CONSTRAINT
	PK_comm_transactions PRIMARY KEY CLUSTERED 
	(
	id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]";
        }
    }
}