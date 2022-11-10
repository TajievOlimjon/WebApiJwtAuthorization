using WebApi.Enums;

namespace WebApi.Entities.EntitieDtos
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public int CourseId { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
    }
}
