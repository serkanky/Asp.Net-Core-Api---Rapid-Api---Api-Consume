using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApiConsume.Controllers
{
    [Route("api/[controller]")]  
    [ApiController]
                                                    //API`NIN HANGİ ATTRIBUTE ILE ÇALIŞACAĞINI BELİRTMEK GEREKİYOR
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]                          //VERILERIN LISTELENECEGI KISIM  //HERNHANGI BIR PARAMETRE YOKSA DIREKT VERI GETIRMEK ISTERSEK HTTPGET ATTRIBUTESİ KULLANILIR
        public IActionResult RoomList()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }
        [HttpPost]                              //YENI VERI EKLEME KISMI
        public IActionResult AddRoom(Room room)
        {
            _roomService.TInsert(room);
            return Ok();
        }
        [HttpDelete("{id}")]                           //SİLME İŞLEMİ İÇİN
        public IActionResult DeleteRoom(int id)
        {
            var values = _roomService.TGetByID(id);
            _roomService.TDelete(values);
            return Ok();
        }
        [HttpPut]                             //UPDATE İŞLEMİ İÇİN
        public IActionResult UpdateRoom(Room room)
        {
            _roomService.TUpdate(room);
            return Ok();
        }
        [HttpGet("{id}")]                    //GET İŞLEMİ - ID YE GÖRE GETİRME İŞLEMİ
        public IActionResult GetRoom(int id)
        {
            var values = _roomService.TGetByID(id);
            return Ok(values);
        }
    }
}
