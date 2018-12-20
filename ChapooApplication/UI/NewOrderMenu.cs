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
    public partial class NewOrderMenu : Form
    {
        public List<OrderItem> ChoosenItems = new List<OrderItem>();
        protected Order order;
        int TableNr;

        public NewOrderMenu(int TableId)
        {
            TableNr = TableId;
            InitializeComponent();
            ChangeLabelText();
        }

        private void ChangeLabelText()
        {
            label_TableId.Text = TableNr.ToString();
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
            //else if (sender.GetType() == typeof(FoodsKind))
            //{
            //    NewOrder_FormClosed((FoodsKind)sender);
            //}
        }

        void NewOrder_FormClosed(DrinksKind sender)
        {
            ChoosenItems = sender.ChoosenItems;
            this.additems(ChoosenItems);
            this.Show();
        }

        private void button_Drinks_Click(object sender, EventArgs e)
        {
            //gekozenTafel = (Tafel)cmb_Tafelnummer.SelectedItem;
            DrinksKind form = new DrinksKind(ChoosenItems, order);
            form.FormClosed += new FormClosedEventHandler(NewOrder_FormClosed);
            this.Hide();
            form.Show();
        }
    }
}
