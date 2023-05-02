using EmployeeSamGTU.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeSamGTU
{
    // Это для бд
    public class AppDbContext:DbContext
    {


        public DbSet<Employee> Employees { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> dbContext): base(dbContext)
        {

        }
    }
}
