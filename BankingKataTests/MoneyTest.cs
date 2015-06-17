using BankingKata;
using NUnit.Framework;

namespace BankingKataTests
{
    [TestFixture]
    public class MoneyTest
    {
        [Test]
        public void NewMoneyHasValueZero()
        {
            Money money = new Money(10);
            Assert.True(money.Equals(new Money(0)));
        }
    }


        
}