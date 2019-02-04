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
    public partial class Overview : Form
    {
        private Function function;
        OverviewService overviewService = new OverviewService();

        public Overview(Function function, Employee employee)
        {
            InitializeComponent();
            LoginService login = new LoginService();            
            function = login.funtion(employee);

            if (function == Function.Barkeeper)
            {
                label_Overview.Text = "Bar Overview";
            }
            else
            {
                label_Overview.Text = "Kitchen Overview";
            }

            ListView lv = listView_OrderOverview;
            {
                lv.View = View.Details;
                lv.Columns.Add("Id", -2, HorizontalAlignment.Left);
                lv.Columns.Add("Name", -2, HorizontalAlignment.Left);
                lv.Columns.Add("Count", -2, HorizontalAlignment.Left);
                lv.Columns.Add("Table", -2, HorizontalAlignment.Left);
                lv.Columns.Add("Comment", -2, HorizontalAlignment.Left);
            }

            GetOrders(function);
        }

        private void GetOrders(Function function)
        {
            List<OrderItem> OrderItemList = overviewService.OrderItemList(function);

            foreach (OrderItem Item in OrderItemList)
            {
                ListViewItem row = new ListViewItem(Item.Order.OrderId.ToString());
                row.SubItems.Add(Item.MenuItem.Name);
                row.SubItems.Add(Item.Count.ToString());
                row.SubItems.Add(Item.Table.TableId.ToString());
                row.SubItems.Add(Item.Comment);
                row.Tag = Item;
                listView_OrderOverview.Items.Add(row);
            }
        }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {

        }

        private void button_OrderReady_Click(object sender, EventArgs e)
        {

        }

        public void AutoRefresh()
        {
            while (listView_OrderOverview.Items.Count == 0)
            {
                GetOrders(function);
            }

        }
    }
}
