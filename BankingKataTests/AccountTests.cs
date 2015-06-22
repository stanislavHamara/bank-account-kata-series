using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingKata;
using NUnit.Framework;

namespace BankingKataTests
{
	[TestFixture]
    public class AccountTests
    {
	    [Test]
	    public void DepositingMoneyIntoAnAccountIncreasesTheBalanceByThatAmount()
	    {
	        var account = new Account();

	        account.Deposit(new Money(2));
	        account.Deposit(new Money(3));
	        account.Deposit(new Money(5));
	        var balance = account.CalculateBalance();

	        var expectedBalance = new Money(10);
	        Assert.That(balance, Is.EqualTo(expectedBalance));
	    }
    }

}
