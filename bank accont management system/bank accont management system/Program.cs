using bank_account_management_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bank_accont_management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saving account default constructor");
            SavingAccount savAccount = new SavingAccount();
            savAccount.AccountNumber = 1001;
            savAccount.HolderName = "30000";
            savAccount.Balance = 5000.0d;
            savAccount.InterestRate = 0.01d;
            savAccount.MinimumBalance = 1000.0d;
            savAccount.ShowDetails();
            Console.WriteLine("calculate annual interest "+savAccount.CalculateAnnualInterest());
            Console.WriteLine("Is penalty applicable " + savAccount.IsPenaltyApplicable());


            Console.WriteLine("\n");
            Console.WriteLine("saving account peramiterize constructor");
            SavingAccount savAccount1 = new SavingAccount(1101,"40000",10000.0d,0.01d,1000.0d);
            savAccount1.ShowDetails();
            Console.WriteLine("calculate annual interest " + savAccount1.CalculateAnnualInterest());
            Console.WriteLine("Is penalty applicable " + savAccount1.IsPenaltyApplicable());

            Console.WriteLine("\n");
            Console.WriteLine("Current Account default constructor");
            CurrentAccount curAccount = new CurrentAccount();
            curAccount.AccountNumber = 1111;
            curAccount.HolderName = "5000";
            curAccount.Balance = 10000000000.0d;
            curAccount.OverdraftLimit = 5000.0d;
            curAccount.TransactionFree = 2.5d;
            curAccount.ShowDetails();
            Console.WriteLine("can Withdraw "+curAccount.CanWithdraw(30000.0d));
            Console.WriteLine("can Withdraw " + curAccount.CanWithdraw(40000.0d, curAccount.TransactionFree));



            Console.WriteLine("\n");
            Console.WriteLine("current amount paramiterize constructor");
            CurrentAccount curAccount1 = new CurrentAccount(2222,"3000",2000000.0d,50000.0d,2.5d);
            curAccount1.ShowDetails();
            Console.WriteLine("can Withdraw " + curAccount1.CanWithdraw(30000.0d));
            Console.WriteLine("can Withdraw " + curAccount1.CanWithdraw(40000.0d, curAccount.TransactionFree));















        }
    }
}
