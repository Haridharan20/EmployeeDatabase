using Microsoft.EntityFrameworkCore;

namespace EmployeeDatabase.Models
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options):base(options)
        { }

        //Create Table here
       public DbSet<EmployeeModel> employees { get; set; }
    }
}
