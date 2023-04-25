using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.Service
{
    public class CreateServiceDto
    {

        [Required(ErrorMessage = "Lüten hizmet iconu giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Lüten hizmet başlığı giriniz")]
        [StringLength(100, ErrorMessage = "Max 100 karakter olabilir.")]
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
