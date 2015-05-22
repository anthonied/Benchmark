using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class CreateNewUserRoleMenuItemTable : Script
    {
        public string GetScript()
        {
            return @"
                CREATE TABLE [dbo].[user_role_menu_item](
	                [id] [int] IDENTITY(1,1) NOT NULL,
	                [user_role_id] [int] NULL,
	                [menu_item_id] [int] NULL,
                 CONSTRAINT [PK_user_role_menu_item] PRIMARY KEY CLUSTERED 
                (
	                [id] ASC
                )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                ) ON [PRIMARY]
            ";
        }
    }
}