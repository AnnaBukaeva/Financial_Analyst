using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Analyst.Logic
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        void AddAccount(IAccount account); //метод, позволяющий принять содержимое интерфейса IAccount
        ReadOnlyCollection<IAccount> GetAccount();
    }
}