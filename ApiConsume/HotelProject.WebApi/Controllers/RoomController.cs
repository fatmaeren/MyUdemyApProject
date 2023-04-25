using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var value = _roomService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult RoomAdd(Room Room)
        {
            _roomService.TInsert(Room);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult RoomDelete(int id)
        {
            var values = _roomService.TGetById(id);
            _roomService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult RoomUpdate(Room Room)
        {
            _roomService.TUpdate(Room);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult RoomGet(int id)
        {
            var value = _roomService.TGetById(id);
            return Ok(value);
        }
    }
}
