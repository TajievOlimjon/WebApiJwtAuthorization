using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Entities;
using WebApi.Entities.EntitieDtos;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebApi.EntitiesServices
{
    public class StudentService:IStudentService
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        public StudentService(ApplicationContext applicationContext,IMapper mapper)
        {
            _context = applicationContext;
            _mapper=mapper;
        }

       
        public async Task<string> Delete(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student==null) return $"Not found Id ={id}";
            _context.Students.Remove(student);
            var deletedEntry= await _context.SaveChangesAsync();
            if (deletedEntry.Equals(null)) return $"Not Deleted: Id = {student.Id}";
            return $"Deleted Student: Id = {student.Id}";
        }

        public Task<string> DeleteById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<List<GetGroupStudentByCourse>> GetGroupStudentByCourses()
        {
            var query = await (from s in _context.Students
                               join c in _context.Courses on s.CourseId equals c.Id
                               group s by new
                               {
                                   CourseId = s.CourseId,
                                   CousrName = c.Name,
                                   Description = c.Description
                               }
                                into gKey
                               select new GetGroupStudentByCourse
                               {
                                   Id = gKey.Key.CourseId,
                                   CourseName = gKey.Key.CousrName,
                                   Description=gKey.Key.Description,
                                   Students = gKey.Select(x => new StudentDto
                                   {
                                       Id = x.Id,
                                       Name = x.Name,
                                       LastName = x.LastName,
                                       Age = x.Age,
                                       PhoneNumber = x.PhoneNumber,
                                       Email = x.Email,
                                       Gender = x.Gender,
                                       CourseId = x.CourseId
                                   }).ToList()
                               }).ToListAsync();
            return query;
        }

        public async Task<StudentDto> GetStudentById(int id)
        {
            var student = await _context.Students.FindAsync(id);
            var mappedStudent = _mapper.Map<StudentDto>(student);
            if (mappedStudent == null) return null;
            return mappedStudent;
        }

        public async Task<List<StudentDto>> GetStudents()
        {   
            var listOfStudents= await _context.Students.ToListAsync();
            var mapped = _mapper.Map<List<StudentDto>>(listOfStudents);
            return mapped;
        }

        public async Task<string> Insert(StudentDto student)
        {
            var mapped = _mapper.Map<Student>(student);
            await _context.Students.AddAsync(mapped);
            var save = await _context.SaveChangesAsync();
            if (save.Equals(null)) return "Not Saved";
            return $"Saved Student:{student.Name}," +
                   $"{student.LastName},{student.Email},{student.PhoneNumber}";
        }

        public async Task<string> Update(StudentDto student)
        {
            var mapped = _mapper.Map<Student>(student);
            _context.Entry(mapped).State = EntityState.Modified;
            var save = await _context.SaveChangesAsync();
            if (save.Equals(null)) return "Not Updated";
            return $"Updated Student:{student.Id}";
        }
    }
}
