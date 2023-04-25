using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _testimonialService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult TestimonialAdd(Testimonial Testimonial)
        {
            _testimonialService.TInsert(Testimonial);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult TestimonialDelete(int id)
        {
            var values = _testimonialService.TGetById(id);
            _testimonialService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult TestimonialUpdate(Testimonial Testimonial)
        {
            _testimonialService.TUpdate(Testimonial);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult TestimonialGet(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }
    }
}
