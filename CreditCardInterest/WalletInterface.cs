using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterest
{
    public interface WalletInterface
    {
        public double CalculateSimpleInterest(Wallet wallet, int months);
    }
}
