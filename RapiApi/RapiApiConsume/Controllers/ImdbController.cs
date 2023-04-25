using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapiApiConsume.Models;

namespace RapiApiConsume.Controllers
{
    public class ImdbController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<AoiMovieViewModel> awmv = new List<AoiMovieViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "X-RapidAPI-Key", "c42bc531c3mshee00b0e5954d966p1bd423jsn332551149e5c" },
        { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                awmv=JsonConvert.DeserializeObject<List<AoiMovieViewModel>>(body);
                return View(awmv);


            }
           
        }
    }
}
