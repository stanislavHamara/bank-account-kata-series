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
            Money money = new Money(0);
            Assert.True(money.Equals(new Money(0)));
        }

        [Test]
        public void CompareToNotMoneyObject()
        {
            Money money = new Money(10);
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
    }
}


        
