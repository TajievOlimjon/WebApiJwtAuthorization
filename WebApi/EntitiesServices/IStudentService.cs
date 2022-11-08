using WebApi.BaseServices;
using WebApi.Entities;

namespace WebApi.EntitiesServices
{
    public interface IStudentService:IBaseService<Student>
    {
        Task<List<Student>> GetStudents();
        Task<Student> GetStudentById(int id);
        Task<string> Delete(int Id);


    }
}
