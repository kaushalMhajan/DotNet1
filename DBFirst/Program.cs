using Employment.Data;
using Employment.Model;

using var emp = new EmpDbContext();

// int Id, string Name,int deptid,float salary


if (args.Length == 0)
{
    foreach (var employee in emp.Employees)
    {
        Console.WriteLine("{0} {1} {2}", employee.Id, employee.EmployeeName, employee.DepartmentId);
    }
}
// else
// {

//     int id = int.Parse(args[0]);
//     string name = args[1];
//     int deptId = int.Parse(args[2]);
//     float sal = float.Parse(args[3]);
//     var empschema = new EmpModel();
//     empschema.AddEmployee(id, name, deptId, sal);
// }
else{
    int id = int.Parse(args[0]);
    string name = args[1];
    var deptschema = new EmpModel();
    deptschema.AddDepartment(id,name);

     foreach (var departments in emp.Departments)
    {
        Console.WriteLine("{0} {1}", departments.Id, departments.DepartmentName);
    }

}