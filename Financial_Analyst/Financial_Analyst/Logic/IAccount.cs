using System.Collections.Generic;

namespace Financial_Analyst.Logic
{
    public interface IAccount
    {
        string Name { get; set; }
        decimal Balance { get; }

        List <ITransaction> Transactions { get; set; }        
        void AddTransaction(ITransaction transaction); //метод, позволяющий принять содержимое интерфейса ITransaction
    }
}