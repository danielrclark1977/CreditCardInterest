using System;
namespace CreditCardInterest
{
    public class CreditCard : CardInterface
    {
        public string Name { get; set; }
        public double InterestRate { get; set; }
        public double Balance { get; set; }
        public double MonthlyInterest { get; set; }

        public double CalculateSimpleInterest(CreditCard card, int months)
        {
            card.MonthlyInterest = card.InterestRate * card.Balance * months;
            return card.MonthlyInterest;
        }
    }
}