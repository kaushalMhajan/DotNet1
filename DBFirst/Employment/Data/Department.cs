namespace Employment.Data;
using System.ComponentModel.DataAnnotations.Schema;

[Table("DEPT")]
public class Department{

    [Column("deptID")]
    public int Id{get; set;}

    [Column("dname")]
    public string DepartmentName{get;set;}

}