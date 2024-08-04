using DesafioControleDeHoras.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioControleDeHoras.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext>opts):base(opts)             
        {
        }
        public DbSet<Employee>Employees { get; set; }
    }
    
    
}
