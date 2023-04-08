using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using RapidApiCosnume.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace RapidApiCosnume.Controllers
{
    public class WeatherController : Controller
    {
        List<WeatherViewModel>  weatherViewModels = new List<WeatherViewModel>();
        public async Task< IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weatherbit-v1-mashape.p.rapidapi.com/current?lon=38.5&lat=-78.5&lang=tr"),
                Headers =
    {
        { "X-RapidAPI-Key", "4937dc5408mshd570ca5712003aap1c3663jsn53baf67799bc" },
        { "X-RapidAPI-Host", "weatherbit-v1-mashape.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject < WeatherViewModel>(body);
                return View(values);
            }
           
        }
    }
}
