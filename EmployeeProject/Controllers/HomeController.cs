using Employment.Data;
using Employment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employment.Controllers;

public class HomeController(EmpModel emp) :Controller{
    public IActionResult Index()
    {
        var employee = emp.GetEmployees();
        return View(employee);
    }

    public IActionResult Register(){
        return View();
    }
    
    [HttpPost]
    public IActionResult Register(int empId,string empname,int deptid,float empsal){
        emp.AddEmployee(empId,empname,deptid,empsal);
        return RedirectToAction("Index");
    }

}