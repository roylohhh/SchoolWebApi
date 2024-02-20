using SchoolWebApi.Data;

namespace SchoolWebApi.Models.DataManager;

public class InstructorManager
{
    private readonly SchoolContext _context;

    public InstructorManager(SchoolContext context)
    {
        _context = context;
    }

    //Read
    public Instructor GetInstructor(string InstructorID)
    {
        return _context.Instructors.Find(InstructorID);
    }

    public IEnumerable<Instructor> GetAllInstructors()
    {
        return _context.Instructors.ToList();
    }

    //Create
    public string AddInstructor(Instructor instructor)
    {
        _context.Instructors.Add(instructor);
        _context.SaveChanges();

        return instructor.InstructorID;
    }

    //Remove
    public string DeleteInstructor(string InstructorID)
    {
        _context.Instructors.Remove(_context.Instructors.Find(InstructorID));
        _context.SaveChanges();

        return InstructorID;
    }

    //Update
    public string UpdateInstructor(string InstructorID, Instructor instructor)
    {
        _context.Update(instructor);
        _context.SaveChanges();

        return InstructorID;
    }

}