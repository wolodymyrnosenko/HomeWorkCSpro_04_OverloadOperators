using System.Formats.Asn1;

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
            private set
            {
                value = value.Replace(" ", "");
                if (value.Length == 16 && IsAllDigits(value))
                    cardNumber = value;
                else
                    throw new ArgumentException("Номер картки має містити 16 цифр");
            }
        }

        public string HolderName
        {
            get => holderName;
            private set => holderName = value;
        }

        public string Cvc
        {
            get => cvc;
            private set
            {
                if (value.Length == 3 && IsAllDigits(value))
                    cvc = value;
                else
                    throw new ArgumentException("CVC код має містити 3 цифри");
            }
        }

        public decimal Balance
        {
            get => balance;
            //private set => balance = value;
            private set
            {
                decimal tepm = value * 100;
                if (tepm != Math.Floor(tepm))
                    throw new ArgumentException("Значення не має містити більше двох знаків після коми");
                balance = value;
            }
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
            return $"Card number: {CardNumberToString(CardNumber)}\tHolder: {HolderName}\tCVC: {Cvc}\tBalance: {Balance:F2}";
        }

        private string CardNumberToString(string number)
        {
            string str = string.Empty;
            for (int i = 1; i <= number.Length; i++)
            {
                str +=  number[i-1];
                if (i % 4 == 0)
                    str += " ";
            }
            return str;
        }
        private bool IsAllDigits(string number)
        {
            foreach (char c in number)
                if (c < '0' || c > '9')
                    return false;
            return true;
        }
    }
}