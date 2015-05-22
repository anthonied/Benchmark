using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddNewUserTypeMenuItemTable : Script
    {
        public string GetScript()
        {
            return @"IF OBJECT_ID('user_type_menu_item') IS NULL
                     CREATE TABLE user_type_menu_item(
	                    id int IDENTITY(1,1) NOT NULL,
	                    user_type_id int NULL,
	                    menu_item_id int NULL,
                        CONSTRAINT PK_user_type_menu_item PRIMARY KEY CLUSTERED 
                    (
	                    [id] ASC
                    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                    ) ON [PRIMARY]


                    ALTER TABLE [dbo].[user_type_menu_item]  WITH CHECK ADD  CONSTRAINT [FK_user_type_menu_item_menu_item] FOREIGN KEY([menu_item_id])
                    REFERENCES [dbo].[menu_item] ([id])

                    ALTER TABLE [dbo].[user_type_menu_item] CHECK CONSTRAINT [FK_user_type_menu_item_menu_item]

                    ALTER TABLE [dbo].[user_type_menu_item]  WITH CHECK ADD  CONSTRAINT [FK_user_type_menu_item_user_type] FOREIGN KEY([user_type_id])
                    REFERENCES [dbo].[user_type] ([id])

                    ALTER TABLE [dbo].[user_type_menu_item] CHECK CONSTRAINT [FK_user_type_menu_item_user_type]
                    ";
        }
    }
}