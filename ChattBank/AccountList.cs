using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************************************************************

   Rachel Heaton

   Final Project - Dec 5, 2022

   I wrote this code myself.

 **************************************************************/

namespace ChattBank
{
    public class AccountList
    {
        // properties
        public int Count { get; set; } = 0;
        public Account[] AcctArr = new Account[5];

        // methods
        public void Add(Account acct)
        {
            // add an account to the array
            AcctArr[Count] = acct;

            // increase Count
            Count++;
        }

        // display list of accounts
        public void Display()
        {
            for (int i = 0; i < Count; i++)
            {
                AcctArr[i].Display();
            }
        }
    }
}
