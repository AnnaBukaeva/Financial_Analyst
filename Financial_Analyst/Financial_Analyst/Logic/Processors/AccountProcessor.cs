using Financial_Analyst.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace Financial_Analyst.Logic
{
    public class AccountProcessor
    {
        private static List<IAccount> _accounts;

        static AccountProcessor()
        {
            _accounts = AccountRepository.GetAccounts();
        }

        public static void CreateAccount(string name, decimal balance, string comment, List<int> usersAccess)
        {
            foreach (IAccount item in _accounts)
            {
                if (item.Name == name)
                {
                    throw new ArgumentException("Счет с таким именем уже существует!");
                }
            }    
            IAccount account = new Account(name, balance, comment, usersAccess);           
            _accounts.Add(account);
            AccountRepository.SaveAccount(account);            
        }

        public static IReadOnlyCollection<IAccount> GetAccounts(IUser user)
        {
            List<IAccount> accountsAccessible = new List<IAccount>();      //доступные транзакции
            foreach (IAccount account in _accounts)
            {
                if (account.CheckAccess(user))
                {
                    accountsAccessible.Add(account);
                }
            }
            IReadOnlyCollection<IAccount> result = new ReadOnlyCollection<IAccount>(accountsAccessible);
            return result;
        }
    }
}
