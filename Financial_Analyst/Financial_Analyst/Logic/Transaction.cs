using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Analyst.Logic
{
    public class Transaction : ITransaction
    {
        public DateTime Date { get; }

        public decimal PaymentSum { get; }

        public string Comment { get; set; }
        public IUser User { get; set; }
        public IAccount Account { get; set; }
        public ICategory Category { get; set; }
        public Transaction(DateTime date, decimal paymentSum,  IUser user, IAccount account, ICategory category, string comment = null)
        {
            Date = date;
            PaymentSum = paymentSum;
            Comment = comment;
            User = user;
            Account = account;
            Category = category;
            Account.ChangeBalance(paymentSum); //вызвали метод аккаунта чтобы в момент создания транзакции менялся баланс счета
        }
    }
}
