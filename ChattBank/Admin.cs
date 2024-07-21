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
    public partial class Admin : Form
    {
        // global variables
        Customer cust = new Customer();

        public Admin()
        {
            InitializeComponent();
        }

        // sign out menu btn functionality
        private void SignOutMenuItem_Click(object sender, EventArgs e)
        {
            // open login window
            Login login = new Login();
            login.Show();

            // close this window
            this.Close();
        }

        // clear menu btn functionality
        private void ClearMenuItem_Click(object sender, EventArgs e)
        {
            // clear all textboxes
            ClearTB();
        }

        // find btn functionality
        private void FindBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // get customer data from DB
                cust.SelectDB(CustIDTB.Text);

                // populate textboxes
                CustIDTB.Text = cust.CustID;
                CustPassTB.Text = cust.CustPass;
                FNameTB.Text = cust.FirstName;
                LNameTB.Text = cust.LastName;
                AddressTB.Text = cust.Address;
                EmailTB.Text = cust.Email;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // update btn functionality
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // get data from textfields
                cust.CustID = CustIDTB.Text;
                cust.CustPass = CustPassTB.Text;
                cust.FirstName = FNameTB.Text;
                cust.LastName = LNameTB.Text;
                cust.Address = AddressTB.Text;
                cust.Email = EmailTB.Text;

                // update customer data in DB
                cust.UpdateDB();

                // clear textboxes
                ClearTB();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // add btn functionality
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // get data from textfields
                cust.CustID = CustIDTB.Text;
                cust.CustPass = CustPassTB.Text;
                cust.FirstName = FNameTB.Text;
                cust.LastName = LNameTB.Text;
                cust.Address = AddressTB.Text;
                cust.Email = EmailTB.Text;

                // add new customer to DB
                cust.InsertDB();

                // clear textboxes
                ClearTB();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // delete btn functionality
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // get customer ID
                cust.CustID = CustIDTB.Text;

                // delete customer from DB
                cust.DeleteDB();

                // clear textboxes
                ClearTB();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // clear textboxes
        public void ClearTB()
        {
            // clear all textboxes
            CustIDTB.Text = "";
            CustPassTB.Text = "";
            FNameTB.Text = "";
            LNameTB.Text = "";
            AddressTB.Text = "";
            EmailTB.Text = "";
        }
    }
}
