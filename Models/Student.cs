using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolWebApi.Models;

public class Student
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string StudentID {get; set;}

    [Required, StringLength(50)]
    [RegularExpression("^[A-Z][a-zA-Z]*$",ErrorMessage ="First letter must be a capital letter followed by alphabets")]
    public string LastName {get; set;}

    [Required, StringLength(50)]
    [RegularExpression("^[A-Z][a-zA-Z]*$",ErrorMessage ="First letter must be a capital letter followed by alphabets")]
    public string FirstMidName {get; set;}

    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime EnrolmentDate {get; set;}

    public virtual List<Enrolment> Enrolments {get; set;}

}