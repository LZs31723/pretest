using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Service;

namespace WebApplication8.Controller;

public class CourseController : ControllerBase
{
    private readonly IServiceCourse _serviceCourse;

    public CourseController(IServiceCourse serviceCourse)
    {
        _serviceCourse = serviceCourse;
    }

    [HttpGet("api/course-statistics")]
    public async Task<IActionResult> GetPatients([FromQuery] int? courseId = null)
    {   
        var courseSummaries = _serviceCourse.GetPatientsAsync(courseId);
        return Ok(await courseSummaries);
    }

}