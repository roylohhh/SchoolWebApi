using SchoolWebApi.Models;

namespace SchoolWebApi.Data;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        var context = serviceProvider.GetRequiredService<SchoolContext>();

        if(context.Students.Any())
            return;

        const string format = "yyyy-MM-dd";

        context.Departments.AddRange(
            new Department
            {
                DepartmentID = "4001",
                Name = "Computing Technologies",
                Budget = 6000,
                StartDate = DateTime.ParseExact("2024-02-01", format, null),
                InstructorID = "2001"
            }
        );

        context.Courses.AddRange(
            new Course
            {
                CourseID = "COS456",
                Title = "Web Development Technologies",
                Credit = 5,
                DepartmentID = "4001"
            }
        );

        context.Instructors.AddRange(
            new Instructor
            {
                InstructorID = "2001",
                LastName = "Johnson",
                FirstMidName = "Lebron Bryant",
                HireDate = DateTime.ParseExact("2022-08-11", format, null)
            }
        );

        context.Students.AddRange(
            new Student
            {
                StudentID = "s1234567",
                LastName = "Doe",
                FirstMidName = "John",
                EnrolmentDate = DateTime.ParseExact("2023-09-01", format, null)
            }
        );

        context.Enrolments.AddRange(
            new Enrolment
            {
                CourseID = "COS456",
                StudentID = "s1234567",
                Grade = null
            }
        );

        context.CourseAssignments.AddRange(
            new CourseAssignment
            {
                CourseID = "COS456",
                InstructorID = "2001"
            }
        );

        context.OfficeAssignments.AddRange(
            new OfficeAssignment
            {
                InstructorID = "2001",
                Location = "12.10.26"
            }
        );

        context.SaveChanges();
    }
}