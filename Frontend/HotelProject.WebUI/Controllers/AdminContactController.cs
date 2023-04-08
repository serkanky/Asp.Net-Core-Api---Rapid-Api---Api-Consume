using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.SendMessageDto;
using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Inbox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessaage = await client.GetAsync("http://localhost:2450/api/Contact");               //buraya istekte bulunduk, başarılı bir geri dönüş olursa

            var client2 = _httpClientFactory.CreateClient();
            var responseMessaage2 = await client2.GetAsync("http://localhost:2450/api/Contact/GetContactCount");

            var client3 = _httpClientFactory.CreateClient();
            var responseMessaage3 = await client3.GetAsync("http://localhost:2450/api/SendMessage/GetSendMessageCount");

            if (responseMessaage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessaage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsonData);                 //gelen veriyi jsondata diye bi değişkene atadım. Veriyi Deserialize ederek //tablomda gösterebilecek formata dönüştürdüm.

                var jsonData2 = await responseMessaage2.Content.ReadAsStringAsync();
                ViewBag.contactCount = jsonData2;

                var jsonData3 = await responseMessaage3.Content.ReadAsStringAsync();
                ViewBag.sendMessageCount = jsonData3;

                return View(values);                                                                      
            }
            return View();
        }
        public async Task<IActionResult> SendBox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessaage = await client.GetAsync("http://localhost:2450/api/SendMessage");               //buraya istekte bulunduk, başarılı bir geri dönüş olursa
            if (responseMessaage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessaage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSendBoxDto>>(jsonData);                 //gelen veriyi jsondata diye bi değişkene atadım. Veriyi Deserialize ederek
                return View(values);                                                                      //tablomda gösterebilecek formata dönüştürdüm.
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddSendMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSendMessage(CreateSendMessage createSendMessage)
        {
            createSendMessage.SenderMail = "kayapalace@humanresources.com";
            createSendMessage.SenderName = "Admin";
            createSendMessage.Date =DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createSendMessage);
            StringContent stringcontent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:2450/api/SendMessage", stringcontent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("SendBox");
            }
            return View();
        }
        public PartialViewResult SidebarAdminContactPartial()
        {
            return PartialView();
        }
        public PartialViewResult SidebarAdminContactCategoryPartial()
        {
            return PartialView();
        }
        public async Task<IActionResult> MessageDetailsBySendbox(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:2450/api/SendMessage/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetMessageByIDDto>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> MessageDetailsByInbox(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:2450/api/Contact/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<InboxContactDto>(jsonData);
                return View(values);
            }
            return View();
        }
        //public async Task<IActionResult> GetContactCount()
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessaage = await client.GetAsync("http://localhost:2450/api/Contact/GetContactCount");               //buraya istekte bulunduk, başarılı bir geri dönüş olursa
        //    if (responseMessaage.IsSuccessStatusCode)
        //    {
        //        var jsonData = await responseMessaage.Content.ReadAsStringAsync();
        //        var values = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsonData);                 //gelen veriyi jsondata diye bi değişkene atadım. Veriyi Deserialize ederek
        //        return View(values);                                                                      //tablomda gösterebilecek formata dönüştürdüm.
        //    }
        //    return View();
        //}
    }
}
