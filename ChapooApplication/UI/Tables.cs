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
        public Tables()
        {
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
                Button tafelbtn = new Button();
                tafelbtn.Text = table.TableId.ToString();
                tafelbtn.Font = new Font(tafelbtn.Font.FontFamily, 16);
                tafelbtn.Enabled = true;

                tafelbtn.Click += (s, e) =>
                {

                };

                tafelbtn.Size = button_Table.Size;

                switch (tableService.GetTableStatus(table))
                {
                    case TableStatus.Available:
                        tafelbtn.BackColor = Color.Green;
                        break;

                    case TableStatus.Reserved:
                        tafelbtn.BackColor = Color.Orange;
                        break;

                    case TableStatus.Taken:
                        tafelbtn.BackColor = Color.Red;
                        break;

                    default:
                        break;
                }

                tafelbtn.ForeColor = Color.White;
                tableLayoutPanel1.Controls.Add(tafelbtn);
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
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
