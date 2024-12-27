using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ymtProje.Business.Abstract;
using ymtProje.DTO.DTOs.Aboutdtos;
using ymtProje.DTO.DTOs.CourseDtos;
using ymtProje1.Entity.Entities;

namespace Ytm.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController(IGenericService<Course> courseService,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = courseService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var value = courseService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            courseService.TDelete(id);
            return Ok("Hakkımızda Alanı Silindi ");
        }
        [HttpPost]

        public IActionResult Create(CreateCourseDto createCourseDto)
        {
            var newValue = mapper.Map<Course>(createCourseDto);
            courseService.TCreate(newValue);
            return Ok("Yeni Hakkımızda Alanı Oluşturuldu");
        }
        [HttpPut]

        public IActionResult Update(UpdateCourseDto updateCourseDto)
        {
            var value = mapper.Map<Course>(updateCourseDto);
            courseService.TUpdate(value);
            return Ok("Hakkımda Alanı Güncellendi");
        }
    }
}
