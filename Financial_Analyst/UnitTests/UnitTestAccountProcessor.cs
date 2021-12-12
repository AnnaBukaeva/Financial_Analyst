using NUnit.Framework;
using Financial_Analyst.Logic;
using Financial_Analyst.Logic.Helpers;
using System.Collections.Generic;
using System;
using System.Drawing;

namespace UnitTests
{
    public class UnitTestsAccountProcessor
    {

        [Test]
        public void AddIncomTransactioTest()
        {
            //given
            DateTime dateTime = DateTime.Now;
            decimal paymentSum = 10;
            IUser user = new User("Test", HashHelper.CalcHash("123"));
            IAccount account = new Account("test_acc", 100, "", new List<int> { user.ID });
            ICategory category = new Category("test_cat", "test", Color.Black, CategoryType.Incom);
            //when
            TransactionProcessor.CreateTransaction(dateTime, paymentSum, user, account, category);
            //then
            Assert.AreEqual(110, account.Balance);
        }

        [Test]
        public void AddExpenseTransactioTest()
        {
            //given
            DateTime dateTime = DateTime.Now;
            decimal paymentSum = 10;
            IUser user = new User("Test", HashHelper.CalcHash("123"));
            IAccount account = new Account("test_acc", 100, "", new List<int> { user.ID });
            ICategory category = new Category("test_cat", "test", Color.Black, CategoryType.Expense);
            //when
            TransactionProcessor.CreateTransaction(dateTime, paymentSum, user, account, category);
            //then
            Assert.AreEqual(90, account.Balance);
        }
    }
}