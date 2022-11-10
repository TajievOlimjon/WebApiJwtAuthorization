using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Entities;
using WebApi.Entities.EntitieDtos;

namespace WebApi.EntitiesServices
{
    public class CourseService : ICourseService
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public CourseService(ApplicationContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public Task<string> DeleteById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<CourseDto> GetCourseById(int Id)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<List<CourseDto>> GetCoursesAsync()
        {
            var query = await _context.Courses.ToListAsync();
            var mapped = _mapper.Map<List<CourseDto>>(query);
            return mapped;
        }
       

        public async Task<string> Insert(CourseDto entry)
        {
            var mapped = _mapper.Map<Course>(entry);
            await _context.Courses.AddAsync(mapped);
            var course= await _context.SaveChangesAsync();
            if (course == 0) return $"Not Saved !";
            return "Saved Course ";
        }

        public Task<string> Update(CourseDto entry)
        {
            throw new NotImplementedException();
        }
    }
}
