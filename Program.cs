using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject2
{
    class Program
    {
        private static int accno = 0;
        public static int AutoIdGenerator()
        {
            accno++;
            return accno;

        }
        static void Main(string[] args)
        {
            Bank bank = new Bank("TEST BANK", 100);

            Console.WriteLine("\n_______PLEASE SELECT OPTION THOUGH TYPING COMMAND GIVEN IN THE BRACKET_______");
            Console.WriteLine("\n_______Select Required Option_______");
            Console.Write("1. Open Account(open)\n2. Make Transaction(account)\n3. Exit(quit)\n\nEnter : ");
            string x = System.Console.ReadLine();

            switch (x)
            {
                case "open":
                    Console.WriteLine("\n______Select Account Type_______ ");
                    Console.Write("1. Savings Account(savings)\n2. Checkings Account(checkings)\n3. Exit(quit)\n\nEnter : ");
                    string y = System.Console.ReadLine();
                    break;

                    switch (y)
                    {
                        case "savings" && "checkings":
                            {
                                Console.Write("\n______Enter Details_______ \nName : ");
                                string accountName = Console.ReadLine();
                                Console.Write("Balance : ");
                                double balance = Convert.ToDouble(Console.ReadLine());
                                Console.Write("\n_______Address_______\nRoad No. : ");
                                string roadNo = Console.ReadLine();
                                Console.Write("House No. : ");
                                string houseNo = Console.ReadLine();
                                Console.Write("City : ");
                                string city = Console.ReadLine();
                                Console.Write("Country : ");
                                string country = Console.ReadLine();

                                int id = AutoIdGenerator();

                                b1.AddAccount(new Account(id, accountName, balance, new Address(roadNo, houseNo, city, country)));

                                Console.WriteLine("_____ACCOUNT CREATED SUCCESSFULLY_____");
                                break;
                            }
                        case "quit":
                            {
                                break;
                            }
                         break;
                    }

                case "account":
                    {
                        Console.Write("Enter You Account Number : ");
                        int accountNumber = Convert.ToInt32(Console.ReadLine());
                        int found = b1.SearchAccount(accountNumber);

                        if(found >=0)
                        {
                            Console.Write("\n_______Select What You Want_______\n1. Make a Withdraw(withdraw)\n2. Make a Deposit(diposit)");
                            Console.Write("3. Make a Transfer(transfer)\n4. Change Name(change)\n5. Show Account Details(show) \n6. Exit\n\nEnter : ");
                            string z = System.Console.ReadLine();

                            switch (z)
                            {
                                case "withdraw":
                                    {
                                        Console.Write("Enter the amount you want to withdraw : ");
                                        double amount = Convert.ToDouble(Console.ReadLine());
                                        b1.Transaction(z, found, amount);
                                        break;
                                    }

                                case "diposit":
                                    {
                                        Console.Write("Enter the amount you want to Deposit : ");
                                        double amount = Convert.ToDouble(Console.ReadLine());
                                        break;
                                    }

                                case "transfer":
                                    {
                                        Console.Write("Enter Receiver Account Number : ");
                                        int recAccountNum = Convert.ToInt32(Console.ReadLine());
                                        break;
                                    }

                                case "change":
                                    {
                                        Console.Write("Enter Account Number You want to change: ");
                                        int AccountNum = Convert.ToInt32(Console.ReadLine());
                                        break;
                                    }

                                case "show":
                                    {
                                        Console.WriteLine("_____ACCOUNT INFORMATION_____");
                                        b1.PrintAccountDetails();
                                    }

                                case "quit":
                                    {
                                        break;
                                    }

                                default:
                                    {
                                        Console.WriteLine("_____WRONG INPUT!!_____");
                                        break;
                                    }

                            }
                        }
                        else
                        {
                            Console.WriteLine("_____WRONG INPUT!!_____");
                        }

                    }
                case "quit":
                    {
                        break;
                    }

                default:
                    {
                        Console.WriteLine("_____WRONG INPUT!!_____");
                        break;
                    }

            }
               
        }
    }
}
