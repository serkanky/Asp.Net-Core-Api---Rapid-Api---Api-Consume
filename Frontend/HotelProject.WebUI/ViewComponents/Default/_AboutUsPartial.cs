﻿using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _AboutUsPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutUsPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessaage = await client.GetAsync("http://localhost:2450/api/About");               //buraya istekte bulunduk, başarılı bir geri dönüş olursa
            if (responseMessaage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessaage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);                 //gelen veriyi jsondata diye bi değişkene atadım. Veriyi Deserialize ederek
                return View(values);                                                                      //tablomda gösterebilecek formata dönüştürdüm.
            }
            return View();
        }
    }
}
