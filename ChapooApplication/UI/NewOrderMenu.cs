using ChapooApplication.Logica;
using ChapooApplication.Model;
using ChapooApplication.UI.NewOrder;
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
    public partial class NewOrderMenu : Form
    {
        public List<OrderItem> ChoosenItems = new List<OrderItem>();
        protected Order order;
        protected Table ChoosenTable;

        public NewOrderMenu(int TableId)
        {
            ChoosenTable = new Table(TableId, 3);
            InitializeComponent();
            ChangeLabelText();

            //de laaste nu moet nog verandert worden zodat er gekozen wordt met wat er betaald wordt dmv buttons!!!
            order = new Order(0, ChoosenTable, TimeSpan.FromTicks(DateTime.Now.Ticks), DateTime.Now, false, 0);
            ListView lv = listView_OrderItems;
            {
                lv.View = View.Details;
                lv.Columns.Add("Id", -2, HorizontalAlignment.Left);
                lv.Columns.Add("Naam", -2, HorizontalAlignment.Left);
                lv.Columns.Add("Aantal", -2, HorizontalAlignment.Left);
            }

            additems(ChoosenItems);
        }

        private void ChangeLabelText()
        {
            label_TableId.Text = ChoosenTable.TableId.ToString();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            int TableView = 1;
            this.Hide();
            Tables tables = new Tables(TableView);
            tables.FormClosed += new FormClosedEventHandler(back_FormClosed);
            tables.Show();
        }

        void back_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {

        }

        private void label_TableId_Click(object sender, EventArgs e)
        {

        }

        public void additems(List<OrderItem> choosenItems)
        {
            listView_OrderItems.Items.Clear();

            foreach (OrderItem choosenItem in choosenItems)
            {
                ListViewItem lvi = new ListViewItem(choosenItem.OrderItemId.ToString());
                lvi.SubItems.Add(choosenItem.MenuItem.Name);
                lvi.SubItems.Add(choosenItem.Count.ToString());
                listView_OrderItems.Items.Add(lvi);
            }

        }

        void NewOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sender.GetType() == typeof(DrinksKind))
            {
                NewOrder_FormClosed((DrinksKind)sender);
            }
            else if (sender.GetType() == typeof(FoodsKind))
            {
                NewOrder_FormClosed((FoodsKind)sender);
            }
        }

        void NewOrder_FormClosed(DrinksKind sender)
        {
            ChoosenItems = sender.ChoosenItems;
            this.additems(ChoosenItems);
            this.Show();
        }

        void NewOrder_FormClosed(FoodsKind sender)
        {
            ChoosenItems = sender.ChoosenItems;
            this.additems(ChoosenItems);
            this.Show();
        }

        private void button_Drinks_Click(object sender, EventArgs e)
        {
            DrinksKind form = new DrinksKind(ChoosenItems, order);
            form.FormClosed += new FormClosedEventHandler(NewOrder_FormClosed);
            this.Hide();
            form.Show();
        }

        private void button_Food_Click(object sender, EventArgs e)
        {
            FoodsKind form = new FoodsKind(ChoosenItems, order);
            form.FormClosed += new FormClosedEventHandler(NewOrder_FormClosed);
            this.Hide();
            form.Show();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            OrderService orderService = new OrderService();
            orderService.AddOrder(ChoosenItems);
            ChoosenItems.RemoveRange(0, ChoosenItems.Count);
            additems(ChoosenItems);
        }


        private void button_plus_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listView_OrderItems.SelectedIndices[0];
                ChoosenItems[index].Count++;
                additems(ChoosenItems);
            }
            catch (Exception)
            {

            }
        }

        private void button_min_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listView_OrderItems.SelectedIndices[0];
                ChoosenItems[index].Count--;
                additems(ChoosenItems);
            }
            catch (Exception)
            {

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listView_OrderItems.SelectedIndices[0];
                ChoosenItems.RemoveAt(index);
                additems(ChoosenItems);
            }
            catch (Exception)
            {

            }
        }
    }
}
