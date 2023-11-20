using System.ComponentModel.DataAnnotations.Schema;

namespace SEIITestForAmericanSpecialtyProject.Models
{
    [NotMapped]
    public class Supervisor : Person
    {
        public decimal AnnualSalary { get; set; }
    }
}
