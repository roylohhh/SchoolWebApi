using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolWebApi.Models;

public class Course 
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string CourseID {get; set;}

    [StringLength(50, MinimumLength =3)]
    public string Title {get; set;}

    [Range(1,5)]
    public int Credit {get; set;}

    public string DepartmentID {get; set;}
    public virtual Department Department {get; set;}

    public virtual List<Enrolment> Enrolments {get; set;}

    public virtual List<CourseAssignment> CourseAssignments {get; set;}

}