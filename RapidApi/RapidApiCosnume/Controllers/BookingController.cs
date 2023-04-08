using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RapidApiCosnume.Models;
using System.Linq;

namespace RapidApiCosnume.Controllers                         //İLK ÖNCE CONTROLLER OLUŞTURDUK 1. ADIM
                                                              //VERİLERİ CODE SNİPETS C# HTML OLARAK ALIP BURAYA YAPIŞTIRDIM. //METOTU ASYNC TASK HALE GETİRDİM
{
    public class BookingController : Controller
    {
        public async Task<IActionResult> Index()           //3. ADIM ASYNC TASK ÇEVİRDİM METODU            //5. ADIM VİEW EKLEDİM.
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=popularity&adults_number=2&checkin_date=2023-04-10&filter_by_currency=USD&dest_id=-1456928&locale=en-gb&checkout_date=2023-04-15&units=metric&room_number=1&dest_type=city&include_adjacency=true&children_number=2&page_number=0&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1"),
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
                var values = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
                return View(values.results.ToList());                                        //4. ADIM RETURN VİEW ÇEVİRDİK EN BAŞTA, SONRA VALUES İÇİNDE Kİ RESULTS İLE ÇALIŞACAĞIZ DEDİK. LİST OLARAK GETİRECEK
            }
        }
    }
}
