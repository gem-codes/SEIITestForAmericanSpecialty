using Microsoft.EntityFrameworkCore;
using SEIITestForAmericanSpecialtyProject.Models;
using System.Collections.Generic;

namespace SEIITestForAmericanSpecialtyProject.DbContextFactory
{

    public class AppDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Manager> Manager { get; set; }
        public DbSet<Supervisor> Supervisor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your database connection here
            optionsBuilder.UseSqlServer(_configuration["ConnectionStrings:DefaultConnection"]);
        }

        public void SeedData()
        {
            if (!Person.Any())
            {
                // Add initial data
                var employee = new Employee { FirstName = "John", LastName = "Doe", Address1 = "123 Main St", PayPerHour = 15.50m };
                var manager = new Manager { FirstName = "Jane", LastName = "Smith", Address1 = "456 Oak St", AnnualSalary = 80000.00m, MaxExpenseAmount = 2000.00m };
                var supervisor = new Supervisor { FirstName = "Sam", LastName = "Johnson", Address1 = "789 Pine St", AnnualSalary = 60000.00m };

                Person.AddRange(employee, manager, supervisor);

                SaveChanges();
            }
        }
    }
}
