using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet5
{
    internal class Program

    {
        class Bank
        {
            int money = 32000;
            String accountname = "Sharif";
            String accountnumber;
            static String bankname = "ICICI";
            static public int updatedBalance;
            public void depositMoney()
            {

                Console.WriteLine("\nEnter the amount you want to deposit:");
                int depMoney = int.Parse(Console.ReadLine());
                updatedBalance = money + depMoney;
                if (depMoney == 0)
                {
                    Console.WriteLine("minimum deposit should be 1000 ");
                }
                else
                {
                    Console.WriteLine("updated balance of " + accountname + " after deposit is " + updatedBalance);
                }

            }
            public void withdrawMoney()
            {
                try
                {
                    Console.WriteLine("Welcome " + accountname + " your accountbalance: " + updatedBalance);
                    Console.WriteLine("\nEnter the amount you want to withdraw:");
                    int withdraw = Convert.ToInt32(Console.ReadLine());
                    updatedBalance = updatedBalance - withdraw;
                    if (withdraw > updatedBalance)
                    {
                        Console.WriteLine("insuffiecient balance");
                    }
                    else
                    {
                        Console.WriteLine("updated balance of " + accountname + " after withdrawal is " + updatedBalance);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"enter balance in number not in words inputmissmatch exception ", ex);
                }
            }
            public void AccountBalance()
            {
                Console.WriteLine("welcome to the " + bankname + "bank ");
                Console.WriteLine("Enter account number: ");
                accountnumber = Console.ReadLine();
                Console.WriteLine("Welcome " + accountname + " your accountbalance: " + money);

            }
        }

        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.AccountBalance();
            bank.depositMoney();
            bank.withdrawMoney();
            Console.ReadLine();
        }
    }
}


