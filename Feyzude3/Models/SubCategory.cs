using System.ComponentModel.DataAnnotations;

namespace Feyzude3.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategory_Id { get; set; }
        [Display(Name ="Alt Kategori Adı")]
        public string SubCategory_Name { get; set; } = string.Empty;
        [Display(Name = "Kategori No")]
        public int Category_Id { get; set; }    
        public virtual Category? Category { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}
