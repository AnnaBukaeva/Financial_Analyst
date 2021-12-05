using Financial_Analyst.Data;
using System.Collections.Generic;
using System.Drawing;

namespace Financial_Analyst.Logic
{
    static class CategoryProcessor
    {
        private static List<ICategory> _category;

        static CategoryProcessor()
        {
            _category = CategoryRepository.GetCategories();
        }

        public static void CreateCategory (string name, string discription, Color categoryColor, CategoryType cType)
        {
            ICategory category = new Category (name, discription, categoryColor, cType);
            _category.Add(category);
            CategoryRepository.SaveCategory(category);
        }

        public static IReadOnlyCollection<ICategory> GetCategory()
        {            
            return _category.AsReadOnly();
        }
    }
}
