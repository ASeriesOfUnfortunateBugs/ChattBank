using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

/**************************************************************

   Rachel Heaton

   Final Project - Dec 5, 2022

   I wrote this code myself.

 **************************************************************/

namespace ChattBank
{
    public class Customer
    {
        // properties
        public string CustID { get; set; }
        public string CustPass { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public AccountList Accts = new AccountList();

        // constructors
        public Customer()
        {
            CustID = "";
            CustPass = "";
            FirstName = "";
            LastName = "";
            Address = "";
            Email = "";
        }

        public Customer(string id, string pass, string fname, string lname, string add, string email)
        {
            CustID = id;
            CustPass = pass;
            FirstName = fname;
            LastName = lname;
            Address = add;
            Email = email;
        }

        // methods
        public void Display()
        {
            // display all data stored in object
            Console.WriteLine("Customer ID: " + CustID);
            Console.WriteLine("Password: " + CustPass);
            Console.WriteLine("First name: " + FirstName);
            Console.WriteLine("Last name: " + LastName);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Email: " + Email);
            Accts.Display();
        }

        public void GetAcctList()
        {
            // select statement defined
            cmd = "SELECT AcctNo FROM Accounts WHERE Cid = '" + CustID + "'";
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);

            try
            {
                // open connection + execute command
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                // declare account for storage + variable to store customer ID
                string AcctNum = "";
                Account Acct1;

                // create schedule
                while (dr.Read())
                {
                    Acct1 = new Account();
                    AcctNum = dr.GetValue(0) + "";
                    Acct1.SelectDB(AcctNum);
                    Accts.Add(Acct1);
                }

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

        public void SelectDB(string id)
        {
            // prepare DB
            DBSetup();

            // select statement defined
            cmd = "SELECT * FROM Customers WHERE CustID = '" + id + "'";
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
                CustID = id;
                CustPass = dr.GetValue(1) + "";
                FirstName = dr.GetValue(2) + "";
                LastName = dr.GetValue(3) + "";
                Address = dr.GetValue(4) + "";
                Email = dr.GetValue(5) + "";
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

            GetAcctList();
        }

        // insert record into DB
        public void InsertDB()
        {
            // prepare DB
            DBSetup();

            // insert statement defined
            cmd = "INSERT INTO Customers VALUES('" + CustID + "'," +
                                "'" + CustPass + "'," +
                                "'" + FirstName + "'," +
                                "'" + LastName + "'," +
                                "'" + Address + "'," +
                                "'" + Email + "')";

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
                    MessageBox.Show("Customer record added successfully!");
                }
                else
                {
                    // output failure message
                    Console.WriteLine("ERROR: Inserting Data");
                    MessageBox.Show("Customer record could not be added!");
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
            cmd = "UPDATE Customers SET CustPassword = '" + CustPass + "', " +
             "CustFirstName = '" + FirstName + "', " +
             "CustLastName = '" + LastName + "', " +
             "CustAddress = '" + Address + "', " +
             "CustEmail = '" + Email + "'" +
             " WHERE CustID = '" + CustID + "'";

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
                    MessageBox.Show("Customer data updated!");
                }
                else
                {
                    // output failure message
                    Console.WriteLine("ERROR: Updating Data");
                    MessageBox.Show("Customer data could not be updated!");
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
            cmd = "DELETE FROM Customers WHERE CustID = '" + CustID + "'";
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
                    MessageBox.Show("Customer has been deleted!");
                }
                else
                {
                    // output failure message
                    Console.WriteLine("ERROR: Deleting Data");
                    MessageBox.Show("Customer could not be deleted!");
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
