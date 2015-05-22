using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAuthentication.Domain;

namespace Benchmark.Data
{
    public class menu_item_data
    {
        public int id { get; set; }
        public string text { get; set; }
        public string href { get; set; }
        public string role { get; set; }
        public string data_toggle { get; set; }
        public bool is_header { get; set; }
        public string translation_key { get; set; }

        public Menu ToDomain()
        {
            return new Menu
            {
                Id = id,
                DataToggle = data_toggle,
                HRef = href,
                UseRootUrl = true,
                IsHeader = is_header,
                Role = role,
                Text = text,
                DropDown = new List<Menu>()
            };
        }
    }
}
