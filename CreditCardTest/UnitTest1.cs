using CreditCardInterest;
using NUnit.Framework;
using System.Collections.Generic;
using static CreditCardInterest.Program;

namespace CreditCardTest
{
    public class Tests
    {
        private Visa visa = new Visa();
        private MC mc = new MC();
        private Discover discover = new Discover();
        private CreditCard creditCard = new CreditCard();
        private Wallet wallet = new Wallet();
        private Person person1;
        private Person person2;
        [SetUp]
        public void Setup()
        {
            person1 = new Person()
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
            person2 = new Person()
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
        }
        

        [Test]
        public void Test1()
        {
            Assert.IsTrue(person1.Id  == 1);
            Assert.IsTrue(person1.walletList.Count == 1);
            Assert.IsTrue(person1.walletList[0].CreditCards.Count == 3);
            Assert.IsTrue(person1.CalculateSimpleInterest(person1, 1) == 16);
            Assert.IsTrue(wallet.CalculateSimpleInterest(person1.walletList[0], 1) == 16);
            Assert.IsTrue(creditCard.CalculateSimpleInterest(person1.walletList[0].CreditCards[0], 1) == 10);
            Assert.IsTrue(creditCard.CalculateSimpleInterest(person1.walletList[0].CreditCards[1], 1) == 5);
            Assert.IsTrue(creditCard.CalculateSimpleInterest(person1.walletList[0].CreditCards[2], 1) == 1);
            Assert.IsTrue(person2.Id == 2);
            Assert.IsTrue(person2.walletList.Count == 2);
            Assert.IsTrue(person2.walletList[0].Id == 1);
            Assert.IsTrue(person2.walletList[0].CreditCards.Count == 2);
            Assert.IsTrue(person2.walletList[0].CreditCards[0].Balance == 100);
            Assert.IsTrue(person2.walletList[0].CreditCards[1].Balance == 100);
            Assert.IsTrue(person2.walletList[1].CreditCards.Count == 1);
            Assert.IsTrue(person2.walletList[1].Id == 2);
            Assert.IsTrue(person2.walletList[1].CreditCards[0].Balance == 100);
            Assert.IsTrue(person2.CalculateSimpleInterest(person2, 1) == 16);
            Assert.IsTrue(wallet.CalculateSimpleInterest(person2.walletList[0], 1) == 11);
            Assert.IsTrue(wallet.CalculateSimpleInterest(person2.walletList[1], 1) == 5);
            Assert.IsTrue(creditCard.CalculateSimpleInterest(person2.walletList[0].CreditCards[0], 1) == 10);
            Assert.IsTrue(creditCard.CalculateSimpleInterest(person2.walletList[0].CreditCards[1], 1) == 1);
            Assert.IsTrue(creditCard.CalculateSimpleInterest(person2.walletList[1].CreditCards[0], 1) == 5);
        }
    }
}