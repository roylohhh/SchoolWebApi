using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolWebApi.Models;

public class Department
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string DepartmentID {get; set;}

    [StringLength(50, MinimumLength = 3)]
    public string Name {get; set;}

    [Column(TypeName = "money")]
    [DataType(DataType.Currency)]
    public int Budget {get; set;}

    public DateTime StartDate {get; set;}

    public string InstructorID {get; set;}
    public virtual Instructor Instructor {get; set;}

    public virtual List<Course> Courses {get; set;}

}