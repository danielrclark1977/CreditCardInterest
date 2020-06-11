using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterest
{
    public class OutputInterestToConsole
    {
        public void writeInterestValuesToConsole(Person person, bool writePersonInterest = true, bool writeWalletInterest = true, bool writeCardInterest = true)
        {
            if (writePersonInterest)
            {
                Console.WriteLine("Person "+ person.Id +" Monthly Interest:" + person.CalculateSimpleInterest(person, 1));
            }
            if (writeWalletInterest || writeCardInterest)
            {
                foreach (Wallet wallet in person.walletList)
                {
                    if (writeWalletInterest)
                    {
                        Console.WriteLine("Person " + person.Id +" Wallet " + wallet.Id + " Monthly Interest:" + wallet.CalculateSimpleInterest(wallet, 1));
                    }
                    if (writeCardInterest == true)
                    {
                        int cardCounter = 1;
                        foreach (CreditCard creditCard in wallet.CreditCards)
                        {
                            Console.WriteLine("Person " + person.Id + " Card " + cardCounter + " Monthly Interest:" + creditCard.CalculateSimpleInterest(creditCard, 1));
                            cardCounter++;
                        }
                    }
                }
            }
        }
    }
}
