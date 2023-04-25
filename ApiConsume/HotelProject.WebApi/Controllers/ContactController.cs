using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var value = _contactService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult ContactAdd(Contact contact)
        {
            contact.Date=Convert.ToDateTime(DateTime.Now.ToString());
            _contactService.TInsert(contact);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult ContactDelete(int id)
        {
            var values = _contactService.TGetById(id);
            _contactService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult ContactUpdate(Contact contact)
        {
            _contactService.TUpdate(contact);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult ContactGet(int id)
        {
            var value = _contactService.TGetById(id);
            return Ok(value);
        }

        [HttpGet("ContactCount")]
        public IActionResult ContactCount()
        {
            return Ok(_contactService.TGetSendContactCount());
        }
    }
}
