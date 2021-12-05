using Financial_Analyst.Data;
using Financial_Analyst.Logic.Helpers;
using System;
using System.Collections.Generic;

namespace Financial_Analyst.Logic
{
    static class UserProcessor
    {
        private static List<IUser> _users;    

        static UserProcessor()
        {
            _users = UsersRepository.GetUsers();
        }

        public static IUser FindAndCheckPassword(string fio, string password)
        {
            if (_users == null || _users.Count == 0)
                return null;

            foreach (IUser us in _users)
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
            string pass_hash = HashHelper.CalcHash(password);
            IUser user = new User(fio, pass_hash);
            UsersRepository.SaveUser(user);
            if (user != null)
                _users.Add(user);
            else
                throw new Exception("Не удалось создать пользователя!");
        }

        public static IReadOnlyCollection<IUser> GetUsers()
        {
            return _users.AsReadOnly();
        }
    }
}
