using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject2
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;

        public Account(int accountNumber, string accountName, double balance, Address address)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;

        }
        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }
        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }
        
        public abstract void Withdraw(double ammount)
        {
            if (balance < ammount && balance == 0)
            {
                Console.WriteLine("_____NOT ENOUGH BALANCE/INVALID BALANCE_____");
            }
            else
            {
                Console.WriteLine("_____WITHDRAW DONE SUCCESFULLY_____");
                balance -= ammount;
                Console.WriteLine("Current Balance: "+ this.balance );
            }
        }
        public void Diposit(double ammount)
        {
            Console.WriteLine("_____DIPOSIT SUCCESSFUL_____");
            balance += ammount;
            Console.WriteLine("Current Balance: " + this.balance );
        }
        public void Transfer(Account receiver, double ammount)
        {
            if (balance < ammount && balance == 0)
            {
                Console.WriteLine("_____NOT ENOUGH BALANCE/INVALID BALANCE_____");
            }
            else
            {
                Console.WriteLine("_____TRANSFER SUCCESSFULLY_____");
                this.balance -= ammount;
                Console.WriteLine("Current Balance: " + this.balance );
                receiver.Balance += ammount;
            }
        }
        public void ChangeName(string name)
        {
            accountName = name;
            Console.WriteLine("New Account name :" + this.accountName);
        }
        public abstract void ShowAccountInfo()
        {
            Console.WriteLine("ACCOUNT INFORMATION :\n" + "Account Number: " + this.accountNumber +
                "\nName: " + this.accountName + "\nBalance: " + this.balance + "\nAddress: " + address.getAddress());
        }

    }
}
