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

        private void button_logIn_Click(object sender, EventArgs e)
        {
            try
            {
                int Employeeid = int.Parse(textBox_Id.Text);
                string EmployeePassword = textBox_password.Text;
                Employee employee = new Employee(Employeeid, EmployeePassword);
                LoginService login = new LoginService();

                Function function = login.funtion(employee);

                if (login.CheckLogin(employee))
                {
                    if (Enum.IsDefined(typeof(Function), function))
                    {
                        switch (function)
                        {
                            case Function.Owner:
                                OwnerMenu main = new OwnerMenu();
                                main.FormClosed += new FormClosedEventHandler(login_FormClosed);
                                main.Show();
                                this.Hide();
                                break;

                            case Function.Barkeeper:
                                Overview bar = new Overview(employee.function, employee);
                                bar.FormClosed += new FormClosedEventHandler(login_FormClosed);
                                bar.Show();
                                this.Hide();
                                break;

                            case Function.Cook:
                                Overview kitchen = new Overview(employee.function, employee);
                                kitchen.FormClosed += new FormClosedEventHandler(login_FormClosed);
                                kitchen.Show();
                                this.Hide();
                                break;

                            case Function.Waiter:
                                WaiterMenu menu = new WaiterMenu();
                                menu.FormClosed += new FormClosedEventHandler(login_FormClosed);
                                menu.Show();
                                this.Hide();
                                break;

                            default:
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong ID");
                    }
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
