using System;
using System.Collections.Generic;

namespace Financial_Analyst.Logic
{
    public class Account : IAccount
    {
        public string Name { get; }
        public decimal Balance { get; private set; } //приватный так как лучше ограничить возможность изменения баланса из других классов
        public string Comment { get; set; }

        public List<int> UsersAccess { get; } //ID пользователейу которых есть доступ к счету

        public Account(string name, decimal balance, List<int> usersAccess)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name should not be empty or null!");
            }
            Name = name;
            Balance = balance;
            UsersAccess = usersAccess;
        }

        public bool CheckAccess(IUser user)
        {
            foreach (int ID in UsersAccess)
            {
                if (ID == user.ID)
                {
                    return true;
                }
            }
            return false;
        }

        public void ChangeBalance(decimal paymentSum)
        {
            Balance += paymentSum;
        }
    }
}
