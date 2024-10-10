using Microsoft.EntityFrameworkCore;

namespace MVCNO1.Models
{
    public class ITIDbContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-2B2ELT1;Database=ITI54;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
