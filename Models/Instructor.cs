using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolWebApi.Models;

public class Instructor 
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string InstructorID {get; set;}

    [Required, StringLength(50)]
    [RegularExpression("^[A-Z][a-zA-Z]*$",ErrorMessage ="First letter must be a capital letter followed by alphabets")]
    public string LastName {get; set;}

    [Required, StringLength(50)]
    [RegularExpression("^[A-Z][a-zA-Z]*$",ErrorMessage ="First letter must be a capital letter followed by alphabets")]
    public string FirstMidName {get; set;}

    public DateTime HireDate {get; set;}

    public virtual OfficeAssignment OfficeAssignment {get; set;}

    public virtual List<CourseAssignment> CourseAssignments {get; set;}
}