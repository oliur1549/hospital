using System;
using System.Collections.Generic;
using System.Text;

namespace HealthLab.Framework.Menu
{
    public class MenuItems
    {
        public string Title { get; set; }
        public IList<MenuChildItem> menuChildItems { get; set; }
    }
}
