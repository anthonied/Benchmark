using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benchmark.Data;
using Benchmark.Domain.Layout;
using Dapper;
using UserAuthentication.Domain;

namespace Benchmark.Repository
{
    public class MenuRepository : RepositoryBase
    {
        public List<Menu> GetUserTypeMainMenusById(int userType)
        {
            var dBMenus = _db.Query<menu_item_data>(@"
                SELECT menuitem.*
                  FROM user_type_menu_item usertypemenuitem
                  inner join menu_item menuitem on usertypemenuitem.menu_item_id = menuitem.id
                  where usertypemenuitem.user_type_id = @UserType 
                  AND menuitem.is_header = 'true'",
            new
            {
                UserType = userType
            });

            return dBMenus.Select(menu => menu.ToDomain()).ToList();
        }

        public List<DropdownMenu> GetDropdownRelationship()
        {
            var dropdown = _db.Query<menu_item_dropdown>(@"SELECT * FROM menu_item_dropdown 
                                                            INNER JOIN menuitem on ");
            return dropdown.Select(menu => menu.ToDomain()).ToList();
        }

        public List<Menu> GetDropdownsForMainMenuById(int id)
        {
            var dBMenus = _db.Query<menu_item_data>(@"
                SELECT menu_item.*
                  FROM menu_item 
                  inner join menu_item_dropdown  on menu_item.id = menu_item_dropdown.child_menu_item_id
                  where menu_item_dropdown.parent_menu_item_id = @id",
            new
            {
                id
            });

            return dBMenus.Select(menu => menu.ToDomain()).ToList();
        }

        public List<Menu> GetAllMainMenuItems()
        {
            return _db.Query<menu_item_data>(@"SELECT *
                                               FROM menu_item
                                               WHERE is_header = 'true'")
                .ToList()
                .Select(item => item.ToDomain())
                .ToList();
        }

        public List<Menu> GetUserRoleMainMenusById(int userRole)
        {
            var dBMenus = _db.Query<menu_item_data>(@"
                SELECT menuitem.*
                  FROM user_role_menu_item userrolemenuitem
                  inner join menu_item menuitem on userrolemenuitem.menu_item_id = menuitem.id
                  where userrolemenuitem.user_role_id = @UserRole",
            new
            {
                UserRole = userRole
            });

            return dBMenus.Select(menu => menu.ToDomain()).ToList();
        }
    }
}
