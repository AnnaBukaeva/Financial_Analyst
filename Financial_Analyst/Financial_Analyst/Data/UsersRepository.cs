using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Financial_Analyst.Logic;
using Financial_Analyst.Logic.Helpers;

namespace Financial_Analyst.Data
{
    class UsersRepository
    {
        private static string users_finename = @"users.dat";

        static UsersRepository()
        {
            if (!File.Exists(users_finename))
            {
                using (FileStream fl = new FileStream(users_finename, FileMode.CreateNew))
                {
                }
            }
        }
        public static List<User> GetUsers()
        {
            BinaryFormatter bf = new BinaryFormatter();
            List<User> actual_users = new List<User>();
            using (FileStream fl = new FileStream(users_finename, FileMode.Open))
            {
                try
                {
                    actual_users = (List<User>)bf.Deserialize(fl);
                }
                catch { }
            }
            return actual_users;
        }

        public static User RegisterUser(string fio, string password)
        {
            string pass_hash = HashHelper.CalcHash(password);
            User user = new User(fio, pass_hash);

            List<User> actual_users = new List<User>();

            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                using (FileStream fl = new FileStream(users_finename, FileMode.Open))
                {
                    actual_users = (List<User>)bf.Deserialize(fl);
                }
            }
            catch { }

            actual_users.Add(user);

            using (FileStream fl = new FileStream(users_finename, FileMode.Create))
            {
                bf.Serialize(fl, actual_users);
            }
            return user;
        }
    }
}
