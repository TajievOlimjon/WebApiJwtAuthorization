using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebApi.EntitiesServices
{
    public class StudentService:IStudentService
    {
        private readonly ApplicationContext _context;
        public StudentService(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }

       
        public async Task<string> Delete(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student==null) return $"Not found Id ={id}";
            _context.Students.Remove(student);
            var deletedEntry= await _context.SaveChangesAsync();
            if (deletedEntry.Equals(null)) return  "Not Deleted";
            return $"Deleted Student: {student.Id},{student.Name},{student.LastName},{student.Email} ,{student.PhoneNumber} ";
        }

        public async Task<Student> GetStudentById(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null) return null;
            return student;
        }

        public async Task<List<Student>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<string> Insert(Student student)
        {             
            await _context.Students.AddAsync(student);
            var save = await _context.SaveChangesAsync();
            if (save.Equals(null)) return "Not Saved";
            return $"Saved Student:{student.Name}," +
                   $"{student.LastName},{student.Email},{student.PhoneNumber}";
        }

        public async Task<string> Update(Student student)
        {
             _context.Entry(student).State = EntityState.Modified;
            var save = await _context.SaveChangesAsync();
            if (save.Equals(null)) return "Not Updated";
            return $"Updated Student:{student.Id}";
        }
    }
}
