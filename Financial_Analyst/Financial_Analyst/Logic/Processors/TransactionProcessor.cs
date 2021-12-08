using Financial_Analyst.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Financial_Analyst.Logic
{
    static class TransactionProcessor
    {
        private static List<ITransaction> _transactions;

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

        private static void RemoveTransaction(ITransaction transaction)
        {
            _transactions.Remove(transaction);
            transaction.Account.ChangeBalance(transaction.PaymentSum * (-1));
            AccountRepository.UpdateAccount(transaction.Account);
            TransactionRepository.RemoveTransaction(transaction.TransactionID);

        }

        public static void RemoveTransactionsList(int transactionID)
        {
            foreach (ITransaction transaction in _transactions)
            {
               if (transactionID == transaction.TransactionID)
               {
                    RemoveTransaction(transaction);
                    break;
               }
            }          
        }
    }
}
