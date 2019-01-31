using ChapooApplication.DAL;
using ChapooApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooApplication.Logica
{
    class MenuItemService
    {
        IMenuDAL menuDAL = new MenuDAL();
        IItemDAL itemDAL = new ItemDAL();

        public List<MenuItem> FilterDrinks(int DrankKind)
        {
            List<Menu> menus = menuDAL.GetItemByCategorie(DrankKind);

            List<MenuItem> Drinks = new List<MenuItem>();

            foreach (Menu menu in menus)
            {
                if (menu.menuItem.Count > 0)
                {
                    Drinks.Add(menu.menuItem);
                }
            }

            return Drinks;
        }

        public List<MenuItem> FilterFoods(int FoodKind)
        {
            List<Menu> menus = menuDAL.GetItemByCategorie(FoodKind);

            List<MenuItem> foods = new List<MenuItem>();

            foreach (Menu menu in menus)
            {
                if (menu.menuItem.Count > 0)
                {
                    foods.Add(menu.menuItem);
                }
            }

            return foods;
        }
    }
}
