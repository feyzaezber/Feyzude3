using System.ComponentModel.DataAnnotations;

namespace Feyzude3.Models
{
    public class Iletisim
    {
        [Key]
        public int IletisimId { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; } 
    }
}
