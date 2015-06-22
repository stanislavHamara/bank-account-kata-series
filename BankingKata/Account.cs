using System.Collections.Generic;
using System.Linq;

namespace BankingKata
{
    public class Account
    {
        private readonly List<Money> _transactionList = new List<Money>();
       
        public void Deposit(Money money)
        {
            _transactionList.Add(money);
        }

        public object CalculateBalance()
        {
            var balance = new Money(0);
            return _transactionList.Aggregate(balance, (current, money) => current + money);
        }

        public void Withdraw(Money money)
        {
            _transactionList.Add(-money);
        }
    }
}
