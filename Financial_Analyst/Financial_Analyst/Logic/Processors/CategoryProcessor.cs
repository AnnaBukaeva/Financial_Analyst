using Financial_Analyst.Data;
using System;
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
            foreach (ICategory item in _category)
            {
                if (item.Name == name)
                {
                    throw new ArgumentException("Категория с таким именем уже существует!");
                }
            }
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
