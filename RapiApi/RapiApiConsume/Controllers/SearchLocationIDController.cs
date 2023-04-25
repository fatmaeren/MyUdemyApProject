using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapiApiConsume.Models;

namespace RapiApiConsume.Controllers
{
    public class SearchLocationIDController : Controller
    {
        public async Task<IActionResult> Index(string cityName)
        {
            if(!string.IsNullOrEmpty(cityName))
            {
                List<BookingLocationModel> model = new List<BookingLocationModel>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={cityName}&locale=en-gb"),
                    Headers =
    {
        { "X-RapidAPI-Key", "f230684c2bmsh0cfc7099af1f00ap1fe700jsn61c66d50e05f" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    model = JsonConvert.DeserializeObject<List<BookingLocationModel>>(body);
                    return View(model.Take(1).ToList());
                }
            }
            else
            {
                List<BookingLocationModel> model = new List<BookingLocationModel>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/locations?name=%C4%B0zmir&locale=en-gb"),
                    Headers =
    {
        { "X-RapidAPI-Key", "f230684c2bmsh0cfc7099af1f00ap1fe700jsn61c66d50e05f" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    model = JsonConvert.DeserializeObject<List<BookingLocationModel>>(body);
                    return View(model.Take(1).ToList());
                }
            }
            
        }
    }
}
