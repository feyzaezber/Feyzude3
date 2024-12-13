using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feyzude3.Models
{
    public class Product
    {
        [Key]
        public int Product_Id { get; set; }
        public string Product_Name { get; set; } = string.Empty;
        public string Product_Description { get; set; } = string.Empty;
        public string Product_Image { get; set; } = string.Empty;
        public string Product_Price { get; set; }
        [ForeignKey("Category")]
        public int Category_Id { get; set; }
        public virtual Category? Category { get; set; }
        [ForeignKey("SubCategories")]
        public int SubCategory_Id {  get; set; }
        public virtual SubCategory? SubCategory { get; set; }
        public string Product_Feature { get; set; } = string.Empty;

    }
}
