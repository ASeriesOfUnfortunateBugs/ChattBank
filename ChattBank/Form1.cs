using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void custBtn_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer("48654", "48787", "Miranda", "Hummle", "555 Some Avenue",
                "mh@email.com");
            cust.Display();
            cust.DeleteDB();
        }

        private void acctBtn_Click(object sender, EventArgs e)
        {
            Account acct = new Account("45665", "48654", "SAV", 10000.00);
            acct.Display();
            acct.DeleteDB();
        }
    }
}
