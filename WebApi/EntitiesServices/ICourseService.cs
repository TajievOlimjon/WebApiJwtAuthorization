using WebApi.BaseServices;
using WebApi.Entities.EntitieDtos;

namespace WebApi.EntitiesServices
{
    public interface ICourseService:IBaseService<CourseDto>
    {
        ValueTask<List<CourseDto>> GetCoursesAsync();
        ValueTask<CourseDto> GetCourseById(int Id);
        
    }
}
