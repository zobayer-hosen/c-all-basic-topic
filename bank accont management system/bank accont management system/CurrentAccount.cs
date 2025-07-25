using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bank_accont_management_system
{
    class CurrentAccount:BankAccount
    {
        private double overdraftLimit;
        private double transactionFree;
         

        public double OverdraftLimit
        {
            get { return this.overdraftLimit; }
            set { this.overdraftLimit = value; }
        }
        public double TransactionFree
        {
            get { return this.transactionFree; }
            set { this.transactionFree = value; }
        }
        public CurrentAccount()
        {

        }
        public CurrentAccount(int accountNumber, string holderName,double balance,double overdraftLimit,double transactionFree):base(accountNumber,holderName,balance)
        {
            Console.WriteLine("paramiterize constractor for CurrentAccount");
            this.overdraftLimit = overdraftLimit;
            this.transactionFree = transactionFree;
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("The overdraftLimit" + this.overdraftLimit);
            Console.WriteLine("The transactionFree" + this.transactionFree);
        }

        public bool CanWithdraw(double amount)
        {
            if(amount<= this.balance + this.overdraftLimit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CanWithdraw( double amount, double fee)
        {
            if(amount<= this.balance - fee + this.overdraftLimit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
