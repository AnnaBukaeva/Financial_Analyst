using Financial_Analyst.Logic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UnitTests
{
    public class AccountUnitTest
    {
        [Test]
        public void AddTransactions_Test()
        {
            //given
            ITransaction incom = new IncomTransaction(150, "Cashback", DateTime.Now);
            ITransaction expenses = new ExpensesTransaction(-50, "Cosmetics", DateTime.Now);
            IAccount account = new Account("Test", 0);
            decimal expectedBalance = 100;
            ReadOnlyCollection<ITransaction> expectedTransactionCollections = new List<ITransaction> { incom, expenses }.AsReadOnly();
            //when
            account.AddTransaction(incom);
            account.AddTransaction(expenses); 
            // then
            Assert.AreEqual(expectedBalance, account.Balance);
            Assert.AreEqual(expectedTransactionCollections, account.GetTransactions());
        }
           

    }
}
