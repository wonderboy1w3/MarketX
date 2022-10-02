using MagazinSystem.Domain.Enums;

namespace MagazinSystem.Service.DTOs
{
    public class FoodForCreationDto : GenericDto
    {
        public int Count { get; set; }
        public FoodType FoodType { get; set; }
        public decimal Price { get; set; }
    }
}
