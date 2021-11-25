using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Analyst.Logic
{
    class User : IUser
    {
        public string FirstName => throw new NotImplementedException();

        public string LastName => throw new NotImplementedException();

        public List<IAccount> Accounts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddAccount(IAccount account)
        {
            throw new NotImplementedException();
        }
    }
}
