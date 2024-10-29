namespace Employment.Data;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("EMPLOYEE")]
public class Employee{

    [Column("empId")]
    public int Id{get; set;}

    [Column("name"),StringLength(40,MinimumLength=5)]
    public string EmployeeName{get; set;}

    public double salary{get; set;}

    [Column("fk_dept")]
    public int DepartmentId{get; set;}

}