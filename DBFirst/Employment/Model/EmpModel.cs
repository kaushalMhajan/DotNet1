using Employment.Data;

namespace Employment.Model;

public class EmpModel{

    public void AddEmployee(int id, string Name,int deptid,float salary){
            using var emp = new EmpDbContext();
            var empschema = emp.Employees.Find(id);
            if(empschema is null){
                empschema = new Employee{Id = id};
                emp.Employees.Add(empschema);
            }
            empschema.EmployeeName = Name;
            empschema.DepartmentId = deptid;
            empschema.salary = salary;

            //to save the changes in the database
            emp.SaveChanges();
    }

    public void AddDepartment(int id, string Name){
            using var dept = new EmpDbContext();
            var deptschema = dept.Departments.Find(id);
            if(deptschema is null){
                deptschema = new Department{Id = id};
                dept.Departments.Add(deptschema);
            }
            deptschema.DepartmentName = Name;

            //to save the changes in the database
            dept.SaveChanges();
    }

}