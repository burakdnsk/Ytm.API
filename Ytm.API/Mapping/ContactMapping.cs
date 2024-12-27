using AutoMapper;
using ymtProje.DTO.DTOs.ContactDtos;
using ymtProje1.Entity.Entities;

namespace Ytm.API.Mapping
{
    public class ContactMapping: Profile
    { 
        public ContactMapping() 
        {
            CreateMap<CreateContactDto,Contact>().ReverseMap();
            CreateMap<UpdateContactDto, Contact>().ReverseMap();
        }
    }
}
