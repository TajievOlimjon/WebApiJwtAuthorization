using WebApi.Data;
using WebApi.Enums;

namespace WebApi.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public DateTimeOffset CreateDate { get; set; }= DateTimeOffset.Now;
        public DateTimeOffset UpdateDate { get; set; }
        public virtual List<CourseStudent> Courses { get; set; }
    }
}
