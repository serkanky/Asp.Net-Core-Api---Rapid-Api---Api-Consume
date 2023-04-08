using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiCosnume.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RapidApiCosnume.Controllers
{
    public class AirportController : Controller
    {
        List<ApiAirportViewModel> apiAirportViewModels = new List<ApiAirportViewModel>();
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://skyscanner50.p.rapidapi.com/api/v1/searchAirport?query=turkey"),
                Headers =
    {
        { "X-RapidAPI-Key", "4937dc5408mshd570ca5712003aap1c3663jsn53baf67799bc" },
        { "X-RapidAPI-Host", "skyscanner50.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                apiAirportViewModels = JsonConvert.DeserializeObject<List<ApiAirportViewModel>>(body);
                return View(apiAirportViewModels);
            }
        }
    }
}
