using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Analyst.Logic
{
    public class User : IUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        private List<IAccount> _accounts;

        public User(string firstName, string lastName, List<IAccount> accounts)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentNullException("FirstName should not be empty or null!");
            }
            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException("LastName should not be empty or null!");
            }
            if (accounts == null)
            {
                throw new ArgumentNullException("Accounts should not be null!");
            }
            FirstName = firstName;
            LastName = lastName;
            _accounts = accounts;
        }
        public User (string firstName, string lastName) // транзакций может не быть при создании аккаунта
           : this(firstName, lastName, new List<IAccount>())
        {
        }

        public User()
        {
        }

        public void AddAccount(IAccount account)
        {
            if (account == null)
            {
                throw new ArgumentNullException("Account should not be null!");
            }
            foreach (IAccount item in _accounts)
            {
                if (account.Name == item.Name)
                {
                    throw new Exception("An account with this name already exists!");
                }             
            }
            _accounts.Add(account);
        }        
        public ReadOnlyCollection<IAccount> GetAccount()
        {
            return _accounts.AsReadOnly();
        }
    }
}
