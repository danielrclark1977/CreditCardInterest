using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterest
{
    public class InterestCalculator
    {
        public double CalculateSimpleInterest(CreditCard card, int months)
        {
            card.MonthlyInterest = card.InterestRate * card.Balance * months;
            return card.MonthlyInterest;
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
