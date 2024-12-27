using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ymtProje.Business.Abstract;
using ymtProje.DTO.DTOs.Aboutdtos;
using ymtProje.DTO.DTOs.ContactDtos;
using ymtProje1.Entity.Entities;

namespace Ytm.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController(IGenericService<Contact> contactService,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = contactService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var value = contactService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            contactService.TDelete(id);
            return Ok("İletişim Alanı Silindi ");
        }
        [HttpPost]

        public IActionResult Create(CreateContactDto createContactDto)
        {
            var newValue = mapper.Map<Contact>(createContactDto);
            contactService.TCreate(newValue);
            return Ok("Yeni İletişim Alanı Oluşturuldu");
        }
        [HttpPut]

        public IActionResult Update(UpdateContactDto updateContactDto)
        {
            var value = mapper.Map<Contact>(updateContactDto);
            contactService.TUpdate(value);
            return Ok("İletişim Alanı Güncellendi");
        }
    }
}
