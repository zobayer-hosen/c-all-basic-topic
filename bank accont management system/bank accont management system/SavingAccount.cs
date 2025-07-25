﻿using bank_accont_management_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace bank_account_management_system
{
    public class SavingAccount : BankAccount
    {
        private double interestRate;
        private double minimumBalance;

        public double InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }

        public double MinimumBalance
        {
            get { return this.minimumBalance; }
            set { this.minimumBalance = value; }
        }

        public SavingAccount()
        {
        }

        public SavingAccount(int accountNumber, string holderName, double balance,
                            double interestRate, double minimumBalance)
            : base(accountNumber, holderName, balance)
        {
            Console.WriteLine("paramiterize constractor for Saving Account");
            this.interestRate = interestRate;
            this.minimumBalance = minimumBalance;
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Interest Rate:"+ this.interestRate);
            Console.WriteLine("Minimum Balance:"+this.minimumBalance);
        }

        public double CalculateAnnualInterest()
        {
            return this.balance * this.interestRate;
        }

        public bool IsPenaltyApplicable()
        {
            if(this. balance < this.minimumBalance)
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