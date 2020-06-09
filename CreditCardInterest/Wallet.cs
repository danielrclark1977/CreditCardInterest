using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CreditCardInterest
{
    public class Wallet
    {
        public int Id { get; set; }
        public List<CreditCard> CreditCards { get; set; }
        public double MonthlyInterest { get; set; }
    }
}
