using System;

namespace Financial_Analyst.Logic
{
    public interface ITransaction
    {
        decimal PaymentSum { get; }
        string PaymentCategorie { get; set; }
        DateTime Date { get; }

    }
}