using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddIncompleteUserToUserTypeTable : Script
    {
        public string GetScript()
        {
            return @"SET IDENTITY_INSERT [dbo].[user_type] ON 
                     INSERT INTO [dbo].[user_type]
                           ([id]
                           ,[description]
                           ,[start_page])
                     VALUES
                           ('4'
                           ,'Incomplete User'
                           ,'Home/LoggedInIndex')
                     SET IDENTITY_INSERT [dbo].[user_type] OFF";
        }
    }
}