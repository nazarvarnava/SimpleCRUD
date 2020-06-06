using Microsoft.EntityFrameworkCore;

namespace MyCRUD.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {

        }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}
