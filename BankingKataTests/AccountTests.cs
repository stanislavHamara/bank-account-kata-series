using BankingKata;
using NUnit.Framework;

namespace BankingKataTests
{
    [TestFixture]
    public class AccountTests
    {
        private Account _account;

        [SetUp]
        public void Init()
        {
            _account = new Account();
        }

        [Test]
        public void DepositingMoneyIntoAnAccountIncreasesTheBalanceByThatAmount()
        {
            _account.Deposit(new Money(2));
            var balance = _account.CalculateBalance();

            var expectedBalance = new Money(2);
            Assert.That(balance, Is.EqualTo(expectedBalance));
        }

        [Test]
        public void WithdrawingMoneyFromAccountDecreasesTheBalanceByThatAmount()
        {
            _account.Deposit(new Money(5));
            _account.Withdraw(new Money(3));
            var balance = _account.CalculateBalance();

            var expectedBalance = new Money(2);
            Assert.That(balance, Is.EqualTo(expectedBalance));
        }
    }
}
