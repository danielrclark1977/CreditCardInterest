using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CreditCardInterest
{
    public class Program
    {
        public class Visa : CreditCard {
            public CreditCard CreateCreditCard(double balance)
            {
                return new CreditCard() { InterestRate = .1, Balance = balance, Name = "Visa" };
            }
        };
        public class MC : CreditCard
        {
            public CreditCard CreateCreditCard(double balance)
            {
                return new CreditCard() { InterestRate = .05, Balance = balance, Name = "MC" };
            }
        };
        public class Discover : CreditCard {
            public CreditCard CreateCreditCard(double balance)
            {
                return new CreditCard() { InterestRate = .01, Balance = balance, Name = "Discover" };
            }
        };
        static void Main(string[] args)
        {
            Visa visa = new Visa();
            MC mc = new MC();
            Discover discover = new Discover();
            Person person1 = new Person()
            {
                Id = 1,
                walletList = new List<Wallet>() {
                    new Wallet() {
                    Id = 1,
                    CreditCards = new List<CreditCard>() {
                        visa.CreateCreditCard(100),
                        mc.CreateCreditCard(100),
                        discover.CreateCreditCard(100)
                    }
                }
            }
            };
            Person person2 = new Person()
            {
                Id = 2,
                walletList = new List<Wallet>() {
                    new Wallet() {
                        Id = 1,
                        CreditCards = new List<CreditCard>() {
                            visa.CreateCreditCard(100),
                            discover.CreateCreditCard(100)
                        }
                    },
                    new Wallet()
                    {
                        Id = 2,
                        CreditCards = new List<CreditCard>() {
                            mc.CreateCreditCard(100)
                        }

                    }
                }
            };
            Person person3 = new Person()
            {
                Id = 3,
                walletList = new List<Wallet>() {
                    new Wallet() {
                    Id = 1,
                    CreditCards = new List<CreditCard>() {
                        visa.CreateCreditCard(100),
                        mc.CreateCreditCard(100)
                    }
                    }
                }
            };
            Person person4 = new Person()
            {
                Id = 4,
                walletList = new List<Wallet>() {
                    new Wallet() {
                    Id = 1,
                    CreditCards = new List<CreditCard>() {
                        mc.CreateCreditCard(100),
                        visa.CreateCreditCard(100)                        
                    }
                    }
                }
            };
            OutputInterestToConsole outputInterestToConsole = new OutputInterestToConsole();
            outputInterestToConsole.writeInterestValuesToConsole(person1, true, false, true);
            outputInterestToConsole.writeInterestValuesToConsole(person2, true, true, false);
            outputInterestToConsole.writeInterestValuesToConsole(person3, true, true, false);
            outputInterestToConsole.writeInterestValuesToConsole(person4, true, true, false);
        }
    }
}
