using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterest
{
    public class OutputInterestToConsole
    {
        public void writeInterestValuesToConsole(Person person, bool writePersonInterest = true, bool writeWalletInterest = true, bool writeCardInterest = true)
        {
            InterestCalculator interesetCalculator = new InterestCalculator();
            if (writePersonInterest)
            {
                Console.WriteLine("Person "+ person.Id +" Monthly Interest:" + interesetCalculator.CalculateSimpleInterest(person, 1));
            }
            if (writeWalletInterest || writeCardInterest)
            {
                foreach (Wallet wallet in person.walletList)
                {
                    if (writeWalletInterest)
                    {
                        Console.WriteLine("Person " + person.Id +" Wallet " + wallet.Id + " Monthly Interest:" + interesetCalculator.CalculateSimpleInterest(wallet, 1));
                    }
                    if (writeCardInterest == true)
                    {
                        int cardCounter = 1;
                        foreach (CreditCard creditCard in wallet.CreditCards)
                        {
                            Console.WriteLine("Person " + person.Id + " Card " + cardCounter + " Monthly Interest:" + interesetCalculator.CalculateSimpleInterest(creditCard, 1));
                            cardCounter++;
                        }
                    }
                }
            }
        }
    }
}
