using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Feyzude3.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage ="Bu alanı boş bırakamazsınız")]
        public string AdminName { get; set; }
        [DisplayName("Şİfre")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız")]
        [MinLength(8, ErrorMessage ="Sekiz karakterden az olamaz")]
        public string AdminPass { get; set; }
    }
}
