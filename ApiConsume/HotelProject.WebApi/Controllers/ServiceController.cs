using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var value = _serviceService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult ServiceAdd(Service Service)
        {
            _serviceService.TInsert(Service);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult ServiceDelete(int id)
        {
            var values = _serviceService.TGetById(id);
            _serviceService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult ServiceUpdate(Service Service)
        {
            _serviceService.TUpdate(Service);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult ServiceGet(int id)
        {
            var value = _serviceService.TGetById(id);
            return Ok(value);
        }
    }
}
