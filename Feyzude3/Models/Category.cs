using System.ComponentModel.DataAnnotations;

namespace Feyzude3.Models
{
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }
        public string Category_Name{ get; set; }
        public virtual ICollection<SubCategory>? SubCategories { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}
