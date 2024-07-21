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
    public partial class CustHome : Form
    {
        // global variables
        Customer cust = new Customer();

        // constructors
        public CustHome()
        {
            InitializeComponent();
        }

        public CustHome(Customer c)
        {
            InitializeComponent();

            // set customer object
            cust = c;

            // variable for number of accounts
            int AcctCount = cust.Accts.Count;

            foreach (ListViewItem item in AcctLstVw.Items)
            {
                AcctLstVw.Items.Remove(item);
            }

            if (AcctCount == 1)
            {
                // storage variables
                Account acct1;
                ListViewItem item;
                string[] arr = new string[3];

                // set data and display
                acct1 = cust.Accts.AcctArr[0];
                arr[0] = acct1.AcctNo;
                arr[1] = acct1.AcctType;
                arr[2] = acct1.Balance.ToString("c");
                item = new ListViewItem(arr);
                AcctLstVw.Items.Add(item);
            }
            else if (AcctCount == 2)
            {
                // storage variables
                Account acct1;
                ListViewItem item;
                string[] arr = new string[3];

                // set data and display
                for (int i = 0; i < AcctCount; i++)
                {
                    acct1 = cust.Accts.AcctArr[i];
                    arr[0] = acct1.AcctNo;
                    arr[1] = acct1.AcctType;
                    arr[2] = acct1.Balance.ToString("c");
                    item = new ListViewItem(arr);
                    AcctLstVw.Items.Add(item);
                }
            }
            else if (AcctCount == 3)
            {
                // storage variables
                Account acct1;
                ListViewItem item;
                string[] arr = new string[3];

                // set data and display
                for (int i = 0; i < AcctCount; i++)
                {
                    acct1 = cust.Accts.AcctArr[i];
                    arr[0] = acct1.AcctNo;
                    arr[1] = acct1.AcctType;
                    arr[2] = acct1.Balance.ToString("c");
                    item = new ListViewItem(arr);
                    AcctLstVw.Items.Add(item);
                }
            }
            else if (AcctCount == 4)
            {
                // storage variables
                Account acct1;
                ListViewItem item;
                string[] arr = new string[3];

                // set data and display
                for (int i = 0; i < AcctCount; i++)
                {
                    acct1 = cust.Accts.AcctArr[i];
                    arr[0] = acct1.AcctNo;
                    arr[1] = acct1.AcctType;
                    arr[2] = acct1.Balance.ToString("c");
                    item = new ListViewItem(arr);
                    AcctLstVw.Items.Add(item);
                }
            }
            else if (AcctCount == 5)
            {
                // storage variables
                Account acct1;
                ListViewItem item;
                string[] arr = new string[3];

                // set data and display
                for (int i = 0; i < AcctCount; i++)
                {
                    acct1 = cust.Accts.AcctArr[i];
                    arr[0] = acct1.AcctNo;
                    arr[1] = acct1.AcctType;
                    arr[2] = acct1.Balance.ToString("c");
                    item = new ListViewItem(arr);
                    AcctLstVw.Items.Add(item);
                }
            }
        }

        // sign out menu functionality
        private void SignOutMenuItem_Click(object sender, EventArgs e)
        {
            // open login window
            Login login = new Login();
            login.Show();

            // close this window
            this.Close();
        }

        // manage funds btn functionality
        private void MngFundsBtn_Click(object sender, EventArgs e)
        {
            // hide this window
            this.Hide();

            // open fund management window
            MngFunds MngFund = new MngFunds(cust);
            MngFund.ShowDialog();
        }

        // create account btn functionality
        private void NewAcctBtn_Click(object sender, EventArgs e)
        {
            // hide this window
            this.Hide();

            // open new account window
            NewAcct newAcct = new NewAcct(cust);
            newAcct.ShowDialog();
        }
    }
}
