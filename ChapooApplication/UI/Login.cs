using ChapooApplication.Logica;
using ChapooApplication.Model;
using ChapooApplication.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_logIn_Click(object sender, EventArgs e)
        {
            try
            {
                int Employeeid = int.Parse(textBox_Id.Text);
                string EmployeePassword = textBox_password.Text; 
                Employee employee = new Employee(Employeeid, EmployeePassword);
                LoginService login = new LoginService();
                if (login.CheckLogin(employee))
                {
                    WaiterMenu menu = new WaiterMenu();
                    menu.FormClosed += new FormClosedEventHandler(login_FormClosed);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong ID");
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
            }
        }

        void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            textBox_Id.Clear();
        }

    }
}
