using System.Collections.Generic;

namespace Financial_Analyst.Logic
{
    public interface IAccount
    {
        string Name { get; }
        decimal Balance { get; }          
        string Comment { get; set; }
        List <int> UsersAccess { get; }

        bool CheckAccess(IUser user);
        void ChangeBalance(decimal paymentSum);            
    }
}