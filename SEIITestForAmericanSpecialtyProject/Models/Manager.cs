using System.ComponentModel.DataAnnotations.Schema;

namespace SEIITestForAmericanSpecialtyProject.Models
{
    [NotMapped]
    public class Manager : Person
    {
        public decimal AnnualSalary { get; set; }
        public decimal MaxExpenseAmount { get; set; }
    }
}
