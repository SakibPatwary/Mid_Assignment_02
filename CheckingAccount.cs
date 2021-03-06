using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject2
{
    class CheckingAccount : Account
    {
        public CheckingAccount(int accountNumber, string accountName, double balance, Address address) : base(accountNumber, accountName, balance, address)
        {

        }
        public override void Withdraw(double ammount)
        {
            if (ammount > 0 && amount <= Balance)
            {
                Console.WriteLine("_____WITHDRAW SUCCESSFUL_____");
                Balance -= ammount;
                Console.WriteLine("Current Balance: " + this.balance);
            }
            else
            {
                Console.WriteLine("_____SOMETHING WRONG!! CAN'T WITHDRAW_____");
            }
        }
        public virtual void ShowAccountInfo()
        {
            Console.WriteLine("ACCOUNT INFORMATION :\n" + "Account Number: " + this.accountNumber +
                "\nName: " + this.accountName + "\nBalance: " + this.balance + "\nAddress: " + address.getAddress());
        }
    }
}
