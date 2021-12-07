using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Financial_Analyst.Data
{
    public class LastIDRepository
    {
        private static string lastID_filename = @"LastID.dat";

        static LastIDRepository()
        {
            if (!File.Exists(lastID_filename))
            {
                using (FileStream fl = new FileStream(lastID_filename, FileMode.CreateNew))
                {

                }
            }
        }

        public static int GetLastID()
        {
            BinaryFormatter bf = new BinaryFormatter();
            int actual_lastID = 0;
            using (FileStream fl = new FileStream(lastID_filename, FileMode.Open))
            {
                try
                {
                    actual_lastID = (int)bf.Deserialize(fl);
                }
                catch { }
            }
            return actual_lastID;
        }

        public static void SaveLastID(int lastID)
        {
            BinaryFormatter bf = new BinaryFormatter();
            
            using (FileStream fl = new FileStream(lastID_filename, FileMode.Create))
            {
                bf.Serialize(fl, lastID);
            }
        }
    }
}
