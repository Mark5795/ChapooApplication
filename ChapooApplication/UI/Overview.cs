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
            GetOrders(function);
        }

        private void GetOrders(Function function)
        {
            OverviewService overviewService = new OverviewService();

            ////vul de list met menuitems
            //List<Model.BestelItem> LijstBestelItem = Overzicht.BestelItemLijst(functie);


            ////maak voor elk item een kolom
            //foreach (Model.BestelItem Item in LijstBestelItem)
            //{
            //    ListViewItem rij = new ListViewItem(Item.Bestelling.BestellingId.ToString());
            //    rij.SubItems.Add(Item.Item.Naam);
            //    rij.SubItems.Add(Item.Aantal.ToString());
            //    rij.SubItems.Add(Item.Tafel.ToString());
            //    rij.SubItems.Add(Item.Commentaar);
            //    rij.Tag = Item;
            //    lst_Overzicht.Items.Add(rij);

            //}
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
