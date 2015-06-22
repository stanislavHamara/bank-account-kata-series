using System;
using System.CodeDom;

namespace BankingKata
{
    public class Money
    {
        private readonly int _value;
        public Money(int i)
        {
            this._value = i;
        }

        public bool Equals(Money money)
        {
            return this._value == money._value;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return Equals((Money) obj);
        }

        public static bool operator <(Money a, Money b)
        {
            return a._value < b._value;
        }

        public static bool operator >(Money a, Money b)
        {
            return a._value > b._value;
        }

        public static Money operator +(Money a, Money b)
        {
            return new Money(a._value + b._value);
        }

        public static Money operator -(Money a)
        {
            return new Money(-a._value);
        }

    }
}