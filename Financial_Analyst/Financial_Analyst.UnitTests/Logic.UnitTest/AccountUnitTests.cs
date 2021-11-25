using Financial_Analyst.Logic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Analyst.UnitTests.Logic.UnitTest
{
    class AccountUnitTests
    {
        [Test]
        public void AddTransactionTest()
        {
            //given
            ITransaction incom = new IncomTransaction(150, "Cashback", DateTime.Now);
            ITransaction expenses = new ExpensesTransaction( -50, "Cosmetics", DateTime.Now);
            IAccount account = new Account("Test", 0);
            //when
            account.AddTransaction(incom);
            account.AddTransaction(expenses);
            // then
            Assert.AreEqual(100, account.Balance);

        }

    }
}
