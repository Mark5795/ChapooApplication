using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooApplication.Model;

namespace ChapooApplication.UI
{
    public partial class DrinksKind : Form
    {
        Button btn_Soda = new Button();
        Button btn_Beer = new Button();
        Button btn_Wine = new Button();        
        Button btn_Distilled = new Button();
        Button btn_WarmeDrank = new Button();

        protected List<OrderItem> choosenItems = new List<OrderItem>();
        protected Order order;

        public List<OrderItem> ChoosenItems
        {
            get
            {
                return choosenItems;
            }
        }

        public DrinksKind(List<OrderItem> ChoosenItems, Order order)
        {
            InitializeComponent();
        }

        private void DrinkButtons()
        {
            TableLayoutRowStyleCollection Rowstyles = tableLayoutPanel1.RowStyles;
            foreach (RowStyle style in Rowstyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = btn_Soda.Height;
            }

            btn_Soda.Text = "Soda";
            btn_Soda.Name = "btn_Soda";
            tableLayoutPanel1.Controls.Add(btn_Soda);

            btn_Wine.Size = btn_Soda.Size;
            btn_Wine.Text = "Wine";
            btn_Wine.Click += new EventHandler(btn_Wine_Click);
            tableLayoutPanel1.Controls.Add(btn_Wine);

            btn_Beer.Size = btn_Soda.Size;
            btn_Beer.Text = "Beer";
            btn_Beer.Click += new EventHandler(btn_Beer_Click);
            tableLayoutPanel1.Controls.Add(btn_Beer);

            btn_Distilled.Size = btn_Soda.Size;
            btn_Distilled.Text = "Distilled";
            btn_Distilled.Click += new EventHandler(btn_Distilled_Click);
            tableLayoutPanel1.Controls.Add(btn_Distilled);

            btn_WarmeDrank.Size = btn_Soda.Size;
            btn_WarmeDrank.Text = "Hot";
            btn_WarmeDrank.Click += new EventHandler(btn_WarmeDrank_Click);
            tableLayoutPanel1.Controls.Add(btn_WarmeDrank);
        }

        private void btn_Soda_Click(object sender, EventArgs e)
        {
            DrinksChoosen form = new DrinksChoosen((int)Drinks.Soda, ChoosenItems, order);
            form.FormClosed += new FormClosedEventHandler(DrinksKind_FormClosed);
            form.Show();
            this.Hide();
        }

        private void btn_Beer_Click(object sender, EventArgs e)
        {
            DrinksChoosen form = new DrinksChoosen((int)Drinks.Beer, ChoosenItems, order);
            form.FormClosed += new FormClosedEventHandler(DrinksKind_FormClosed);
            form.Show();
            this.Hide();
        }

        private void btn_Wine_Click(object sender, EventArgs e)
        {
            DrinksChoosen form = new DrinksChoosen((int)Drinks.Wine, ChoosenItems, order);
            form.FormClosed += new FormClosedEventHandler(DrinksKind_FormClosed);
            form.Show();
            this.Hide();
        }

        private void btn_Distilled_Click(object sender, EventArgs e)
        {
            DrinksChoosen form = new DrinksChoosen((int)Drinks.Distilled, ChoosenItems, order);
            form.FormClosed += new FormClosedEventHandler(DrinksKind_FormClosed);
            form.Show();
            this.Hide();
        }

        private void btn_WarmeDrank_Click(object sender, EventArgs e)
        {
            DrinksChoosen form = new DrinksChoosen((int)Drinks.Hot, ChoosenItems, order);
            form.FormClosed += new FormClosedEventHandler(DrinksKind_FormClosed);
            form.Show();
            this.Hide();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_DrinksKind_Click(object sender, EventArgs e)
        {
            
        }

        void DrinksKind_FormClosed(object sender, FormClosedEventArgs e)
        {
            Drinks form = (Drinks)sender;
            //ChoosenItems = form.ChoosenItems;
            this.Show();
        }
    }
}
