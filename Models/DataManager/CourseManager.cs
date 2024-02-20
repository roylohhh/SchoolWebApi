using SchoolWebApi.Data;

namespace SchoolWebApi.Models.DataManager;

public class CourseManager
{
    private readonly SchoolContext _context;

    public CourseManager(SchoolContext context)
    {
        _context = context;
    }

    public Course GetCourse(string CourseID)
    {
        return _context.Courses.Find(CourseID);
    }

    public IEnumerable<Course> GetAllCourses()
    {
        return _context.Courses.ToList();
    }

    public string AddCourse(Course course)
    {
        _context.Courses.Add(course);
        _context.SaveChanges();

        return course.CourseID;
    }

    public string DeleteCourse(string CourseID)
    {
        _context.Courses.Remove(_context.Courses.Find(CourseID));
        _context.SaveChanges();

        return CourseID;
    }

    public string UpdateCourse(string CourseID, Course course)
    {
        _context.Update(course);
        _context.SaveChanges();

        return CourseID;
    }

}