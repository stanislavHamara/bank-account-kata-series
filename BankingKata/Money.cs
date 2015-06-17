namespace BankingKata
{
    public class Money
    {
        private readonly int value;
        public Money(int i)
        {
            this.value = i;
        }

        public bool Equals(Money money)
        {
            return this.value == money.value;
        }
    }
}