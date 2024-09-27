using Microsoft.EntityFrameworkCore;
using MVCDAY1AGAIN.DAL.Entites;

namespace MVCDAY1AGAIN.DAL.DB
{
    public class Applicationcontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=test1;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
