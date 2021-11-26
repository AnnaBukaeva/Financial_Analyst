using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financial_Analyst.Logic;
using NUnit.Framework;

namespace UnitTests
{
    public class UserUnitTest
    {
        [Test]
        public void AddAccount_Test()
        {
            //given       
            IUser user = new User("Vasilii", "Egorov");
            IAccount account = new Account("First account", 15000.00m);
            ReadOnlyCollection<IAccount> expectedTAccountCollections = new List<IAccount> { account }.AsReadOnly(); // пока один аккаунт ожидаемая коллекция аккаунтов после его добавления пользователем
            //when
            user.AddAccount(account);
            // then
            Assert.AreEqual(expectedTAccountCollections, user.GetAccount());
        }
    }
}
