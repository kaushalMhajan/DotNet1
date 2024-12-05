using Employment.Data;

namespace Employment.Models;

public class EmpModel
{

    public IEnumerable<AllEmployee> GetEmployees()
    {
        using var emp = new EmpDbContext();
        var selection = from e in emp.Employees
                        select new AllEmployee
                        {
                            Id = e.Id,
                            Name = e.EmployeeName,
                            Salary = e.salary,
                            Department = e.DepartmentId
                        };
        return selection.ToList();
    }

    public IEnumerable<AllEmployee> GetAnEmployees(int id)
    {
        using var emp = new EmpDbContext();
        var selection = from e in emp.Employees
                        where e.Id == id
                        select new AllEmployee
                        {
                            Id = e.Id,
                            Name = e.EmployeeName,
                            Salary = e.salary,
                            Department = e.DepartmentId
                        };
        return selection.ToList();
    }

    public IEnumerable<AllDepartment> GetAllDepartments()
    {
        using var emp = new EmpDbContext();
        var selection = from e in emp.Departments
                        select new AllDepartment
                        {
                            Id = e.Id,
                            DName = e.DepartmentName
                        };
        return selection.ToList();
    }

    public void AddEmployee(string Name, int deptid, float salary)
    {
        using var emp = new EmpDbContext();
        var count = emp.Counters.Find("employee");
        if (count != null)
        {
            count.currentvalue = ++count.currentvalue;
        }
        int newId = (int)count.currentvalue;
        var empschema = emp.Employees.Find(newId);
        if (empschema is null)
        {
            empschema = new Employee { Id = newId };
            emp.Employees.Add(empschema);
        }
        empschema.EmployeeName = Name;
        empschema.DepartmentId = deptid;
        empschema.salary = salary;

        //to save the changes in the database
        emp.SaveChanges();
    }

    public void AddDepartment(string Name)
    {
        using var dept = new EmpDbContext();
        var count = dept.Counters.Find("dept");
        if (count != null)
        {
            count.currentvalue = ++count.currentvalue;
        }
        int newId = (int)count.seedvalue * (int)count.currentvalue;
        var deptschema = dept.Departments.Find(newId);
        if (deptschema is null)
        {
            deptschema = new Department { Id = newId };
            dept.Departments.Add(deptschema);
        }
        deptschema.DepartmentName = Name;

        //to save the changes in the database
        dept.SaveChanges();
    }

    public void DeleteDepartment(int Id){
        using var dept = new EmpDbContext();
        var deptschema = dept.Departments.Find(Id);
        var count = dept.Counters.Find("dept");
        if (count != null)
        {
            count.currentvalue = --count.currentvalue;
        }
        if(deptschema != null){
            dept.Departments.Remove(deptschema);
        }
        dept.SaveChanges();
    }
    public void DeleteEmployee(int Id){
        using var emp = new EmpDbContext();
        var empschema = emp.Employees.Find(Id);
         var count = emp.Counters.Find("dept");
        if (count != null)
        {
            count.currentvalue = --count.currentvalue;
        }
        if(empschema != null){
            emp.Employees.Remove(empschema);
        }
        emp.SaveChanges();
    }

}
