using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Lütfen oda görseli yükleyiniz.")]
        public string RoomImage { get; set; }
        [Required(ErrorMessage = "Lütfen oda numarsını yazınız.")]

        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen oda ücretini yazınız.")]

        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen oda başlığı yazınız.")]
        [StringLength(100, ErrorMessage ="En fazla 100 karakter girebilirsiniz.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısını yazınız.")]

        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo sayısını yazınız.")]
        public string BathCount { get; set; }
        [Required(ErrorMessage = "Lütfen wifi durumunu yazınız.")]
        public string Wifi { get; set; }

        public string Description { get; set; }
    }
}
