using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Entities.EntitieDtos;
using WebApi.EntitiesServices;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService course)
        {
            _courseService = course;
        }
        
        [HttpGet("GetCourses")]
        public async ValueTask<List<CourseDto>> GetCoursesAsync()
        {
            return await _courseService.GetCoursesAsync();
        }

        [HttpPost("AddCourse")]
        public async Task<ActionResult> Create([FromForm] CourseDto courseDto)
        {
            var course = await _courseService.Insert(courseDto);
            if (course == null) return BadRequest();
            return Ok(course);
        }
    }
}
