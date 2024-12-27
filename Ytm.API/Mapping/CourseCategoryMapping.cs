using AutoMapper;
using ymtProje.DTO.DTOs.CourseCategoryDtos;
using ymtProje.DTO.DTOs.CourseDtos;
using ymtProje1.Entity.Entities;

namespace Ytm.API.Mapping
{
    public class CourseCategoryMapping:Profile
    {
        public CourseCategoryMapping() 
        {
            CreateMap<CreateCourseCategoryDto, CourseCategory>().ReverseMap();
            CreateMap<UpdateCourseCategoryDto, CourseCategory>().ReverseMap();
            CreateMap<ResultCourseCategoryDto, CourseCategory>().ReverseMap();
        }
    }
}
