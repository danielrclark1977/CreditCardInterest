using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterest
{
    public class Person
    {
        public int Id { get; set; }
        public List<Wallet> walletList { get; set; }
        public double MonthlyInterest { get; set; }

    }
}
