using Financial_Analyst.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Analyst.Logic
{    
        static class AuthProcessor
        {
            static List<User> _users;

            static AuthProcessor()
            {
                _users = UsersRepository.GetUsers();
            }

            public static IUser FindAndCheckPassword(string fio, string password)
            {
                if (_users == null || _users.Count == 0)
                    return null;

                foreach (User us in _users)
                {
                    if (us.CheckPassword(fio, password))
                    {
                        return us;
                    }
                }
                return null;
            }
            public static void RegisterUser(string fio, string password)
            {
                User user = UsersRepository.RegisterUser(fio, password);
                if (user != null)
                    _users.Add(user);
                else
                    throw new Exception("Не удалось создать пользователя!");
            }
        }
}
