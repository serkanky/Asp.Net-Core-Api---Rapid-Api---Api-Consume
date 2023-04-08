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
    public class SearchLocationIDController : Controller
    {

        public async Task<IActionResult> Index(string cityName)
        {
            if (string.IsNullOrEmpty(cityName))
            {

                List<BookingApiLocationSearchViewModel> bookingApiLocationSearchViewModels = new List<BookingApiLocationSearchViewModel>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name=(cityName)&locale=en-gb"),
                    Headers =
    {
        { "X-RapidAPI-Key", "4937dc5408mshd570ca5712003aap1c3663jsn53baf67799bc" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    bookingApiLocationSearchViewModels = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);
                    return View(bookingApiLocationSearchViewModels.Take(1).ToList());
                }
            }
            else
            {
                List<BookingApiLocationSearchViewModel> bookingApiLocationSearchViewModels = new List<BookingApiLocationSearchViewModel>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/locations?name=paris&locale=en-gb"),
                    Headers =
    {
        { "X-RapidAPI-Key", "4937dc5408mshd570ca5712003aap1c3663jsn53baf67799bc" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    bookingApiLocationSearchViewModels = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);
                    return View(bookingApiLocationSearchViewModels.Take(1).ToList());
                }
            }
        }
    }
}
