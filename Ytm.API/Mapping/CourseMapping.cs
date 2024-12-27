using AutoMapper;
using ymtProje.DTO.DTOs.CourseDtos;
using ymtProje1.Entity.Entities;

namespace Ytm.API.Mapping
{
    public class CourseMapping: Profile
    {
        public CourseMapping() 
        {
            CreateMap<CreateCourseDto,Course>().ReverseMap();
            CreateMap<UpdateCourseDto, Course>().ReverseMap();
            CreateMap<ResultCourseDto, Course>().ReverseMap();
        }
    }
}
