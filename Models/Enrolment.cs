using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SchoolWebApi.Models;

public enum Grade
{
    A = 1,
    B = 2,
    C = 3,
    D = 4,
    E = 5,
    F = 6
}

public class Enrolment
{
    [Key]
    public int EnrolmentID {get; set;}

    [ForeignKey("Course")]
    public string CourseID {get; set;}
    public virtual Course Course {get; set;}

    [ForeignKey("Student")]
    public string StudentID {get; set;} 
    public virtual Student Student {get; set;}

    public Grade? Grade {get; set;}
}