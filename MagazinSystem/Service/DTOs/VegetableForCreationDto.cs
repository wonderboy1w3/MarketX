using MagazinSystem.Domain.Enums;

namespace MagazinSystem.Service.DTOs
{
    public class VegetableForCreationDto : GenericDto
    {
        public int Count { get; set; }
        public VegetableType VegetableType { get; set; }
        public decimal Price { get; set; }
    }
}
