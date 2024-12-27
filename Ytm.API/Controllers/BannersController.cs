using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ymtProje.Business.Abstract;
using ymtProje.DTO.DTOs.Bannerdtos;
using ymtProje1.Entity.Entities;

namespace Ytm.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController : ControllerBase
    {
        private readonly IGenericService<Banner> _bannerService;
        private readonly IMapper _mapper;

        public BannersController(IGenericService<Banner> bannerService, IMapper mapper)
        {
            _bannerService = bannerService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var values = _bannerService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _bannerService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bannerService.TDelete(id);
            return Ok("Banner Alanı Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateBannerDto createBannerDto)
        {
            var newValue = _mapper.Map<Banner>(createBannerDto);
            _bannerService.TCreate(newValue);
            return Ok("Yeni Banner Alanı Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateBannerDto updateBannerDto)
        {
            var value = _mapper.Map<Banner>(updateBannerDto);
            _bannerService.TUpdate(value);
            return Ok("Banner Alanı Güncellendi");
        }
    }
}
