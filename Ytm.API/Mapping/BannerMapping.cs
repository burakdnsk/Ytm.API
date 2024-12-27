using AutoMapper;
using ymtProje.DTO.DTOs.Bannerdtos;
using ymtProje1.Entity.Entities;

namespace Ytm.API.Mapping
{
    public class BannerMapping:Profile
    {
        public BannerMapping()
        {
        CreateMap<CreateBannerDto, Banner>().ReverseMap();
        CreateMap<UpdateBannerDto, Banner>().ReverseMap();

        }
    }
}
