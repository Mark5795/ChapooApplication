using ChapooApplication.Logica;
using ChapooApplication.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooApplication.UI
{
    public partial class ItemChoosen : Form
    {
        protected List<Model.MenuItem> items;
        protected List<OrderItem> choosenItems;
        private Order order;
        private MenuItemService menuItemService = new MenuItemService();
        private OrderService orderService = new OrderService();
        private Model.MenuItem ChoosenItem;

        public ItemChoosen(int ItemsKind, List<OrderItem> choosenItems, Order order)
        {
            InitializeComponent();
            this.choosenItems = choosenItems;
            this.order = order;
            if (ItemsKind >= 7)
            {
                items = menuItemService.FilterDrinks(ItemsKind);
            }
            else
            {
                items = menuItemService.FilterFoods(ItemsKind);
            }
            AddButtons(items);
        }

        public List<OrderItem> ChoosenItems
        {
            get
            {
                return choosenItems;
            }
        }

        private void AddButtons(List<Model.MenuItem> items)
        {
            tableLayoutPanel1.ColumnCount = 2;
            if (items.Count % 2 == 1)
            {
                tableLayoutPanel1.RowCount = ((items.Count / 2) + 1);
            }
            else
            {
                tableLayoutPanel1.RowCount = items.Count / 2;
            }

            TableLayoutRowStyleCollection Rowstyles = tableLayoutPanel1.RowStyles;
            foreach (RowStyle style in Rowstyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = button_Item.Height;
            }

            button_Item.Name = items[0].Name;
            button_Item.Tag = items[0];
            button_Item.Text = items[0].Name;
            button_Item.Click += (s, e) => {
                ChoosenItem = (Model.MenuItem)button_Item.Tag;
            };

            for (int i = 1; i < items.Count; i++)
            {
                Button b = new Button();
                b.Name = "btn_" + items[i].Name;
                b.Tag = items[i];
                b.Text = items[i].Name;
                b.Size = button_Item.Size;
                b.Click += (s, e) => {
                    ChoosenItem = (Model.MenuItem)b.Tag;
                };
                tableLayoutPanel1.Controls.Add(b);
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (ChoosenItem != null)
            {
                choosenItems = orderService.CreateOrder(choosenItems, ChoosenItem, richTextBox_Comment.Text, order);
                this.Close();
            }
        }
    }
}
