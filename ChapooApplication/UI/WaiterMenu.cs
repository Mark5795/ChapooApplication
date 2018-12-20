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
    public partial class WaiterMenu : Form
    {
        private int TableView;
        //private string TableView;


        public WaiterMenu()
        {
            InitializeComponent();
        }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void button_NewOrder_Click(object sender, EventArgs e)
        {
            TableView = 1;
            this.Hide();
            Tables tables = new Tables(TableView);
            tables.FormClosed += new FormClosedEventHandler(back_FormClosed);
            tables.Show();
        }

        private void button_ChangeOrder_Click(object sender, EventArgs e)
        {

        }

        private void button_OrderStatus_Click(object sender, EventArgs e)
        {

        }

        private void button_Checkout_Click(object sender, EventArgs e)
        {

        }

        private void button_tables_Click(object sender, EventArgs e)
        {
            TableView = 0;
            this.Hide();
            Tables tables = new Tables(TableView);
            tables.FormClosed += new FormClosedEventHandler(back_FormClosed);
            tables.Show();
        }

        void back_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
