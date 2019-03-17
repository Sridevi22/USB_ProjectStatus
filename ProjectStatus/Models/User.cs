
using System.ComponentModel.DataAnnotations;

namespace ProjectStatus.Models
{
    public class User
    {
        [Key]
        public long EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeMailID { get; set; }
    }
}
