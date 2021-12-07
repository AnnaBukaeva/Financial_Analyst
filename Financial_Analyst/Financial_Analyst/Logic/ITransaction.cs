using System;

namespace Financial_Analyst.Logic
{
    public interface ITransaction
    {
        int TransactionID { get; }
        DateTime Date { get; }
        decimal PaymentSum { get; }
        string Comment { get; set; } // описание
        IUser User { get; set; }
        IAccount Account { get; set; }
        ICategory Category { get; set; }
    }
}