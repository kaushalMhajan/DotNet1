using Microsoft.EntityFrameworkCore;

namespace Employment.Data;

public class EmpDbContext : DbContext{

    public DbSet<Employee> Employees {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite("Data Source = emp.db");
    }    
}