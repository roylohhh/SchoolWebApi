using Microsoft.AspNetCore.Mvc;
using SchoolWebApi.Models;
using SchoolWebApi.Models.DataManager;

namespace school.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CourseController : ControllerBase
{
    private readonly CourseManager _repo;

    public CourseController(CourseManager repo)
    {
        _repo = repo;
    }

    //GET: api/courses
    [HttpGet]
    public IEnumerable<Course> GetCourses()
    {
        return _repo.GetAllCourses();
    }

    //GET: api/courses/1
    [HttpGet("{CourseID}")]
    public Course GetCourses(string CourseID)
    {
        return _repo.GetCourse(CourseID);
    }

    //POST: api/courses
    [HttpPost]
    public void PostCourse([FromBody] Course course)
    {
        _repo.AddCourse(course);
    }

    //DELETE: api/courses/1
    [HttpDelete("{CourseID}")]
    public string DeleteCourse(string CourseID)
    {
        return _repo.DeleteCourse(CourseID);
    }

    //PUT: api/courses
    [HttpPut]
    public void UpdateCourse([FromBody] Course course)
    {
        _repo.UpdateCourse(course.CourseID, course);
    }

}