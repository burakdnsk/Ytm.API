using AutoMapper;
using ymtProje.DTO.DTOs.BlogDtos;
using ymtProje1.Entity.Entities;

namespace Ytm.API.Mapping
{
    public class BlogCategoryMapping: Profile
    {
        public BlogCategoryMapping() 
        { 
            CreateMap<CreateBlogDto, BlogCategory>().ReverseMap();
            CreateMap<UpdateBlogDto, BlogCategory>().ReverseMap();
            CreateMap<ResultBlogDto, BlogCategory>().ReverseMap();
        }
    }
}
