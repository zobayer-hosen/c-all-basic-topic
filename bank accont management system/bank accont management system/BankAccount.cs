using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace bank_accont_management_system
{
    public class BankAccount
    {
        protected int accountNumber;
        protected string holderName;
        protected double balance;
        protected static int totalAccounts=1;

        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        public string HolderName
        {
            get { return this.holderName; }
            set { this.holderName = value; }

        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public  static int TotalAccounts
        {
            get { return TotalAccounts; }
            set { TotalAccounts = value; }
        }
        public BankAccount()
        {

        }
        public BankAccount(int accountNumber, string holderName,double balance)
        {
            Console.WriteLine("paramiterize constractor for BnakAccont");
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = balance;

        }
        public virtual void ShowDetails()
        {
            Console.WriteLine("The account number " + this.accountNumber);
            Console.WriteLine("the holder Name" + this.holderName);
            Console.WriteLine("the balance " + this.balance);
            
        }
    }
}
