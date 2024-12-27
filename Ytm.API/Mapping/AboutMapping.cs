using AutoMapper;
using ymtProje.DTO.DTOs.Aboutdtos;
using ymtProje1.Entity.Entities;

namespace Ytm.API.Mapping
{
    public class AboutMapping :Profile
    {

        public AboutMapping() 
        {
            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
        }

    }
}
