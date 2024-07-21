using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

/**************************************************************

   Rachel Heaton

   Final Project - Dec 5, 2022

   I wrote this code myself.

 **************************************************************/

namespace ChattBank
{
    public class Account
    {
        // properties
        public string AcctNo { get; set; }
        public string CustID { get; set; }
        public string AcctType { get; set; }
        public double Balance { get; set; }

        // constructors
        public Account()
        {
            AcctNo = "";
            CustID = "";
            AcctType = "";
            Balance = 0.0;
        }

        public Account(string num, string id, string type, double bal)
        {
            AcctNo = num;
            CustID = id;
            AcctType = type;
            Balance = bal;
        }

        // methods
        public void Display()
        {
            Console.WriteLine("Account no.: " + AcctNo);
            Console.WriteLine("Customer ID: " + CustID);
            Console.WriteLine("Account type: " + AcctType);
            Console.WriteLine("Balance: " + Balance);
        }

        // deposit money to account
        public void Deposit(double dep)
        {
            Balance += dep;
        }

        // withdraw money from account
        public void Withdraw(double wd)
        {
            // subtract withdraw amount from balance
            Balance -= wd;
        }

        // DB connectivity
        public System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;
        public System.Data.OleDb.OleDbCommand OleDbSelectCommand2;
        public System.Data.OleDb.OleDbCommand OleDbInsertCommand2;
        public System.Data.OleDb.OleDbCommand OleDbUpdateCommand2;
        public System.Data.OleDb.OleDbCommand OleDbDeleteCommand2;
        public System.Data.OleDb.OleDbConnection OleDbConnection2;
        public string cmd;

        // prepare DB
        public void DBSetup()
        {
            // DBSetup function
            OleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            OleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbConnection2 = new System.Data.OleDb.OleDbConnection();

            //OleDbDataAdapter1
            OleDbDataAdapter2.DeleteCommand = OleDbDeleteCommand2;
            OleDbDataAdapter2.InsertCommand = OleDbInsertCommand2;
            OleDbDataAdapter2.SelectCommand = OleDbSelectCommand2;
            OleDbDataAdapter2.UpdateCommand = OleDbUpdateCommand2;

            OleDbConnection2.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" +
            "ocking Mode=1;Data Source=C:\\Users\\super\\source\\repos\\ChattBank\\ChattBankMDB.mdb;J" +
            "et OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System datab" +
            "ase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=S" +
            "hare Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet " +
            "OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" +
            "r=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";
        }

        // select record from DB
        public void SelectDB(string num)
        {
            // prepare DB
            DBSetup();

            // select statement defined
            cmd = "SELECT * FROM Accounts WHERE AcctNo = '" + num + "'";
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);

            try
            {
                // open connection + execute command
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                // assign returned data to object
                dr.Read();
                AcctNo = dr.GetValue(0) + "";
                CustID = dr.GetValue(1) + "";
                AcctType = dr.GetValue(2) + "";
                Balance = Convert.ToDouble(dr.GetValue(3));
            }
            catch (Exception e)
            {
                // print exception information to console
                Console.WriteLine(e.ToString());
            }
            finally
            {
                // close connection
                OleDbConnection2.Close();
            }
        }

        // insert record into DB
        public void InsertDB()
        {
            // prepare DB
            DBSetup();

            // insert statement defined
            cmd = "INSERT INTO Accounts VALUES('" + AcctNo + "'," +
                                "'" + CustID + "'," +
                                "'" + AcctType + "'," +
                                Balance + ")";

            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);

            try
            {
                // open connection + execute command
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();

                // check for successful execution
                if (n == 1)
                {
                    // output confirmation message
                    Console.WriteLine("Data Inserted");
                    MessageBox.Show("Account created successfully!");
                }
                else
                {
                    // output failure message
                    Console.WriteLine("ERROR: Inserting Data");
                    MessageBox.Show("Account creation failed!");
                }
            }
            catch (Exception ex)
            {
                // print exception information to console
                Console.WriteLine(ex);
            }
            finally
            {
                // close connection
                OleDbConnection2.Close();
            }
        }

        // update record in DB
        public void UpdateDB()
        {
            // prepare DB
            DBSetup();

            // update statement defined
            cmd = "UPDATE Accounts SET Cid = '" + CustID + "', " +
             "Type = '" + AcctType + "', " +
             "Balance = " + Balance +
             " WHERE AcctNo = '" + AcctNo + "'";

            OleDbDataAdapter2.UpdateCommand.CommandText = cmd;
            OleDbDataAdapter2.UpdateCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);

            try
            {
                // open connection + execute command
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.UpdateCommand.ExecuteNonQuery();

                // check for successful execution
                if (n == 1)
                {
                    // output confirmation message
                    Console.WriteLine("Data Updated");
                    MessageBox.Show("Account data updated!");
                }
                else
                {
                    // output failure message
                    Console.WriteLine("ERROR: Updating Data");
                    MessageBox.Show("Account data could not be updated!");
                }
            }
            catch (Exception ex)
            {
                // print exception information to console
                Console.WriteLine(ex);
            }
            finally
            {
                // close connection
                OleDbConnection2.Close();
            }
        }

        // delete record from DB
        public void DeleteDB()
        {
            // prepare DB
            DBSetup();

            // delete statement defined
            cmd = "DELETE FROM Accounts WHERE AcctNo = '" + AcctNo + "'";
            OleDbDataAdapter2.DeleteCommand.CommandText = cmd;
            OleDbDataAdapter2.DeleteCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);

            try
            {
                // open connection + execute command
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.DeleteCommand.ExecuteNonQuery();

                // check for successful execution
                if (n == 1)
                {
                    // output confirmation message
                    Console.WriteLine("Data Deleted");
                    MessageBox.Show("Account has been deleted!");
                }
                else
                {
                    // output failure message
                    Console.WriteLine("ERROR: Deleting Data");
                    MessageBox.Show("Account could not be deleted!");
                }
            }
            catch (Exception ex)
            {
                // print exception information to console
                Console.WriteLine(ex);
            }
            finally
            {
                // close connection
                OleDbConnection2.Close();
            }
        }
    }
}
