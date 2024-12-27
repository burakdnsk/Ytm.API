using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ymtProje.Business.Abstract;
using ymtProje.DTO.DTOs.BlogDtos;
using ymtProje1.Entity.Entities;

namespace Ytm.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IGenericService<Blog> _blogService;
        private readonly IMapper _mapper;

        public BlogsController(IGenericService<Blog> blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var values = _blogService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _blogService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _blogService.TDelete(id);
            return Ok("Blog Alanı Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateBlogDto createBlogDto)
        {
            var newValue = _mapper.Map<Blog>(createBlogDto);
            _blogService.TCreate(newValue);
            return Ok("Yeni Blog Alanı Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateBlogDto updateBlogDto)
        {
            var value = _mapper.Map<Blog>(updateBlogDto);
            _blogService.TUpdate(value);
            return Ok("Blog Alanı Güncellendi");
        }
    }
}
