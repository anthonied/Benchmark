using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    public class AddNewMenuItemDropdown : Script
    {
        public string GetScript()
        {
            return @"IF OBJECT_ID('menu_item_dropdown') IS NULL
                     CREATE TABLE menu_item_dropdown(
	                    parent_menu_item_id int NOT NULL,
	                    child_menu_item_id int NOT NULL
                    ) ON [PRIMARY]


                    ALTER TABLE [dbo].[menu_item_dropdown]  WITH CHECK ADD  CONSTRAINT [FK_menu_item_dropdown_menu_item] FOREIGN KEY([parent_menu_item_id])
                    REFERENCES [dbo].[menu_item] ([id])

                    ALTER TABLE [dbo].[menu_item_dropdown] CHECK CONSTRAINT [FK_menu_item_dropdown_menu_item]

                    ALTER TABLE [dbo].[menu_item_dropdown]  WITH CHECK ADD  CONSTRAINT [FK_menu_item_dropdown_menu_item1] FOREIGN KEY([child_menu_item_id])
                    REFERENCES [dbo].[menu_item] ([id])

                    ALTER TABLE [dbo].[menu_item_dropdown] CHECK CONSTRAINT [FK_menu_item_dropdown_menu_item1]
                    ";
        }
    }
}