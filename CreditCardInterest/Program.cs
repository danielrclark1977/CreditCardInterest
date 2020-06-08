using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CreditCardInterest
{
    public class Program
    {
        private class Visa : CreditCard { private new readonly double InterestRate = 0.1;  };
        private class MC : CreditCard { private new readonly double InterestRate = 0.05; };
        private class Discover : CreditCard { private new readonly double InterestRate = 0.01; };
    static void Main(string[] args)
        {
            Person person1 = new Person()
            {
                walletList = new List<Wallet>() {
                    new Wallet() {
                    CreditCards = new List<CreditCard>() {
                        new Visa() { Balance = 100.00 },
                        new MC() { Balance = 100.00 },
                        new Discover() { Balance = 100.00 }
                    }
                }
            }
            };
            Person person2 = new Person()
            {
                walletList = new List<Wallet>() {
                    new Wallet() {
                        CreditCards = new List<CreditCard>() {
                            new Visa() { Balance = 100.00 },
                            new Discover() { Balance = 100.00 }
                        }
                    },
                    new Wallet()
                    {
                        CreditCards = new List<CreditCard>() {
                            new MC() { Balance = 100.00 }
                        }

                    }
                }
            };
            Person person3 = new Person()
            {
                walletList = new List<Wallet>() {
                    new Wallet() {
                    CreditCards = new List<CreditCard>() {
                        new Visa() { Balance = 100.00 },
                        new MC() { Balance = 100.00 },
                        new Discover() { Balance = 100.00 }
                    }
                    }
                }
            };
            Person person4 = new Person()
            {
                walletList = new List<Wallet>() {
                    new Wallet() {
                    CreditCards = new List<CreditCard>() {
                        new Visa() { Balance = 100.00 },
                        new MC() { Balance = 100.00 },
                        new Discover() { Balance = 100.00 }
                    }
                    }
                }
            };
        }
    }
}
