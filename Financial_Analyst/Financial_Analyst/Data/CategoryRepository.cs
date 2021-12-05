using Financial_Analyst.Logic;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Financial_Analyst.Data
{
    static class CategoryRepository
    {
        private static string category_filename = @"category.dat";

        static CategoryRepository()
        {
            if (!File.Exists(category_filename))
            {
                using (FileStream fl = new FileStream(category_filename, FileMode.CreateNew))
                {

                }
            }
        }

        public static List<ICategory> GetCategories()
        {
            BinaryFormatter bf = new BinaryFormatter();
            List<ICategory> actual_categories = new List<ICategory>();
            using (FileStream fl = new FileStream(category_filename, FileMode.Open))
            {
                try
                {
                    actual_categories = (List<ICategory>)bf.Deserialize(fl);
                }
                catch { }
            }
            return actual_categories;
        }

        public static void SaveCategory(ICategory category)
        {
            List<ICategory> actual_category = new List<ICategory>();

            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                using (FileStream fl = new FileStream(category_filename, FileMode.Open))
                {
                    actual_category = (List<ICategory>)bf.Deserialize(fl);
                }
            }
            catch { }

            actual_category.Add(category);

            using (FileStream fl = new FileStream(category_filename, FileMode.Create))
            {
                bf.Serialize(fl, actual_category);
            }
        }
    }
}
