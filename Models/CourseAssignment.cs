using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolWebApi.Models;

[PrimaryKey(nameof(CourseID), nameof(InstructorID))]
public class CourseAssignment 
{
    [ForeignKey("Course")]
    public string CourseID {get; set;}
    public virtual Course Course {get; set;}

    [ForeignKey("Instructor")]
    public string InstructorID {get; set;}
    public virtual Instructor Instructor {get; set;}
}