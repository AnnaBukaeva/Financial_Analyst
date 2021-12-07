using System;
using Financial_Analyst.Data;
using Financial_Analyst.Logic.Helpers;

namespace Financial_Analyst.Logic
{
    [Serializable]
    public class User : IUser
    {
        private string _pass_hash;        

        public string FIO { get; set; }
        public int ID { get; }       
        
        public User(string fio, string pass_hash)
        {
            int lastID = LastIDRepository.GetLastID();
            lastID++;
            ID = lastID;
            LastIDRepository.SaveLastID(lastID);

            if (string.IsNullOrEmpty(fio))
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
