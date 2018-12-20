using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooApplication.Model
{
    public class MenuItem
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }

        public MenuItem()
        {

        }

        public MenuItem(int ItemId, string Name, float Price, int Count)
        {
            this.ItemId = ItemId;
            this.Name = Name;
            this.Price = Price;
            this.Count = Count;
        }
    }
}
