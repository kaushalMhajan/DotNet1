using Microsoft.EntityFrameworkCore;

namespace Employment.Data;

public class EmpDbContext : DbContext{

    public DbSet<Employee> Employees {get; set;}
    public DbSet<Department> Departments {get; set;}
    public DbSet<Counters> Counters {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlServer("Data Source=iitdac.met.edu;Database=Shop1;User Id=dac1;Password=Dac1@1234;Encrypt=False");
    }
    
}