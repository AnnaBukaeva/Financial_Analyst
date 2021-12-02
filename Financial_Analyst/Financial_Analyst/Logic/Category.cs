
using System.Drawing;

namespace Financial_Analyst.Logic
{
    public class Category : ICategory
    {
        public string Name { get; set; }
        public string Discription { get; set; }
        public Color CategoryColor { get; set; }
        public CategoryType CType { get; set; }

        public Category (string name, string discription, Color categoryColor, CategoryType cType)
        {
            Name = name;
            Discription = discription;
            CategoryColor = categoryColor;
            CType = cType;
        }
    }
}
