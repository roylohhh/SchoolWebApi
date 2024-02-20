using Microsoft.EntityFrameworkCore;
using SchoolWebApi.Models;

namespace SchoolWebApi.Data;

public class SchoolContext : DbContext 
{
    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
    {}

    public DbSet<Student> Students {get; set;}
    public DbSet<Course> Courses {get; set;}
    public DbSet<Department> Departments {get; set;}
    public DbSet<Enrolment> Enrolments {get; set;}
    public DbSet<Instructor> Instructors {get; set;}
    public DbSet<OfficeAssignment> OfficeAssignments {get; set;}
    public DbSet<CourseAssignment> CourseAssignments {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    }
}