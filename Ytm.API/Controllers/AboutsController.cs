using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ymtProje1.Entity.Entities;
using ymtProje.Business.Abstract;
using AutoMapper;
using ymtProje.DTO.DTOs.Aboutdtos;

namespace Ytm.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AboutsController(IGenericService<About> aboutService,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        {
            var values = aboutService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var value = aboutService.TGetById(id);  
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            aboutService.TDelete(id);
            return Ok("Hakkımızda Alanı Silindi ");
        }
        [HttpPost]

        public IActionResult Create(CreateAboutDto createAboutDto) 
        {
            var newValue = mapper.Map<About>(createAboutDto);
            aboutService.TCreate(newValue);
            return Ok("Yeni Hakkımızda Alanı Oluşturuldu");
        }
        [HttpPut]

        public IActionResult Update(UpdateAboutDto updateAboutDto) 
        {
            var value = mapper.Map<About>(updateAboutDto);
            aboutService.TUpdate(value);
            return Ok("Hakkımda Alanı Güncellendi");
        }
    }   
}
