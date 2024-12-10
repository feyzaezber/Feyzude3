using System.ComponentModel.DataAnnotations;

namespace Feyzude3.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategory_Id { get; set; }
        public string SubCategory_Name { get; set; } = string.Empty;
        public int Category_Id { get; set; }    
        public virtual Category? Category { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}
