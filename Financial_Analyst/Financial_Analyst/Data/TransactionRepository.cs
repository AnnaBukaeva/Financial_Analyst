using Financial_Analyst.Logic;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Financial_Analyst.Data
{
    static class TransactionRepository
    {
        private static string transaction_filename = @"transaction.dat";

        static TransactionRepository()
        {
            if (!File.Exists(transaction_filename))
            {
                using (FileStream fl = new FileStream(transaction_filename, FileMode.CreateNew))
                {

                }
            }
        }

        public static List<ITransaction> GetTransactions()
        {
            BinaryFormatter bf = new BinaryFormatter();
            List<ITransaction> actual_transactions = new List<ITransaction>();
            using (FileStream fl = new FileStream(transaction_filename, FileMode.Open))
            {
                try
                {
                    actual_transactions = (List<ITransaction>)bf.Deserialize(fl);
                }
                catch { }
            }
            return actual_transactions;
        }

        public static void SaveTransaction(ITransaction transaction)
        {
            List<ITransaction> actual_transactions = new List<ITransaction>();

            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                using (FileStream fl = new FileStream(transaction_filename, FileMode.Open))
                {
                    actual_transactions = (List<ITransaction>)bf.Deserialize(fl);
                }
            }
            catch { }

            actual_transactions.Add(transaction);

            using (FileStream fl = new FileStream(transaction_filename, FileMode.Create))
            {
                bf.Serialize(fl, actual_transactions);
            }
        }
        public static void RemoveTransaction (int transactionID)
        {
            List<ITransaction> actual_transactions = new List<ITransaction>();

            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                using (FileStream fl = new FileStream(transaction_filename, FileMode.Open))
                {
                    actual_transactions = (List<ITransaction>)bf.Deserialize(fl);
                }
            }
            catch { } //чтение из файла в список actual_transactions

            foreach (ITransaction transaction in actual_transactions)
            {
                if (transactionID == transaction.TransactionID)
                {
                    actual_transactions.Remove(transaction);
                    break;
                }
            }
            using (FileStream fl = new FileStream(transaction_filename, FileMode.Create))// сохранеение нового списка в файл
            {
                bf.Serialize(fl, actual_transactions);
            }
        }
    }
}
