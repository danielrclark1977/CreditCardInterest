using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CreditCardInterest
{
    interface ICreditCard
    {
        void CalculateSimpleInterest(CreditCard card, int months)
        {
        }
        void CalculateSimpleInterest(Wallet wallet, int months)
        {
        }
        void CalculateSimpleInterest(Person person, int months)
        {
        }
    }
}
