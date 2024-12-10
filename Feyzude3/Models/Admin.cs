using System.ComponentModel.DataAnnotations;

namespace Feyzude3.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminPass { get; set; }
    }
}
