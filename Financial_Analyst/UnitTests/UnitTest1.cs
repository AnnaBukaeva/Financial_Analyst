using Financial_Analyst.Logic;
using NUnit.Framework;
using System;

namespace UnitTests
{
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            //given
            ITransaction incom = new IncomTransaction(150, "Cashback", DateTime.Now);
            ITransaction expenses = new ExpensesTransaction(-50, "Cosmetics", DateTime.Now);
            IAccount account = new Account("Test", 0);
            //when
            account.AddTransaction(incom);
            account.AddTransaction(expenses);
            // then
            Assert.AreEqual(100, account.Balance);
        }
    }
}
