using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooApplication.Model
{
    public class Menu
    {
        public int MenuId { get; private set; }
        public MenuItem menuItem { get; set; }
        public int MenuCategorie { get; set; }

        public Menu(int MenuId, MenuItem menuItem, int MenuCategorie)
        {
            this.MenuId = MenuId;
            this.menuItem = menuItem;
            this.MenuCategorie = MenuCategorie;
        }

    }
}
