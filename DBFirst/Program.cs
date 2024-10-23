using Employment.Data;

using var emp = new EmpDbContext();

foreach(var employee in emp.Employees){
    Console.WriteLine("{0} {1} {2}",employee.Id,employee.EmployeeName,employee.DepartmentId);
}

