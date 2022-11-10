namespace WebApi.Entities.EntitieDtos
{
    public class GetGroupStudentByCourse
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public  List<StudentDto> Students { get; set; }

    }
}
