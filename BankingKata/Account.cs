using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingKata
{
    public class Account
    {
        private readonly List<Money> transactionList = new List<Money>();
       
        public void Deposit(Money money)
        {
            transactionList.Add(money);
        }

        public object CalculateBalance()
        {
            var balance = new Money(0);
            return transactionList.Aggregate(balance, (current, money) => current + money);
        }

        public void Withdraw(Money money)
        {
            transactionList.Add(-money);
        }
    }
}
