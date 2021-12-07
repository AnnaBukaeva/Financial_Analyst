using Financial_Analyst.Data;
using System;

namespace Financial_Analyst.Logic
{
    [Serializable]
    public class Transaction : ITransaction
    {
        public DateTime Date { get; }
        public decimal PaymentSum { get; }
        public string Comment { get; set; }
        public IUser User { get; set; }
        public IAccount Account { get; set; }
        public ICategory Category { get; set; }

        public int TransactionID { get; }

        public Transaction(DateTime date, decimal paymentSum, IUser user, IAccount account, ICategory category, string comment = null)
        {
            int lastTransactionID = LastIDRepository.GetLastID();
            lastTransactionID++;
            TransactionID = lastTransactionID;
            LastIDRepository.SaveLastID(lastTransactionID);
            if (category.CType == CategoryType.Incom)
            {
                paymentSum = Math.Abs(paymentSum);                
            }
            if (category.CType == CategoryType.Expense)
            {
                paymentSum = Math.Abs(paymentSum) * -1; 
            }
            Date = date;
            PaymentSum = paymentSum;
            Comment = comment;
            User = user;
            Account = account;
            Category = category;
            Account.ChangeBalance(paymentSum);
            AccountRepository.UpdateAccount(account);
        }        
    }
}
