using Financial_Analyst.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace Financial_Analyst.Logic
{
    class AccountProcessor
    {
        private static List<IAccount> _accounts;

        static AccountProcessor()
        {
            _accounts = AccountRepository.GetAccounts();
        }

        public static void CreateAccount (string name, decimal balance, List<int> usersAccess)
        {
            IAccount account = new Account (name, balance, usersAccess);
            _accounts.Add(account);
            AccountRepository.SaveAccount(account);
        } 

        public static IReadOnlyCollection<IAccount> GetAccounts (IUser user)
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
