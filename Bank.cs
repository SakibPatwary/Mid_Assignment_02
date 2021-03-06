using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject2
{
    class Bank
    {
        private string bankName;
        private Account[] myBank;

        public Bank(string bankName, int size)
        {
            this.bankName = bankName;
            this.myBank = new Account[size];
        }

        public string BankName
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }

        public Account[] MyBank
        {
            get { return this.myBank; }
        }
        public void AddAccount(Account account)
        {
            bool flag = false;
            int num = -1;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    flag = true;
                    num = i;
                    break;
                }
            }
            if (flag) Console.WriteLine("_____ACCOUNT ADDED_____\ntYour Account Number = {0} ", myBank[num].AccountNumber);
            else Console.WriteLine("_____SOMETHING IS WRONG CAN'T ADD_____");
        }

   
        public void Transaction(int option, params dynamic[] x)
        {
            if (option == 1)
            {
                myBank[x[0]].Withdraw(x[1]);
            }
            else if (option == 2)
            {
                myBank[x[0]].Diposit(x[1]);
            }
            else if (option == 3)
            {
                myBank[x[0]].Transfer(myBank[x[1]], x[2]);
            }
            else if (option == 4)
            {
                myBank[x[0]].ChangeOwnerName(Array[1]);
            }
            else
            {
                Console.WriteLine("_____WRONG INPUT_____");
            }
        }
        public void PrintAccountDetails()
        {
            Console.WriteLine("Bank Name : " + this.bankName);

        }
    }
}
