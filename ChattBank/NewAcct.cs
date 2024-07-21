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
    public partial class NewAcct : Form
    {
        // global variabls
        Customer cust;

        public NewAcct()
        {
            InitializeComponent();
        }

        public NewAcct(Customer c)
        {
            InitializeComponent();

            // assign global variable
            cust = c;
        }

        // back btn functionality
        private void BackBtn_Click(object sender, EventArgs e)
        {
            // hide this window
            this.Hide();

            // show customer home
            CustHome custhome = new CustHome(cust);
            custhome.ShowDialog();
        }

        // create account btn functionality
        private void NewAcctBtn_Click(object sender, EventArgs e)
        {
            // make sure user had selected an account type
            if (AcctTypeLstBx.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an account type before creating an account!");
            } else
            {
                // create new account
                Account acct = new Account();

                // generate new account number
                Random num = new Random();
                acct.AcctNo = num.Next(100000, 800000).ToString();

                // set customer ID
                acct.CustID = cust.CustID;

                // set account type
                acct.AcctType = AcctTypeLstBx.SelectedItem.ToString();

                // set starting balance
                acct.Balance = 0.0;

                // add new account to DB
                acct.InsertDB();

                // add account to customer object
                cust.Accts.Add(acct);
            }
        }
    }
}
