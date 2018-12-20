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
    public partial class DrinksChoosen : Form
    {
        protected List<Model.MenuItem> Drinks;
        protected List<OrderItem> ChoosenItems;
        private Order order;
        private MenuItemService menuItemService = new MenuItemService();
        private OrderService bestelService = new OrderService();
        private Model.MenuItem ChoosenItem;

        public DrinksChoosen(int DrinksKind, List<OrderItem> ChoosenItems, Order order)
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {

        }
    }
}
