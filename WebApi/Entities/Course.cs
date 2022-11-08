namespace WebApi.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<CourseStudent> Students { get; set; }

    }
}
