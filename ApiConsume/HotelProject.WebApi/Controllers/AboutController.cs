using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutservice _aboutService;

        public AboutController(IAboutservice aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var value = _aboutService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult ServiceAdd(About About)
        {
            _aboutService.TInsert(About);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult ServiceDelete(int id)
        {
            var values = _aboutService.TGetById(id);
            _aboutService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult ServiceUpdate(About About)
        {
            _aboutService.TUpdate(About);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult ServiceGet(int id)
        {
            var value = _aboutService.TGetById(id);
            return Ok(value);
        }
    }
}
