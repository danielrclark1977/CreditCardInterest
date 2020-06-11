using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CreditCardInterest
{
    public class Wallet: WalletInterface
    {
        public int Id { get; set; }
        public List<CreditCard> CreditCards { get; set; }
        public double MonthlyInterest { get; set; }
        public double CalculateSimpleInterest(Wallet wallet, int months)
        {
            double calculatedInterest = 0;
            foreach (CreditCard card in wallet.CreditCards)
            {
                CreditCard creditCard = new CreditCard();
                calculatedInterest += creditCard.CalculateSimpleInterest(card, months);
            }
            return calculatedInterest;
        }
    }
}
