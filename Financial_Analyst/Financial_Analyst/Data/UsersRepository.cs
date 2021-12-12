using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Financial_Analyst.Logic;

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
        public static List<IUser> GetUsers()
        {
            BinaryFormatter bf = new BinaryFormatter();
            List<IUser> actual_users = new List<IUser>();
            using (FileStream fl = new FileStream(users_finename, FileMode.Open))
            {
                try
                {
                    actual_users = (List<IUser>)bf.Deserialize(fl);
                }
                catch { }
            }
            return actual_users;
        }

        public static void SaveUser(IUser user)
        {

            List<IUser> actual_users = new List<IUser>();

            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                using (FileStream fl = new FileStream(users_finename, FileMode.Open))
                {
                    actual_users = (List<IUser>)bf.Deserialize(fl);
                }
            }
            catch { }

            actual_users.Add(user);

            using (FileStream fl = new FileStream(users_finename, FileMode.Create))
            {
                bf.Serialize(fl, actual_users);
            }
        }   
    }
}
