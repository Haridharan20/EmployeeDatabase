using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDatabase.Models
{
    public class EmployeeModel
    {
        [Key]
        public int empId { get; set; }

        [Column(TypeName="varchar(100)")]
        public string name { get; set; }

        [Required(AllowEmptyStrings =true)]
        public int age { get; set; }

        [Column(TypeName ="varchar(30)")]
        public string department { get; set; }  
    }
}
