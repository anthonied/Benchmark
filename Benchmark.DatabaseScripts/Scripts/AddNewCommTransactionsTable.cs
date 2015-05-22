using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddNewCommTransactionsTable : Script
    {
        public string GetScript()
        {
            return @"CREATE TABLE dbo.comm_transactions(
                                  id int IDENTITY(1,1) NOT NULL,
                                  type varchar(50) NULL,
                                  source varchar(50) NULL,
                                  recipient varchar(50) NULL,
                                  subject varchar(50) NULL,
                                  time_stamp datetime NULL,
                     CONSTRAINT PK_comm_transactions PRIMARY KEY CLUSTERED 
                    (
                    	[id] ASC
                    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                    ) ON [PRIMARY]";
        }
    }
}