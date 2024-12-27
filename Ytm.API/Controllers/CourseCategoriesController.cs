using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ymtProje.Business.Abstract;
using ymtProje.DTO.DTOs.Aboutdtos;
using ymtProje.DTO.DTOs.CourseCategoryDtos;
using ymtProje1.Entity.Entities;

namespace Ytm.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoriesController(IGenericService<CourseCategory> courseCategoryServices,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = courseCategoryServices.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var value = courseCategoryServices.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            courseCategoryServices.TDelete(id);
            return Ok("Kurs Kategori Alanı Silindi ");
        }
        [HttpPost]

        public IActionResult Create(CreateCourseCategoryDto createCourseCategoryDto)
        {
            var newValue = mapper.Map<CourseCategory>(createCourseCategoryDto);
            courseCategoryServices.TCreate(newValue);
            return Ok("Yeni Kurs Kategori Alanı Oluşturuldu");
        }
        [HttpPut]

        public IActionResult Update(UpdateCourseCategoryDto updateCourseCategoryDto)
        {
            var value = mapper.Map<CourseCategory>(updateCourseCategoryDto);
            courseCategoryServices.TUpdate(value);
            return Ok("Kurs Kategori Alanı Güncellendi");
        }
    }
}
