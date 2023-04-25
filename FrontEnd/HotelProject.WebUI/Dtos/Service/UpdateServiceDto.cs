using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.Service
{
    public class UpdateServiceDto
    {

        public int ID { get; set; }
        [Required(ErrorMessage ="Lüten hizmet iconu giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Lüten hizmet başlığı giriniz")]
        [StringLength(100, ErrorMessage ="Max 100 karakter olabilir.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lüten hizmet açıklamsı giriniz")]
        [StringLength(500, ErrorMessage = "Max 500 karakter olabilir.")]
        public string Description { get; set; }
    }
}
