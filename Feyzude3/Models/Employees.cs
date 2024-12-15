using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feyzude3.Models
{
    
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeFeature { get; set; }
        public  string EmployeeImage { get; set; }
    }
}
