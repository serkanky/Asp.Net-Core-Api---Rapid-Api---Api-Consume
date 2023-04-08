using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApiConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;

        public GuestController(IGuestService guestService)
        {
            _guestService = guestService;
        }

        [HttpGet]                          //VERILERIN LISTELENECEGI KISIM  //HERNHANGI BIR PARAMETRE YOKSA DIREKT VERI GETIRMEK ISTERSEK HTTPGET ATTRIBUTESİ KULLANILIR
        public IActionResult GuestList()
        {
            var values = _guestService.TGetList();
            return Ok(values);
        }
        [HttpPost]                              //YENI VERI EKLEME KISMI
        public IActionResult AddGuest(Guest guest)
        {
            _guestService.TInsert(guest);
            return Ok();
        }
        [HttpDelete("{id}")]                           //SİLME İŞLEMİ İÇİN
        public IActionResult DeleteGuest(int id)
        {
            var values = _guestService.TGetByID(id);
            _guestService.TDelete(values);
            return Ok();
        }
        [HttpPut]                             //UPDATE İŞLEMİ İÇİN
        public IActionResult UpdateGuest(Guest guest)
        {
            _guestService.TUpdate(guest);
            return Ok();
        }
        [HttpGet("{id}")]                    //GET İŞLEMİ - ID YE GÖRE GETİRME İŞLEMİ
        public IActionResult GetRoom(int id)
        {
            var values = _guestService.TGetByID(id);
            return Ok(values);
        }
    }
}
