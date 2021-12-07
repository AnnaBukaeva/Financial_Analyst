using Financial_Analyst.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Financial_Analyst.Logic
{
    static class TransactionProcessor
    {
        private static List<ITransaction> _transactions;
        private static string transaction_filename;

        static TransactionProcessor()
        {
            _transactions = TransactionRepository.GetTransactions();
        }

        public static void CreateTransaction(DateTime date, decimal paymentSum, IUser user, IAccount account, ICategory category, string comment = null)
        {
            ITransaction transaction = new Transaction(date, paymentSum, user, account, category, comment);
            _transactions.Add(transaction);
            TransactionRepository.SaveTransaction(transaction);
        }

        public static IReadOnlyCollection<ITransaction> GetTransactions(IUser user)
        {
            List<ITransaction> transactionsAccessible = new List<ITransaction>();      //доступные транзакции
            foreach (ITransaction transaction in _transactions)
            {
                if (transaction.Account.CheckAccess(user))
                {
                    transactionsAccessible.Add(transaction);
                }
            }
            IReadOnlyCollection<ITransaction> result = new ReadOnlyCollection<ITransaction>(transactionsAccessible);
            return result;
        }

        public static void RemoveTransaction(int transactionID)
        {
            // в списке транзакций актуальном найти транзакцию с таким ID
            // удалить эту транзакцию через метод remove
            // удалить эту транзакцию в базе данных
            foreach (ITransaction transaction in _transactions)
            {
                if (transactionID == transaction.TransactionID)
                {
                    _transactions.Remove(transaction);
                    transaction.Account.ChangeBalance(transaction.PaymentSum * (-1));
                    AccountRepository.UpdateAccount(transaction.Account);
                    TransactionRepository.RemoveTransaction(transactionID);
                    break;
                }
            }           
        }
    }
}
