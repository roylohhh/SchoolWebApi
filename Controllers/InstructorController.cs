using Microsoft.AspNetCore.Mvc;
using SchoolWebApi.Models;
using SchoolWebApi.Models.DataManager;

namespace school.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InstructorController : ControllerBase
{
    private readonly InstructorManager _repo;

    public InstructorController(InstructorManager repo)
    {
        _repo = repo;
    }

    //GET: api/instructors
    [HttpGet]
    public IEnumerable<Instructor> GetInstructors()
    {
        return _repo.GetAllInstructors();
    }

    //GET: api/instructors/1
    [HttpGet("{InstructorID}")]
    public Instructor GetInstructors(string InstructorID)
    {
        return _repo.GetInstructor(InstructorID);
    }

    //POST: api/instructors
    [HttpPost]
    public void PostInstructor([FromBody] Instructor instructor)
    {
        _repo.AddInstructor(instructor);
    }

    //DELETE: api/instructors/1
    [HttpDelete("{InstructorID}")]
    public string DeleteInstructor(string InstructorID)
    {
        return _repo.DeleteInstructor(InstructorID);
    }

    //PUT: api/instructors
    [HttpPut]
    public void PutInstructor([FromBody] Instructor instructor)
    {
        _repo.UpdateInstructor(instructor.InstructorID, instructor);
    }

}