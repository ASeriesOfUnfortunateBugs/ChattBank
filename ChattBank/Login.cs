using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**************************************************************

   Rachel Heaton

   Final Project - Dec 5, 2022

   I wrote this code myself.

 **************************************************************/

namespace ChattBank
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // exit menu btn functionality
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            // close this program
            this.Close();
        }

        // clear menu btn functionality
        private void ClearMenuItem_Click(object sender, EventArgs e)
        {
            // clear login textboxes
            SignInIDTB.Text = "";
            SignInPassTB.Text = "";
        }

        // sign in btn functionality
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            // sign in as admin
            if (SignInIDTB.Text == "admin" && SignInPassTB.Text == "123")
            {
                // clear textboxes
                SignInIDTB.Text = "";
                SignInPassTB.Text = "";

                // hide this window
                this.Hide();

                // open admin window
                Admin admin = new Admin();
                admin.ShowDialog();
            } else
            {
                try
                {
                    Customer cust = new Customer();
                    cust.SelectDB(SignInIDTB.Text);
                    if (cust.CustPass == SignInPassTB.Text)
                    {
                        // clear textboxes
                        SignInIDTB.Text = "";
                        SignInPassTB.Text = "";

                        // hide this window
                        this.Hide();

                        // open customer window
                        CustHome custhome = new CustHome(cust);
                        custhome.ShowDialog();
                    } else
                    {
                        MessageBox.Show("Wrong ID or password!");
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
