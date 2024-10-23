namespace Employment.Data;
using System.ComponentModel.DataAnnotations.Schema;

[Table("EMPLOYEE")]
public class Employee{

    [Column("empId")]
    public int Id{get; set;}

    [Column("name")]
    public string EmployeeName{get; set;}

    public float salary{get; set;}

    [Column("fk_dept")]
    public int DepartmentId{get; set;}

}