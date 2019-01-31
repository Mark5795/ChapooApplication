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

namespace ChapooApplication.UI.NewOrder
{
    public partial class FoodsKind : Form
    {
        Button btn_LunchMain = new Button();
        Button btn_LunchDessert = new Button();

        Button btn_DinnerEntremets = new Button();
        Button btn_DinnerMain = new Button();
        Button btn_DinnerDessert = new Button();

        protected int FoodKind;
        protected List<OrderItem> choosenItems = new List<OrderItem>();
        protected Order order;

        public List<OrderItem> ChoosenItems
        {
            get { return choosenItems; }
        }

        public FoodsKind(List<OrderItem> choosenItems, Order order)
        {
            InitializeComponent();
            ShowLunchSorts();
            ShowDinnerSorts();
            this.choosenItems = choosenItems;
            this.order = order;
        }

        private void ShowLunchSorts()
        {
            TableLayoutRowStyleCollection Rowstyles = tableLayoutPanel1.RowStyles;
            foreach (RowStyle style in Rowstyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = button_LunchKind.Height;
            }

            button_LunchKind.Text = "Starters";
            button_LunchKind.Name = "btn_LunchStarters";
            tableLayoutPanel1.Controls.Add(button_LunchKind, 0, 0);

            btn_LunchMain.Size = button_LunchKind.Size;
            btn_LunchMain.Text = "Main";
            btn_LunchMain.Click += new EventHandler(Btn_LunchMain_Click);
            tableLayoutPanel1.Controls.Add(btn_LunchMain, 0, 1);

            btn_LunchDessert.Size = button_LunchKind.Size;
            btn_LunchDessert.Text = "Dessert";
            btn_LunchDessert.Click += new EventHandler(Btn_LunchDessert_Click);
            tableLayoutPanel1.Controls.Add(btn_LunchDessert, 0, 2);

        }

        private void ShowDinnerSorts()
        {
            TableLayoutRowStyleCollection Rowstyles = tableLayoutPanel2.RowStyles;
            foreach (RowStyle style in Rowstyles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = button_DinnerKind.Height;
            }

            button_DinnerKind.Text = "Starters";
            button_DinnerKind.Name = "btn_DinnerStarters.";
            tableLayoutPanel2.Controls.Add(button_DinnerKind, 1, 0);

            btn_DinnerEntremets.Size = button_DinnerKind.Size;
            btn_DinnerEntremets.Text = "Entremets";
            btn_DinnerEntremets.Click += new EventHandler(Btn_DinnerEntremets_Click);
            tableLayoutPanel2.Controls.Add(btn_DinnerEntremets, 1, 1);

            btn_DinnerMain.Size = button_DinnerKind.Size;
            btn_DinnerMain.Text = "Main";
            btn_DinnerMain.Click += new EventHandler(Btn_DinnerMain_Click);
            tableLayoutPanel2.Controls.Add(btn_DinnerMain, 1, 2);

            btn_DinnerDessert.Size = button_DinnerKind.Size;
            btn_DinnerDessert.Text = "Dessert";
            btn_DinnerDessert.Click += new EventHandler(Btn_DinnerDessert_Click);
            tableLayoutPanel2.Controls.Add(btn_DinnerDessert, 1, 3);
        }


        private void button_LunchKind_Click(object sender, EventArgs e)
        {
            ItemChoosen form = new ItemChoosen((int)FoodCategories.L_Starters, choosenItems, order);
            form.FormClosed += new FormClosedEventHandler(FoodsKind_FormClosed);
            form.Show();
            this.Hide();
        }

        private void button_DinnerKind_Click(object sender, EventArgs e)
        {
            ItemChoosen form = new ItemChoosen((int)FoodCategories.D_Starters, choosenItems, order);
            form.FormClosed += new FormClosedEventHandler(FoodsKind_FormClosed);
            form.Show();
            this.Hide();
        }

        private void Btn_LunchMain_Click(object sender, EventArgs e)
        {
            ItemChoosen form = new ItemChoosen((int)FoodCategories.L_Main, choosenItems, order);
            form.FormClosed += new FormClosedEventHandler(FoodsKind_FormClosed);
            form.Show();
            this.Hide();
        }

        private void Btn_LunchDessert_Click(object sender, EventArgs e)
        {
            ItemChoosen form = new ItemChoosen((int)FoodCategories.L_Dessert, choosenItems, order);
            form.FormClosed += new FormClosedEventHandler(FoodsKind_FormClosed);
            form.Show();
            this.Hide();
        }

        private void Btn_DinnerStarters_Click(object sender, EventArgs e)
        {
            ItemChoosen form = new ItemChoosen((int)FoodCategories.D_Starters, choosenItems, order);
            form.FormClosed += new FormClosedEventHandler(FoodsKind_FormClosed);
            form.Show();
            this.Hide();
        }

        private void Btn_DinnerEntremets_Click(object sender, EventArgs e)
        {
            ItemChoosen form = new ItemChoosen((int)FoodCategories.D_Entremets, choosenItems, order);
            form.FormClosed += new FormClosedEventHandler(FoodsKind_FormClosed);
            form.Show();
            this.Hide();
        }

        private void Btn_DinnerMain_Click(object sender, EventArgs e)
        {
            ItemChoosen form = new ItemChoosen((int)FoodCategories.D_Main, choosenItems, order);
            form.FormClosed += new FormClosedEventHandler(FoodsKind_FormClosed);
            form.Show();
            this.Hide();
        }

        private void Btn_DinnerDessert_Click(object sender, EventArgs e)
        {
            ItemChoosen form = new ItemChoosen((int)FoodCategories.D_Dessert, choosenItems, order);
            form.FormClosed += new FormClosedEventHandler(FoodsKind_FormClosed);
            form.Show();
            this.Hide();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void FoodsKind_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                FoodsKind form = (FoodsKind)sender;
                choosenItems = form.ChoosenItems;

                this.Show();
            }
            catch (Exception)
            {

                this.Show();
            }
        }
    }
}
