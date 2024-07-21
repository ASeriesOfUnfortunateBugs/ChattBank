using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChattBank
{
    public partial class MngFunds : Form
    {
        // global variables
        Customer cust;

        // constructors
        public MngFunds()
        {
            InitializeComponent();
        }

        public MngFunds(Customer c)
        {
            InitializeComponent();

            // set global variable
            cust = c;

            // prepare dropdown menu
            for (int i = 0; i < cust.Accts.Count; i++)
            {
                AcctLstBx.Items.Add(cust.Accts.AcctArr[i].AcctNo);
            }
        }

        // back btn functionality
        private void BackBtn_Click(object sender, EventArgs e)
        {
            // hide this window
            this.Hide();

            // open customer home
            CustHome custHome = new CustHome(cust);
            custHome.Show();
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            // make sure an account is selected
            if (AcctLstBx.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an account!");
            }
            else
            {
                // create new account object
                Account acct = new Account();

                // get account data from DB
                acct.SelectDB(AcctLstBx.SelectedItem.ToString());

                // withdraw funds
                acct.Withdraw(Double.Parse(AmtTB.Text));

                // update data in DB
                acct.UpdateDB();

                // update customer object
                cust.Accts.AcctArr[AcctLstBx.SelectedIndex].Balance -= Double.Parse(AmtTB.Text);
            }
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            // make sure an account is selected
            if (AcctLstBx.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an account!");
            } else
            {
                // create new account object
                Account acct = new Account();

                // get account data from DB
                acct.SelectDB(AcctLstBx.SelectedItem.ToString());

                // deposit funds
                acct.Deposit(Double.Parse(AmtTB.Text));

                // update data in DB
                acct.UpdateDB();

                // update customer object
                cust.Accts.AcctArr[AcctLstBx.SelectedIndex].Balance += Double.Parse(AmtTB.Text);
            }
        }

        // deposit radio functionality
        private void DepRDO_CheckedChanged(object sender, EventArgs e)
        {
            // hide withdraw button
            WithdrawBtn.Visible = false;

            // show deposite button
            DepositBtn.Visible = true;
        }

        // withdraw radio functionality
        private void WithdrawRDO_CheckedChanged(object sender, EventArgs e)
        {
            // hide deposit button
            DepositBtn.Visible = false;

            // show withdraw button
            WithdrawBtn.Visible = true;
        }
    }
}
