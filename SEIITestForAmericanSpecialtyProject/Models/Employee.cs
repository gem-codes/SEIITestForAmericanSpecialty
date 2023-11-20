using System.ComponentModel.DataAnnotations.Schema;

namespace SEIITestForAmericanSpecialtyProject.Models
{
    [NotMapped]
    public class Employee : Person
    {
        public decimal PayPerHour { get; set; }
    }
}
