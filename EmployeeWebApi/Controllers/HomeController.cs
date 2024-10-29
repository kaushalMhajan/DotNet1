using Employment.Data;
using Employment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employment.Controllers;

//ControllerBase class is use to handle the request , response through http url

//Controller class is use to render the views , add additional functionalities and it also inherits from ControllerBase class. 

//Controllers are used to render views and manage the user interface.

//Api Controller are used to expose data and services.

[ApiController]
public class HomeController : ControllerBase{

    [HttpGet("/api/home")]
    public IActionResult ReadEmployees(EmpModel emp)
    {
        var employee = emp.GetEmployees();
        if(employee.Any())
            return Ok(employee);
        return NotFound();

    }

    [HttpGet("/api/home/dept")]
    public IActionResult ReadDepartments(EmpModel emp){
        var dept = emp.GetAllDepartments();
        if(dept.Any())
            return Ok(dept);
         return NotFound();
    }

    [HttpPost("/api/home/dept/adddept")]
    public IActionResult WriteDepartments(Department input,EmpModel emp){
        emp.AddDepartment(input.DepartmentName);
        return Ok();
    }

    [HttpPost("/api/home/emp/addemp")]
    public IActionResult WriteEmployees(Employee input,EmpModel emp){
        emp.AddEmployee(input.EmployeeName,input.DepartmentId,(int)input.salary);
        return Ok();
    }

    // public IActionResult Department(){
    //     var dept = emp.GetAllDepartments();
    //     return View(dept);
    // }

    // public IActionResult Register(){
    //     return View();
    // }

    // public IActionResult AddDepartment(){
    //     return View();
    // }

    // public IActionResult DeleteDepartment(){
    //     return View();
    // }
    
    // [HttpPost]
    // public IActionResult Register(string empname,int deptid,float empsal){
    //     emp.AddEmployee(empname,deptid,empsal);
    //     return RedirectToAction("Index");
    // }

    // [HttpPost]
    // public IActionResult AddDepartment(string dname){
    //     emp.AddDepartment(dname);
    //     return RedirectToAction("Department");
    // }

    // [HttpPost]
    // public IActionResult DeleteDepartment(int deptid){
    //     emp.DeleteDepartment(deptid);
    //     return RedirectToAction("Department");
    // }

}