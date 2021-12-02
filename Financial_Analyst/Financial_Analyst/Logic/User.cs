using System;
using Financial_Analyst.Logic.Helpers;

namespace Financial_Analyst.Logic
{
    public class User : IUser
    {
        private string _pass_hash;

        public string FIO { get; set; }
        public int ID { get; }
        public static int LastID { get; set; } = 0;
        
        public User(string fio, string pass_hash)
        {
            LastID++;
            ID = LastID;
            if (string.IsNullOrEmpty(FIO))
            {
                throw new ArgumentNullException("FirstName should not be empty or null!");
            }
            if (pass_hash == null)
            {
                throw new ArgumentNullException("password should not be null!");
            }
            _pass_hash = pass_hash;
            FIO = fio;
        }
        
        public bool CheckPassword(string fio, string password)
        {
            string pass_hash = HashHelper.CalcHash(password);
            return FIO == fio && _pass_hash == pass_hash;
        }   
    }
}
