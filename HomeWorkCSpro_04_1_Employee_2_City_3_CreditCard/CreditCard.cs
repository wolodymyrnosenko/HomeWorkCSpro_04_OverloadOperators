namespace HomeWorkCSpro_04_1_Employee_2_City
{
    internal class CreditCard
    {
        private string cardNumber;
        private string holderName;
        private string cvc;
        private decimal balance;

        public string CardNumber
        {
            get => cardNumber;
            private set => cardNumber = value;
        }

        public string HolderName
        {
            get => holderName;
            private set => holderName = value;
        }

        public string Cvc
        {
            get => cvc;
            private set => cvc = value;
        }

        public decimal Balance
        {
            get => balance;
            private set => balance = value;
        }

        public CreditCard(string cardNumber, string holderName, string cvc, decimal balance)
        {
            CardNumber = cardNumber;
            HolderName = holderName;
            Cvc = cvc;
            Balance = balance;
        }

        public static CreditCard operator +(CreditCard card, decimal sum)
        {
            card.balance += sum;
            return card;
        }

        public static CreditCard operator -(CreditCard card, decimal sum)
        {
            card.balance -= sum;
            return card;
        }

        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            return card1.cvc == card2.cvc;
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return !(card1 == card2);
        }

        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.balance > card2.balance;
        }

        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.balance < card2.balance;
        }

        public override string ToString()
        {
            return $"Card number: {cardNumber}, \tHolder: {holderName}, \tCVC: {cvc}, \tBalance: {balance}";
        }
    }
}