using Financial_Analyst.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Analyst.Data
{
    static class AccountRepository
    {
        private static string account_filename = @"account.dat";

        static AccountRepository()
        {
            if (!File.Exists(account_filename))
            {
                using (FileStream fl = new FileStream(account_filename, FileMode.CreateNew))
                {

                }
            }
        }

        public static List<IAccount> GetAccounts()
        {
            BinaryFormatter bf = new BinaryFormatter();
            List<IAccount> actual_account = new List<IAccount>();
            using (FileStream fl = new FileStream(account_filename, FileMode.Open))
            {
                try
                {
                    actual_account = (List<IAccount>)bf.Deserialize(fl);
                }
                catch { }
            }
            return actual_account;
        }

        public static void SaveAccount(IAccount account)
        {
            List<IAccount> actual_accounts = new List<IAccount>();

            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                using (FileStream fl = new FileStream(account_filename, FileMode.Open))
                {
                    actual_accounts = (List<IAccount>)bf.Deserialize(fl);
                }
            }
            catch { }

            actual_accounts.Add(account);

            using (FileStream fl = new FileStream(account_filename, FileMode.Create))
            {
                bf.Serialize(fl, actual_accounts);
            }
        }
    }
}
