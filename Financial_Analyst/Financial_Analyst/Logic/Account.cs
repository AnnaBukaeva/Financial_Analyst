using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Analyst.Logic
{
    public class Account : IAccount
    {
        public string Name { get; set; }
        public decimal Balance { get; private set; } //приватный так как лучше ограничить возможность изменения баланса из других классов
        private List<ITransaction> _transactions;

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
            _transactions = transactions;
        }
        public Account(string name, decimal balance) // счетов может не быть при создании аккаунта
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
            _transactions.Add(transaction);
        }
        public ReadOnlyCollection<ITransaction> GetTransactions()
        {
            return _transactions.AsReadOnly();
        }
    }
}
