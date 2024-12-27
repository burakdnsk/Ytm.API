using AutoMapper;
using ymtProje.DTO.DTOs.BlogDtos;
using ymtProje1.Entity.Entities;

namespace Ytm.API.Mapping
{
    public class BlogMapping : Profile
    {
        public BlogMapping() 
        { 
            CreateMap<CreateBlogDto, Blog>().ReverseMap();
            CreateMap<UpdateBlogDto, Blog>().ReverseMap();
            CreateMap<ResultBlogDto, Blog>().ReverseMap();

        }
    }
}
