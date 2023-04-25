using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {

        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }


        [HttpGet]
        public IActionResult BookingList()
        {
            var value = _bookingService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult BookingAdd(Booking Booking)
        {
            _bookingService.TInsert(Booking);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult BookingDelete(int id)
        {
            var values = _bookingService.TGetById(id);
            _bookingService.TDelete(values);
            return Ok();
        }

        [HttpPut("BookingUpdate")]
        public IActionResult BookingUpdate(Booking Booking)
        {
            _bookingService.TUpdate(Booking);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult BookingGet(int id)
        {
            var value = _bookingService.TGetById(id);
            return Ok(value);
        }
        [HttpPut("BookingReservation")]
        public IActionResult BookingReservation(Booking booking)
        {
            _bookingService.TBookinStatusChangeApproved(booking);
            return Ok();
        }
    }
}
