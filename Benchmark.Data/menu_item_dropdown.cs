using Benchmark.Domain.Layout;

namespace Benchmark.Data
{
    public class menu_item_dropdown
    {
        public int parent_menu_item_id { get; set; }
        public int child_menu_item_id { get; set; }


        public DropdownMenu ToDomain()
        {
            return new DropdownMenu
            {
                ParentId = parent_menu_item_id,
                ChildId = child_menu_item_id
            };
        }
    }
}
