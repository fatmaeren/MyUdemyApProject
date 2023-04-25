using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var value= _staffService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult StaffAdd(Staff staff)
        {
            _staffService.TInsert(staff);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult StaffDelete(int id)
        {
            var values= _staffService.TGetById(id);
             _staffService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult StaffUpdate(Staff staff)
        {
            _staffService.TUpdate(staff);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult StaffGet(int id)
        {
            var value = _staffService.TGetById(id);
            return Ok(value);
        }
    }
}
