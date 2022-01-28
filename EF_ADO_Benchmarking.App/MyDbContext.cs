using Microsoft.EntityFrameworkCore;

namespace EF_ADO_Benchmarking.App
{
    public class MyDbContext : DbContext
    {
        protected MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(e =>
            {
                e.ToTable("employees");

                e.Property(p => p.Id);
                e.Property(p => p.Name);
                e.Property(p => p.TeamId);
                e.Property(p => p.Salary);

                e.HasKey(k => k.Id);
            });

            modelBuilder.Entity<Team>(e =>
            {
                e.ToTable("teams");

                e.Property(p => p.Id);
                e.Property(p => p.Name);

                e.HasKey(k => k.Id);
            });
        }
    }
}