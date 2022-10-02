using MagazinSystem.Domain.Entities;
using MagazinSystem.Domain.Enums;

namespace MagazinSystem.Service.DTOs
{
    public class SoldFoodForCreationDto : GenericDto
    {
        public int Count { get; set; }
        public FoodType FoodType { get; set; }
        public Seller Seller { get; set; }
        public decimal Price { get; set; }
    }
}
