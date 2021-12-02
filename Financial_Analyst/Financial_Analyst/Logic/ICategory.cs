using System.Drawing;

namespace Financial_Analyst.Logic
{
    public interface ICategory
    {
        string Name { get; set; }
        string Discription { get; set; }
        Color CategoryColor { get; set; }
        CategoryType CType { get; set; }    
    }
}
