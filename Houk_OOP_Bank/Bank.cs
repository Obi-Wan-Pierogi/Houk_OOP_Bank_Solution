using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houk_OOP_Bank
{
    internal class Bank
    {
        private decimal _balance;
        private decimal _withdraw;
        private decimal _deposit;

        public Bank(decimal balance)
        {
            _balance = balance;
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public decimal Deposit(decimal amount)
        {
            DepositAmount = amount;
            Balance += DepositAmount;
            return Balance;
        }

        public decimal Withdraw(decimal amount)
        {
            WithdrawAmount = amount;
            Balance -= WithdrawAmount;
            return Balance;          
        }

        public static string Error()
        {
            return "Withdrawals are limited to $500";
        }

        public decimal Balance
        {
            get { return _balance; }
            set 
            { 
                if (value < 0)
                    value = 0;
                _balance = value; 
            }            
        }

        public decimal WithdrawAmount
        {
            get { return _withdraw; }
            set
            {
                if (value > 500)
                    value = 500;
                if (value < 0)
                    value = 0;
                _withdraw = value;
            }
        }
        public decimal DepositAmount
        {
            get { return _deposit; }
            set
            {
                if (value < 0)
                    value = 0;
                _deposit = value;
            }
        }
    }
}
