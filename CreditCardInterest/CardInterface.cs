using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterest
{
    public interface CardInterface
    {
        public double CalculateSimpleInterest(CreditCard card, int months);
     
    }
}
