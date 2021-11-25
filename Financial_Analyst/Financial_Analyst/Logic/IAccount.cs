using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Financial_Analyst.Logic
{
    public interface IAccount
    {
        string Name { get; set; }
        decimal Balance { get; }          
   
        void AddTransaction(ITransaction transaction); //метод, позволяющий принять содержимое интерфейса ITransaction
        ReadOnlyCollection<ITransaction> GetTransactions();
    }
}