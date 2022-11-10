using WebApi.BaseServices;
using WebApi.Entities;
using WebApi.Entities.EntitieDtos;

namespace WebApi.EntitiesServices
{
    public interface IStudentService:IBaseService<StudentDto>
    {
        Task<List<StudentDto>> GetStudents();
        Task<StudentDto> GetStudentById(int id);
        Task<string> Delete(int Id);
        ValueTask<List<GetGroupStudentByCourse>> GetGroupStudentByCourses();


    }
}
