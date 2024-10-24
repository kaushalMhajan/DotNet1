using Microsoft.EntityFrameworkCore;

namespace Employment.Data;

public class EmpDbContext : DbContext{

    public DbSet<Employee> Employees {get; set;}
    public DbSet<Department> Departments {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite("Data Source=site.db");
    }    
}