using WebApi.Entities;

namespace WebApi.EntitiesServices
{
    public interface IStudentService
    {
        Task<List<Student>> GetStudents();
        Task<Student> GetStudentById(int id);
        Task<string> Insert(Student student);
        Task<string> Update(Student student);
        Task<string> Delete(int id);


    }
}
