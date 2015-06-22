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
	    private Account account;

	    [SetUp]
	    public void Init()
	    {
           account = new Account();
	    }

	    [Test]
	    public void DepositingMoneyIntoAnAccountIncreasesTheBalanceByThatAmount()
	    {
	        account.Deposit(new Money(2));
	        var balance = account.CalculateBalance();

	        var expectedBalance = new Money(2);
	        Assert.That(balance, Is.EqualTo(expectedBalance));
	    }

	    [Test]
	    public void WithdrawingMoneyFromAccountDecreasesTheBalanceByThatAmount()
	    {
            account.Deposit(new Money(5));
	        account.Withdraw(new Money(3));
	        var balance = account.CalculateBalance();

            var expectedBalance = new Money(2);
            Assert.That(balance, Is.EqualTo(expectedBalance));
	    }
    }

}
