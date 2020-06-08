using System;
namespace CreditCardInterest
{
    abstract public class CreditCard : ICreditCard
    {
        public string Name { get; set; }
        public double InterestRate { get; set; }
        public double Balance { get; set; }
        public double MonthlyInterest { get; set; }
        public double CalculateSimpleInterest(CreditCard card, int months)
        {
            double calculatedInterest = 0;
            card.MonthlyInterest = card.InterestRate * card.Balance * months;
            return calculatedInterest;
        }
        public double CalculateSimpleInterest(Wallet wallet, int months)
        {
            double calculatedInterest = 0;
            foreach (CreditCard card in wallet.CreditCards)
            {
                calculatedInterest += CalculateSimpleInterest(card, months);
            }
            return calculatedInterest;
        }
        public double CalculateSimpleInterest(Person person, int months)
        {
            double calculatedInterest = 0;
            foreach (Wallet wallet in person.walletList)
            {
                calculatedInterest += CalculateSimpleInterest(wallet, months);
            }
            return calculatedInterest;
        }
    }
}