using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendMessageService;

        public SendMessageController(ISendMessageService sendMessageService)
        {
            _sendMessageService = sendMessageService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var value = _sendMessageService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult StaffAdd(SendMessage sendMessage)
        {
            _sendMessageService.TInsert(sendMessage);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult StaffDelete(int id)
        {
            var values = _sendMessageService.TGetById(id);
            _sendMessageService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult StaffUpdate(SendMessage sendMessage)
        {
            _sendMessageService.TUpdate(sendMessage);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult StaffGet(int id)
        {
            var value = _sendMessageService.TGetById(id);
            return Ok(value);
        }

        [HttpGet("SendMessageCount")]
        public IActionResult SendMessageCount()
        {
            return Ok(_sendMessageService.TGetSendMessageCount());
        }

    }
}
