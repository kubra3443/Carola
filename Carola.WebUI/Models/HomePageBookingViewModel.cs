using Carola.DtoLayer.CarDtos;
using Carola.DtoLayer.LocationDtos;

namespace Carola.WebUI.Models
{
    public class HomePageBookingViewModel
    {
        public int? CarId { get; set; }
        public int? PickupLocationId { get; set; }
        public int? ReturnLocationId { get; set; }
        public DateTime? PickupDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public List<ResultCarDto> Cars { get; set; } = new();
        public List<ResultLocationDto> Locations { get; set; } = new();
    }
}
