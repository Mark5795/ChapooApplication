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
    public partial class Tables : Form
    {
        private int WhichView;

        public Tables(int view)
        {
            WhichView = view;
            InitializeComponent();
            GetTables();
        }

        private void GetTables()
        {
            TableService tableService = new TableService();

            List<Table> tableList = tableService.GetAllTables();

            tableLayoutPanel1.Controls.Clear();
            TableLayoutRowStyleCollection Rowstyles = tableLayoutPanel1.RowStyles;

            foreach (RowStyle style in Rowstyles)
            {
                style.SizeType = SizeType.AutoSize;
                style.Height = button_Table.Height;
            }

            foreach (Table table in tableList)
            {
                int id = table.TableId;
                Button tablebtn = new Button();
                tablebtn.Text = table.TableId.ToString();
                tablebtn.Font = new Font(tablebtn.Font.FontFamily, 16);
                tablebtn.Enabled = true;

                if (WhichView == 1)
                {
                    tablebtn.Click += (s, e) =>
                    {
                        int TableId = tableService.GetTableId(table);
                        this.Hide();
                        NewOrderMenu newOrder = new NewOrderMenu(TableId);
                        newOrder.Show();
                    };
                }
                else
                {
                    tablebtn.Click += (s, e) =>
                    {
                        tableService.ChangeTableStatus(table);
                        GetTables();
                    };
                }

                tablebtn.Size = button_Table.Size;

                switch (tableService.GetTableStatus(table))
                {
                    case TableStatus.Available:
                        tablebtn.BackColor = Color.Green;
                        break;

                    case TableStatus.Reserved:
                        tablebtn.BackColor = Color.Orange;
                        break;

                    case TableStatus.Taken:
                        tablebtn.BackColor = Color.Red;
                        break;

                    default:
                        break;
                }

                tablebtn.ForeColor = Color.White;
                tableLayoutPanel1.Controls.Add(tablebtn);
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            WaiterMenu menu = new WaiterMenu();
            menu.FormClosed += new FormClosedEventHandler(back_FormClosed);
            menu.Show();
            this.Hide();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            GetTables();
        }

        void back_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button_Table_Click(object sender, EventArgs e)
        {

        }
    }
}
