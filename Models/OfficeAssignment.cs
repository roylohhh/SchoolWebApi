using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolWebApi.Models;

public class OfficeAssignment
{
    [Key]
    [ForeignKey("Instructor")]
    public string InstructorID {get; set;}
    public virtual Instructor Instructor {get; set;}

    [StringLength(50)]
    public string Location {get; set;}
}