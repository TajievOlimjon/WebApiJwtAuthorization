using AutoMapper;
using WebApi.Entities;
using WebApi.Entities.EntitieDtos;

namespace WebApi.Data.MapperService
{
    public class MapperEntities:Profile
    {
        public MapperEntities( )
        {
            CreateMap<BookDto,Book>().ReverseMap();
            CreateMap<AuthorDto,Author>().ReverseMap();
            CreateMap<CourseDto,Course>().ReverseMap();
            CreateMap<StudentDto,Student>().ReverseMap();
            CreateMap<GetGroupStudentByCourse, Student>().ReverseMap();

        }
    }
}
