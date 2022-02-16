using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using Exercicio_Excecao.Entities.Exceptions;

namespace Exercicio_Excecao.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double deposit)
        {            
             Balance += deposit;
        }

        public void Withdraw(double withdraw)
        {
            if (withdraw >= WithdrawLimit)
            {
                throw new DomainException("Withdraw solicited exceed withdraw limited.");
            } 
            else if (withdraw > Balance)
            {
                throw new DomainException("Balance insufficient");
            }
            Balance -= withdraw;
        }

    }
}
