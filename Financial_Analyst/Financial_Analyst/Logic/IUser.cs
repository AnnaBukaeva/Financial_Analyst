namespace Financial_Analyst.Logic
{
    public interface IUser
    {
        int ID { get; }
        string FIO { get; set; }       
        bool CheckPassword(string fio, string password);   
    }
}