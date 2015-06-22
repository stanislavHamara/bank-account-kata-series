using System;
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
            var money = new Money(0);
            Assert.True(money.Equals(new Money(0)));
        }

        [Test]
        public void CompareToNotMoneyObject()
        {
            var money = new Money(10);
            Assert.False(money.Equals(new DateTime()));
        }

        [Test]
        public void CanCompareTwoMoniesForGreaterThan()
        {
            Assert.True(new Money(-10) > new Money(-100));
        }

        [Test]
        public void CanCompareTwoMoniesForLessThan()
        {
            Assert.True(new Money(-100) < new Money(-10));
        }

        [Test]
        public void CanAddTwoMoneys()
        {
            var expectedMoney = new Money(6);
            var addedMoney = new Money(2) + new Money(4);
            Assert.True(expectedMoney.Equals(addedMoney));
        }
    }
}


        
