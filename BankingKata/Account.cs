using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingKata
{
    public class Account
    {
        private List<Money> transactionList = new List<Money>();
       
        public void Deposit(Money p0)
        {
            transactionList.Add(p0)
        }

        public object CalculateBalance()
        {
            return null;
        }
    }
}
