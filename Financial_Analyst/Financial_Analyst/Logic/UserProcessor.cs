using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financial_Analyst.Data;

namespace Financial_Analyst.Logic
{
    public static class UserProcessor
    {
        private static List<User> _users;
        static UserProcessor()
        {
            _users = UsersRepository.GetUsers();
        }

        public static List<User> GetUsers()
        {
            return _users;
        }
    }
}
