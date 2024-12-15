using System.ComponentModel.DataAnnotations;

namespace Feyzude3.Models
{
    public class Randevu
    {
        [Key]
        public int RandevuId { get; set; }
        public string RandevuName { get; set; }
        public string RandevuSaat { get; set; }
        public string RandevuTelefon { get; set; }

    }
}
