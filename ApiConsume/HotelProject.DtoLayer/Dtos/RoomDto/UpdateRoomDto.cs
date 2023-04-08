using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Oda numarası yazınız!!")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Oda fotoğrafı ekleyiniz!!")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Fiyat bilgisi yazınız!!")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Başlık bilgisi yazınız!!")]
        [StringLength(100, ErrorMessage ="En fazla 100 karakter veri girişi yapınız!!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Yatak bilgisi yazınız!!")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Banyo bilgisi yazınız!!")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Açıklama yazınız!!")]
        public string Description { get; set; }
    }
}
