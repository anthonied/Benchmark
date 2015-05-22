using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class Initialization : Script
    {
        public string GetScript()
        {
            return @"
                    CREATE TABLE [dbo].[user_type](
	                    [id] [int] IDENTITY(1,1) NOT NULL,
	                    [description] [varchar](50) NULL,
	                    [start_page] [varchar](50) NULL,
                     CONSTRAINT [PK_user_type] PRIMARY KEY CLUSTERED 
                    (
	                    [id] ASC
                    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                    ) ON [PRIMARY]
                    INSERT INTO [dbo].[user_type]
                               ([description],[start_page])
                         VALUES
                               ('Logged Out User','')

                    INSERT INTO [dbo].[user_type]
                               ([description],[start_page])
                         VALUES
                               ('General User','Home/LoggedInIndex')

                    INSERT INTO [dbo].[user_type]
                               ([description],[start_page])
                         VALUES
                               ('Office Admin','Home/LoggedInIndex')

                    CREATE TABLE [dbo].[users](
	                    [base_id] [int] IDENTITY(1,1) NOT NULL,
	                    [user_type_id] [int] NULL,
	                    [email_address] [varchar](30) NULL,
	                    [password] [varchar](20) NULL,
	                    [full_name] [varchar](30) NULL,
	                    [surname] [varchar](30) NULL,
	                    [confirmed] [bit] NOT NULL,
	                    [email_id] [uniqueidentifier] NOT NULL,
	                    [reset_password_id] [uniqueidentifier] NULL,
                     CONSTRAINT [PK__User__E7970876AAEA5660] PRIMARY KEY CLUSTERED 
                    (
	                    [base_id] ASC
                    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                    ) ON [PRIMARY]";
        }
    }
}
