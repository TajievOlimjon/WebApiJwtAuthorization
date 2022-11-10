using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApi.Entities;
using WebApi.Entities.EntitieDtos;
using WebApi.EntitiesServices;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController :ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        // GET: StudentController
        [HttpGet("GetStudents")]
        public async Task<ActionResult<List<StudentDto>>> GetStudents()
        {
            var student = await _studentService.GetStudents();
            return student;
        }
        [HttpGet("GetGroupStudentByCourses")]
        public async ValueTask<List<GetGroupStudentByCourse>> GetGroupStudentByCourses()
        {
            return await _studentService.GetGroupStudentByCourses();
        }


        [HttpGet("GetStudentById")]
        public async Task<StudentDto> GetStudentById(int Id)
        {
            var student = await _studentService.GetStudentById(Id);           
            return student;
        }
        [HttpPost("AddStudent")]
        public async Task<string> AddStudent([FromForm] StudentDto student)
        {
            return    await _studentService.Insert(student);
        }

        [HttpPut("EditStudent")]
        public async Task<string> EditStudent([FromForm] StudentDto student)
        {
            return  await _studentService.Update(student);
            //if (save != null) return "Saved";
            //return "Not Saved";
        }

        [HttpDelete("DeleteStudent")]
        public async Task<string> DeleteStudent(int Id)
        {
            return await _studentService.Delete(Id);
            
        }


    }
}
