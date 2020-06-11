using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CreditCardInterest
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            OutputInterestToConsole outputInterestToConsole = new OutputInterestToConsole();
            foreach (Person person in createPersonList())
            {
                if(person.Id == 1)
                    outputInterestToConsole.writeInterestValuesToConsole(person, true, false, true);
                if (person.Id == 2)
                    outputInterestToConsole.writeInterestValuesToConsole(person, true, true, false);
                if (person.Id == 3)
                    outputInterestToConsole.writeInterestValuesToConsole(person, true, true, false);
                if (person.Id == 4)
                    outputInterestToConsole.writeInterestValuesToConsole(person, true, true, false);
            }
        }
        public class Visa : CreditCard
        {
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
        public class Discover : CreditCard
        {
            public CreditCard CreateCreditCard(double balance)
            {
                return new CreditCard() { InterestRate = .01, Balance = balance, Name = "Discover" };
            }
        };
        public static List<Person> createPersonList()
        {
            List<Person> personList = new List<Person>();
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
            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);
            personList.Add(person4);
            return personList;
        }

    }
}
