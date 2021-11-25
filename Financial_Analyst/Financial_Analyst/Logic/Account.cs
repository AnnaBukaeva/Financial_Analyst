using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Analyst.Logic
{
    public class Account : IAccount
    {
        public string Name { get; set; }
        public decimal Balance { get; private set; } //приватный так как лучше ограничить возможность изменения баланса из других классов
        public List<ITransaction> Transactions { get; set; }

        public Account(string name, decimal balance, List<ITransaction> transactions)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name should not be empty or null!");
            }
            if (transactions == null)
            {
                throw new ArgumentNullException("Transactions should not be null!");
            }
            Name = name;
            Balance = balance;
            Transactions = transactions;
        }

        public Account(string name, decimal balance) // транзакций может не быть при создании аккаунта
            :this(name, balance, new List<ITransaction>())
        {
        }

        public void AddTransaction(ITransaction transaction)
        {
            if (transaction == null)
            {
                throw new ArgumentNullException("Transactions should not be null!");
            }
            Balance += transaction.PaymentSum;  // одной строкой решили поведение для двух типов транзакций списание(+ * - = -) и поступление
            Transactions.Add(transaction);
        }
    }
}
