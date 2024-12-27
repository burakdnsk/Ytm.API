using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Design;
using ymtProje.DTO.DTOs.Aboutdtos;
using ymtProje.DTO.DTOs.BlogCategoryDtos;
using ymtProje1.Entity.Entities;

namespace Ytm.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoryController(ymtProje.Business.Abstract.IGenericService<BlogCategory> blogCategoryService,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = blogCategoryService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var value = blogCategoryService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            blogCategoryService.TDelete(id);
            return Ok("Blog Alanı Silindi ");
        }
        [HttpPost]

        public IActionResult Create(CreateBlogCategoryDto createBlogcategoryDto)
        {
            var newValue = mapper.Map<BlogCategory>(createBlogcategoryDto);
            blogCategoryService.TCreate(newValue);
            return Ok("Yeni Blog Alanı Oluşturuldu");
        }
        [HttpPut]

        public IActionResult Update(UpdateBlogCategoryDto updateBlogcategoryDto)
        {
            var value = mapper.Map<BlogCategory>(updateBlogcategoryDto);
            blogCategoryService.TUpdate(value);
            return Ok("Blog Alanı Güncellendi");
        }
    }
}
