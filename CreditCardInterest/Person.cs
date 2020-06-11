using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterest
{
    public class Person:  PersonInterface
    {
        public int Id { get; set; }
        public List<Wallet> walletList { get; set; }
        public double MonthlyInterest { get; set; }
        public double CalculateSimpleInterest(Person person, int months)
        {
            double calculatedInterest = 0;
            foreach (Wallet personWallet in person.walletList)
            {
                Wallet wallet = new Wallet();
                calculatedInterest += wallet.CalculateSimpleInterest(personWallet, months);
            }
            return calculatedInterest;
        }

    }
}
