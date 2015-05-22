using SolutionServer.DatabaseManager.Domain;

namespace Benchmark.DatabaseScripts.Scripts
{
    internal class AddRelationshipsToUserRoleMenuItemAndUsers : Script
    {
        public string GetScript()
        {
            return @"ALTER TABLE user_role_menu_item
        ADD CONSTRAINT FK_user_role_menu_item_user_role
		   FOREIGN KEY (user_role_id)
			REFERENCES user_role(id)

        ALTER TABLE user_role_menu_item
        ADD CONSTRAINT FK_user_role_menu_item_menu_item
		   FOREIGN KEY (menu_item_id)
			REFERENCES menu_item(id)

        ALTER TABLE users
        ADD CONSTRAINT FK_users_user_type	
		   FOREIGN KEY (user_type_id)
			REFERENCES user_type(id)

";
        }
    }
}
